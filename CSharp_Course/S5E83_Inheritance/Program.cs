using System;

namespace S5E83_Inheritance
{
    //Example of three Bank terminals communication with server

    // "virtual" is used so some heirs could use basic class method & some could reuse it

    public class BankTerminal
    {
        protected string id;

        //rewritten Constructor for all heirs:
        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine($"Basic Connection Protocol {id}.");

        }

    }
    //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    public class Model_X_Terminal : BankTerminal
    {
        /*
        //Constructor:
        public Model_X_Terminal(string id)
        {
            base.id = id;
        }
        //Can be rewritten for all heirs in base class
        */
        // And give all work to base constructor:
        public Model_X_Terminal(string id) : base(id)
        {

        }

        public override void Connect()
        {
            //to use basic variation of this method "base" key word is used

            base.Connect();
            Console.WriteLine("Aditional actions for Model_X");
        }
    }
    //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    public class Model_S_Terminal : BankTerminal
    {
        public Model_S_Terminal(string id) : base(id)
        {
            base.id = id;
        }

        public override void Connect()
        { 
           Console.WriteLine($"Aditional actions for Model_S {id}");
        }
    }
}
    

