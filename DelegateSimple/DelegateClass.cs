using System; 
namespace DelegateSimple
{
    public class DelegateClass
    {
        //Declare Delegate Type
        public delegate void SimpleDelegate();
        /*Now create instance of the delegate type that 
        you can assign the method*/
        public SimpleDelegate mySimpleDelegate;
        public delegate int NotSimpleDelegate(ref string Message);
        public NotSimpleDelegate myNotSimpleDelegate;

        /*action delegate does not return value */
        public Action<> myAction;
        public Func<string> myfunctionDelegate;
        
    }
}