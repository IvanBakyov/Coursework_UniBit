using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    class Galaxy
    {
        string imeGalaktika;
        string vidGalaktika;
        string godiniGalaktika;

        public string ImeGalaktika
        {
            set { imeGalaktika = value; }
        }
        public string VidGalaktika
        {
            set { vidGalaktika = value; }
        }
        public string GodiniGalaktika
        {
            set { godiniGalaktika = value; }
        }

        public Galaxy() { }

        public Galaxy(string imeGalaktika, string vidGalaktika, string godiniGalaktika)
        {
            this.ImeGalaktika = imeGalaktika;
            this.VidGalaktika = vidGalaktika;
            this.GodiniGalaktika = godiniGalaktika;
        }

        public void ShowGalaxyInfo()
        {
            Console.WriteLine($"Galaxy name: {this.imeGalaktika}");
        }
    }
}
