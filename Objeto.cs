using Proyecto1;
using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Objeto
    {
        List<Poligono> listaPoligonos;
        Punto centroObj;
        Pen lapiz = new Pen(Color.DarkRed, 1);

        public Objeto()
        {
            listaPoligonos = new List<Poligono>();
            centroObj = new Punto(0, 0,0);
        }

        public Objeto(Punto Centro)
        {
            listaPoligonos = new List<Poligono>();
            centroObj = new Punto(Centro.x, Centro.y, Centro.z);
        }

        public Objeto(int x, int y,int z)
        {
            listaPoligonos = new List<Poligono>();
            centroObj = new Punto(x, y,z);
        }

        public void setCentroObj(float valor)
        {
            centroObj.setPunto(valor);
         
        }

        public void setCentroObj(Punto Centro)
        {
            centroObj = Centro;
        }

        public Punto getCentroObj()
        {
            return centroObj;
        }

        public void addPoligono(Poligono pol)
        {
            listaPoligonos.Add(pol);
        }

        public void removePolIndexOf(int index)
        {
            listaPoligonos.RemoveAt(index);
        }

        public void removeLastPol()
        {
            listaPoligonos.RemoveAt(listaPoligonos.Count - 1);
        }
        public Poligono getPolIndexOf(int index)
        {
            return listaPoligonos[index];
        }

      /*  public void drawObjeto(Graphics lugar, Punto centroEsc)
        {
            for (int i = 0; i < listaPoligonos.Count; i++)
            {
                listaPoligonos[i].drawPol(lugar, centroEsc, centroObj);
            }
        }*/

    }
}
