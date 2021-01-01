namespace Datadog.Trace.Tagging
{
    /// <summary>
    /// Common Tags
    /// </summary>
    public class CommonTags : TagsList
    {
        /// <summary>
        /// Common Metrics Properties
        /// </summary>
        protected static readonly IProperty<double?>[] CommonMetricsProperties =
        {
            new Property<CommonTags, double?>(Trace.Metrics.SamplingLimitDecision, t => t.SamplingLimitDecision, (t, v) => t.SamplingLimitDecision = v),
            new Property<CommonTags, double?>(Trace.Metrics.SamplingPriority, t => t.SamplingPriority, (t, v) => t.SamplingPriority = v)
        };

        /// <summary>
        /// Common Tags Properties
        /// </summary>
        protected static readonly IProperty<string>[] CommonTagsProperties =
        {
            new Property<CommonTags, string>(Trace.Tags.Env, t => t.Environment, (t, v) => t.Environment = v),
            new Property<CommonTags, string>(Trace.Tags.Version, t => t.Version, (t, v) => t.Version = v)
        };

        /// <summary>
        /// Gets or sets Environment
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// Gets or sets Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Sampling Priority
        /// </summary>
        public double? SamplingPriority { get; set; }

        /// <summary>
        /// Gets or sets Sampling Limit Decision
        /// </summary>
        public double? SamplingLimitDecision { get; set; }

        /// <summary>
        /// Get Additional Metrics
        /// </summary>
        /// <returns>Tags</returns>
        protected override IProperty<double?>[] GetAdditionalMetrics() => CommonMetricsProperties;

        /// <summary>
        /// Get Additional Tags
        /// </summary>
        /// <returns>Tags</returns>
        protected override IProperty<string>[] GetAdditionalTags() => CommonTagsProperties;
    }
}
