namespace oops
{
    public class SmsNotification: Notification
    {
        private string mobilenumFrom;
        private string mobilenumTo;
        public SmsNotification():base()
        {
            
        }
        public SmsNotification(string fromnum, string tonum, string msg): base(msg)
        {
            mobilenumFrom = fromnum;
            mobilenumTo = tonum;
        }
        public override void SendNotification()
        {
            if(mobilenumFrom!=null && mobilenumFrom.Length == 10 && mobilenumTo!=null && mobilenumTo.Length == 10)
            {
                CheckWithProvider();
                SendMessage();
            }
            else
                Console.WriteLine("Message sending failed as mobile numbers are invalid {0}, {1}",mobilenumFrom,mobilenumTo);
        }
        private void CheckWithProvider()
        {
            Console.WriteLine("Checking with provider with {0} has balance to send message {1}",mobilenumFrom,base.GetNotification());
        }
        private void SendMessage()
        {
          Console.WriteLine("Message {0} sent to {1}",base.GetNotification(), mobilenumTo);   
        }
    }
}