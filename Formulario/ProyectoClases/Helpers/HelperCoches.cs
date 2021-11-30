using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using ProyectoClases;

namespace ProyectoClases.Helpers
{
    public class HelperCoches
    {
        XmlSerializer xmlserial;
        ColeccionCoches coches;

        public HelperCoches() {

            xmlserial = new XmlSerializer(typeof(ColeccionCoches));
            coches = new ColeccionCoches();
        }

        public async Task GuardarCoches(List<Coche>coches) {

            this.coches =(ColeccionCoches) coches;

            StreamWriter writer = new StreamWriter("listacoches.xml");

            this.xmlserial.Serialize(writer,this.coches);

            await writer.FlushAsync();
            writer.Close();
        
        }

        public List<Coche> LeerCoches() {

            StreamReader reader = new StreamReader("listacoches.xml");

            this.coches = (ColeccionCoches)this.xmlserial.Deserialize(reader);

            reader.Close();

            return this.coches;
        }
    }
}
