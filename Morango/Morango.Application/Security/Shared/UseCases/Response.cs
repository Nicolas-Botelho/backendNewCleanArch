using Flunt.Notifications;

namespace Morango.Application.Shared.UseCases
{
    public abstract class Response
    {
        public string Message { get; set; } = string.Empty;
        public int Status { get; set; } = 400;
        public bool IsSuccess => Status is >= 200 and <= 299;
        public IEnumerable<Notification>? Notifications { get; set; }
    }
}