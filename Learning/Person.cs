using System.Reflection;
class Address
{
    public string location;
}
class Person
{
    public string name;
    public Company company;
    public Address address;
    public Car car;
    public Person()
    {
        name = "Undefined";
        company = new Company();
        address = new Address();
        car = new Car();
    }
    public void Print() => Console.WriteLine($"Name: {name}, Company: {company.title}, Location: {address.location}, Car: name:{car.name}, year:{car.age}, color:{car.color}");
}

class Company
{
    public string title = "Unknown";
}

struct Car
{
    public string name;
    public int age;
    public string color;

    //public Car(string name, int age, string color)
    //{
    //    this.name = name;
    //    this.age = age;
    //    this.color = color;
    //}
}