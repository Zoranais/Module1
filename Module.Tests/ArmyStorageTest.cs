using Module.Models;
using Module.Services;

namespace Module.Tests;

[TestClass]
public class ArmyStorageTest
{
    
    [TestMethod]
    public void GenerateArmy_ShouldGenerateCorrectAmountOfMagicians()
    {
        int count = 10;
        var storage = new ArmyStorage(count, 0, 0);
        
        Assert.AreEqual(count, storage.Army.Where(x => x is Magician).Count());
    }

    [TestMethod]
    public void GenerateArmy_ShouldGenerateCorrectAmountOfCrossbowman()
    {
        int count = 10;
        var storage = new ArmyStorage(0, count, 0);

        Assert.AreEqual(count, storage.Army.Where(x => x is Crossbowman).Count());
    }

    [TestMethod]
    public void GenerateArmy_ShouldGenerateCorrectAmountOfCatapults()
    {
        int count = 10;
        var storage = new ArmyStorage(0, 0, count);

        Assert.AreEqual(count, storage.Army.Where(x => x is Catapult).Count());
    }
}