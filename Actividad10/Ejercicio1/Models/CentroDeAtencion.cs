using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesEntradas = new LinkedList<Solicitud>();
        Queue<Solicitud> ColaDeAtencion = new Queue<Solicitud>();
        public void ImportarCsvSolicitudesEntrantes(FileStream sf)
        {

            StreamReader sr = new StreamReader(sf);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                Solicitud solicitud = new Solicitud();
                solicitud.Importar(linea);

                solicitudesEntradas.AddLast(solicitud);
            }
            sr.Close();
        }

        public LinkedListNode<Solicitud> GetSolicitudPedientes()
        {
            return solicitudesEntradas.First;

        }
        public void Atender(Solicitud solicitud)
        {
            if(solicitudesEntradas.Remove(solicitud)==true);
            { ColaDeAtencion.Enqueue(solicitud); }

        }
        public string[] VerdDescripcioColaAtencion()
        {
            string[] descripcion = new string[ColaDeAtencion.Count];
            int n = 0;
            foreach (Solicitud solicitud in ColaDeAtencion)
            {
                descripcion[n++]=solicitud.ToString();
            }
            return descripcion;
        }
    }
}
