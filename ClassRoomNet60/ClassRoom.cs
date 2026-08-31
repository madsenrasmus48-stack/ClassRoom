using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60;

public class ClassRoom
{
    public string ClassName { get; }
    public List<Student> StudentList { get; set; }
    public DateTime SemesterStart { get; }

    public ClassRoom(string className, DateTime semesterStart)
    {
        StudentList = new List<Student>();
        ClassName = className;
        SemesterStart = semesterStart;
    }

}
