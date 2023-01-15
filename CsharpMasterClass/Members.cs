using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMasterClass
{
    class Members
    {// fields/ class members 


        private string memberName;
        private string jobTitle;
        private int age;


        // properties
        public string JobTitle
        {
            get
            {
                return this.jobTitle;
            }
            set { jobTitle = value; }
        }
        public int Age{ get; set; }
        public string MemberName { get; set; }


        #region Constructor
        public Members()
        {
            jobTitle = "Developer";
            memberName = "Sally";
            age = 45;
            Console.WriteLine("You are a friend");
        }
        #endregion

        #region destructor
        //only one per class. When members run out of scope, the finalizer or descructor is called. only use when necessary
        // only here for this specific class. Not inheritable. Here for cleaining up

        ~Members()
        {
            Console.WriteLine("This is a finalizer");
        }
        #endregion
    }
}
