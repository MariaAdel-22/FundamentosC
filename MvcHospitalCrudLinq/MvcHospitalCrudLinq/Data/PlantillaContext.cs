using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcHospitalCrudLinq.Models;
using System.Data.SqlClient;
using System.Data;

namespace MvcHospitalCrudLinq.Data
{
    public class PlantillaContext
    {
        private string cadenaconexion;
        private SqlDataAdapter adPlantilla;
        private DataTable TablaPlantilla;

        public PlantillaContext() {

            this.cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

            string sql = "SELECT * FROM PLANTILLA";

            this.adPlantilla = new SqlDataAdapter(sql,cadenaconexion);
            this.TablaPlantilla = new DataTable();
            this.adPlantilla.Fill(this.TablaPlantilla);

        }

        public ModelPlantillas GetPlantillasHospital(int hospital_cod) {

            var consulta = from datos in this.TablaPlantilla.AsEnumerable() where datos.Field<int>("HOSPITAL_COD") == hospital_cod select datos;

            List<Plantilla> plantillas = new List<Plantilla>();

            foreach (var row in consulta) {

                Plantilla pl = new Plantilla();

                pl.Apellido = row.Field<string>("APELLIDO");
                pl.Empleado_No = row.Field<int>("EMPLEADO_NO");
                pl.Funcion = row.Field<string>("FUNCION");
                pl.Hospital_Cod = row.Field<int>("HOSPITAL_COD");

                pl.Salario = row.Field<int>("SALARIO");
                pl.Sala_Cod = row.Field<int>("SALA_COD");
                pl.T =char.Parse (row.Field<string>("T"));

                plantillas.Add(pl);
            }

            int personas = plantillas.Count();
            int suma = plantillas.Sum(x => x.Salario);
            double media = plantillas.Average(z => z.Salario);

            ModelPlantillas modPlantillas = new ModelPlantillas();

            modPlantillas.Plantillas = plantillas;
            modPlantillas.MediaSalarial = media;
            modPlantillas.Personas = personas;
            modPlantillas.SumaSalarial = suma;

            return modPlantillas;
        }
    }
}
