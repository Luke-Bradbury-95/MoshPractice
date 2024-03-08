using MoshPractice;
using System.Security.AccessControl;
// Object creating
Cars bmw = new Cars("Bmw", 350, "Red");
bmw.Drive();
Cars audi = new Cars("Audi", 450, "Blue");
audi.Drive();
audi.Description();
bmw.Description();

Console.WriteLine("Press 1 to stop");
string userInput = Console.ReadLine();
if(userInput == "1")
{
    bmw.Stop();
}
else if(userInput == "2")
{
    audi.Stop();
}
else
{
    {
        Console.WriteLine("Car drives forever");
    }
}
Console.ReadKey();




public class Phone
{
    public string Company;
    public string Model;
    public string ReleaseDay;

    public Phone()
    {
        Company = "unknown";
        Model = "unknown";
        ReleaseDay = "unknown";
        }

    public Phone(string company, String model, String releaseDay = "unknown")
    {
        Company = company;
        Model = model;
        ReleaseDay = releaseDay;
    }

    public Phone(string company, String model, String releaseDay)
    {
        Company = company;
        Model = model;
        ReleaseDay = releaseDay;
    }