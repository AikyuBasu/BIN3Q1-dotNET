using LINQDataContext;
using System.ComponentModel.DataAnnotations;

DataContext dc = new DataContext();

Student? jdepp = (from student in dc.Students
                  where student.Login == "jdepp"
                  select student).SingleOrDefault();

if (jdepp != null)
{
    Console.WriteLine(jdepp.Last_Name + jdepp.First_Name);
}

// exercice 2.2
var Res1 = from s in dc.Students
                  select new { LName = s.Last_Name, FName = s.First_Name, ID = s.Student_ID, BirthDate = s.BirthDate};

foreach (var stu in Res1)
{
    Console.WriteLine("{0} {1}, ID {2}, born in {3}", stu.FName, stu.LName, stu.ID, stu.BirthDate);
}

// exercice 3.1
var Res2 = from s in dc.Students
           where s.BirthDate.Year < 1955
           select new { LName = s.Last_Name, YearResult = s.Year_Result, Statut = (s.Year_Result > 12) ? "OK" : "KO" };

foreach (var stu in Res2)
{
    Console.WriteLine("{0} {1} {2}", stu.LName, stu.YearResult, stu.Statut);
}

// exercice 3.4
var Res3 = dc.Students.Where(stu => stu.Year_Result <= 3).OrderByDescending(stu => stu.Year_Result);

foreach (var stu in Res3)
{
    Console.WriteLine("{0} {1}", stu.Last_Name, stu.Year_Result);
}

// exercice 3.5
var Res4 = from s in dc.Students
           where s.Section_ID == 1110
           orderby s.Last_Name
           select new { LName = s.Last_Name, FName = s.First_Name, YResult = s.Year_Result };
foreach (var stu in Res4)
{
    Console.WriteLine("{0} {1} {2}", stu.LName, stu.FName, stu.YResult);
}

Console.WriteLine("======Exercice 4.1=======");

float Res5 = dc.Students.Average(a => (float) a.Year_Result);

Console.WriteLine("avg year result is {0}", Res5);

Console.WriteLine("======Exercice 4.5=======");

int Res6 = dc.Students.Count();
Console.WriteLine("nb of lines {0}", Res6);

Console.WriteLine("======Exercice 5.1=======");

var Res7 = dc.Students.GroupBy(a => a.Section_ID);

foreach(var Section in Res7)
{
    Console.WriteLine("Section n°{0} : {1} students.", Section.Key, Section.Count());
    int Max = 0;
    foreach (var Student in Section)
    {
        if (Student.Year_Result > Max) Max = Student.Year_Result;
    }
    Console.WriteLine("Max grade for section {0} is {1}.", Section.First().Section_ID, Max);
}

Console.WriteLine("======Exercice 5.3=======");
// Donner le résultat moyen (AVG_Result) et le mois en chiffre (BirtMonth) pour les étudiants né le même mois entre 1970 et 1985.
var Res8 = dc.Students
    .Where(stu => stu.BirthDate.Year >= 1970 && stu.BirthDate.Year <= 1985)
    .GroupBy(stu => stu.BirthDate.Month);

foreach(var MonthGroup in Res8)
{
    float Sum_Results = 0;
    Console.WriteLine("There are {0} students born in month no {1}", MonthGroup.Count(), MonthGroup.First().BirthDate.Month);
    foreach (var Stu in MonthGroup)
    {
        Console.WriteLine("Student ID {0} has a year result of {1}", Stu.Student_ID, Stu.Year_Result);
        Sum_Results += Stu.Year_Result;
    }
    float AVG_Result = Sum_Results / MonthGroup.Count();
    Console.WriteLine("Students born in month {0} have an average result of {1}", MonthGroup.First().BirthDate.Month, AVG_Result);
}


Console.WriteLine("======Exercice 5.5=======");
// Donner pour chaque cours le nom du professeur responsable ainsi que la section dont il fait partie.
// Course_name	Section_name	Professor_name

foreach (var Course in dc.Courses)
{
    string? CourseName = Course.Course_Name;
    Professor? Professor = (from professor in dc.Professors
                             where professor.Professor_ID == Course.Professor_ID
                             select professor)
                             .SingleOrDefault();

    string? ProfessorName = Professor?.Professor_Name;

    string? SectionName = (from Section in dc.Sections 
                           where Section.Section_ID == Professor?.Section_ID 
                           select Section)
                           .SingleOrDefault()?
                           .Section_Name;

    Console.WriteLine("Course {0} / professor {1} / section {2}", CourseName, ProfessorName, SectionName);
}


Console.WriteLine("======Exercice 5.7=======");
