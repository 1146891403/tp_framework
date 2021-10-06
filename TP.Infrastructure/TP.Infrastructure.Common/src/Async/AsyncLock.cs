using System;
using System.Threading;
using System.Threading.Tasks;

namespace TP.Infrastructure.Common.Async
{
    public sealed class AsyncLock
    {
        private readonly AsyncSemaphore _semaphore;
        private readonly Task<Releaser> _releaser;

        public AsyncLock()
        {
            _semaphore = new AsyncSemaphore(1);
            _releaser = Task.FromResult(new Releaser(this));
        }

        public Task<Releaser> LockAsync()
        {
            var wait = _semaphore.WaitAsync();

            return wait.IsCompleted ?
                _releaser :
                wait.ContinueWith((t, state) => new Releaser((AsyncLock)state), this, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }

        public struct Releaser : IDisposable
        {
            private readonly AsyncLock _asyncLock;

            internal Releaser(AsyncLock asyncLock)
            {
                _asyncLock = asyncLock;
            }

            public void Dispose()
            {
                if (_asyncLock != null)
                    _asyncLock._semaphore.Release();
            }
        }
    }
}
