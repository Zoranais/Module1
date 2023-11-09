using Module.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Models;
public class Magician : BaseSoilder
{
    private const int price = 5;
    private const int speed = 5;
    public Magician() : base(price, speed)
    {
    }

    public override string ToString()
    {
        return "Чарівник у легкій броні";
    }
}
