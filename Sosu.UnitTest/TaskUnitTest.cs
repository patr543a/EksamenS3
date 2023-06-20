namespace Sosu.UnitTest;

public class TaskUnitTest
{
    [Fact]
    public void GetAllTasksFromResident_Minus1_AssertsTrue()
    {
        var service = new TaskService();

        Assert.True(!service.GetAllTasksFromResident(-1).Any());
    }

    [Fact]
    public void GetAllTasksFromResident_One_AssertsTrue()
    {
        var service = new TaskService();

        service.GetAllTasksFromResident(1);
    }

    [Fact]
    public void MarkTaskAsComplete_Minus1_AssertsException()
    {
        var service = new TaskService();

        Assert.ThrowsAny<Exception>(() =>
        {
            service.MarkTaskAsComplete(-1, -1);
        });
    }

    [Fact]
    public void MarkTaskAsComplete_One_AssertsTrue()
    {
        var service = new TaskService();

        service.MarkTaskAsComplete(1, 1);
    }
}
