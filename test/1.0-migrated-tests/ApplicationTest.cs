﻿/*
 * Copyright 2013 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

namespace Splunk.Sdk.UnitTesting
{
    using System.Linq;
    using Splunk.Client;
    using Splunk.Client.UnitTesting;
    using Xunit;
    using System;

    /// <summary>
    /// Application tests
    /// </summary>
    public class ApplicationTest : TestHelper
    {
        /// <summary>
        /// The assert root string
        /// </summary>
        private static string assertRoot = "Application assert: ";

        /// <summary>
        /// Cleans an application from Splunk -- requires a restart
        /// </summary>
        /// <param name="appName">The app name</param>
        /// <param name="service">The connected service</param>
        /// <returns>The new connection</returns>
        private Service CleanApp(string appName, Service service)
        {
            ApplicationCollection apps = service.GetApplicationsAsync().Result;
            if (apps.Any(a => a.Name == appName))
            {
                service.RemoveApplicationAsync(appName).Wait();
                this.SplunkRestart();
                service = this.Connect();
            }

            return service;
        }

        /// <summary>
        /// The app tests
        /// </summary>
        [Fact]
        public void Application()
        {
            string dummyString;
            bool dummyBool;
            int dummyInt;
            Service service = Connect();

            ApplicationCollection apps = service.GetApplicationsAsync().Result;
            foreach (Application app in apps)
            {
                try
                {
                    ApplicationSetupInfo applicationSetup = app.GetSetupInfoAsync().Result;
                    //string setupXml = applicationSetup.SetupXml;
                }
                catch (Exception)
                {
                    // silent exception, if setup doesn't exist, exception occurs
                }

                ApplicationArchiveInfo applicationArchive = app.PackageAsync().Result;
                dummyString = app.Author;
                dummyBool = app.CheckForUpdates;
                dummyString = app.Description;
                dummyString = app.Label;
                dummyBool = app.Refresh;
                dummyString = app.Version;
                dummyBool = app.Configured;
                if (this.VersionCompare(service, "5.0") < 0)
                {
                    //dummyBool = app.IsManageable;
                }
                dummyBool = app.Visible;
                dummyBool = app.StateChangeRequiresRestart;
                ApplicationUpdateInfo applicationUpdate = app.GetUpdateInfoAsync().Result;
                //dummyString = applicationUpdate.Checksum;
                //dummyString = applicationUpdate.ChecksumType;
                //dummyString = applicationUpdate.Homepage;
                //dummyInt = applicationUpdate.UpdateSize;
                //dummyString = applicationUpdate.UpdateName;
                //dummyString = applicationUpdate.AppUrl;
                //dummyString = applicationUpdate.Version;
                //dummyBool = applicationUpdate.IsImplicitIdRequired;
            }

            if (apps.Any(a => a.Name == "sdk-tests"))
            {

                service = this.CleanApp("sdk-tests", service);             
            }

            apps = service.GetApplicationsAsync().Result;
            Assert.False(apps.Any(a => a.Name == "sdk-tests"), assertRoot + "#1");

            ApplicationAttributes createArgs = new ApplicationAttributes();
            createArgs.ApplicationAuthor = "me";
            if (this.VersionCompare(service, "4.2.4") >= 0)
            {
                createArgs.Configured = false;
            }
            createArgs.Description = "this is a description";
            createArgs.Label = "SDKTEST";
            if (this.VersionCompare(service, "5.0") < 0)
            {
                //createArgs.manageable", false);
            }
            //createArgs.template", "barebones");
            createArgs.Visible = false;
            service.CreateApplicationAsync("sdk-tests", "barebones", createArgs).Wait();
            apps.GetAsync().Wait();
            Assert.True(apps.Any(a => a.Name == "sdk-tests"), assertRoot + "#2");

            Application app2 = service.GetApplicationAsync("sdk-tests").Result;

            dummyBool = app2.CheckForUpdates;
            Assert.Equal("SDKTEST", app2.Label);
            Assert.Equal("me", app2.ApplicationAuthor);
            Assert.False(app2.Configured, assertRoot + "#5");
            if (this.VersionCompare(service, "5.0") < 0)
            {
                //Assert.False(app2.Manageable, assertRoot + "#6");
            }
            Assert.False(app2.Visible, assertRoot + "#7");

            // update the app
            ApplicationAttributes attr = new ApplicationAttributes();
            attr.ApplicationAuthor = "not me";
            attr.Description = "new description";
            attr.Label = "new label";
            attr.Visible = false;
            if (this.VersionCompare(service, "5.0") < 0)
            {
                //app2.IsManageable = false;
            }
            //attr.Version = "5.0.0";
            app2.UpdateAsync(attr, true).Wait();
            app2.GetAsync().Wait();

            // check to see if args took.
            Assert.Equal("not me", app2.ApplicationAuthor);
            Assert.Equal("new description", app2.Description);
            Assert.Equal("new label", app2.Label);
            Assert.False(app2.Visible, assertRoot + "#11");
            //Assert.Equal("5.0.0", app2.Version);

            // archive (package) the application
            ApplicationArchiveInfo appArchive = app2.PackageAsync().Result;
            Assert.True(appArchive.ApplicationName.Length > 0, assertRoot + "#13");
            Assert.True(appArchive.Path.Length > 0, assertRoot + "#14");
            Assert.True(appArchive.Uri.AbsolutePath.Length > 0, assertRoot + "#15");

            ApplicationUpdateInfo appUpdate = app2.GetUpdateInfoAsync().Result;
            //ApplicationUpdate appUpdate = app2.AppUpdate();
            //Assert.True(appUpdate.ContainsKey("eai:acl"), assertRoot + "#16");

            service = this.CleanApp("sdk-tests", service);
            apps = service.GetApplicationsAsync().Result;
            Assert.False(apps.Any(a => a.Name == "sdk-tests"), assertRoot + "#17");
        }
    }
}
