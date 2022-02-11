using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcCoreLinqXML.Repositories
{
    public class RepositoryPeliculas
    {
        private XDocument documentPeliculas;
        private XDocument documentEscenas;

        private string pathPeliculas;
        private string pathEscenas;

        public RepositoryPeliculas(PathProvider provider) {

            string filenamePeliculas = "peliculas.xml";

            this.pathPeliculas = provider.MapPath(filenamePeliculas,Folders.Documents);
            this.documentPeliculas = XDocument.Load(pathPeliculas);

            string filenameEscenas = "escenaspeliculas.xml";
            this.pathEscenas = provider.MapPath(filenameEscenas, Folders.Documents);
            this.documentEscenas = XDocument.Load(pathEscenas);

        }

        public List<Escena> GetEscenasPelicula(int id) {

            var consulta = from datos in this.documentEscenas.Descendants("escena") where datos.Attribute("idpelicula").Value == id.ToString() select datos;
            
            List<Escena> escenas = new List<Escena>();

            foreach (XElement elem in consulta) {

                Escena esc = new Escena();

                esc.IdPeliculaEscena = int.Parse(elem.Attribute("idpelicula").Value);
                esc.TituloEscena = elem.Element("tituloescena").Value;
                esc.Descripcion = elem.Element("descripcion").Value;
                esc.Imagen = elem.Element("imagen").Value;

                escenas.Add(esc);
            }

            return escenas;
        }

        public List<Pelicula> GetPeliculas() {

            var consulta = from datos in this.documentPeliculas.Descendants("pelicula") select datos;

            List<Pelicula> peliculas = new List<Pelicula>();

            foreach (XElement elem in consulta) {

                Pelicula pel = new Pelicula();

                pel.IdPelicula =int.Parse(elem.Attribute("idpelicula").Value);
                pel.Titulo = elem.Element("titulo").Value;
                pel.TituloOriginal = elem.Element("titulooriginal").Value;
                pel.Descripcion = elem.Element("descripcion").Value;
                pel.Poster = elem.Element("poster").Value;

                peliculas.Add(pel);
            }

            return peliculas;
        }
    }
}
