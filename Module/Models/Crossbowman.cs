using Module.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Models;
public class Crossbowman: BaseSoilder
{
    private const int price = 3;
    private const int speed = 7;

    public Crossbowman(): base(price, speed)
    {        
    }

    public override string ToString()
    {
        return "Арбалетчик у шкіряній броні";
    }
}
