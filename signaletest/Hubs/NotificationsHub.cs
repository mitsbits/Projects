using Microsoft.AspNetCore.SignalR;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace signaletest.Hubs
{
    public class NotificationsHub : Hub
    {
        private readonly string[] _args;
        private readonly Func<int, int, string> _groupKey = (i, j) => $"{i}-{j}";

        public NotificationsHub(string[] args)
        {
            _args = args;
        }

        public override Task OnConnectedAsync()
        {
            var i = this.Context.Connection.GetHttpContext().Request.Query["articleId"].SingleOrDefault();
            var j = this.Context.Connection.GetHttpContext().Request.Query["languageId"].SingleOrDefault();
            var groupName = _groupKey.Invoke(int.Parse(i), int.Parse(j));
            Groups.AddAsync(this.Context.ConnectionId, groupName);

            return base.OnConnectedAsync();
        }

        public async Task Notify()
        {

            var r = new Random();
            var model = new Notification
            {
                Id = r.Next(100, 1000),
                ArticleId = r.Next(1, 3),
                LanguageId = r.Next(1, 2),
                Image = r.Next(1, 3) == 2 ? @"images/peiraiws-ceo-708.jpg": string.Empty

            };
            model.Description = $"Desc for article {model.ArticleId}, language {model.LanguageId} with id {model.Id}";
            model.Title = $"A title for {model.Id}";
            var groupName = _groupKey.Invoke(model.ArticleId, model.LanguageId);
            //await Clients.Group(groupName).InvokeAsync("notify", model);
            await Clients.All.InvokeAsync("notify", model);
        }

        public class Notification
        {
            public int LanguageId { get; set; }
            public int ArticleId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.UtcNow;

            public string Image { get; set; } = @"images/peiraiws-ceo-708.jpg";
        }
    }
}