namespace LeThiMinhTuoi_2231200122_Lab1;

// The result img is in folder result img -> Screenshot(2529).png
// 1. Program class (em comment nha thay)
public class Program
{
    // 1. Main()
    public static void Main(string[] args)
    {
        // 2. console WriteLine
        Console.WriteLine("Hello World!");

        // 3.
        Console.WriteLine("Q3:");
        // initialize variables
        Console.Write("Enter the first number to add:");
        var firstNumToAdd = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number to add:");
        var secondNumToAdd = int.Parse(Console.ReadLine());

        Console.WriteLine($"The sum of {firstNumToAdd} and {secondNumToAdd} is {AddTwoNumbers(firstNumToAdd,secondNumToAdd)}");

        // 4.
        Console.WriteLine("Q4:");
        // initialize variables
        Console.Write("Enter the first number to swap:");
        var firstNumToSwap = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number to swap:");
        var secondNumToSwap = int.Parse(Console.ReadLine());

        SwapNumbers(firstNumToSwap, secondNumToSwap);

        // 5.
        Console.WriteLine("Q5:");
        // initialize variables
        Console.Write("Enter the grade to classify:");
        var grade = int.Parse(Console.ReadLine());

        ClassifyStudent(grade);

        // 6.
        Console.WriteLine("Q6:");
        // initialize variables
        Console.Write("Enter the valid month:");
        var validMonth = int.Parse(Console.ReadLine());

        PrintMonthInfo(validMonth);

        // initialize variables
        Console.Write("Enter the invalid month:");
        var invalidMonth = int.Parse(Console.ReadLine());
        PrintMonthInfo(invalidMonth);

        // 7.
        Console.WriteLine("Q7:");
        // initialize variables
        Console.Write("Enter the n to calculate sum from 1 to n:");
        var n = int.Parse(Console.ReadLine());
        SumToN(n);
    }

    // 3. AddTwoNumbers
    static int AddTwoNumbers(int numberA, int numberB)
    {
        return numberA + numberB;
    }

    // 4. SwapNumbers
    static void SwapNumbers(int numberA, int numberB)
    {
        Console.WriteLine($"Before: A = {numberA}, B = {numberB}");

        var temp = numberA;
        numberA = numberB;  
        numberB = temp;
        Console.WriteLine($"After: A = {numberA}, B = {numberB}");
    }

    // 5. ClassifyStudent
    /* 
         * >= 90 → Excellent
         * 80–89 → Good
         * 70–79 → Fair
         * < 70  → Average
         */
    static void ClassifyStudent(double averageScore)
    {
        if (averageScore > 69)
        {
            if (averageScore > 79)
            {
                if(averageScore > 89)
                {
                    Console.WriteLine("Excellent");
                }
                else
                {
                    Console.WriteLine("Good");
                }
            }
            else
            {
                Console.WriteLine("Fair");
            }
        }
        else
        {
            Console.WriteLine("Average");
        }
    }

    // 6. PrintMonthInfo
    static void PrintMonthInfo(int month)
    {
        // Check if month is valid
        if (month < 1 || month > 12)
        {
            Console.WriteLine("The month input is invalid.");
            return;
        }

        // Use switch to print month info
        switch (month)
        {
            case 1:
                Console.WriteLine("January - Have 31 days.");
                break;
            case 2:
                Console.WriteLine("February - Have 28 or 29 days.");
                break;
            case 3:
                Console.WriteLine("March - Have 31 days.");
                break;
            case 4:
                Console.WriteLine("April - Have 30 days.");
                break;
            case 5:
                Console.WriteLine("May - Have 31 days.");
                break;
            case 6:
                Console.WriteLine("June - Have 30 days.");
                break;
            case 7:
                Console.WriteLine("July - Have 31 days.");
                break;
            case 8:
                Console.WriteLine("August - Have 31 days.");
                break;
            case 9:
                Console.WriteLine("September - Have 30 days.");
                break;
            case 10:
                Console.WriteLine("October - Have 31 days.");
                break;
            case 11:
                Console.WriteLine("November - Have 30 days.");
                break;
            case 12:
                Console.WriteLine("December - Have 31 days.");
                break;
        }
    }

    // 7. Sum of Numbers (Loop + Validation)
    static void SumToN(int n)
    {
        // check if the input is valid
        if (n <= 0)
        {
            Console.WriteLine("n must be greater than 0.");
            return;
        }

        int sum = 0;

        // add numbers from 1 to n
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"The sum from 1 to {n} is {sum}");
    }
}