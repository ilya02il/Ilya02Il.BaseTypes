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
            return await (Task<T>)(await TaskCancellation<T>(task, cancelToken));
        }

        public static async Task WithCancellation(this Task task,
            CancellationToken cancelToken)
        {
            await TaskCancellation<object>(task, cancelToken);
        }

        public static async Task Then(this Task task,
            Action onSuccess = default,
            Action onCancelled = default)
        {
            try
            {
                await task;

                if (onSuccess == null)
                    await Task.CompletedTask;

                onSuccess();
            }
            catch (OperationCanceledException)
            {
                if (onCancelled == null)
                    await Task.CompletedTask;

                onCancelled();
                return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<TOut> Then<TIn, TOut>(this Task<TIn> task,
            Func<TIn, TOut> onSuccess,
            Func<TOut> onCancelled = default)
        {
            try
            {
                var taskResult = await task;
                return onSuccess(taskResult);
            }
            catch (OperationCanceledException)
            {
                if (onCancelled == null)
                    throw new ArgumentNullException(nameof(onCancelled));

                return onCancelled();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static async Task Catch(this Task task, Action<Exception> catchBlock = default)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                catchBlock?.Invoke(ex);
            }
        }

        public static async Task<TOut> Catch<TOut>(this Task<TOut> task,
            Func<Exception, TOut> catchBlock)
        {
            try
            {
                return await task;
            }
            catch (Exception ex)
            {
                return catchBlock(ex);
            }
        }

        public static async Task Finally(this Task task, Action finallyBlock)
        {
            try
            {
                await task;
            }
            finally
            {
                finallyBlock();
            }
        }

        public static async Task<TOut> Finally<TOut>(this Task<TOut> task,
            Action finallyBlock)
        {
            try
            {
                return await task;
            }
            finally
            {
                finallyBlock();
            }
        }

        private static async Task<Task> TaskCancellation<T>(Task task, CancellationToken cancelToken)
        {
            var taskCompletionSrc = new TaskCompletionSource<T>(
                TaskCreationOptions.RunContinuationsAsynchronously);

            var cancelTokenRegistration = cancelToken.Register(state =>
                ((TaskCompletionSource<T>)state).TrySetResult(default),
                taskCompletionSrc);

            using (cancelTokenRegistration)
            {
                var resultTask = await Task.WhenAny(task, taskCompletionSrc.Task);

                if (resultTask == taskCompletionSrc.Task)
                    throw new OperationCanceledException(cancelToken);

                return task;
            }
        }
    }
}
