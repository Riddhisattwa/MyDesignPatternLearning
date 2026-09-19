/*
Abstraction and Inheritence displayed together. SendNotification abstracts all the internals
from outside and also inherits from Notification. We can create Notification object using EmailNotification concrete class.
 We can inject EmailNotification directly to improve loose coupling.
*/
namespace oops
{
    public class MailNotification : Notification
    {
        public MailNotification():base()
        {
        }
        public MailNotification(string message): base(message)
        {
            
        }
        public override void SendNotification()
        {
            Authenticate();
            SendMessage();
        }
        private void Authenticate()
        {
            Console.WriteLine("Authenticating user");
        }
        private void SendMessage()
        {
            Console.WriteLine("Sending Message to server:{0}",base.GetNotification());
        }
    }
}