using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    public class Pack
    {
        public long PackID { get; set; } = 0;
        public string Name { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int SizeZ { get; set; }
    }
}
