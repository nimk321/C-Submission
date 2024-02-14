using System;

class RoseBlanches
{
    static void Main()
    {    
        //Taking user input
        Console.Write("How much money did you receive from your aunt ($)? ");
        double totalAmount = double.Parse(Console.ReadLine());

        // Calculating the three quarter amount for books and supplies
        int booksAndSupplies = (int)(0.75 * totalAmount);

        double leftAmount = 0.25 * totalAmount;
        double rest_part = leftAmount / 3;

        // Calculating the cost of each item
        double coffeeCost = 2;
        double flashComputerCost = 4;
        double subwayTicketCost = 3;

        // Calculating the number of coffees, Flash Computers, and subway tickets that can be bought with the remaining amount
        int countCoffees = (int)(rest_part / coffeeCost);
        int countFlashComputers = (int)(rest_part / flashComputerCost);
        int countSubwayTickets = (int)(rest_part / subwayTicketCost);

        // Calculating the amount spent on each item
        double spentOnCoffees = countCoffees * coffeeCost;
        double spentOnFlashComputers = countFlashComputers * flashComputerCost;
        double spentOnSubwayTickets = countSubwayTickets * subwayTicketCost;

        // Calculating the remaining amount for white roses
        double countWhiteFlowers = leftAmount - spentOnCoffees - spentOnFlashComputers - spentOnSubwayTickets;

        // Displaying the results
        Console.WriteLine($"\nBook and Supplies: {booksAndSupplies} $");
        Console.WriteLine($"You can then buy:");
        Console.WriteLine($"{countCoffees} coffees");
        Console.WriteLine($"\n{countFlashComputers} Flash Computer Numbers");
        Console.WriteLine($"{countSubwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {countWhiteFlowers} dollars for the white roses.");
    }
}