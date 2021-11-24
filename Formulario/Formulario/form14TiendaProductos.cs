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
    public partial class form14TiendaProductos : Form
    {
        public form14TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;

            if (this.lsTienda.Items.Contains(producto))
            { //Si cumple la condición de que el producto está ya almacenado en la colección

                int posicion = this.lsTienda.Items.IndexOf(producto); //Recogemos en una variable el índice del producto que existe
                this.lsTienda.SelectedIndex = -1; //Colocamos el índice seleccionado a -1 para vaciarlo 
                this.lsTienda.SelectedIndex = posicion;//Entonces aquí recogemos el índice y seleccionamos el producto
            }
            else {

                this.lsTienda.Items.Add(producto);
            }
            this.txtProducto.SelectAll();
            this.txtProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numeroElementos = this.lsTienda.Items.Count - 1; //Esto es lo mismo que un .length

            for (int i=numeroElementos;i>=0;i--) {

                int indice = this.lsTienda.SelectedIndices[i]; /*Con esto lo que hacemos es coger todos los índices de todos los elementos
                                                                seleccionados en el listado*/
                this.lsTienda.Items.RemoveAt(indice); //Va eliminando del listado que indice que ha sido seleccionado
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtProducto.Text.ToUpper(); //Convertimos el texto recogido a mayúsculas

            for (int i=0;i<this.lsTienda.SelectedItems.Count;i++) {

                int indice = this.lsTienda.SelectedIndices[i]; //Vamos recogiendo todos los indices de todos los elementos seleccionados
                this.lsTienda.Items[indice] = elemento; /*Aquí le estamos diciendo que, por el elemento que es seleccionado en la lista
                                                         se modifique por el recogido en el texto*/
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lsTienda.Items.Clear();//Limpiamos toda la lista de la colección de tienda
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            foreach (string producto in this.lsTienda.SelectedItems) { /*Le estamos diciendo que recoga cada producto de los seleccionados
                                                                         en la colección de tienda*/

                this.lsAlmacen.Items.Add(producto); //Vamos añadiendo cada producto recogido en la colección de almacén
            }

            int numeroElementos = this.lsTienda.SelectedIndices.Count - 1; //.length -1

            for (int i=numeroElementos; i>=0;i--) { //Estamos recorriendo todos los elementos seleccionados en la colección tienda

                int indice = this.lsTienda.SelectedIndices[i]; //vamos recogiendo los índices de todos los elementos seleccionados
                this.lsTienda.Items.RemoveAt(indice); //Y los vamos eliminando después de añadirlos a la colección almacén
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lsAlmacen.Items.AddRange(this.lsTienda.Items); /*Con el método AddRange lo que le decimos es que añada,
                                                                 dentro del objeto Items, todos los Items que pertenecen a la 
                                                                colección de tienda*/
            this.lsTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lsAlmacen.SelectedIndex; //Primero recogemos el índice del producto que es seleccionado
            string elemento = this.lsAlmacen.SelectedItem.ToString(); //después recogemos el producto que es seleccionado (hay que parsear)
            this.lsAlmacen.Items.RemoveAt(indice);//eliminamos el índice de dicho producto
            this.lsAlmacen.Items.Insert(indice - 1, elemento);/*y seguidamente insertamos en la colección el producto pero en una 
                                                               posición más arriba*/
            this.lsAlmacen.SelectedIndex = indice - 1; /*Le tenemos que indicar que el elemento seleccionado será el que esté una 
                                                        posición más arriba (recuerda, -1 para subir, +1 para bajar)*/
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lsAlmacen.SelectedIndex; //Recogemos el índice del producto que es seleccionado
            string elemento = this.lsAlmacen.SelectedItem.ToString(); //Parseamos a string el producto recogido (el seleccionado)
            this.lsAlmacen.Items.RemoveAt(indice);//Eliminamos al elemento de esa posición
            this.lsAlmacen.Items.Insert(indice+1,elemento);//Y volvemos a insertar el producto en la posición pero en un índice más bajo

            this.lsAlmacen.SelectedIndex = indice + 1; //Le indicamos que el elemento seleccionado está en una posición más abajo
        }

        private void lsAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsAlmacen.SelectedIndex == 0) //Si cumple la condición de que el índice seleccionado es 0 (que no hay seleccionado)
            {

                this.btnSubir.Enabled = false;
            }
            else {

                this.btnSubir.Enabled = true;
            }

            if (this.lsAlmacen.SelectedIndex == this.lsAlmacen.Items.Count - 1) //Si la cantidad de índice seleccionado es igual a -1 NADA
            {

                this.btnBajar.Enabled = false;

            }
            else {

                this.btnBajar.Enabled = true;
            }
        }
    }
}
