/*
 * Author: Andrew Newbill
 * Date: 2/25/21
 * File: Widget.cs
 * Description: This file contains the Decorator class and all of its children. Currently,  Decorator simply assigns its own widget passed in from the constructor. The child classes actually implement 
 *                  the modifications to the widget. They do not actually modify the widget though as this program is only here to show the model. Instead, they print to the console what they are and what
 *                  object they are "modifying".
 * Environment: Windows 10, C# NET Core 3.1
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Andrew_N
{
    public abstract class Decorator : Widget
    {
        //This abstract class allows us to "decorate"  any widget 
        public Widget wid;

        protected Decorator(Widget w)
        {
            wid = w;
        }

        public virtual void draw()
        {
        }

    }

    public class BorderDecorator : Decorator
    {
        //This class will draw a border around a widget

        //We can use the base class constructor for this
        public BorderDecorator(Widget w) : base(w) { }

        public override void draw()
        {
            //wid.draw();
            Console.WriteLine("I am a border decorator, holding a " + wid.GetType().Name);
        }

    }

   public  class ScrollDecorator : Decorator
    {
        //This class will add a scroll decorator to the widget

        //We can use the base class constructor for this
        public ScrollDecorator(Widget w) : base(w) { }

        public override void draw()
        {
            //wid.draw();
            Console.WriteLine("I am a scroll decorator, holding a " + wid.GetType().Name);
        }

    }

    public class BoldDecorator : Decorator
    {
        //This class will bold all text in the widget

        //We can use the base class constructor for this
        public BoldDecorator(Widget w) : base(w) { }

        public override void draw()
        {
            //wid.draw();
            Console.WriteLine("I am a bold decorator, holding a " + wid.GetType().Name);
        }

    }
}
