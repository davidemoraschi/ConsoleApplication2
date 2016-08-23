using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Brick brick = new Brick(new UsbCommunication());
            brick.BrickChanged += OnBrickChanged;
            brick.ConnectAsync();
        }

        private static void OnBrickChanged(object sender, BrickChangedEventArgs e)
        {
            // print out the value of the sensor on Port 1 (more on this later...)
            Debug.WriteLine(e.Ports[InputPort.One].SIValue);
        }
    }
}
