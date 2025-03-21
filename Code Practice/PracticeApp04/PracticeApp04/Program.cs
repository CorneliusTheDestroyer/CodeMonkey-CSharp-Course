/*
 * Events *Done
 * Subscribe / Unsubscribe *Done
*/

namespace PracticeApp04
{
    class Button
    {
        // Step 1: Define a delegate that matches the event handler signature
        public delegate void ClickEventHandler(object sender, EventArgs e);

        // Step 2: Declare an event based on the delegate
        public event ClickEventHandler Click;

        // Step 3: Method to raise the event
        public void OnClick() 
        {
            Console.WriteLine("Button clicked. Raising event...");

            // Check if there are any subscribers before raising the event
            Click?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of Button
            Button button = new Button();

            // Step 4: Subscribe to the Click event with a handler method
            button.Click += Button_Click; 

            // Simulate clicking the button
            button.OnClick();

            // Step 4: Unsubscribe to the Click event
            button.Click -= Button_Click;
        }

        private static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button click event handled");
        }
    }
}
