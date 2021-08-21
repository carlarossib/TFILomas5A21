using System;
using System.Collections.Generic;
using LMJ.Framework.Model;

namespace LMJ.Framework.Logging
{
    public  interface ILoggingService
    {
        void Log(string message);
        void Error(string message);
        void Error(Exception ex);
        void Initialise(int maxLogSize); IList<LogEntry> ListLogFile();
        void Recycle();
        void ClearLogFiles();
    }
}
