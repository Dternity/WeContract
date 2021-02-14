using System.Reflection;

namespace WeContractLib.Diagnostics
{
    public static class Log
    {
        public static void Debug(string text) => Logger.Inst.Debug(text);
        public static void Error(string text) => Logger.Inst.Error(text);
        public static void Error(string text, MethodBase methodBase) => Logger.Inst.Error(text, methodBase);

        public static void Fatal(string text) => Logger.Inst.Fatal(text);
        public static void Fatal(string text, MethodBase methodBase) => Logger.Inst.Fatal(text, methodBase);
        public static void Info(string text) => Logger.Inst.Info(text);
        public static void Trace(string text) => Logger.Inst.Trace(text);
        public static void Warning(string text) => Logger.Inst.Warning(text);
    }
}
