class Person
{
    private string name;
    private string surname;
    private string studentID;

    public Person(string name, string surname, string studentID)
    {
        this.name = name;
        this.surname = surname;
        this.studentID = studentID;
    }

    public string GetPersonInfo()
    {
        return String.Format("{0},{1},{2}", this.name, this.surname, this.studentID);
    }

    public static string InputPersonInfo()
    {
        Console.WriteLine("Please input name, surname and studentID: ");
        Person person = new Person(
            Console.ReadLine(),
            Console.ReadLine(),
            Console.ReadLine()
        );

        return person.GetPersonInfo();
    }
}