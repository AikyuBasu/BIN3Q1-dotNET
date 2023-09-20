using LINQDataContext;

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
//TODO