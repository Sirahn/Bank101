using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank101
{
    class Clients
    {

        //fields
        private string firstName = null;
        private string lastName = null;

        //properties

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        //methods
        public override string ToString()
        {
            return firstName + " " + lastName;
        }


        //contructor

        
        public Clients()
        {
            this.FirstName = "Sirahn";
            this.LastName = "Butler";
        }
       

        

    }
}
