using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP9_ABSM_B
{
    public partial class ABMS : Form
    {
        private string nombreArchivoAlumnos = @"\archivoAlumno.txt";
        private string ArchivoAuxAlumnos = @"\archivoAuxAlumnos.txt";

        private string nombreArchivoNotas = @"\archivoNotas.txt";
        private string ArchivoAuxNotas = @"\archivoAuxNotas.txt";

        private string NotasAlumnos = @"\NotasAlumnos.txt";

        BindingList<Alumno> ListaAlumnos = new BindingList<Alumno>();
        BindingList<Nota> ListaNotas = new BindingList<Nota>();

        public ABMS()
        {
            InitializeComponent();
            dataGridView1.DataSource = ListaAlumnos;
            dataGridView2.DataSource = ListaNotas;
            ListarAlumnos();
            ListarNotas();
            Aparear();
        }

        private void AltaAlumno()
        {
            Alumno Alumno = new Alumno(nombre.Text, apellido.Text, int.Parse(dni1.Text));

            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoAlumnos, FileMode.Append))
            {
                using (StreamWriter escritor = new StreamWriter(archivo))
                {
                    escritor.WriteLine(Alumno.ToString());
                }

            }
        }

        private void BajaAlumno()
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoAlumnos, FileMode.Open);
            FileStream auxiliar = new FileStream(Directory.GetCurrentDirectory() + ArchivoAuxAlumnos, FileMode.Create);

            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(auxiliar);

            int DNI = int.Parse(dni1.Text);           

            while (!lector.EndOfStream)
            {
                string registro = lector.ReadLine();

                if (registro != null)
                {
                    if (int.Parse(registro.Split(',')[2]) != DNI)
                    {
                        escritor.WriteLine(registro);
                    }
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            auxiliar.Close();
        }

        private void ModificarAlumno()
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoAlumnos, FileMode.Open);
            FileStream auxiliar = new FileStream(Directory.GetCurrentDirectory() + ArchivoAuxAlumnos, FileMode.Create);

            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(auxiliar);

            int DNI = int.Parse(dni1.Text);
            string Registro;

            while (!lector.EndOfStream)
            {
                Registro = lector.ReadLine();

                if (Registro != null)
                {
                    if (int.Parse(Registro.Split(',')[2]) == DNI)
                    {
                        Alumno aux = new Alumno(nombre.Text, apellido.Text, int.Parse(dni1.Text));
                        Registro = aux.ToString();
                    }
                    escritor.WriteLine(Registro);
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            auxiliar.Close();

            File.Delete(Directory.GetCurrentDirectory() + nombreArchivoAlumnos);
            File.Move(Directory.GetCurrentDirectory() + ArchivoAuxAlumnos, Directory.GetCurrentDirectory() + nombreArchivoAlumnos);
        }

        private void AltaNota()
        {
            Nota Nota = new Nota(int.Parse(dni2.Text), double.Parse(_nota.Text), DateTime.Parse(fecha.Text));

            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoNotas, FileMode.Append))
            {
                using (StreamWriter escritor = new StreamWriter(archivo))
                {
                    escritor.WriteLine(Nota.ToString());
                }
            }
        }

        private void BajaNota()
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoNotas, FileMode.Open);
            FileStream auxiliar = new FileStream(Directory.GetCurrentDirectory() + ArchivoAuxNotas, FileMode.Create);

            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(auxiliar);

            int DNI = int.Parse(dni2.Text);

            while (!lector.EndOfStream)
            {
                string registro = lector.ReadLine();

                if (registro != null)
                {
                    if (int.Parse(registro.Split(',')[0]) != DNI)
                    {
                        escritor.WriteLine(registro);
                    }
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            auxiliar.Close();
        }

        private void ModificarNota()
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoNotas, FileMode.Open);
            FileStream auxiliar = new FileStream(Directory.GetCurrentDirectory() + ArchivoAuxNotas, FileMode.Create);

            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(auxiliar);

            int DNI = int.Parse(dni2.Text);
            string Registro;

            while (!lector.EndOfStream)
            {
                Registro = lector.ReadLine();

                if (Registro != null)
                {
                    if (int.Parse(Registro.Split(',')[0]) == DNI)
                    {
                        Nota aux = new Nota(int.Parse(dni2.Text), double.Parse(_nota.Text), DateTime.Parse(fecha.Text));
                        Registro = aux.ToString();
                    }
                    escritor.WriteLine(Registro);
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            auxiliar.Close();

            File.Delete(Directory.GetCurrentDirectory() + nombreArchivoNotas);
            File.Move(Directory.GetCurrentDirectory() + ArchivoAuxNotas, Directory.GetCurrentDirectory() + nombreArchivoNotas);
        }

        private void ListarAlumnos()
        {
            ListaAlumnos.Clear();
            string registro;

            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoAlumnos, FileMode.Open))
            {
                using (StreamReader lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        registro = lector.ReadLine();
                        Alumno AlumnoAux = new Alumno(registro.Split(',')[0], registro.Split(',')[1], int.Parse(registro.Split(',')[2]));
                        ListaAlumnos.Add(AlumnoAux);
                    }
                }
            }
        }

        private void ListarNotas()
        {
            ListaNotas.Clear();
            string registro;

            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivoNotas, FileMode.Open))
            {
                using (StreamReader lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        registro = lector.ReadLine();
                        Nota NotaAux = new Nota(int.Parse(registro.Split(',')[0]), double.Parse(registro.Split(',')[1]), DateTime.Parse(registro.Split(',')[2]));
                        ListaNotas.Add(NotaAux);
                    }
                }
            }
        }

        private void Aparear()
        {
            string path = Directory.GetCurrentDirectory() + NotasAlumnos;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream archivo = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(archivo))
                {
                    foreach (Alumno x in ListaAlumnos)
                    {
                        escritor.WriteLine(x.DNI + " " + x.Apellido + " " + x.Nombre);
                        foreach (Nota y in ListaNotas)
                        {
                            if (x.DNI == y.DNI)
                            {
                                escritor.WriteLine(y.DNI + " " + y.Valor + " " + y.Fecha);
                            }
                        }
                        escritor.WriteLine("");
                    }
                }
            }
        }

        private void OrdenarAlumnos()
        {
            ListarAlumnos();

            List<Alumno> AlumnosOrdenados = ListaAlumnos.OrderBy(alumno => alumno.Nombre).ToList();

            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + ArchivoAuxAlumnos, FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(archivo))
                {
                    foreach (Alumno x in AlumnosOrdenados)
                    {
                        escritor.WriteLine(x.ToString());
                    }
                }
            }

            File.Delete(Directory.GetCurrentDirectory() + nombreArchivoAlumnos);
            File.Move(Directory.GetCurrentDirectory() + ArchivoAuxAlumnos, Directory.GetCurrentDirectory() + nombreArchivoAlumnos);
            ListarAlumnos();
        }

        private void OrdenarNotas()
        {
            ListarNotas();
            List<Nota> NotasOrdenadas = ListaNotas.OrderBy(nota => nota.Valor).ToList();

            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + ArchivoAuxNotas, FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(archivo))
                {
                    foreach (Nota x in NotasOrdenadas)
                    {
                        escritor.WriteLine(x.ToString());
                    }
                }
            }

            File.Delete(Directory.GetCurrentDirectory() + nombreArchivoNotas);
            File.Move(Directory.GetCurrentDirectory() + ArchivoAuxNotas, Directory.GetCurrentDirectory() + nombreArchivoNotas);
            ListarNotas();
        }

        private void guardar1_Click(object sender, EventArgs e)
        {
            AltaAlumno();
            ListarAlumnos();
        }

        private void modificar1_Click(object sender, EventArgs e)
        {
            ModificarAlumno();
            ListarAlumnos();
        }

        private void borrar1_Click(object sender, EventArgs e)
        {
            BajaAlumno();
            ListarAlumnos();
        }

        private void guardar2_Click(object sender, EventArgs e)
        {
            AltaNota();
            ListarNotas();
        }

        private void modificar2_Click(object sender, EventArgs e)
        {
            ModificarNota();
            ListarNotas();
        }

        private void borrar2_Click(object sender, EventArgs e)
        {
            BajaNota();
            ListarNotas();
        }

        private void ordenarAlumnos_Click(object sender, EventArgs e)
        {
            OrdenarAlumnos();
        }

        private void ordenarNotas_Click(object sender, EventArgs e)
        {
            OrdenarNotas();
        }

        private void aparearArchivos_Click(object sender, EventArgs e)
        {
            Aparear();
        }
    }
}
