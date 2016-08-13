using System;

namespace DecorateMode
{
    public class ConcreateComponent : BaseComponent
    {
        public override void Operation()
        {
            Console.WriteLine("Operation of concreate object.");
        }
    }
}