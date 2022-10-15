using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ilya02Il.BaseTypes.Extensions
{
    public static class AsyncExtensions
    {
        public static async Task<T> WithCancellation<T>(this Task<T> task,
            CancellationToken cancelToken)
        {
            return await (Task<T>)((Task)task).WithCancellation(cancelToken);
        }

        public static async Task WithCancellation(this Task task,
            CancellationToken cancelToken)
        {
            var taskCompletionSrc = new TaskCompletionSource<object>(
                TaskCreationOptions.RunContinuationsAsynchronously);

            var cancelTokenRegistration = cancelToken.Register(state =>
                ((TaskCompletionSource<object>)state).TrySetResult(null),
                taskCompletionSrc);

            using (cancelTokenRegistration)
            {
                var resultTask = await Task.WhenAny(task, taskCompletionSrc.Task);

                if (resultTask == taskCompletionSrc.Task)
                    throw new OperationCanceledException(cancelToken);

                await task;
            }
        }

        public static async Task TryAsync(this Task task,
            Action<Exception> errorHandler = null)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                errorHandler?.Invoke(ex);
                await Task.FromException(ex);
            }
        }

        public static async Task<T> TryAsync<T>(this Task<T> task,
            Action<Exception> errorHandler = null)
        {
            return await (Task<T>)((Task)task).TryAsync(errorHandler);
        }
    }
}
