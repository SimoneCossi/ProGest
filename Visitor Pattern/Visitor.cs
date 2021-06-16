using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto_Esame_PMO.Prodotti;

namespace Progetto_Esame_PMO.Visitor_Pattern
{
    // interfaccia per implementazione del visitor pattern
    interface Visitor
    {
        // dichiarazione dei vari metodi
        void VisitVini(Vino v);
        void VisitMarmellate(Marmellata v);     // DA RICONTROLLARE ASSOLUTAMENTE
        void VisitVigneti(Vigneto v);
    }
}
