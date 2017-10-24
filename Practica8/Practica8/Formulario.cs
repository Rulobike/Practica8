using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Practica8
{
    [Table("Tab_db")]
   public class Formulario
    {
            string matricula;
            string nombre;
            string apellido;
            string direccion;
            string telefono;
            string carrera;
            string semestre;
            string correo;
            string github;
            [PrimaryKey, Unique, MaxLength(8)]
            public string Id
            {
                get { return matricula; }
                set { matricula = value; }
            }

            [Column("Nombre"), MaxLength(20)]
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            [Column("Apellidos"), MaxLength(30)]
            public string Apellidos
            {
                get { return apellido; }
                set { apellido = value; }
            }

            [Column("Direccion"), MaxLength(40)]
            public string Direccion
            {
                get { return direccion; }
                set { direccion = value; }
            }

            [Column("Telefono"), MaxLength(10)]
            public string Telefono
            {
                get { return telefono; }
                set { telefono = value; }
            }

            [Column("Carrera"), MaxLength(30)]
            public string Carrera
            {
                get { return carrera; }
                set { carrera = value; }
            }
            [Column("Semestre"), MaxLength(20)]
            public string Semestre
            {
                get { return semestre; }
                set { semestre = value; }
            }

            [Column("Correo"), MaxLength(20)]
            public string Correo
            {
                get { return correo; }
                set { correo = value; }
            }

            [Column("GitHub"), MaxLength(20)]
            public string Github
            {
                get { return github; }
                set { github = value; }
            }
        }
}
