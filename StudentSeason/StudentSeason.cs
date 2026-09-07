

using ClassRoomNet60;

namespace StudentSeason;

[TestClass]
public sealed class StudentSeason
{
    [TestMethod]
    [DataRow("Hans",1,1,"Winter")]
    [DataRow("Tina",7,31,"Summer")]

    public void TestMethod1(string name, int birthMonth, int birthday, string expectedSeason )
    {
        //Arrange
        Student student = new Student(name, birthMonth, birthday);

        //Act
        string season = student.Season();

        //Assert
        Assert.AreEqual(expectedSeason, season);
    }
}
