/*
 * Author: Andrew Newbill
 * Date: 2/25/21
 * File: Widget.cs
 * Description: This is the widget interface which all widgets will inherit from. It simply defines what functions each widget must contain.
 * Environment: Windows 10, C# NET Core 3.1
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Andrew_N
{
    public interface Widget
    {
        //This interface is the parent of all widgets
        void draw();

    }
}
