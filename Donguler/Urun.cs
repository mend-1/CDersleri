using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    public class Urun
    {
        //prop(properties) deyip tap tap yaptık
        //public yapınca diğer sayfalardan erişilebilir oluyor
        public int Id { get; set; }
     
        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

    }
}
