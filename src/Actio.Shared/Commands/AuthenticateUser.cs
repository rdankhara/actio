namespace  Actio.Shared.Commands
{
    public class AuthenticateUser : ICommand
    {
        public string Email {get;set;}

        public string Password {get;set;}
    }
}