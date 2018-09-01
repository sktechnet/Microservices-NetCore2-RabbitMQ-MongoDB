namespace Actio.Common.Commands
{
    public class AuthenticateUser : IEvent
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
