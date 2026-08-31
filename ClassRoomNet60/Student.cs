using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60;

public class Student
{
   public string Name { get; private set; }

    public int BirthMonth { get;  }
    
    public int BirthDay { get; }

    public Student(string name, int birthMonth, int birthDay)
    {
        Name = name;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }

    public override string ToString()
    {
        return Name;
    }

    public string Season()
    {
        List<int> winter = [12, 1, 2];
        List<int> spring = [3, 4, 5];
        List<int> summer = [6, 7, 8];
        List<int> autumn = [9, 10, 11];

        string season = "";
        if (winter.Contains(BirthMonth))
        {
            return "Winter";
        }
        else if (spring.Contains(BirthMonth))
        {
            return "Spring";
        }
        else if (summer.Contains(BirthMonth))
        {
            return "Summer";
        }
        else if (autumn.Contains(BirthMonth))
        {
            return "Autumn";
        }
        else
        {
            return "Default";
        }
    }
}
