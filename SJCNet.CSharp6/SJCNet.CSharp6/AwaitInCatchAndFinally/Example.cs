using System;
using System.Threading;
using System.Threading.Tasks;
using SJCNet.CSharp6.Utility;

namespace SJCNet.CSharp6.AwaitInCatchAndFinally
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Await in Catch and Finally");
            ExecuteAsync();
        }

        public async void ExecuteAsync()
        {
            try
            {
                DoSomeWork();
            }
            catch (Exception ex)
            {
                Logger.Write("Catch Await: Start");
                await LogAsync(ex.Message);
                Logger.Write("Catch Await: End");
            }
            finally
            {
                Logger.Write("Finally Await: Start");
                await LogAsync("In finally block");
                Logger.Write("Finally Await: End");
            }
        }

        public void DoSomeWork()
        {
            Logger.Write("DoSomeWork: Start");
            Thread.Sleep(1000);
            throw new Exception("DoSomeWork failed");
        }

        public async Task LogAsync(string message)
        {
            await Task.Factory.StartNew(() =>
            {
                Logger.Write("LogAsync Start");
                Thread.Sleep(1000);
                Logger.Write($"LogAsync Message: {message}");
                Logger.Write("LogAsync End");
            });
        }
    }
}