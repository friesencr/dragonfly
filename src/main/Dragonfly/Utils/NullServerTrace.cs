﻿using System.Diagnostics;

namespace Dragonfly.Utils
{
    class NullServerTrace : IServerTrace
    {
        public static readonly IServerTrace Instance = new NullServerTrace();

        public void Event(TraceEventType type, TraceMessage message)
        {            
        }
    }
}