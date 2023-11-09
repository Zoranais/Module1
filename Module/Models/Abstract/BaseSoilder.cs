using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Models.Abstract;
public abstract class BaseSoilder
{
    public int Price { get; }
    public int Speed { get; }

    public BaseSoilder(int price, int speed)
    {
        Price = price;
        Speed = speed;
    }

    public abstract override string ToString();
}
