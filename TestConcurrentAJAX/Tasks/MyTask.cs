using System;
using System.Threading.Tasks;

namespace TestConcurrentAJAX.Tasks
{
    public class MyTask
    {
        private readonly int _id;

        public MyTask(int id)
        {
            _id = id;
        }

        public async Task<int> DoTaskAsync()
        {
            var delay = new Random(this._id).Next(3000, 3000);
            await Task.Delay(delay);

            return delay;
        }
    }
}