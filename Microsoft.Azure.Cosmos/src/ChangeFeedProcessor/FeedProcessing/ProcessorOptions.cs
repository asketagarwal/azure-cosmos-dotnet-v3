﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.ChangeFeed.FeedProcessing
{
    using System;

    internal class ProcessorOptions
    {
        public FeedRange FeedRange { get; set; }

        public int? MaxItemCount { get; set; }

        public TimeSpan FeedPollDelay { get; set; }

        public string StartContinuation { get; set; }

        public bool StartFromBeginning { get; set; }

        public DateTime? StartTime { get; set; }

        public string SessionToken { get; set; }
    }
}