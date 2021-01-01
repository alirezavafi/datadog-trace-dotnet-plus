using System;
using System.Linq;
using System.Threading.Tasks;
using Datadog.Trace.DogStatsd;
using Datadog.Trace.Logging;
using Datadog.Trace.Util;
using Datadog.Trace.Vendors.StatsdClient;

namespace Datadog.Trace.Agent
{
    internal class AgentWriter : IAgentWriter
    {
        public Task<bool> Ping()
        {
            return Task.FromResult(true);
        }

        public void WriteTrace(Span[] trace)
        {
            Serilog.Log.Logger.Information("Captured Trace {@Trace}", trace);
        }

        public Task FlushAndCloseAsync()
        {
            return Task.FromResult(0);
        }

        public Task FlushTracesAsync()
        {
            return Task.FromResult(0);
        }

        public void SetApiBaseEndpoint(Uri uri)
        {
        }
    }
}
