using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoshPractice
{
    internal class Cars
    {
        private string _name;
        private int _hp;
        private string _color;

        

        // Default Constructor

        public Cars()
        {
            Console.WriteLine(_name + " was created");
            _name = "Car";
            _hp = 0;
            _color = "Red";

        }

        //Partial Specific Constructor
        public Cars(string name, int hp = 0, string color = "black")
        {
            Console.WriteLine(name + " was created");
            _name = name;
            _hp = hp;
            _color = color;
        }

        //Specific COnstructor 



        public void Drive()
        {
            Console.WriteLine(_name + " is now driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + " has stopped driving");
        }

        public void Description()
        {
            Console.WriteLine("The" + _color + " " + _name + " has " + _hp + " Horsepower");
        }
    }
}
