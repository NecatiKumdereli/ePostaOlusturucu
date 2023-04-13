using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeOdevEposta
{
    public class HaberEpostaOlusturucu : ePostaOlusturucu

    {
        public override ePosta ePostaOlustur()
        {
            return new HaberEposta();
        }
    }
}
