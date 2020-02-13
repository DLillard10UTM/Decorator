using System;


/*
 * Author: Danny Lillard
 * Date 2.12.2020
 * Description: Main driver, calls decorators in an intuitive manner.
 */
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
