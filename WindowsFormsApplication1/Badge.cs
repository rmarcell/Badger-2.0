using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badger
{
    public class Badge
    {
        public string Name { get; set; }
        public string Pos { get; set; }

        public Badge(string name, string pos)
        {
            if (name != null)
            {
                this.Name = name;
            }
            else {
                this.Name = "";
            }

            if (pos != null)
            {
                this.Pos = pos;
            }
            else {
                this.Pos = "";
            }
        }

        public Badge()
        {
            this.Name = "";
            this.Pos = "";
        }

    }
}
