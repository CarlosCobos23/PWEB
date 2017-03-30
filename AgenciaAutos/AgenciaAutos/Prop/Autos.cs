using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaAutos.Prop
{
    public class Autos
    {
        public Autos()
        {

        }

        private int _id_auto;
        private string _modelo;
        private int _año;
        private decimal _precio;

        public int Id_auto
        {
            get
            {
                return _id_auto;
            }

            set
            {
                _id_auto = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public int Año
        {
            get
            {
                return _año;
            }

            set
            {
                _año = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                _precio = value;
            }
        }

        public Autos(int id_auto, string modelo, int año, decimal precio)
        {
            this.Id_auto = id_auto;
            this.Modelo = modelo;
            this.Año = año;
            this.Precio = precio;
        }
    }
}