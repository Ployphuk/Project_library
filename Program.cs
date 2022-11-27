//Menu
enum MainMenu
{
    Register = 1,
    Login
}
enum RegisterMenu
{
    Student = 1,
    Admin
}
enum AdminMenu
{
    Accept = 1,
    Check
}
 class Program
{
    static DataList data;
   
    public static void Main()
    {
        PersonListLoad();
        ChooseMenu();
    }
//
    static void ChooseMenu()
    {
        Console.Clear();
        Console.WriteLine("1.Register\n2.Login");
        ChooseMenuFromKeyboard();
    } 
    static void ChooseMenuFromKeyboard()
    {
        Console.Write("Please choose your Menu : ");
       MainMenu menu = (MainMenu)(int.Parse(Console.ReadLine()));
       DisplayMenu(menu);
    }
//  
     static void ChooseRegisterMenu()
    {
        Console.WriteLine("1.Student\n2.Admin");
        ChooseRegisterMenuFromKeyboard();
    }
    
     static void ChooseRegisterMenuFromKeyboard()
    {
       Console.Write("Please choose your Menu : ");
       RegisterMenu menu = (RegisterMenu)(int.Parse(Console.ReadLine()));
       DisplayRegisterMenu(menu);
    }
    static void DisplayMenu(MainMenu menu)
    {
        switch(menu)
        {
            case MainMenu.Register: ChooseRegisterMenu();
            break;
            case MainMenu.Login: LoginFromKeyboard();
            break;
        
        }
    }
   
    static void DisplayRegisterMenu(RegisterMenu menu)
    {
        switch(menu)
        {
            case RegisterMenu.Student: NewStudent();
            break;
            case RegisterMenu.Admin: NewAdmin();
            break;
        }
    }
    static void NewStudent()
    {
        Console.Clear();
        Student student = new Student(InputEmail,Password());
        Student checkdata = data.Checkstudent(student);
        if(checkdata != null)
        {
            Program.data.PeopleAdd(student);
            ChooseMenu();
        }
        else if( checkdata == null)
        {
            Console.Clear();
            Console.WriteLine("This user already register");
            NewStudent();
        }
     }
        
    static void NewAdmin()
    {
        Console.Clear();
        Admin admin = new Admin(InputEmail(),Password());
        Admin checkdata = data.CheckAdmin(admin);
        if(checkdata != null)
        {
            Program.data.PeopleAdd(admin);
            ChooseMenu();
        }
        else if(checkdata == null)
        {
            Console.WriteLine("This user already register");
            NewAdmin();
        }  

    }
//
    
//Login
    static void LoginFromKeyboard()
    {
       
        Console.Write("Email: ");
        string Email = Console.ReadLine();
        Console.Write("Password: ");
        string Password = Console.ReadLine();
        if(data.Logincheck(Email,Password) == true)
        {
            if(data.Check() == true )
            {
                TeacherAccept(Email,Password);
            }
            else if(data.Check() == false)
            {
                StudentReserve(Email,Password);
            }
        }
        else if(data.Logincheck(Email,Password) == false)
        {
            Console.Clear();
            Console.WriteLine("Invalid Email/Password");

            LoginFromKeyboard();
        }
//ส่วนMenuLoginนักศึกษา
        static void StudentReserve(string email , string password)
        {
            Console.Clear();
            Console.WriteLine("Welcome");
            data.Who(email,password);
        }
        
//ส่วนAdmin
        static void TeacherAccept(string email , string password)
        {
            Console.Clear();
            Console.WriteLine("Welcome");
            data.Who(email,password);
            Console.WriteLine("Choose Menu\n1. Accept room\n2. Check Student");
            Console.Write("Choose: ");
            AdminMenu menu = (AdminMenu)(int.Parse(Console.ReadLine()));
            SwitchAdminMenu(menu);

        }
        static void SwitchAdminMenu(AdminMenu menu)
        {
            switch(menu)
            {
               case AdminMenu.Accept:AdminConfirm();
               break; 
               case AdminMenu.Check:Display_tudent_CheckList();
               break;
            }
        } 
        static void Display_tudent_CheckList()
        {
            data.fetchdata();
        }  
        static void AdminConfirm()
        {
            Console.WriteLine("Commingsoon");
        }
        

    }
//กรอกข้อมูล
    public static string InputEmail()
    {
        Console.Write("Please input your Email : ");
        return Console.ReadLine();
    }
    public static string Password()
    {
      Console.Write("Please input your Password: ");
      return Console.ReadLine();
    }
//
    static void PersonListLoad()
    {
        Program.data = new DataList();
    }   
}