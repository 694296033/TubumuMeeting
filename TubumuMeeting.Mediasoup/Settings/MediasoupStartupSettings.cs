﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TubumuMeeting.Mediasoup
{
    public class MediasoupStartupSettings
    {
        public string MediasoupVersion { get; set; }

        public string WorkerPath { get; set; }

        public int NumberOfWorkers { get; set; }
    }
}
