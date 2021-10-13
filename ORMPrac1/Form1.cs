using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMPrac1
{

    /// <summary>
    /// Conversion de vectores, son vistas para el Form1, variables globales 
    /// </summary>

    public partial class Form1 : Form

    {
        public List<Model.ALUMNO> oAlumno;
        public List<Model.APODERADO> oApoderado;
        public List<Model.CURSO> oCurso;
        public List<Model.INSCRITO> oInscrito;
        int indice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Texto del ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ALUMNO");
            comboBox1.Items.Add("APODERADO");
            comboBox1.Items.Add("CURSO");
            comboBox1.Items.Add("INSCRITO");
        }

        /// <summary>
        /// Se plantean los casos pertinentes para el ComboBox, va del 0 al 3 (Casos)
        /// Funcion: Busqueda de cada una de las tablas dependiendo de la solicitud.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (Model.DBPrac1Entities db = new Model.DBPrac1Entities())
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        oAlumno = db.ALUMNO.ToList();
                        break;
                    case 1:
                        oApoderado = db.APODERADO.ToList();
                        break;
                    case 2:
                        oCurso = db.CURSO.ToList();
                        break;
                    case 3:
                        oInscrito = db.INSCRITO.ToList();
                        break;
                }

                indice = 0;
                Llenar();
            }
        }

        /// <summary>
        /// Botones del click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            indice--;
            Llenar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indice++;
            Llenar();
        }

        /// <summary>
        /// Metodo para llenar el TextBox con i-registro de la j-Tabla en el ComboBox1
        /// </summary>
        
        public void Llenar()
        {
            if (indice < 0)
                indice = 0;

            string cadena = "";
            switch (comboBox1.SelectedIndex)
            {
                // Busqueda en tabla ALUMNOS ---Caso 0

                case 0:
                    if (indice >= oAlumno.Count)
                        indice = oAlumno.Count - 1;

                    cadena = "Id: " + oAlumno[indice].Id.ToString() + " --- El nombre del alumno es: " + oAlumno[indice].Nombre + ", Proveniente de la ciudad de: " + oAlumno[indice].Ciudad + " Y su edad es de: " + oAlumno[indice].Edad + " Años";
                    break;

                // Se usa Find y DBPrac1Entiti para buscar diferentes tablas, El caso de apoderado --- Caso 1 

                case 1:
                    if (indice >= oApoderado.Count)
                        indice = oApoderado.Count - 1;


                    using (Model.DBPrac1Entities db = new Model.DBPrac1Entities())
                    {
                        oAlumno = db.ALUMNO.ToList();

                        // 1ero Extraer Id_Apoderado gracias al objeto oApoderado, 2do Evalua Id_Alumno y Apoderado para comprobar si existe un relacion y 3ero se trae el Nombre del Alumno, El caso de Alumno

                        cadena = "Id: " + oApoderado[indice].Id.ToString() + " --- El nombre del apoderado es: " + oApoderado[indice].Nombre + ", El cual representa a: " + oAlumno.Find(a => a.Id == (int)oApoderado[indice].Id_Alumno).Nombre;
                    }
                    break;

                // Busqueda tabla Curso --- Caso 2

                case 2:
                    if (indice >= oCurso.Count)
                        indice = oCurso.Count - 1;

                    cadena = "Id: " + oCurso[indice].Cod.ToString() + " --- Nombre del curso: " + oCurso[indice].Nombre + ", Tiene una fecha de inicio de: " + oCurso[indice].Fecha_Inicio + ", Duracion del curso: " + oCurso[indice].Duracion + " Dias, "  + " Y el valor de curso es: " + " $" + oCurso[indice].Valor + " USD";
                    break;


                //1ero Busqueda en tabla INSCRITO y tabla ALUMNO 2do Ejecuta Find de para validar datos identicos en las tablas --- Caso 3

                case 3:
                    if (indice >= oInscrito.Count)
                        indice = oInscrito.Count - 1;
                    using (Model.DBPrac1Entities db = new Model.DBPrac1Entities())
                    {
                        oAlumno = db.ALUMNO.ToList();
                        oCurso = db.CURSO.ToList();


                        cadena = "Id: " + oInscrito[indice].Id.ToString() + " --- El nombre del inscrito es: " + oAlumno.Find(a => a.Id == (int)oInscrito[indice].Id_Alumno).Nombre + " Y se encuentra en el curso de: " + oCurso.Find(a => a.Cod == (int)oInscrito[indice].Cod_Curso).Nombre;

                    }
                    break;


            }

            //El TexBox1 dara su respectivo valor dependiendo del Caso del Switch

            textBox1.Text = cadena;
        }
    }
}
