/*
 * Author: Andrew Newbill
 * Date: 2/25/21
 * File: Program.cs
 * Description: This is the main class, where all of are objects are acted upon. We create a widget, then add decorators to it to "modify" it's contents. This program doesn't actually do anything other than
 *                  demonstrate the decorator pattern. For more information on the classes are connected, see the included UML. Each class has a draw function, which will either draw the widget or in the case of a decorator,
 *                  modify the widget.
 * Environment: Windows 10, C# NET Core 3.1
 */
using System;

namespace Decorator_Andrew_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main will create a text field and three decorator objects that hold it. They can "theoritically" be used to modify it but for now they simply state what they are and what they hold.

            TextField text = new TextField(10,10);
            BorderDecorator bDecorator = new BorderDecorator(text);
            ScrollDecorator sDecorator = new ScrollDecorator(text);
            BoldDecorator boldDecorator = new BoldDecorator(text);

            text.draw();

            bDecorator.draw();
            sDecorator.draw();
            boldDecorator.draw();

            //Use this to keep the console open until a key is pressed.
            Console.ReadLine();



        }
    }
}
