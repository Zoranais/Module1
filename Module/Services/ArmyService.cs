using Module.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Services;
public class ArmyService : IArmyService
{
    private readonly IArmyStorage _storage;

    public ArmyService(IArmyStorage storage)
    {
        _storage = storage;
    }

    public int CalculateArmyPrice()
    {
        return _storage.Army.Sum(x => x.Price);
    }

    public double CalculateArmySpeed()
    {
        return _storage.Army.Average(x => x.Speed);
    }
}
