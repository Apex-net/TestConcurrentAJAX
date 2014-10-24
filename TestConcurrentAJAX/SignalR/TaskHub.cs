
using TestConcurrentAJAX.Utilities;

namespace TestConcurrentAJAX.SignalR
{
    using Microsoft.AspNet.SignalR;
    using System.Threading.Tasks;
    using Tasks;

    public class TaskHub : Hub
    {
        public async Task DoTaskAsync(int id)
        {
            ////// Call the broadcastMessage method to update clients.
            ////Clients.All.broadcastMessage(name, message);

            var delay = await new MyTask(id).DoTaskAsync();

            Clients.All.showResult(ContentFormatter.FormatContent(id, delay));
        }
    }
}
