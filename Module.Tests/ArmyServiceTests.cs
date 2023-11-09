using Module.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Tests;

[TestClass]
public class ArmyServiceTests
{
    [TestMethod]
    public void CalculateArmyPrice_ShouldCalculateCorrectSum()
    {
        var expected = 5 + 3 + 0;
        var storage = new ArmyStorage(1, 1, 1);
        var armyService = new ArmyService(storage);

        Assert.AreEqual(expected, armyService.CalculateArmyPrice());
    }

    [TestMethod]
    public void CalculateArmyPrice_ShouldCalculateCorrectSpeed()
    {
        double expected = (5 + 7 + 3) / 3;
        var storage = new ArmyStorage(1, 1, 1);
        var armyService = new ArmyService(storage);

        Assert.AreEqual(expected, armyService.CalculateArmySpeed());
    }
}
