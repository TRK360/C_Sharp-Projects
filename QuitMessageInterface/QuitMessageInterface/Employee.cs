using System;
using System.Collections.Generic;
using System.Text;

namespace QuitMessageInterface
{
    public class Employee : Person, IQuittable
    {


        public int eNumber { get; set; }///receivable input at time of logging a specific type of person (person is abstract)

        public override void Append() { throw new NotImplementedException(); }


        public override void SayName()
        {
            Console.WriteLine("Adding in an element specific to this person type:  \n\nEmployee\n\n\n---ID#:  -" + eNumber + "-  ---\n\n");
            base.SayName();/// calling in the base elements SayName,  override here acknowledges contract between Employee class and parent class

        }


        public void Quit(int l)/// inegers match callup requirement in IPolygon Interface
        {

            int quit = l;
            Console.WriteLine("\nYour Desire to QUIT is acknowledged: " + quit +"%\n\n");

        }







    }
}
