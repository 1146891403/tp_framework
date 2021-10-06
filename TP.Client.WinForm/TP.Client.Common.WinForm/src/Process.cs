using System;
using System.Threading;
using System.Threading.Tasks;

namespace TP.Client.WinForm.Common
{
    public static class Process
    {
        public static Task RunAsync(Action action, Action<Task> continuationFunction)
        {
            if(action == null)
            {
                throw new ArgumentNullException("action");
            }

            return RunAsync(() => new Task(
                () =>
                {
                    action.Invoke();
                }), continuationFunction);
        }

        public static Task RunAsync(Action action, CancellationToken cancellationToken, Action<Task> continuationFunction)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            return RunAsync(() => new Task(
                () =>
                {
                    action.Invoke();
                }, cancellationToken), continuationFunction);
        }

        public static async Task<TResult> RunAsync<TResult>(Action action, Func<Task, TResult> continuationFunction)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            return await RunAsync<TResult>(() => new Task(
                () =>
                {
                    action.Invoke();
                }), continuationFunction);
        }

        public static Task<TResult> Run<TResult>(Func<TResult> action, Action<Task<TResult>> callback)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            return Run<TResult>(() => new Task<TResult>(
                () =>
                {
                    return action.Invoke();
                }), callback);
        }

        public static Task<TResult> Run<TResult>(Func<TResult> action, CancellationToken cancellationToken, Action<Task<TResult>> callback)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            return Run<TResult>(() => new Task<TResult>(
                () =>
                {
                    return action.Invoke();
                }, cancellationToken), callback);
        }
        
        private static Task RunAsync(Func<Task> taskFactory, Action<Task> continuationFunction)
        {
            Task task = taskFactory.Invoke();

            task.Start();

            if (continuationFunction != null)
            {
                task.ContinueWith(
                    t =>
                    {
                        continuationFunction.Invoke(t);
                    });
            }

            return task;
        }

        private static Task<TResult> Run<TResult>(Func<Task<TResult>> taskFactory, Action<Task<TResult>> callback)
        {
            Task<TResult> task = taskFactory.Invoke();

            if (callback != null)
            {
                task.ContinueWith(
                    t =>
                    {
                        callback.Invoke(t);
                    });
            }

            task.Start();

            return task;
        }
        
        private static async Task<TResult> RunAsync<TResult>(Func<Task> taskFactory, Func<Task, TResult> continuationFunction)
        {
            Task task = taskFactory.Invoke();

            task.Start();
            task.Wait();

            var result = task.ContinueWith(
                    t =>
                    {
                        return continuationFunction.Invoke(t);
                    });

            return await result;
        }
        
        private static Task<TResult> Run<TResult>(Func<Task<TResult>> taskFactory, Func<Task<TResult>> continuationFunction)
        {
            Task<TResult> task = taskFactory.Invoke();
            
            if (continuationFunction != null)
            {
                task.ContinueWith(
                    async t =>
                    {
                        return await continuationFunction.Invoke();
                    });
            }

            task.Start();

            return task;
        }
    }
}
