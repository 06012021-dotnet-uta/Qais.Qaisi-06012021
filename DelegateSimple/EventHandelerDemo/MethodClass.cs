using System;
namespace DelegateSimple.EventHandelerDemo
{
    public class MethodClass
    {
        public void OnMessageSend(object sourch, EventArgs args)
        {   
            Console.WriteLine("Add a word");
            string usersMessage= Console.ReadLine();
            args.usersMessage +=usersMessage;
        }
    }
}