
using Students;
using System.Threading;
int choose;

Info info1 = new Info()
{
    Name = "Suat",
    Surname = "Kandemir",
    Age = 16,
    DateTime = 2023,
    Average = 82.38246666666667,
    Department = "Equal weight section",
    StudentID = "243",
    Mathag = "66.2365",
    Literatureag = "85.4565",
    Hisoryag = "95.4544",
};

Info info2 = new Info()
{
    Name = "Yavuz",
    Surname = "Yazıcı",
    Age = 15,
    DateTime = 2022,
    Average = 78.45613333333333,
    Department = "Equal weight section",
    StudentID = "259",
    Mathag = "95.4565",
    Literatureag = "80.4565",
    Hisoryag = "59.4554",
};
Info info3 = new Info()
{
    Name = "Efe",
    Surname = "Yiğit",
    Age = 15,
    DateTime = 2021,
    Average = 47.3824667,
    Department = "Numerical section",
    StudentID = "279",
    Mathag = "65.2365",
    Literatureag = "41.4565",
    Hisoryag = "49,3824667",

};
Console.WriteLine("Student İnfo One:");
Console.WriteLine($"Name:{info1.Name}\nSurname:{info1.Surname}\nAge:{info1.Age}\nDate:{info1.DateTime}\nAverage:{info1.Average}\nDeparment:{info1.Department}\nStudent Number:{info1.StudentID}");
Thread.Sleep(2000);
Console.Clear();

Console.WriteLine("Student İnfo Two :");
Console.WriteLine($"Name:{info2.Name} \nSurname:{info2.Surname}\nAge:{info2.Age}\nDate:{info2.DateTime}\nAverage:{info2.Average}\nDeparment:{info2.Department}\nStudent Number:{info2.StudentID}");
Thread.Sleep(2000);
Console.Clear();

Console.WriteLine("Student İnfo Three :");
Console.WriteLine($"Name:{info3.Name}\nSurname:{info3.Surname}\nAge: {info3.Age}\nDate: {info3.DateTime}\nAverage:{info3.Average}\nDeparment:{info3.Department}\nStudent Number:{info3.StudentID}");
Thread.Sleep(2000);
Console.Clear();

choose:
Console.WriteLine();
Console.WriteLine("Choose student lessons average 1 - 2 - 3");
choose = Convert.ToInt32(Console.ReadLine());
switch (choose)
{
    case 1:
        Console.WriteLine();
        Console.WriteLine("Suat Kandemir lecture notes");
        Info lesson1 = new Info();
        lesson1.Lesson(info1);
        Console.WriteLine(info1.Average >= 50 ? "Student passed the lesson " + info1.Name + ": " + info1.Average : "Student stayed the lesson " + info1.Average);
        Thread.Sleep(1500);
        goto choose;
       
    case 2:
        Console.WriteLine();
        Console.WriteLine("Yavuz Yazıcı lecture notes");
        Info lesson2 = new Info();
        lesson2.Less(info2);
        Console.WriteLine(info2.Average >= 50 ? "Student passed the lesson " + info2.Name + ": " + info2.Average : "Student stayed the lesson " + info2.Average);
        Thread.Sleep(1500);
        goto choose;
        

    case 3:
        Console.WriteLine();
        Console.WriteLine("Efe Yiğit lecture notes");
        Info lesson3 = new Info();
        lesson3.Les(info3);
        Console.WriteLine(info3.Average >= 50 ? "Student passed the lesson " + info3.Name + ": " + info3.Average : "Student stayed the lesson " + info3.Name + ": " + info3.Average);
        Thread.Sleep(2000);
        break;
    default:
        Console.WriteLine("False Value");
        goto choose;
}











