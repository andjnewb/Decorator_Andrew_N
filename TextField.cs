/*
 * Author: Andrew Newbill
 * Date: 2/25/21
 * File: TextField.cs
 * Description: This is the TextField class which inherits from widget. It contains a constructor which accepts a width and height. It also has a draw function, which outputs to the console the size of 
 *                  the TextField widget which was drawn.
 * Environment: Windows 10, C# NET Core 3.1
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Andrew_N
{
    public class TextField : Widget
    {
        //This class will draw a text field based on width and height.
        int width;
        int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void draw()
        {
            //Not actually drawing anything
            Console.WriteLine("Drew a TextField with width: " + width + " and height: " + height);
        }


    }
}
