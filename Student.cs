class student:DataList
{
    string Email;
    string Password;
    public student(string email,string password)
    {
        this.Email = email;
        this.Password = password;
    }
    public string GetEmail()
    {
        return this.Email;
    }
    public string GetPassword()
    {
        return this.Password;
    }
}