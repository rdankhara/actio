using System;

namespace Actio.Shared.Commands
{
    public class CreateActivity : IAuthenticatedCommand
    {
        public CreateActivity()
        {
            
        }
        public Guid UserId {get; set;}
    }
}