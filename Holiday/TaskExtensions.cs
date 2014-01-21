using System;
using System.Threading;
using System.Threading.Tasks;

namespace Holiday
{
    /// <summary>
    /// Provides <see cref="Task"/> related extension methods.
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Throws a <see cref="TimeoutException"/> if the task does not complete within the allocated <see cref="TimeSpan"/>.
        /// </summary>
        /// <typeparam name="T">The result type of the task.</typeparam>
        /// <param name="task">The task.</param>
        /// <param name="timeout">The timeout period.</param>
        /// <returns>A <see cref="Task"/> representing the timeout-restricted task.</returns>
        /// <exception cref="TimeoutException">The task did not complete within the allotted time.</exception>
        public static Task<T> Timeout<T>(this Task<T> task, TimeSpan timeout)
        {
            var delayTask = new Task(() =>
                {
                    var waitHandle = new AutoResetEvent(false);
                    var timer = new Timer(_ => waitHandle.Set(), null, (int)timeout.TotalMilliseconds, -1);

                    waitHandle.WaitOne();
                });

            delayTask.Start();

            return Task.Factory.StartNew<T>(() =>
                {
                    Task.WaitAny(task, delayTask);

                    if (!task.IsCompleted && delayTask.IsCompleted)
                    {
                        throw new TimeoutException();
                    }

                    return task.Result;
                });
        }
    }
}