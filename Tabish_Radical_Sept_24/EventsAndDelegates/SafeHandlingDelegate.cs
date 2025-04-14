using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.EventsAndDelegates
{
    //Events make delegate usage safe and controlled.
    public class ButtonWithSafeDelegate
    {
        // Declare a delegate type
        // This delegate can point to any method that takes no parameters and returns void
        public delegate void ButtonClickHandler();
        public event ButtonClickHandler OnClick;  // ✅ Safer!
        public void Click()
        {
            Console.WriteLine("Button clicked!");

            // Trigger the event
            OnClick?.Invoke();
        }

        public void ShowPopup() { Console.WriteLine("Popup: Button clicked!"); }
        public void LogClick() { Console.WriteLine("Log: Button clicked."); }



    }

    public class Program1
    {

        static void Main(string[] args)
        {
            ButtonWithSafeDelegate btn1 = new ButtonWithSafeDelegate();
            btn1.OnClick += btn1.ShowPopup;
            btn1.OnClick += btn1.LogClick;

            btn1.OnClick += null; // ❌ Now this gives a compile-time ERROR

            btn1.Click();
        }
    }


}
