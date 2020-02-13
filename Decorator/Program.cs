using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget wid;
            BorderDecorator border;

            wid = new TextField(4, 5);
            border = new BorderDecorator(wid);

            wid.draw();
            border.draw();
            Console.ReadKey();
        }
    }
}
