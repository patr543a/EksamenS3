namespace Sosu.UnitTest;

/// <summary>
/// UnitTests for Task
/// </summary>
public class TaskUnitTest
{
    /// <summary>
    /// Tests GetAllTasksFromResident with -1
    /// </summary>
    [Fact]
    public void GetAllTasksFromResident_Minus1_AssertsTrue()
    {
        // Create service
        var service = new TaskService();

        // Test
        Assert.True(!service.GetAllTasksFromResident(-1).Any());
    }

    /// <summary>
    /// Tests GetAllTasksFromResident with 1
    /// </summary>
    [Fact]
    public void GetAllTasksFromResident_One_AssertsTrue()
    {
        // Create service
        var service = new TaskService();

        // Test
        service.GetAllTasksFromResident(1);
    }

    /// <summary>
    /// Tests MarkTaskAsComplete with -1, -1
    /// </summary>
    [Fact]
    public void MarkTaskAsComplete_Minus1_AssertsException()
    {
        // Create service
        var service = new TaskService();

        // Test
        Assert.ThrowsAny<Exception>(() =>
        {
            service.MarkTaskAsComplete(-1, -1);
        });
    }

    /// <summary>
    /// Tests MarkTaskAsComplete with 1, 1
    /// </summary>
    [Fact]
    public void MarkTaskAsComplete_One_AssertsTrue()
    {
        // Create service
        var service = new TaskService();

        // Test
        service.MarkTaskAsComplete(1, 1);
    }
}
