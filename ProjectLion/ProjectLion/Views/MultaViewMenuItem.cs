using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLion.Views
{

    public class MultaViewMenuItem
    {
        public MultaViewMenuItem()
        {
        }

        public string imageUrl { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}