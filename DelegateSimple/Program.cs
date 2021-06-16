using System;

namespace DelegateSimple
{
    public class Methodclass
    {
        
        //Action Delegate example 
        public void method1(int x)
        {Console.WriteLine($"Method  {x}");}
        public void method2(int x)
        {Console.WriteLine($"Method  {x}");}
        public void method3(int x)
        {Console.WriteLine($"Method  {x}");}
        //End of the Action Delegate example 
        public void method1()
        {Console.WriteLine("Method1");}
        public void method2()
        {Console.WriteLine("Method2");}
        public void method3()
        {Console.WriteLine("Method3");}




        #region  "This is the start of the regin"
        public int method4(ref string message)
        {
            Console.WriteLine($"Add Something to this methode4");
            string m=Console.ReadLine();//get a new message from the user 
            message+=m;
            return 1;
        }
    //Function deleagte method
        public int method6(string message)
        {
            Console.WriteLine($"Add something to this methode5"); //get a new message from the user 
            string m=Console.ReadLine();
            message+=m;
            return 6;
        }
        #endregion
    
    }  
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass myDelegateClass= new DelegateClass();
            Methodclass myMethodClass =new Methodclass();
            myDelegateClass.mySimpleDelegate =myMethodClass.method1;
            myDelegateClass.mySimpleDelegate +=myMethodClass.method2;
            myDelegateClass.mySimpleDelegate +=myMethodClass.method3;
            //to invoke the delegate 
            myDelegateClass.mySimpleDelegate();
            Console.WriteLine(myDelegateClass.mySimpleDelegate.GetInvocationList().ToString());
            myDelegateClass.myNotSimpleDelegate= myMethodClass.method4;
            myDelegateClass.myNotSimpleDelegate+= myMethodClass.method5;
            //myDelegateClass.myNotSimpleDelegate("This");
            
            string myString="this";
            int result=myDelegateClass.myNotSimpleDelegate(ref myString);
            Console.WriteLine($"this result is => {result}");
            Console.WriteLine($"this result is => {myString}");
            #region Action<> Delegate
            myDelegateClass.mySimpleDelegate =myMethodClass.method1;
            myDelegateClass.mySimpleDelegate +=myMethodClass.method2;
            myDelegateClass.mySimpleDelegate +=myMethodClass.method3;
            myDelegateClass.myAction(1);
            #endregion
            myDelegateClass.myfunctionDelegate=myMethodClass.method6;
            int myInt=myDelegateClass.myfunctionDelegate;

        }
    }
}
