using System.Collections.Generic;
using System;


public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}

private static List<Student> _students = new List<Student>()
{
new Student { Id = 1, FirstName = "Paul", LastName = "Ochon", BirthDate = new DateTime(1950, 12, 1) },
new Student { Id = 2, FirstName = "Daisy", LastName = "Drathey", BirthDate = new DateTime(1970, 12, 1) },
new Student { Id = 3, FirstName = "Elie", LastName = "Coptaire", BirthDate = new DateTime(1980, 12, 1) }
};
