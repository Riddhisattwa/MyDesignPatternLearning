namespace oops
{
    public class SmsNotification: INotification
    {
        private readonly string mobilenumFrom;
        private readonly string mobilenumTo;

        private string txtMsg;

        public SmsNotification(string fromnum, string tonum)
        {
            mobilenumFrom = fromnum;
            mobilenumTo = tonum;
        }

        public SmsNotification(string fromnum, string tonum, string msg)
        {
            mobilenumFrom = fromnum;
            mobilenumTo = tonum;
            txtMsg = msg;
        }
        public void SendNotification()
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
            Console.WriteLine("Checking with provider with {0} has balance to send message {1}",mobilenumFrom,txtMsg);
        }
        private void SendMessage()
        {
          Console.WriteLine("Message {0} sent to {1}",txtMsg, mobilenumTo);   
        }
        public void UpdateMessage(string message)
        {
            this.txtMsg = message;
        }
    }
}