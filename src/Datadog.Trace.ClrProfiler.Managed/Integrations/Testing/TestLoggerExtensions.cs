namespace Datadog.Trace.ClrProfiler.Integrations.Testing
{
    /// <summary>
    /// Test logger extensions
    /// </summary>
    internal static class TestLoggerExtensions
    {
        public static void TestMethodNotFound(this Serilog.ILogger logger)
        {
            logger.Error("Error: the test method can't be retrieved.");
        }

        public static void TestClassTypeNotFound(this Serilog.ILogger logger)
        {
            logger.Error("Error: the test class type can't be retrieved.");
        }
    }
}
