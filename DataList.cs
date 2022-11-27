class DataList
{
    private List<Person> peopleList;
    public DataList()
    {
        this.peopleList =  new List<Person>();
    }
    public void PeopleAdd(Person person)
    {
        this.peopleList.Add(person);
    }
    public student Checkstudent(Student Check)
    {
        if(peoplelist is student)
        {
            foreach(student Student in peopleList)
            {
                string email = check.GetEmail();
                string password = check.GetPassword();
                if(student.GetEmail().Equals(email)&&student.GetPassword().Equals(password))
                {
                    return null;
                }
            }
        }
        return check;
    }
    public Admin CheckAdmin(Admin Check)
    {
        if(peoplelist is Admin)
        {
            foreach(Admin admin in peopleList)
            {
                string email = check.GetEmail();
                string password = check.GetPassword();
                if(admin.GetEmail().Equals(email)&&admin.GetPassword().Equals(password))
                {
                    return null;
                }
            }
        }
        return check;
    }

    //LOGIN
    public bool Logincheck(string email, string password)
    {
        foreach(Person person in peoplelist)
        {
            if(person is Student student)
            {
                if(email.Equals(student.GetEmail())&&password.Equals(student.GetPassword()))
                {
                    return true;
                }
            }
            else if(person is Admin admin)
            {
                if(email.Equals(admin.GetEmail())&&password.Equals(admin.GetPassword()))
                {
                    return true;
                }
            }
        }
        return false;
    }
    //
    public bool Check()
    {
        foreach(Person person in peoplelist)
        {
            if(person is Admin admin)
            {
                return true;
            }
        }
        return false;
    }
    //
    public void fetchdata()
    {
        foreach(Person person in peoplelist)
        {
            if(person is Student student)
            {
                Console.WriteLine("{0} {1} Class:{2}", student.GetEmail(),student.GetPassword());
            }
        }
    }
    public void Who(string email ,string Password)
    {
        foreach(Person person in peoplelist)
        {
            if(person is Admin admin)
            {
                    if(email.Equals(admin.GetEmail()&&Password.Equals(admin.GetPassword)))
                    {
                        Console.WriteLine("{0} {1}",admin.GetEmail(),admin.GetPassword());
                    }
                else if (person is Student student)
                {
                    if(email.Equals(student.GetEmail()&&Password.Equals(student.GetPassword)))
                    {
                        Console.WriteLine("{0} {1}",student.GetEmail(),student.GetPassword());
                    }
                }
            }
        }
    }

}