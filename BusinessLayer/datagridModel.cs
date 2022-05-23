using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class datagridModel
    {
        DataGridConsult dgc = new DataGridConsult();
        public bool Erease(int id)
        {
            return dgc.DeleteGrid(id);
        }

        DataGridConsult udgc = new DataGridConsult();
        public bool UpdateGrid(int estado)
        {
            return udgc.UpdateGrid(estado);
        }
    }
}
