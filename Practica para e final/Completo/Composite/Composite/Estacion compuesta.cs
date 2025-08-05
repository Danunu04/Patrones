using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Estacion_compuesta:Iestacion
    {
        List<Iestacion> componentes = new List<Iestacion>();

        public Estacion_compuesta(string nombre) : base(nombre) { }
        public override void Agregar(Iestacion estacion)
        {
           componentes.Add(estacion);
        }
        public override void eliminar(Iestacion estacion)
        {
            componentes.Remove(estacion);
        }
        public override void Buscar(Iestacion estacion)
        {
            foreach (var item in componentes)
            {
                if (item is Estacion_compuesta compuesta)
                {
                    if (compuesta.Nombre == estacion.Nombre)
                    {
                        Console.WriteLine($"Estacion {estacion.Nombre} encontrada dentro de una estación compuesta.");
                    }
                }
                else if(item is EstacionSimple estacionSimple)
                {
                    if(estacionSimple == estacion)
                    {
                        Console.WriteLine($"Estacion {estacion.Nombre} encontrada dentro de una estación simple.");
                    }
                }
            }
        }

        public override void ActivarEmergencia(Iestacion estacion)
        {
            foreach (var item in componentes)
            {
                if (item is Estacion_compuesta compuesta)
                {
                    if (compuesta.componentes.Contains(estacion))
                    {
                        Console.WriteLine($"EMERGENCIA EN ESTACION COMPLEJA {estacion.Nombre} CORRAAAAAAAAAAAAAAAAAAAAAAAAN.");
                    }
                }
                else if (item is EstacionSimple estacionSimple)
                {
                    if (estacionSimple == estacion)
                    {
                        estacionSimple.ActivarEmergencia(estacion);
                    }
                }
            }
        }
    }
}
