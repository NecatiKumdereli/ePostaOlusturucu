using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeOdevEposta
{
    public class KampanyaEposta : ePosta
    {
        public override string cıkısHaberi()
        {
            return "Kampanyalardan haberdar olmak için lütfen ABONE olun";
        }
        public override string iletmeMesajı()
        {
            return "Merhaba,Necati Bey Sizleri de aramızda görmekten onur duyarız";
        }
        public override string alici()
        {
            return "necati_kumdereli@hotmail.com";
        }

    }
}
