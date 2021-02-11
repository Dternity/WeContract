using System.Diagnostics;

namespace WeContractLib.Diagnostics
{
    public static class StopWatchExt
    {
        public static double LogElapsedMs(this Stopwatch sw, bool restart = true, string prefix = default)
        {
            sw.Stop();
            var time = sw.Elapsed.TotalMilliseconds;
            Logger.Inst.Info($@"{prefix} Took:{time}ms");
            if (restart)
            {
                sw.Restart();
            }

            return time;
        }
    }
}
