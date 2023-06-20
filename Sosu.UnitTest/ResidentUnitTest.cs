namespace Sosu.UnitTest;

public class ResidentUnitTest
{
    [Fact]
    public void GetAllResidents_AssertsTrue()
    {
        var service = new ResidentService();

        Assert.True(service.GetAllResidents().Any());
    }
}
