using System;

namespace SO.Common.Logging
{
    public interface ILogger
    {
        void LogException(Exception exception);
        void LogError(string message);
        void LogWarningMessage(string message);
        void LogInfoMessage(string message);
    }
}
