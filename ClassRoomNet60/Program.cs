using ClassRoomNet60;
using System.Globalization;

Student christian = new("Christian", 8, 24);
Student rasmus = new("Rasmus", 7, 31);
Student soeren = new("Søren", 4, 20);

ClassRooms room25D = new ClassRooms("25D",new DateTime(2026,08,24,09,10,0));
room25D.StudentList.Add(rasmus);
room25D.StudentList.Add(soeren);
room25D.StudentList.Add(christian);


Console.WriteLine(room25D.SemesterStart);
Console.WriteLine(room25D);