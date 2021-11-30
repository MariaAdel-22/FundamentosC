using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas() {

            this.Mascotas = new List<Mascota>();
        }

        //Métodos para guardar mascota

        public async Task SaveFileMascotas(string path) {

            String data = this.GetMascotasString();

            FileInfo file = new FileInfo(path);

            using (TextWriter writer= file.CreateText()) {

                await writer.WriteAsync(data);
                await writer.FlushAsync();

                writer.Close();
            }

        }

        private String GetMascotasString() {

            //nombre,raza (salto de linea) nombre,raza
            string data = "";

            foreach (Mascota mascota in this.Mascotas)
            {

                String temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "\n";
            }

            data.Trim('\n');

            return data;
        }

        //Métodos para leer mascota

        public void ReadFileMascotas(string path) {

            FileInfo file = new FileInfo(path);

            using (TextReader reader= file.OpenText()) {

                String data = reader.ReadToEnd();
                reader.Close();

                this.CreateMascotas(data);
            }
        }


        private void CreateMascotas(string data) {

            this.Mascotas.Clear(); //recuerda limpiar la lista para crear el nuevo listado

            String[] datosmascotas = data.Split('\n');

            foreach (string d in datosmascotas) {

                //ahora tenemos nombre,raza
                String[] propiedades = d.Split(',');

                Mascota mascota = new Mascota();

                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];

                this.Mascotas.Add(mascota);
            }
        }


    }
}
