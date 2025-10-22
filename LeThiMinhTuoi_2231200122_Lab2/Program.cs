// See https://aka.ms/new-console-template for more information
using LeThiMinhTuoi_2231200122_Lab2.Q1;
using LeThiMinhTuoi_2231200122_Lab2.Q2;
using LeThiMinhTuoi_2231200122_Lab2.Q3;
using LeThiMinhTuoi_2231200122_Lab2.Q4;
using LeThiMinhTuoi_2231200122_Lab2.Q7;
using LeThiMinhTuoi_2231200122_Lab2.Q9;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Book (em comment nha thay)
        Book book = new Book("2231200123", "Story of Minh Tuoi", "Minh Tuoi", 2025, 208);
        book.DisplayInfo();

        // 2. Member
        PremiumMember premiumMember1 = new PremiumMember("2231200122", "Tuoi", "tuoi.eiu", new DateTime(2027,12,12));
        premiumMember1.DisplayInfo();

        // 4.Membership
        Book book1 = new Book("11111", "The Shrek", "Cameron Diaz", 2006, 2);
        Book book2 = new Book("22222", "The SHrek Musical", "Wiz Khalifa", 2015, 1);
        Book book3 = new Book("33333", "The Shrek and Pussy Cat", "Taylor Swift", 2019, 0);  

        Member regularMember = new RegularMember("2231200124", "Hue", "hue@gmail.com"); 
        Member premiumMember = new PremiumMember("2231200125", "Ti", "ti@gmail.com", new DateTime(2027, 12, 12));

        List<Transaction> transactions = new List<Transaction>
        {
            new BorrowTransaction("11111", DateTime.Now, regularMember, book1),

            new BorrowTransaction("22222", DateTime.Now, regularMember, book2),

            new BorrowTransaction("33333", DateTime.Now, regularMember, book3),

            new BorrowTransaction("44444", DateTime.Now, premiumMember, book1),

            new BorrowTransaction("55555", DateTime.Now, regularMember, book1),

            new ReturnTransaction("66666", DateTime.Now, regularMember, book2),

            new BorrowTransaction("77777", DateTime.Now, regularMember, book1),
        };

        Console.WriteLine("Executing Transactions....");
        foreach (Transaction transaction in transactions)
        {
            transaction.Execute();
        }

        Console.WriteLine("\nBook Availability:");
        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();

        Console.WriteLine("\nMembers Borrowed Books:");
        regularMember.DisplayInfo();
        premiumMember.DisplayInfo();

        Console.WriteLine("\nHue currently borrowed:");
        foreach (var b in regularMember.BorrowBooks)
        {
            Console.WriteLine($"{b.Title}, ");
        }

        Console.WriteLine("\nTi currently borrowed:");
        foreach (var b in premiumMember.BorrowBooks)
        {
            Console.WriteLine($"{b.Title}, ");
        }

        // 7. Notifications
        NotificationService basicNoti = new NotificationService();
        AdvancedNotificationService advancedNoti = new AdvancedNotificationService();

        Console.WriteLine("Overridable");
        basicNoti.SendNotification("A book was returned successfully.");
        advancedNoti.SendNotification("A book was returned successfully.");

        Console.WriteLine("Overload");
        basicNoti.SendNotification("Your book is due tomorrow.", "Tuoi");
        var recipients = new List<string> { "Hue", "Ti" };
        basicNoti.SendNotification("The library will be closed for upgrades.", recipients);

        advancedNoti.SendNotification("Book borrowed successfully.");
        basicNoti.SendNotification("Your borrowed book is due in 1 days.", "Hue");
        basicNoti.SendNotification("Your membership will expire in 7 days.", "Ti");

        // 9. Class vs Record
        // Create two objects with identical values for both class and record
        var bookClass1 = new BookClass("123", "Backend", "Minh Tuoi");
        var bookClass2 = new BookClass("123", "Backend", "Minh Tuoi");

        var bookRecord1 = new BookRecord("123", "Backend", "Minh Tuoi");
        var bookRecord2 = new BookRecord("123", "Backend", "Minh Tuoi");

        //Compare using == operator and explain results
        Console.WriteLine("Compare using == operator");
        Console.WriteLine($"Class: {bookClass1 == bookClass2}");
        Console.WriteLine($"Record: {bookRecord1 == bookRecord2}");
        // Explain: Class: == is False because bookClass1, bookClass2 are 2 different references
        //          (2 different objects even though same data)
        //          Record: == is True because == in record is overridden by value comparison
        //          (it compares all props, they match)

        // Test GetHashCode() for both
        Console.WriteLine("Test GetHashCode() for both");
        Console.WriteLine($"Class: {bookClass1.GetHashCode()}");
        Console.WriteLine($"Record: {bookRecord1.GetHashCode()}");

        // Create modified copies using with keyword (for record) + Test immutability behavior
        Console.WriteLine("Create modified copies using with keyword (for record) + Test immutability behavior");
        var modifiedRecord = bookRecord1 with { Title = "Backend Updated" };
        Console.WriteLine($"Original Title: {bookRecord1.Title}");
        Console.WriteLine($"Modified Title: {modifiedRecord.Title}");

        bookClass1.Title = "Backend Updated";
        Console.WriteLine($"Modified Class Title: {bookClass1.Title}");

        // Test ToString() for both
        Console.WriteLine("Test ToString() for both");
        Console.WriteLine($"Class: {bookClass1}");
        Console.WriteLine($"Record: {bookRecord1}");

        Console.WriteLine("Reference equality: in Class, compare references if they are the same object or not. However, in Record, auto-overridden by value equality which check if they are the same data or not (all their props match)");
        Console.WriteLine("Mutibility: for class, props are changeable by default after the object is created. However, for record, props are NOT changeable by default after the object is created. For record, if we want to change the props, we have to use \"with\" which creates a new object with updated values.");
        Console.WriteLine("Use class when: care about object identity, change props over time, do not care about value equality, need to use inheritence. Use record when: care about data, do not want to change the props over time for safety, easy copy with \"with\"");
        Console.WriteLine("\"==: For class, faster because it compares references (identity). For record, slower because it compares property values. Updating: For class, more memory-efficient because it updates in-place. For record, it allocates a new object with updated values. Class and record (class) are stored on heap; record struct is stored on stack. Use class for long-lived, mutable objects with critical performance needs; use record for small, short-lived immutable objects; and record struct for performance-sensitive immutable value types.");

    }
}
