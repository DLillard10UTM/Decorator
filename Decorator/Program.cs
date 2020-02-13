using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget wid;
            BorderDecorator border;
            ScrollDecorator scroll;

            wid = new TextField(4, 5);
            border = new BorderDecorator(wid);
            scroll = new ScrollDecorator(border);

            wid.draw();
            border.draw();
            scroll.draw();
            Console.ReadKey();
        }
    }
}
