using System;

namespace DecorateMode
{
    public abstract class Decorator : BaseComponent
    {
        private BaseComponent _component;

        public void SetComponent(BaseComponent component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component?.Operation();
        }
    }

    public class DecoratorA : Decorator
    {
        public override void Operation()
        {
            Console.WriteLine("DecoratorA invoked.");
            base.Operation();
        }
    }

    public class DecoratorB : Decorator
    {
        public override void Operation()
        {
            Console.WriteLine("DecoratorB invoked.");
            base.Operation();
        }
    }

}