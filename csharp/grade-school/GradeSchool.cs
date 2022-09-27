using System;
using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{
    public struct Student
    {
        public string Name;
        public int Grade;
    }

    private List<Student> roster;

    public GradeSchool()
    {
        roster = new List<Student>();
    }
    public void Add(string student, int grade)
    {
        roster.Add(new Student() { Name = student, Grade = grade });
    }

    public IEnumerable<string> Roster()
    {
        return roster.OrderBy(st => st.Grade).ThenBy(st => st.Name).Select(st => st.Name);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return roster.Where(st => st.Grade == grade).OrderBy(st => st.Name).Select(x => x.Name);
    }
}