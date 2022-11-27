using System;
using System.IO;

class Program
{
    static void ReadCsv()
    {
        //  Get csv file path from user.
        Console.Write("Please input csv file path to read: ");
        string csvFilePath = Console.ReadLine();

        //  Read all csv content as lines of string
        //  and display them.
        string[] lines = File.ReadAllLines(csvFilePath);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    //WriteCsv() อันนี้เก็บไว้ให้เผื่อเฉยๆ แต่จริงๆมันต้องไปรับมาจากผู้ใช้ในส่วนของหมอน ก็เอาส่วนของหมอนมาแปะตรงนี้แทนเลย พวก Get ต่างๆ
    static void InputCsv()
    {
        //  Get csv file path from user.
        Console.Write("Please input csv file path to write: ");
        string csvFilePath = Console.ReadLine();

        //  Get number of person to be added.
        Console.Write("Please input number of persons to be added: ");
        int numPerson = int.Parse(Console.ReadLine());

        //  Get each person info.
        List<string> lines = new List<string>();
        while(numPerson > 0)
        {
            lines.Add(Person.InputPersonInfo());
            numPerson--;
        }

        //  Write all person info to a csv file.
        File.WriteAllLines(csvFilePath, lines);
    }

    //ตรง Main ต้องเอาไปเชื่อมในเมนู Program ของพอยกับหมอนหลังจากเปนแอดมิน ให้เลือกว่าจะมาที่เมนูนี้
    static void Main(string[] args)
    {
        //  Display menu and let user select it.
        Console.WriteLine("---------- Admin Menu ----------");
        Console.WriteLine("1. Read CSV");
        Console.WriteLine("2. Write CSV");
        Console.Write("Please input menu ( 1 / 2 ) : ");
        int menuIndex = int.Parse(Console.ReadLine());

        //  Go to specific page given the selected menu index.
        if(menuIndex == 1)
        {
            ReadCsv();
        }
        else if(menuIndex == 2)
        {
            InputCsv();
        }
        //ตรงนี้เพิ่มมา test ไอระบบ search ถ้าผ่านแล้วก้ลบทิ้งได้เลยย
        else if(menuIndex == 3)
        {
            CategoryMenu();
        }
        //ถึงตรงเน้
    }

    //ตรง CategoryMenu() ต้องเอาไปเชื่อมในเมนู Program ของพอยกับหมอนหลังจาก Login ให้เมนูหมวดหนังสืออยู่ในตัวเลือก
    public static void CategoryMenu()
    {
        Console.Clear();
        Console.WriteLine("---------- Books Category ----------");
        Console.WriteLine("1. Textbook");
        Console.WriteLine("2. Comic book");
        Console.WriteLine("3. Search");
        Console.Write("Please input menu ( 1 / 2 / 3 ) : ");
        int menuIndex = int.Parse(Console.ReadLine());

        if(menuIndex == 1)
        {
            ShowTextbook();
        }
        else if(menuIndex == 2)
        {
            ShowComic();
        }
        else if(menuIndex == 3)
        {
            SearchForBook();
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine("Enter to back to Menu");
            Console.ReadLine();
            CategoryMenu();
        }
    }

    static void ShowTextbook()
    {
        Console.Clear();
        Console.WriteLine("---------- Textbook ----------");
        Console.WriteLine("1. T001 Calculus");
        Console.WriteLine("2. T002 Physics");
        Console.WriteLine("3. Back to Books Category Menu");
        Console.Write("Please input menu ( 1 / 2 / 3 ) : ");
        int menuIndex = int.Parse(Console.ReadLine());

        if(menuIndex == 1)
        {
            //ระบบจองของออม
        }
        else if(menuIndex == 2)
        {
            //ระบบจองของออม
        }
        else if(menuIndex == 3)
        {
            CategoryMenu();
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine("Enter to back to Menu");
            Console.ReadLine();
            ShowTextbook();
        }
    }

    static void ShowComic()
    {
        Console.Clear();
        Console.WriteLine("---------- Comic book ----------");
        Console.WriteLine("1. Goodnight Punpun");
        Console.WriteLine("2. SPY x Family");
        Console.WriteLine("3. Back to Books Category Menu");
        Console.Write("Please input menu ( 1 / 2 / 3 ) : ");
        int menuIndex = int.Parse(Console.ReadLine());

        if(menuIndex == 1)
        {
            GNPunpun();
        }
        else if(menuIndex == 2)
        {
            SPYxFam();
        }
        else if(menuIndex == 3)
        {
            CategoryMenu();
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine("Enter to back to Menu");
            Console.ReadLine();
            ShowComic();
        }
    }

    static void GNPunpun()
    {
        Console.Clear();
        Console.WriteLine("---------- Goodnight Punpun ----------");
        Console.WriteLine("1. C001 Goodnight Punpun vol.1");
        Console.WriteLine("2. C002 Goodnight Punpun vol.2");
        Console.WriteLine("3. C003 Goodnight Punpun vol.3");
        Console.WriteLine("4. Back to Comic Book Menu");
        Console.WriteLine("5. Back to Books Category Menu");
        Console.Write("Please input menu ( 1 / 2 / 3 / 4 / 5 ) : ");
        int menuIndex = int.Parse(Console.ReadLine());

        if(menuIndex == 1 || menuIndex == 2 || menuIndex == 3)
        {
            //ระบบจองของออม
        }
        else if(menuIndex == 4)
        {
            ShowComic();
        }
        else if(menuIndex == 5)
        {
            CategoryMenu();
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine("Enter to back to Menu");
            Console.ReadLine();
            GNPunpun();
        }
    }

    static void SPYxFam()
    {
        Console.Clear();
        Console.WriteLine("---------- SPY x Family ----------");
        Console.WriteLine("1. C011 SPY x Family vol.1");
        Console.WriteLine("2. C012 SPY x Family vol.2");
        Console.WriteLine("3. C013 SPY x Family vol.3");
        Console.WriteLine("4. C014 SPY x Family vol.4");
        Console.WriteLine("5. C015 SPY x Family vol.5");
        Console.WriteLine("6. C016 SPY x Family vol.6");
        Console.WriteLine("7. C017 SPY x Family vol.7");
        Console.WriteLine("8. C018 SPY x Family vol.8");
        Console.WriteLine("9. C019 SPY x Family vol.9");
        Console.WriteLine("10. Back to Comic Book Menu");
        Console.WriteLine("11. Back to Books Category Menu");
        Console.Write("Please input menu ( 1 - 11 ) : ");
        int menuIndex = int.Parse(Console.ReadLine());

        if(menuIndex == 1 || menuIndex == 2 || menuIndex == 3 
        || menuIndex == 4 || menuIndex == 5 || menuIndex == 6 
        || menuIndex == 7 || menuIndex == 8 || menuIndex == 9)
        {
            //ระบบจองของออม
        }
        else if(menuIndex == 10)
        {
            ShowComic();
        }
        else if(menuIndex == 11)
        {
            CategoryMenu();
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine("Enter to back to Menu");
            Console.ReadLine();
            SPYxFam();
        }
    }

    public static void SearchForBook()
    {
        Console.Clear();
        Inventory inventory = new Inventory(initializeInventory());

        Console.WriteLine("---------- Search For Book ----------");
        Console.Write("\nSerial-number (if any) : ");
        string searchSerialNum = Console.ReadLine();
        Console.Write("Book name (if any) : ");
        string searchBookName = Console.ReadLine();

        Book book = new Book(searchSerialNum, searchBookName);
        Book searchResultBook = inventory.Search(book);

        if (searchResultBook != null)
        {
            PrintBookInformation(book);
        }
        else
        {
            Console.WriteLine("\n! Sorry not Found !");
            Console.WriteLine("Enter to back to Menu");
            Console.ReadLine();
            CategoryMenu();
        }

    }

    //ตรงนี้(PrintBookInformation)จะทำให้ search แล้วไม่ว่าจะ serialnum หรือ bookname ที่ตรง อันใดอันนึงตรง 
    //มันจะก็โชว์ข้อมูลของหนังสือเล่มนั้นมาทั้ง serialnum แล้วก้ bookname เลย
    //แต่ติดปัญหาอยู่ แก้ไม่ได้สักที ฝากด้วยคับพอย ;w;
    //แต่ถ้าพอยก้ทำไม่ได้ ก็เอากลับเปนแบบเดิมแบบตัวอย่างกีต้าพี่ก้ได้ ชื่อ method นี้เหมือนกันคับบ
    //แบบเดิมคือเสิร์ชอะไรมา ก้จะปริ้นไอที่ input ออกมาเหมือนกัน ไม่ได้แสดงข้อมูลอื่น ไรงี้
    private static void PrintBookInformation(Book book)
    {
        string[] books = book.initializeInventory();
        //Book[] books = new Book{initializeInventory()};
        
        for (int i = 0; i < books.Length; i++ )
        {
            if (book.GetSerialNumber().Equals(books[i]) || book.GetBookName().Equals(books[i]))
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("\nBook : {0}", books[i]);
                Console.WriteLine("\n----------------------------------------");
                SearchSuccess();
            }
        }
    }

    public static void SearchSuccess()
    {
        Console.Write("\nWill you borrow this book? ( y / n ) : ");
        char borrow = char.Parse(Console.ReadLine());

        if (borrow == 'y')
        {
            //ระบบจองของออม
        }
        else if (borrow == 'n')
        {
            Console.WriteLine("Enter to back to Menu");
            Console.ReadLine();
            CategoryMenu();
        }
    }

    private static Book[] initializeInventory()
    {
        Book[] books = { new Book("T001", "Calculus"),
        new Book("T002", "Physics"),
        new Book("C001", "Goodnight Punpun vol.1"),
        new Book("C002", "Goodnight Punpun vol.2"),
        new Book("C003", "Goodnight Punpun vol.3"),
        new Book("C011", "SPY x Family vol.1"),
        new Book("C012", "SPY x Family vol.2"),
        new Book("C013", "SPY x Family vol.3"),
        new Book("C014", "SPY x Family vol.4"),
        new Book("C015", "SPY x Family vol.5"),
        new Book("C016", "SPY x Family vol.6"),
        new Book("C017", "SPY x Family vol.7"),
        new Book("C018", "SPY x Family vol.8"),
        new Book("C019", "SPY x Family vol.9"),};

        return books;
    }
}