using System;
namespace DelegateSimple.EventHandelerDemo
{
    public class EventHandelerClass
    {
        //1.Create a delegate type
        public delegate void MessageHandeler(object source , EventArgs args);

        //2.instantiate that delegate
        public event MessageHandeler myMessageHandeler;

        //3 Create a method (Rasing or invoke the event prtoector method) 
        public void MessageSend(string message)
        {
            message +=message;
            OnMessageSend(message);

        }
        private void OnMessageSend(string message)
        { 
            if (myMessageHandeler!=null)
            {
                myMessageHandeler(this, new EventArgs() { usersMessage = message});
            }
        {

        }
    }
}