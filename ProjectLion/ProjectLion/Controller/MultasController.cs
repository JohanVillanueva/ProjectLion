using ProjectLion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLion.Controller
{
    public class MultasController
    {
        public List<Multa> data;

        public MultasController()
        {
            data = Variables.Globales.multas;
        }
    }
}
