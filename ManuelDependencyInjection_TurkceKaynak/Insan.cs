using ManuelDependencyInjection_TurkceKaynak;
using ManuelDependencyInjection_TurkceKaynak.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelDependencyInjection_TurkceKaynak
{
  public class Insan
  {
    IGiyin _giyin;

    public Insan(IGiyin giyin)
    {
      _giyin = giyin;
    }

    public string Yaz()
    {
      return _giyin.Giyin();
    }
  }
}

//bu ilkel hali
//public class Insan
//{
//  Ceket _ceket;

//  public Insan(Ceket ceket)
//  {
//    _ceket = ceket;
//  }

//  public string Yaz()
//  {
//    return _ceket.Giyin();
//  }
//}