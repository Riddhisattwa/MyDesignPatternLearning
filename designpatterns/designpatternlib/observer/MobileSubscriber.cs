using System;

namespace designpatternlib.observer;

public class MobileSubscriber : IObserver
{
    private string displaymsg;
    public string Display()
    {
        return displaymsg;
    }

    public void Update(string message, string sender)
    {
        string toBeDisplayed = "Mobile display=Current weather status={0} sent by {1}";
        displaymsg = string.Format(toBeDisplayed,message,sender);
    }
}
