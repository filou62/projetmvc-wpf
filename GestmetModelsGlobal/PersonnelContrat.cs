using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestmetModelsGlobal
{
    public class PersonnelContrat
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public int ContratId { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime DateSortie { get; set; }

    }
}
