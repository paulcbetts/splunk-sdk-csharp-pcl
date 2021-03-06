﻿/*
 * Copyright 2014 Splunk, Inc.
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

namespace Splunk.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    using Xunit;

    public class TestSavedSearchAttributes
    {
        [Trait("class", "Args")]
        [Fact]
        void CanConstruct()
        {
            var attributes = new SavedSearchAttributes();

            Assert.Equal("action.email.bcc=null; action.email.cc=null; action.email.command=null; action.email.format=null; action.email.from=null; action.email.inline=null; action.email.mailserver=null; action.email.maxresults=null; action.email.maxtime=null; action.email.reportCIDFontList=null; action.email.reportIncludeSplunkLogo=null; action.email.reportPaperOrientation=null; action.email.reportPaperSize=null; action.email.reportServerEnabled=null; action.email.sendpdf=null; action.email.sendresults=null; action.email.subject=null; action.email.to=null; action.email.track_alert=null; action.email.ttl=null; action.email.use_ssl=null; action.email.use_tls=null; action.email.width_sort_columns=null; action.populate_lookup.command=null; action.populate_lookup.dest=null; action.populate_lookup.hostname=null; action.populate_lookup.maxresults=null; action.populate_lookup.maxtime=null; action.populate_lookup.track_alert=null; action.populate_lookup.ttl=null; action.rss.command=null; action.rss.maxresults=null; action.rss.maxtime=null; action.rss.track_alert=null; action.rss.ttl=null; action.script.command=null; action.script.filename=null; action.script.hostname=null; action.script.maxresults=null; action.script.maxtime=null; action.script.track_alert=null; action.script.ttl=null; action.summary_index.command=null; action.summary_index.inline=null; action.summary_index.maxresults=null; action.summary_index.maxtime=null; action.summary_index.name=null; action.summary_index.track_alert=null; action.summary_index.ttl=null; actions=null; alert.digest_mode=null; alert.expires=null; alert.severity=null; alert.track=null; alert_comparator=null; alert_condition=null; alert_threshold=null; alert_type=null; auto_summarize=null; auto_summarize.command=null; auto_summarize.cron_schedule=null; auto_summarize.dispatch.time_format=null; auto_summarize.dispatch.ttl=null; auto_summarize.max_disabled_buckets=null; auto_summarize.max_summary_ratio=null; auto_summarize.max_summary_size=null; auto_summarize.max_time=null; auto_summarize.suspend_period=null; cron_schedule=null; description=null; disabled=null; dispatch.buckets=null; dispatch.earliest_time=null; dispatch.latest_time=null; dispatch.lookups=null; dispatch.max_count=null; dispatch.max_time=null; dispatch.reduce_freq=null; dispatch.rt_backfill=null; dispatch.spawn_process=null; dispatch.time_format=null; is_scheduled=null; is_visible=null; max_concurrent=null; realtime_schedule=null; restart_on_searchpeer_add=null; run_on_startup=null; search=null",
                attributes.ToString());
            Assert.Equal(new List<Argument>(), attributes);
        }

        [Trait("class", "Args")]
        [Fact]
        void CanSetEveryValue()
        {
            var attributes = new SavedSearchAttributes()
            {
                ActionEmailBcc = "some-unchecked-string",
                ActionEmailCC = "some-unchecked-string",
                ActionEmailCommand = "some-unchecked-string",
                ActionEmailFormat = EmailFormat.Html,
                ActionEmailFrom = "some-unchecked-string",
                ActionEmailInline = "some-unchecked-string",
                ActionEmailMailServer = "some-unchecked-string",
                ActionEmailMaxResults = 99,
                ActionEmailMaxTime = "some-unchecked-string",
                ActionEmailReportCidFontList = "some-unchecked-string",
                ActionEmailReportIncludeSplunkLogo = true,
                ActionEmailReportPaperOrientation = PaperOrientation.Landscape,
                ActionEmailReportPaperSize = PaperSize.Ledger,
                ActionEmailReportServerEnabled = true,
                ActionEmailSendPdf = true,
                ActionEmailSendResults = true,
                ActionEmailSubject = "some-unchecked-string",
                ActionEmailTo = "some-unchecked-string",
                ActionEmailTrackAlert = true,
                ActionEmailTtl = "some-unchecked-string",
                ActionEmailUseSsl = true,
                ActionEmailUseTls = true,
                ActionEmailWidthSortColumns = true,
                ActionPopulateLookupCommand = "some-unchecked-string",
                ActionPopulateLookupDestination = "some-unchecked-string",
                ActionPopulateLookupHostname = "some-unchecked-string",
                ActionPopulateLookupMaxResults = 99,
                ActionPopulateLookupMaxTime = "some-unchecked-string",
                ActionPopulateLookupTrackAlert = true,
                ActionPopulateLookupTtl = "some-unchecked-string",
                ActionRssCommand = "some-unchecked-string",
                ActionRssMaxResults = 99,
                ActionRssMaxTime = "some-unchecked-string",
                ActionRssTrackAlert = "some-unchecked-string",
                ActionRssTtl = "some-unchecked-string",
                Actions = "some-unchecked-string",
                ActionScriptCommand = "some-unchecked-string",
                ActionScriptFileName = "some-unchecked-string",
                ActionScriptHostname = "some-unchecked-string",
                ActionScriptMaxResults = 99,
                ActionScriptMaxTime = "some-unchecked-string",
                ActionScriptTrackAlert = true,
                ActionScriptTtl = "some-unchecked-string",
                ActionSummaryIndexCommand = "some-unchecked-string",
                ActionSummaryIndexInline = true,
                ActionSummaryIndexMaxResults = 99,
                ActionSummaryIndexMaxTime = "some-unchecked-string",
                ActionSummaryIndexName = "some-unchecked-string",
                ActionSummaryIndexTrackAlert = true,
                ActionSummaryIndexTtl = "some-unchecked-string",
                AlertComparator = AlertComparator.GreaterThan,
                AlertCondition = "some-unchecked-string",
                AlertDigestMode = true,
                AlertExpires = "some-unchecked-string",
                AlertSeverity = AlertSeverity.Warning,
                AlertThreshold = "some-unchecked-string",
                AlertTrack = AlertTrack.Automatic,
                AlertType = AlertType.Always,
                AutoSummarize = true,
                AutoSummarizeCommand = "some-unchecked-string",
                AutoSummarizeCronSchedule = "some-unchecked-string",
                AutoSummarizeDispatchTimeFormat = "some-unchecked-string",
                AutoSummarizeDispatchTtl = "some-unchecked-string",
                AutoSummarizeMaxDisabledBuckets = "some-unchecked-string",
                AutoSummarizeMaxSummaryRatio = "some-unchecked-string",
                AutoSummarizeMaxSummarySize = "some-unchecked-string",
                AutoSummarizeMaxTime = "some-unchecked-string",
                AutoSummarizeSuspendPeriod = "some-unchecked-string",
                CronSchedule = "some-unchecked-string",
                Description = "some-unchecked-string",
                Disabled = true,
                DispatchBuckets = 99,
                DispatchEarliestTime = "some-unchecked-string",
                DispatchLatestTime = "some-unchecked-string",
                DispatchLookups = true,
                DispatchMaxCount = 99,
                DispatchMaxTime = 99,
                DispatchRealTimeBackfill = true,
                DispatchReduceFrequency = 99,
                DispatchSpawnProcess = true,
                DispatchTimeFormat = "some-unchecked-string",
                DispatchTtl = "some-unchecked-string",
                IsScheduled = true,
                IsVisible = true,
                MaxConcurrent = 99,
                RealtimeSchedule = "some-unchecked-string",
                RestartOnSearchPeerAdd = "some-unchecked-string",
                RunOnStartup = true,
                Search = "some-unchecked-string",
            };

            Assert.Equal(
                "action.email.bcc=some-unchecked-string; " +
                "action.email.cc=some-unchecked-string; " +
                "action.email.command=some-unchecked-string; " +
                "action.email.format=Html; " +
                "action.email.from=some-unchecked-string; " +
                "action.email.inline=some-unchecked-string; " +
                "action.email.mailserver=some-unchecked-string; " +
                "action.email.maxresults=99; " +
                "action.email.maxtime=some-unchecked-string; " +
                "action.email.reportCIDFontList=some-unchecked-string; " +
                "action.email.reportIncludeSplunkLogo=t; " +
                "action.email.reportPaperOrientation=Landscape; " +
                "action.email.reportPaperSize=Ledger; " +
                "action.email.reportServerEnabled=t; " +
                "action.email.sendpdf=t; " +
                "action.email.sendresults=t; " +
                "action.email.subject=some-unchecked-string; " +
                "action.email.to=some-unchecked-string; " +
                "action.email.track_alert=t; " +
                "action.email.ttl=some-unchecked-string; " +
                "action.email.use_ssl=t; " +
                "action.email.use_tls=t; " +
                "action.email.width_sort_columns=t; " +
                "action.populate_lookup.command=some-unchecked-string; " +
                "action.populate_lookup.dest=some-unchecked-string; " +
                "action.populate_lookup.hostname=some-unchecked-string; " +
                "action.populate_lookup.maxresults=99; " +
                "action.populate_lookup.maxtime=some-unchecked-string; " +
                "action.populate_lookup.track_alert=t; " +
                "action.populate_lookup.ttl=some-unchecked-string; " +
                "action.rss.command=some-unchecked-string; " +
                "action.rss.maxresults=99; " +
                "action.rss.maxtime=some-unchecked-string; " +
                "action.rss.track_alert=some-unchecked-string; " +
                "action.rss.ttl=some-unchecked-string; " +
                "action.script.command=some-unchecked-string; " +
                "action.script.filename=some-unchecked-string; " +
                "action.script.hostname=some-unchecked-string; " +
                "action.script.maxresults=99; " +
                "action.script.maxtime=some-unchecked-string; " +
                "action.script.track_alert=t; " +
                "action.script.ttl=some-unchecked-string; " +
                "action.summary_index.command=some-unchecked-string; " +
                "action.summary_index.inline=t; " +
                "action.summary_index.maxresults=99; " +
                "action.summary_index.maxtime=some-unchecked-string; " +
                "action.summary_index.name=some-unchecked-string; " +
                "action.summary_index.track_alert=t; " +
                "action.summary_index.ttl=some-unchecked-string; " +
                "actions=some-unchecked-string; " +
                "alert.digest_mode=t; " +
                "alert.expires=some-unchecked-string; " +
                "alert.severity=Warning; " +
                "alert.track=Automatic; " +
                "alert_comparator=GreaterThan; " +
                "alert_condition=some-unchecked-string; " +
                "alert_threshold=some-unchecked-string; " +
                "alert_type=Always; " +
                "auto_summarize=t; " +
                "auto_summarize.command=some-unchecked-string; " +
                "auto_summarize.cron_schedule=some-unchecked-string; " +
                "auto_summarize.dispatch.time_format=some-unchecked-string; " +
                "auto_summarize.dispatch.ttl=some-unchecked-string; " +
                "auto_summarize.max_disabled_buckets=some-unchecked-string; " +
                "auto_summarize.max_summary_ratio=some-unchecked-string; " +
                "auto_summarize.max_summary_size=some-unchecked-string; " +
                "auto_summarize.max_time=some-unchecked-string; " +
                "auto_summarize.suspend_period=some-unchecked-string; " +
                "cron_schedule=some-unchecked-string; " +
                "description=some-unchecked-string; " +
                "disabled=t; " +
                "dispatch.buckets=99; " +
                "dispatch.earliest_time=some-unchecked-string; " +
                "dispatch.latest_time=some-unchecked-string; " +
                "dispatch.lookups=t; " +
                "dispatch.max_count=99; " +
                "dispatch.max_time=99; " +
                "dispatch.reduce_freq=99; " +
                "dispatch.rt_backfill=t; " +
                "dispatch.spawn_process=t; " +
                "dispatch.time_format=some-unchecked-string; " +
                "is_scheduled=t; " +
                "is_visible=t; " +
                "max_concurrent=99; " +
                "realtime_schedule=some-unchecked-string; " +
                "restart_on_searchpeer_add=some-unchecked-string; " +
                "run_on_startup=t; " +
                "search=some-unchecked-string",
                attributes.ToString());

            Assert.Equal(new List<Argument> 
                {
                    new Argument("action.email.bcc", "some-unchecked-string"),
                    new Argument("action.email.cc", "some-unchecked-string"),
                    new Argument("action.email.command", "some-unchecked-string"),
                    new Argument("action.email.format", "Html"),
                    new Argument("action.email.from", "some-unchecked-string"),
                    new Argument("action.email.inline", "some-unchecked-string"),
                    new Argument("action.email.mailserver", "some-unchecked-string"),
                    new Argument("action.email.maxresults", "99"),
                    new Argument("action.email.maxtime", "some-unchecked-string"),
                    new Argument("action.email.reportCIDFontList", "some-unchecked-string"),
                    new Argument("action.email.reportIncludeSplunkLogo", "t"),
                    new Argument("action.email.reportPaperOrientation", "Landscape"),
                    new Argument("action.email.reportPaperSize", "Ledger"),
                    new Argument("action.email.reportServerEnabled", "t"),
                    new Argument("action.email.sendpdf", "t"),
                    new Argument("action.email.sendresults", "t"),
                    new Argument("action.email.subject", "some-unchecked-string"),
                    new Argument("action.email.to", "some-unchecked-string"),
                    new Argument("action.email.track_alert", "t"),
                    new Argument("action.email.ttl", "some-unchecked-string"),
                    new Argument("action.email.use_ssl", "t"),
                    new Argument("action.email.use_tls", "t"),
                    new Argument("action.email.width_sort_columns", "t"),
                    new Argument("action.populate_lookup.command", "some-unchecked-string"),
                    new Argument("action.populate_lookup.dest", "some-unchecked-string"),
                    new Argument("action.populate_lookup.hostname", "some-unchecked-string"),
                    new Argument("action.populate_lookup.maxresults", "99"),
                    new Argument("action.populate_lookup.maxtime", "some-unchecked-string"),
                    new Argument("action.populate_lookup.track_alert", "t"),
                    new Argument("action.populate_lookup.ttl", "some-unchecked-string"),
                    new Argument("action.rss.command", "some-unchecked-string"),
                    new Argument("action.rss.maxresults", "99"),
                    new Argument("action.rss.maxtime", "some-unchecked-string"),
                    new Argument("action.rss.track_alert", "some-unchecked-string"),
                    new Argument("action.rss.ttl", "some-unchecked-string"),
                    new Argument("action.script.command", "some-unchecked-string"),
                    new Argument("action.script.filename", "some-unchecked-string"),
                    new Argument("action.script.hostname", "some-unchecked-string"),
                    new Argument("action.script.maxresults", "99"),
                    new Argument("action.script.maxtime", "some-unchecked-string"),
                    new Argument("action.script.track_alert", "t"),
                    new Argument("action.script.ttl", "some-unchecked-string"),
                    new Argument("action.summary_index.command", "some-unchecked-string"),
                    new Argument("action.summary_index.inline", "t"),
                    new Argument("action.summary_index.maxresults", "99"),
                    new Argument("action.summary_index.maxtime", "some-unchecked-string"),
                    new Argument("action.summary_index.name", "some-unchecked-string"),
                    new Argument("action.summary_index.track_alert", "t"),
                    new Argument("action.summary_index.ttl", "some-unchecked-string"),
                    new Argument("actions", "some-unchecked-string"),
                    new Argument("alert.digest_mode", "t"),
                    new Argument("alert.expires", "some-unchecked-string"),
                    new Argument("alert.severity", "Warning"),
                    new Argument("alert.track", "Automatic"),
                    new Argument("alert_comparator", "GreaterThan"),
                    new Argument("alert_condition", "some-unchecked-string"),
                    new Argument("alert_threshold", "some-unchecked-string"),
                    new Argument("alert_type", "Always"),
                    new Argument("auto_summarize", "t"),
                    new Argument("auto_summarize.command", "some-unchecked-string"),
                    new Argument("auto_summarize.cron_schedule", "some-unchecked-string"),
                    new Argument("auto_summarize.dispatch.time_format", "some-unchecked-string"),
                    new Argument("auto_summarize.dispatch.ttl", "some-unchecked-string"),
                    new Argument("auto_summarize.max_disabled_buckets", "some-unchecked-string"),
                    new Argument("auto_summarize.max_summary_ratio", "some-unchecked-string"),
                    new Argument("auto_summarize.max_summary_size", "some-unchecked-string"),
                    new Argument("auto_summarize.max_time", "some-unchecked-string"),
                    new Argument("auto_summarize.suspend_period", "some-unchecked-string"),
                    new Argument("cron_schedule", "some-unchecked-string"),
                    new Argument("description", "some-unchecked-string"),
                    new Argument("disabled", "t"),
                    new Argument("dispatch.buckets", "99"),
                    new Argument("dispatch.earliest_time", "some-unchecked-string"),
                    new Argument("dispatch.latest_time", "some-unchecked-string"),
                    new Argument("dispatch.lookups", "t"),
                    new Argument("dispatch.max_count", "99"),
                    new Argument("dispatch.max_time", "99"),
                    new Argument("dispatch.reduce_freq", "99"),
                    new Argument("dispatch.rt_backfill", "t"),
                    new Argument("dispatch.spawn_process", "t"),
                    new Argument("dispatch.time_format", "some-unchecked-string"),
                    new Argument("is_scheduled", "t"),
                    new Argument("is_visible", "t"),
                    new Argument("max_concurrent", "99"),
                    new Argument("realtime_schedule", "some-unchecked-string"),
                    new Argument("restart_on_searchpeer_add", "some-unchecked-string"),
                    new Argument("run_on_startup", "t"),
                    new Argument("search", "some-unchecked-string")
                },
                attributes);
        }
    }
}
