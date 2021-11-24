using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class form12ColeccionesGráficas : Form
    {
        public form12ColeccionesGráficas()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtLetra.Text; //Primero recogemos el valor que añadimos en el input elemento
            this.lsLetras.Items.Add(elemento);//Después en la colección, usando Items vamos añadiendo cada elemento
        }

        private void lstLetras_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.lblIndice.Text = "Indice: "+this.lsLetras.SelectedIndices.ToString(); /*Lo que hacemos es que muestre
             en el label de Indice la posición del elemento de la colección que es seleccionado, este evento se activa cuando 
             cambiamos de opción en el listado multiple*/

            this.lblItem.Text = "Item: " + this.lsLetras.SelectedItem; /*Lo que hacemos es mostrar cuál es elemento que se 
            ha seleccionado*/
        } 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*Para eliminar tenemos dos métodos:
                
                .Remove(Object);
                .RemoveAt(index)
             */
            int indice = this.lsLetras.SelectedIndex; //Recogemos el índice del elemento que ha sido seleccionado
            this.lsLetras.Items.RemoveAt(indice);//Aquí eliminamos del listado el item cuyo índice corresponda con el recogido
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lsLetras.Items.Clear();//Con éste método limpiamos toda la lista
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

            string elem = this.txtLetra.Text; //Primero recogemos el valor que añadimos en el input
            int indice = this.lsLetras.SelectedIndex; //Ahora recogemos el índice del elemento que tenemos seleccionado en la lista
            this.lsLetras.Items[indice] = elem; //En el índice de ese objeto seleccionado le metemos el elemento recogido en input.
        }

       
    }
}
