using Microsoft.AspNetCore.SignalR;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace signaletest.Hubs
{
    public class NotificationsHub : Hub
    {
        private readonly string[] _args;

        public NotificationsHub(string[] args)
        {
            _args = args;
        }

        public async Task Notify(Notification message)
        {
            var tasks = _args.Select(x => Clients.All.InvokeAsync("notify", new Notification() { Description = message.Description, Title = x, Id = 2 }));
            await Task.WhenAll(tasks);
        }

        public class Notification
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.UtcNow;
        }
    }
}