using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Proyecto1_01;

namespace Proyecto1
{
    public class Game : GameWindow
    {
       
        
        public Cubo cubo;
        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e) //crear la ventana
        {
            base.OnUpdateFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e) //crear el objeto
        {
            GL.ClearColor(Color4.Black);
            cubo = new Cubo(new Punto(), 10, 10 ,10);
            //XmlSerializer ser = new XmlSerializer(typeof(Cubo));
            //Stream myStream = new FileStream("myDoc.xml", FileMode.Create, FileAccess.Write);
            //ser.Serialize(myStream, cubo);
            //myStream.Close();
            //Deserializar
            //Stream stream= new FileStream("myDoc.xml",FileMode.Open, FileAccess.Read);
            //Console.WriteLine("Reading with TextReader");
            //XmlSerializer serializer = new XmlSerializer(typeof(Cubo));
            // FileStream fs = new FileStream("myDoc.xml", FileMode.OpenOrCreate);
            // TextReader reader = new StreamReader(fs);
            /* Cubo i;

            using (Stream reader = new FileStream("myDoc.xml", FileMode.Open))
             {
                 // Call the Deserialize method to restore the object's state.
                 i = (Cubo)serializer.Deserialize(reader);
             }

             // Write out the properties of the object.
             Console.Write(
             i.origen+ "\t" +
             i.ancho+ "\t" +
             i.alto + "\t" +
             i.alto  + "\t" 
            // i.LineTotal
            );
            */
            string ob = File.ReadAllText("myDoc.json");
            Objeto Cubo = JsonConvert.DeserializeObject<Objeto>(ob);
            base.OnLoad(e);    //
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //limpia pantalla
            GL.Enable(EnableCap.DepthTest); //
            GL.LoadIdentity(); //matriz identidad transformaciones en pila
            //-----------------------
            this.cubo.Dibujar();
            //-----------------------
            Context.SwapBuffers(); //pinta el objeto
            
            base.OnRenderFrame(e);
			//Esta sentencia todo el tiempo se esta ejecutando 
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 30;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

       

    }
}
