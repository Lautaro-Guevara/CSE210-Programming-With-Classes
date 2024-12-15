using System;

class Program
{
    static void Main(string[] args)
    {
        int selectionNumber = 0;

        BreathingActivity breathingActivity = new BreathingActivity();
        Reflectiongactivity reflectiongactivity = new Reflectiongactivity();
        ListingActivity listingActivity = new ListingActivity();

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Variable para almacenar el número ingresado
            int number;

            // Validar la entrada del usuario
            while (true)
            {
                string selection = Console.ReadLine();

                if (int.TryParse(selection, out number))
                {
                    break; // Salir del bucle si la entrada es válida
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter a valid number.");
                }
            }

            // Actualizar el número seleccionado
            selectionNumber = number;

            // Ejecutar la opción seleccionada
            if (selectionNumber == 1)
            {
                breathingActivity.Run();
            }
            else if (selectionNumber == 2)
            {
                reflectiongactivity.Run();
            }
            else if (selectionNumber == 3)
            {
                listingActivity.Run();
            }

        } while (selectionNumber != 4);

        Console.WriteLine("Goodbye!");
    }
}
