using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.Xml.Serialization;

namespace Proyecto1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cubo p = new Cubo();
            Game juego = new Game(800, 600, "Demo OpenTK");
            juego.Run(60);
        }
        
    }
}
