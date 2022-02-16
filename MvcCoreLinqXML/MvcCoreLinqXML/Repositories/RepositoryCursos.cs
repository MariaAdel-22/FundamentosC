using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcCoreLinqXML.Repositories
{
    public class RepositoryCursos
    {
        private XDocument documentCurso;
        private string path;

        public RepositoryCursos(PathProvider provider)
        {

            this.path = provider.MapPath("Cursos.xml", Folders.Documents);
            this.documentCurso = XDocument.Load(path);
        }


        public Usuario GetUsuario(string username,string password) {

            var consulta = from datos in this.documentCurso.Descendants("usuario") where datos.Element("username").Value == username && 
                           datos.Element("password").Value== password select datos;

            Usuario usu = new Usuario();

            foreach (XElement elem in consulta) {

                usu.IdUsuario = int.Parse(elem.Attribute("id").Value);
                usu.Nombre = elem.Element("nombre").Value;
                usu.Apellidos = elem.Element("apellidos").Value;
                usu.Perfil = elem.Element("perfil").Value;
                usu.Nota = int.Parse(elem.Element("nota").Value);
                usu.UserName = elem.Element("username").Value;
                usu.Password = elem.Element("password").Value;
            }
            return usu;
        }

        public Curso GetUsuarios()
        {

            var consulta = from datos in this.documentCurso.Descendants("curso") select datos;

            Curso curso = new Curso();
            List<Usuario> usuario = new List<Usuario>();

            foreach (XElement elem in consulta)
            {
                curso.IdCurso = elem.Attribute("idcurso").Value;
                curso.Titulo = elem.Element("titulo").Value;
                curso.Edicion = elem.Element("edicion").Value;
                curso.Turno = elem.Element("turno").Value;
                curso.Contenidos = elem.Element("contenidos").Value;
            }

            var consulta2 = from datos in this.documentCurso.Descendants("usuario") select datos;

            foreach (XElement elem in consulta2) {

                Usuario usu = new Usuario();

                usu.IdUsuario = int.Parse(elem.Attribute("id").Value);
                usu.Nombre = elem.Element("nombre").Value;
                usu.Apellidos = elem.Element("apellidos").Value;
                usu.Perfil = elem.Element("perfil").Value;
                usu.Nota = int.Parse(elem.Element("nota").Value);
                usu.UserName = elem.Element("username").Value;
                usu.Password = elem.Element("password").Value;

                usuario.Add(usu);
            }

            curso.Usuarios = usuario;

            return curso;
        }

    }
}
