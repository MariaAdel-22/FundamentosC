using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NetCoreLinqSQL.Models;

#region PROCEDIMIENTOS

/*
 CREATE PROCEDURE INCREMENTAR_SALARIOS_OFICIO (@OFICIO NVARCHAR(50), @INCREMENTO INT)
AS
	UPDATE EMP SET SALARIO=SALARIO + @INCREMENTO WHERE OFICIO=@OFICIO
GO
 */
#endregion

namespace NetCoreLinqSQL.Data
{
    public class EmpleadosContext
    {
        private SqlDataAdapter ademp;
        private DataTable tablaemp;

        private SqlConnection connect;
        private SqlCommand com;
        private SqlDataReader reader;

        public EmpleadosContext() {

            string cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            this.RefreshTabla();
        }

        private void RefreshTabla() {

            string sql = "SELECT * FROM EMP";
            this.ademp = new SqlDataAdapter(sql, this.connect);

            this.tablaemp = new DataTable();
            this.ademp.Fill(tablaemp);

        }

        public List<string> GetOficios() {

            List<string> Oficios = new List<string>();

            var consulta = (from datos in this.tablaemp.AsEnumerable() select datos.Field<string>("OFICIO")).Distinct();

            foreach (var oficio in consulta) {

                Oficios.Add(oficio);
            
            }

            return Oficios;
            
        }

        public List<Empleado> EmpleadosOficio(string oficio) {

            List<Empleado> Empleados = new List<Empleado>();

            var consulta = from datos in this.tablaemp.AsEnumerable() where datos.Field<string>("OFICIO") == oficio select datos;

            foreach (var row in consulta) {

                Empleado emp = new Empleado();

                emp.IdDepartamento = row.Field<int>("DEPT_NO");
                emp.IdEmpleado = row.Field<int>("EMP_NO");
                emp.Apellido = row.Field<string>("APELLIDO");
                emp.Oficio = row.Field<string>("OFICIO");
                emp.Salario = row.Field<int>("SALARIO");

                Empleados.Add(emp);
            }

            this.RefreshTabla();
            return Empleados;
        }

        public int IncrementarSalarioEmpleadosOficio(string oficio,int incremento) {

            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.com.Parameters.AddWithValue("@INCREMENTO", incremento);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "INCREMENTAR_SALARIOS_OFICIO";

            this.connect.Open();
            int res = this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();
            this.RefreshTabla();

            return res;
        }

        public List<Empleado> GetEmpleados() {

            List<Empleado> empleados = new List<Empleado>();

            //Para recuperar datos con LINQ necesitamos hacerlo sobre la colección de filas de la tabla

            var consulta = from datos in this.tablaemp.AsEnumerable() select datos;

            //Ahora mismo en consulta tenemos una colección de filas(rows) que tiene cada fila un campo(field)

            foreach (var row in consulta) {

                Empleado emp = new Empleado();

                //Recuperamos cada field del row

                emp.IdEmpleado = row.Field<int>("EMP_NO");
                emp.Apellido = row.Field<string>("APELLIDO");
                emp.Oficio = row.Field<string>("OFICIO");
                emp.Salario = row.Field<int>("SALARIO");
                emp.IdDepartamento = row.Field<int>("DEPT_NO");

                empleados.Add(emp);
            }

            this.RefreshTabla();

            return empleados;
        }

        //Realizar un método para un solo empleado

        public Empleado FindEmpleado(int idempleado) {

            var consulta = from datos in this.tablaemp.AsEnumerable() where datos.Field<int>("EMP_NO") == idempleado select datos;

            //TENEMOS UN MÉTODO PARA RECUPERAR EL PRIMER REGISTRO YA QUE DEVUELVE UNA FILA

            var row = consulta.First();

            Empleado emp = new Empleado();

            emp.Apellido = row.Field<string>("APELLIDO");
            emp.IdDepartamento = row.Field<int>("DEPT_NO");
            emp.IdEmpleado = row.Field<int>("EMP_NO");

            emp.Oficio = row.Field<string>("OFICIO");
            emp.Salario = row.Field<int>("SALARIO");

            return emp;
        }

        public List<Empleado> GetEmpleadosOficioSalario(string oficio,int salario) {


            var consulta = from datos in this.tablaemp.AsEnumerable() where datos.Field<int>("SALARIO") >= salario && datos.Field<string>("OFICIO") == oficio select datos;

            if (consulta.Count() == 0)
            { //Preguntamos si devuelve filas o no, si no encuentra nada siempre devolveremos un NULL si es objeto

                return null;
            }
            else {

                List<Empleado> empleados = new List<Empleado>();

                foreach (var row in consulta) {

                    Empleado emp = new Empleado();

                    emp.Apellido = row.Field<string>("APELLIDO");
                    emp.IdDepartamento = row.Field<int>("DEPT_NO");
                    emp.IdEmpleado = row.Field<int>("EMP_NO");
                    emp.Oficio = row.Field<string>("OFICIO");
                    emp.Salario = row.Field<int>("SALARIO");

                    empleados.Add(emp);
                }

                return empleados;
            }
        }
    }
}
