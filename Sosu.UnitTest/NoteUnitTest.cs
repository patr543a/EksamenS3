namespace Sosu.UnitTest;

/// <summary>
/// UnitTests for Note
/// </summary>
public class NoteUnitTest
{
    /// <summary>
    /// Tests AddNote with missing properties
    /// </summary>
    [Fact]
    public void AddNote_MissingProperties_AssertsException()
    {
        // Create service
        var service = new NoteService();

        // Test
        Assert.Throws<InvalidOperationException>(() =>
        {
            service.AddNote(new()
            {
                EmployeeId = 1,
                Text = "UnitTest"
            });
        });
    }

    /// <summary>
    /// Tests AddNote with Note
    /// </summary>
    [Fact]
    public void AddNote_Note_AssertsTrue()
    {
        // Create service
        var service = new NoteService();

        // Test
        service.AddNote(new()
        {
            EmployeeId = 1,
            TaskId = 2,
            Text = "UnitTest"
        });
    }
}