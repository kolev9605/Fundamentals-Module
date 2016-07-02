using System;

namespace HTMLDispatcher
{
    public class DispatcherMain
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            //Console.WriteLine(div * 2);

        }
    }
}
