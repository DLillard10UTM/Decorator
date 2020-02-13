using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget wid;

            wid = new BlueShadeBlocker(new ScrollDecorator(new BorderDecorator(new TextField(4, 5))));
            wid.draw();
            Console.ReadKey();
        }
    }
}
