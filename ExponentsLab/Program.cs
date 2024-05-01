Console.WriteLine("Welcome to my square and cube calculator!");

do
{
    int x;

    do
    {
        Console.WriteLine("Please enter an integer between 1 and 1290");
        x = int.Parse(Console.ReadLine());

        if (x >= 1 && x <= 1290) break;
    } while (true);

    Console.WriteLine("Number \tSquared\tCubed\n=======\t=======\t=======");

    for(int i = 1; i <= x; i++)
    {
        Console.WriteLine(String.Format("{0, 7}\t{1, 7}\t{2, 7}", i, Math.Pow(i, 2), Math.Pow(i, 3)));
    }

    Console.WriteLine("Would you like to create another table?  Please enter yes or y to continue, enter anything else to exit.");
    string input = Console.ReadLine();
    if (input.ToLower() != "y" && input.ToLower() != "yes") break;

}while(true);