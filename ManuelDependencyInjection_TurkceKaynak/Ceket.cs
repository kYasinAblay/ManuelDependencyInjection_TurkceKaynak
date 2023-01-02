using ManuelDependencyInjection_TurkceKaynak.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelDependencyInjection_TurkceKaynak
{
  public struct Ceket:IGiyin
  {
    public string Giyin()
    {
      return "Özel bir yere davet ediliğdim için Ceket giyindim.";
    }
  }
}
