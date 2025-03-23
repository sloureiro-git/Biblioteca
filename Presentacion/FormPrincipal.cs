using System.Collections;
using Entidades;
using Logica;
using Persistencia;
namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonAÑADIR_Click(object sender, EventArgs e)
        {
            LogicaLibro.añadirLibros(int.Parse(textBoxID.Text), textBoxNombre.Text, textBoxAutor.Text, textBoxGenero.Text, DateTime.Parse(textBoxFechaDeLanzamiento.Text), int.Parse(textBoxCantidadDePaginas.Text));
            obtenerLista();
        }

        private void buttonACTUALIZAR_Click(object sender, EventArgs e)
        {
            LogicaLibro.actualizarLibros(int.Parse(textBoxID.Text), textBoxNombre.Text, textBoxAutor.Text, textBoxGenero.Text, DateTime.Parse(textBoxFechaDeLanzamiento.Text), int.Parse(textBoxCantidadDePaginas.Text));
            obtenerLista();
        }

        private void buttonELIMINAR_Click(object sender, EventArgs e)
        {
            LogicaLibro.eliminarLibros(int.Parse(textBoxID.Text));
            obtenerLista();

        }

        private void listBoxLIBROS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro ItemSeleccionado = listBoxLIBROS.SelectedItems[0] as Libro;
            textBoxID.Text = ItemSeleccionado.Id.ToString();
            textBoxNombre.Text = ItemSeleccionado.Nombre;
            textBoxAutor.Text = ItemSeleccionado.Autor;
            textBoxGenero.Text = ItemSeleccionado.Genero;
            textBoxCantidadDePaginas.Text = ItemSeleccionado.CantidadDePaginas.ToString();
            textBoxFechaDeLanzamiento.Text = ItemSeleccionado.FechaDeLanzamiento.ToString();
        }

        private void obtenerLista()
        {
            listBoxLIBROS.Items.Clear();
            listBoxLIBROS.DisplayMember = "Display";

            ArrayList Libros = LogicaLibro.listarLibros();

            for (int i = 0; i < Libros.Count; i++)
            {
                listBoxLIBROS.Items.Add(Libros[i]);
            }
        }

    }
}
