using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecorateMode
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreateComponent cc = new ConcreateComponent();
            DecoratorA da = new DecoratorA();
            DecoratorB db = new DecoratorB();

            da.SetComponent(cc);
            db.SetComponent(da);
            db.Operation();

            Console.ReadKey();
        }
    }
}
