﻿using LogViewer.Models;
using LogViewer.Persistence.Interface;

namespace LogViewer.Core.Interface
{
    public interface ILogEngine
    {
        bool EngineStarted { get; }

        void StartEngine(params ILogWriter[] logWriters);

        bool Enqueue(Log log);
    }
}
