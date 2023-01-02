using ManuelDependencyInjection_TurkceKaynak.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelDependencyInjection_TurkceKaynak
{
  public struct Mont : IGiyin
  {

    public string Giyin()
    {
      return "Hava soğuk olduğu için Mont giydim..";
    }
  }
}
