
/*
 * EventHandler *Done
*/

namespace PracticeApp05
{
    class Button
    {
        //Declare the event using the built-in EventHandler delegate
        public EventHandler Click;

        public void OnClick()
        {
            Console.WriteLine("Button clicked! Raising event...");

            Click?.Invoke(this, EventArgs.Empty);
        }
    }
    class Program
    {
        static void Main()
        {
            Button button = new Button();

            button.Click += Button_ClickHandler;

            button.OnClick();

            button.Click -= Button_ClickHandler;
        }

        private static void Button_ClickHandler(object? sender, EventArgs e)
        {
            Console.WriteLine("Button click event handled");
        }
    }
}
