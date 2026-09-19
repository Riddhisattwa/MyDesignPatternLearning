namespace oops
{
    public abstract class Notification
    {
        private string notification;
        public Notification()
        {
            notification = "";
        }
        public Notification(string message)
        {
            notification = message;
        }
        public string GetNotification()
        {
            return notification;
        }
        public abstract void SendNotification();
    }
}