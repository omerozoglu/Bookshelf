using Bookshelf.API.Entities.Concrete;
using NLog;

namespace Bookshelf.API.Logger
{
    public class NLogger
    {
        public void LogWithNLog(Log log,NLog.LogLevel logLevel)
        {
            var logger = LogManager.GetLogger("loggerFile");
            var message = 
                " Message: " + log.Message+" "+
                " Data: " +log.Data+" "+
                " Details: "+
                " Source: "+ log.Source+" "+
                " Path: "+ log.Path+" "+
                " CreatedUserId: "+log.CreatedUserId.ToString();
            logger.Log(logLevel,message);
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
