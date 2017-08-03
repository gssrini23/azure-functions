using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"hello world! C# Timer trigger function executed at: {DateTime.Now}");
}
