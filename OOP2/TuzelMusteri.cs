using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate 
    //miras inheritance
    class TuzelMusteri:Musteri                      // Musteri burada ebeveydir. Onda bulunan özellikler TuzelMusteri için de geçerlidir.
    {        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
