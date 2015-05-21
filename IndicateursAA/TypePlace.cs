using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicateursAA
{
    enum Place { Economique, Eco_Premium, Affaire, Premiere };
    class TypePlace
    {
        Place type;

        private TypePlace(Place Type)
        {
            type = Type;
        }
    }
}
