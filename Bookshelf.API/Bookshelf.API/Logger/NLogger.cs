using NLog;

namespace Bookshelf.API.Logger
{
    public class NLogger
    {
        public void LogWithNLog(string message)
        {
            var logger = LogManager.GetLogger("loggerFile");
            logger.Log(NLog.LogLevel.Error,message);
        }
        //in action 
        /*
            Logger.NLogger nLogger  = new Logger.NLogger();
            nlogLogger.LogWithNlog($"Error destination:
            {exceptionHandlerPathFeature.Path} \n Error message:
            {exceptionHandlerPathFeature.Error.Message} \n Stack trace:
            {exceptionHandlerPathFeature.Error.StackTrace}");
         */
    }
}
