using Module.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Models;
public class Catapult: BaseSoilder
{
    private const int price = 0;
    private const int speed = 3;

    public Catapult(): base(price, speed)
    {        
    }

    public override string ToString()
    {
        return "Катапульта";
    }
}
