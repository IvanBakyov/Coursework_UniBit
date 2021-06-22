using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    class Planet
    {
        string imePlaneta;
        string vidPlaneta;
        string obitaema;

        public string ImePlaneta
        {
            set { imePlaneta = value; }
        }
        public string VidPlaneta
        {
            set { vidPlaneta = value; }
        }
        public string Obitaema
        {
            set { obitaema = value; }
        }

        public Planet(string imePlaneta, string vidPlaneta, string obitaema)
        {
            this.ImePlaneta = imePlaneta;
            this.VidPlaneta = vidPlaneta;
            this.Obitaema = obitaema;
        }

        public void ShowPlanetInfo()
        {
            Console.WriteLine($"Planet name: {this.imePlaneta}");
            Console.WriteLine($"Planet type: {this.vidPlaneta}");
            Console.WriteLine($"Supports life? {obitaema.ToString()}.");
        }
    }
}
