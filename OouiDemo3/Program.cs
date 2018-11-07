using Ooui;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace OouiDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();
            UI.Publish("/", new Page1() { BindingContext = new ViewModel()}.GetOouiElement());

#if DEBUG
            UI.Port = 12345;
            UI.Host = "localhost";
            Process.Start("explorer",$"http://{UI.Host}:{UI.Port}");
            Console.ReadLine();
#endif
        }
    }
}
