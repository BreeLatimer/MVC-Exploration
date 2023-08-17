// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the driver class for the MVC application.
//              The driver class creates the Model, View, and Controller objects and starts the application.

namespace MVC
{
    class Driver
    {
        public static void Main(string[] args)
        {
            // Create the View
            View view = new View();

            // Create the Model
            Model model = new Model(view);

            // Create the Controller
            Controller controller = new Controller(view, model);

            // We have to pass the Controller to the View so that the View can call methods on the Controller, basically we're closing the loop.
            view = new View(controller);

            // Start the application
            controller.Start();
        }
    }
}