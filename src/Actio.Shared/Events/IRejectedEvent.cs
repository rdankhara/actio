namespace Actio.Shared.Events
{
    public interface IRejectedEvent : IEvent{

        string Reason {get;}

        string Code {get;}
    }

    public class CreateUserRejected : IRejectedEvent
    {
        public string Reason {get;}

        public string Code {get;}

        public string Email {get;}

        protected CreateUserRejected(){}

        public CreateUserRejected(string email, 
            string code, 
            string reason) 
        {
            Email = email;   
            Code = code;
            Reason = reason;
        }
    }
}