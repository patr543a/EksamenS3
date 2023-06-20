namespace Sosu.UnitTest;

public class NoteUnitTest
{
    [Fact]
    public void AddNote_MissingProperties_AssertsException()
    {
        var service = new NoteService();

        Assert.Throws<InvalidOperationException>(() =>
        {
            service.AddNote(new()
            {
                EmployeeId = 1,
                Text = "UnitTest"
            });
        });
    }

    [Fact]
    public void AddNote_Note_AssertsTrue()
    {
        var service = new NoteService();

        service.AddNote(new()
        {
            EmployeeId = 1,
            TaskId = 2,
            Text = "UnitTest"
        });
    }
}