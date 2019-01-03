using System;

public static void Run(TimerInfo Timer, ICollector<string> outputQueueItem, ILogger log)
{
    outputQueueItem.Add($"New message inserted at {DateTime.UtcNow}");
}
