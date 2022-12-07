using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooop3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (var loggerServices in loggerService)
            {
                loggerServices.Log();
            }
        }
        public void TutariYaz(IKrediManager krediManager)
        {
            krediManager.TutariGetir();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }

    }
}
