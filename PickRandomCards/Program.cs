namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");               // prompt the user for input
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))                      // if line can be converted to an int, return true and assign the value of line to numberOfCards
            {
                string[] result = CardPicker.PickSomeCards(numberOfCards);      // call PickSomeCards with user's input 

                foreach (string card in result)                                 // for each card in the string array 
                {
                    Console.WriteLine(card);                                    // print it to the console
                }
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}