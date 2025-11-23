class Program
{
    static void Main(string[] args)
    {
        // fixed inventory
        string part1 = "hydraulic pump";
        string part2 = "PLC module";
        string part3 = "servo motor";

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");
        
        bool partFound = false;

        while (!partFound)
        {
            Console.Write("Which part do you need? ");
            string partName = Console.ReadLine();

            // check if part is in stock
            if (partName == part1 || partName == part2 || partName == part3)
            {
                Console.WriteLine($"I've got {partName} here for you 😊");
                partFound = true;
            }
            else if (partName == "Do you actually have any parts?" ||
                     partName == "Is there anything in stock at all?")
            {
                Console.WriteLine("We have 3 part(s)!");
                Console.WriteLine(part1);
                Console.WriteLine(part2);
                Console.WriteLine(part3);
            }
            else
            {
                Console.WriteLine($"I am afraid we don’t have any {partName} in the inventory 😔");
            }
        }
    }
}
