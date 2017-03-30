using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.Common;
using System.Data;

namespace COREMEI
{
    public class Login
    {
        public Login()
        {

        }

        private char _id_usuario;
        private char _nombre;
        private char _a_paterno;
        private char _a_materno;
        private char _telefono;
        private char _email;
        private char _pass;

        public char Id_usuario
        {
            get
            {
                return _id_usuario;
            }

            set
            {
                _id_usuario = value;
            }
        }

        public char Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public char A_paterno
        {
            get
            {
                return _a_paterno;
            }

            set
            {
                _a_paterno = value;
            }
        }

        public char A_materno
        {
            get
            {
                return _a_materno;
            }

            set
            {
                _a_materno = value;
            }
        }

        public char Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public char Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public char Pass
        {
            get
            {
                return _pass;
            }

            set
            {
                _pass = value;
            }
        }

        public Login(char Id_usuario, char Nombre, char A_paterno, char A_materno, char Telefono, char Email, char Pass )
        {
            this.Id_usuario = Id_usuario;
            this.Nombre = Nombre;
            this.A_paterno = A_paterno;
            this.A_materno = A_materno;
            this.Telefono = Telefono;
            this.Email = Email;

        }

        public string conection()
        {

        }
    }
}