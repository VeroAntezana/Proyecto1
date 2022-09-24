using Proyecto1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    [Serializable]
    public class Poligono
    {
        private List<Punto> listaPuntos;
        private Punto centroPol;
        private Pen lapiz = new Pen(Color.Black, 4);

        public Poligono()
        {
            listaPuntos = new List<Punto>();
            centroPol = new Punto(0, 0,0);
        }

        public Poligono(Punto Centro)
        {
            listaPuntos = new List<Punto>();
            centroPol = new Punto(Centro.x, Centro.y, Centro.z);
        }

        public Poligono(int ejeX, int ejeY, int ejeZ)
        {
            listaPuntos = new List<Punto>();
            centroPol = new Punto(ejeX, ejeY,ejeZ);
        }

        public void setCentroPol(float valor)
        {
            centroPol.setPunto(valor);
            //centroPol.setY(ejeY);
        }

        public Punto getCentroPol()
        {
            return centroPol;
        }

        public void addPunto(int x, int y,int z)
        {
            listaPuntos.Add(new Punto(x, y,z));
        }

        public void addPunto(Punto punto)
        {
            listaPuntos.Add(punto);
        }

        public void removePuntoIndexOf(int index)
        {
            listaPuntos.RemoveAt(index);
        }

        public void removeLastPunto()
        {
            listaPuntos.RemoveAt(listaPuntos.Count - 1);
        }

       /* public void drawPol(Graphics lugar, Punto centroEsc, Punto centroObj)
        {
            for (int i = 0; i < listaPuntos.Count - 1; i++)
            {
                lugar.DrawLine(lapiz, listaPuntos[i].x + centroEsc.x + centroObj.x + centroPol.x, listaPuntos[i].y + centroEsc.y
                    + centroObj.getY() + centroPol.getY(), listaPuntos[i + 1].getX() + centroEsc.getX() + centroObj.getX() + centroPol.getX()
                    , listaPuntos[i + 1].getY() + centroEsc.getY() + centroObj.getY() + centroPol.getY());
            }
        }*/



    }
}

