using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Danny Lillard
 * Date: 2.12.2020
 * Description: Practice with the decorator design pattern.
 */
namespace Decorator
{
    public interface Widget
    {
        public void draw();
    }

    public class TextField : Widget
    {
        int width;
        int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void draw()
        {
            Console.WriteLine("I am a text field! My values are: height: " + height + " width: " + width);
        }
    }

    public abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget w)
        {
            wid = w;
        }
        public virtual void draw()
        {
            wid.draw();
        }
    }

    public class BorderDecorator : Decorator
    {
        
        public BorderDecorator(Widget w) : base(w)
        {
            
        }

        public override void draw()
        {
            Console.Write("Border Decorator! Containing: ");
            base.draw();
        }
    }

    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {

        }

        public override void draw()
        {
            Console.Write("Scroll Decorator! Containing: ");
            base.draw();
        }
    }
}
