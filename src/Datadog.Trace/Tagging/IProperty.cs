using System;

namespace Datadog.Trace.Tagging
{
    /// <summary>
    /// IProperty
    /// </summary>
    /// <typeparam name="TResult">TResult</typeparam>
    public interface IProperty<TResult>
    {
        /// <summary>
        /// Gets a value indicating whether IsReadOnly
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Gets Key
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Gets Getter
        /// </summary>
        Func<ITags, TResult> Getter { get; }

        /// <summary>
        /// Gets Setter
        /// </summary>
        Action<ITags, TResult> Setter { get; }
    }
}
