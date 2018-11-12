using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLibrary
{
    /// <summary>
    /// Defines a common interface for Logging implementations
    /// </summary>
    public interface ILogger
    {
        void WriteLog(LogType type, string Description);
        void WriteTrace(string Description);
        void WriteInformation(string Description);
        void WriteWarning(string Description);
        void WriteError(string Description);
    }
}
