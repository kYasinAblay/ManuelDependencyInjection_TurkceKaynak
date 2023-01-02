using ManuelDependencyInjection_TurkceKaynak.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelDependencyInjection_TurkceKaynak
{
  public struct Hırka : IGiyin
  {

    public string Giyin()
    {
      return "Hava hafif rüzgarlı olduğu için hırka giydim..";
    }
  }
}
