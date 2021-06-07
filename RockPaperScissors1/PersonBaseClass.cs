using System;
namespace RockPaperScissors1
{
    public class PersonBaseClass
    {
        private string fname;
        private string lname;
        
        //setter and getter for the first name 
        public string Fname
        {
            get{return fname;}
            set
            {
                if (value.Length > 20 || value.Length < 1)
                {
                    throw new InvalidOperationException("that fname is invalid");
                }
                fname = value;
            }

        }

       //setter and getter for the last name 
       public string Lname
        {
            get{return lname;}
            set
            {
                if (value.Length > 20 || value.Length < 1)
                {
                    throw new InvalidOperationException("that fname is invalid");
                }
                lname = value;
            }

        }

        
    }
}