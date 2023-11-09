using Module.Models;
using Module.Models.Abstract;
using Module.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Services;
public class ArmyStorage: IArmyStorage
{
    public IReadOnlyCollection<BaseSoilder> Army { get; }

    public ArmyStorage(int magicians, int crossbowman, int catapults)
    {
        Army = GenerateArmy(magicians, crossbowman, catapults);
    }

    private List<BaseSoilder> GenerateArmy(int magicians, int crossbowman, int catapults)
    {
        var result = new List<BaseSoilder>();

        for (int i = 0; i < magicians; i++)
        {
            result.Add(new Magician());
        }

        for (int i = 0; i < crossbowman; i++)
        {
            result.Add(new Crossbowman());
        }

        for(int i = 0;i < catapults; i++) 
        { 
            result.Add(new Catapult()); 
        }

        return result;
    }
}
