using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Esame_PMO.Visitor_Pattern
{
    // classe per la dichiarazione del metodo "Accept"
    // classe astratta in modo che non possa venir instanziata
    interface Node
    {
        // dichiarazione del metodo "Accept"
        void Accept(Visitor v);
    }
}
