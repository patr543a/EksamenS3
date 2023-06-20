namespace Sosu.UnitTest;

/// <summary>
/// UnitTests for Resident
/// </summary>
public class ResidentUnitTest
{
    /// <summary>
    /// Tests GetAllResidents
    /// </summary>
    [Fact]
    public void GetAllResidents_AssertsTrue()
    {
        // Create service
        var service = new ResidentService();

        // Test
        Assert.True(service.GetAllResidents().Any());
    }
}
