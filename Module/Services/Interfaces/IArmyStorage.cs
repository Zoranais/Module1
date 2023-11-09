using Module.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Services.Interfaces;
public interface IArmyStorage
{
    IReadOnlyCollection<BaseSoilder> Army { get; }
}
