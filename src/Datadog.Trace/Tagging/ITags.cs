namespace Datadog.Trace.Tagging
{
    /// <summary>
    /// Tags
    /// </summary>
    public interface ITags
    {
        /// <summary>
        /// Gets tag
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>value</returns>
        string GetTag(string key);

        /// <summary>
        /// Sets tag
        /// </summary>
        /// <param name="key">tag</param>
        /// <param name="value">value</param>
        void SetTag(string key, string value);

        /// <summary>
        /// Gets metric
        /// </summary>
        /// <param name="key">metric</param>
        /// <returns>value</returns>
        double? GetMetric(string key);

        /// <summary>
        /// Sets metric
        /// </summary>
        /// <param name="key">metric</param>
        /// <param name="value">value</param>
        void SetMetric(string key, double? value);

        /// <summary>
        /// Serialize to byte array
        /// </summary>
        /// <param name="buffer">buffer</param>
        /// <param name="offset">offset</param>
        /// <returns>new offset</returns>
        int SerializeTo(ref byte[] buffer, int offset);
    }
}
