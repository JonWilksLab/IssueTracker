using InterfaceLibrary;
using ModelLibrary;
using System;

namespace InMemoryLoggerImplementation
{
    public class Logger : ILogger
    {
        public void WriteError(string Description)
        {
            throw new NotImplementedException();
        }

        public void WriteInformation(string Description)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(LogType type, string Description)
        {
            throw new NotImplementedException();
        }

        public void WriteTrace(string Description)
        {
            throw new NotImplementedException();
        }

        public void WriteWarning(string Description)
        {
            throw new NotImplementedException();
        }
    }
}
