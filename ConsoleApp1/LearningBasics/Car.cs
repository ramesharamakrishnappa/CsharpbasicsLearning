using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LearningBasics
{
    public class Car : Machine
    {

        public Car()
        {
            Console.WriteLine("Constroctor in Car executed");
        }

        public Car( int EngineSize1)
        {
            EngineSize = EngineSize1;
            Console.WriteLine("parameterized constructor in Car executed");
        }
        public void RunEngine()
        {
            Console.WriteLine("Engine running in Car Class");
        }
       /* public void StopEngine()
        {
            Console.WriteLine("Engine stopped from car class");
        }*/
    }
}
