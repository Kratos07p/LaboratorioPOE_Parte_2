using peliculasDetalles;
using System.Windows.Forms;

namespace EjercicioLabParte2
{
    public partial class Form1 : Form
    {
        //Listas para almacenar las rentas y ventas
        private List<Rentar> peliculasRenta = new List<Rentar>();
        private List<Venta> peliculasVenta = new List<Venta>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Comprobacion de que los espacios del textbox no esten vacios
            if (!string.IsNullOrWhiteSpace(tbPelicula.Text) && !string.IsNullOrWhiteSpace(tbCategoria.Text))
            {
                //Llamado a la clase Pelicula de la bibilioteca de clases
                Pelicula infoPeliculas = new Pelicula();
                infoPeliculas.Peliculas = tbPelicula.Text;
                infoPeliculas.Categorias = tbCategoria.Text;

                string informacion = $"{infoPeliculas.Peliculas} - {infoPeliculas.Categorias}";

                lstCartelera.Items.Add(informacion);

                //Limpiar espacios en los textbox luego de apretar el boton para mas comodidad de el usuario
                tbPelicula.Text = "";
                tbCategoria.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa todos los campos necesarios para agregar la película.");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Comprobacion de que se selecciono algun dato del listbox
            if (lstCartelera.SelectedIndex >= 0)
            {
                //Codigo para obtener los detalles y elementos del dato seleccionado en el listbox
                string selectedItem = lstCartelera.SelectedItem.ToString();
            
                string[] details = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);

                //Poner los elementos en las posiciones correspondientes
                tbPelicula.Text = details[0];
                tbCategoria.Text = details[1];

                lstCartelera.Items.RemoveAt(lstCartelera.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento que se encuentre en la lista para poder editarlo.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCartelera.SelectedIndex >= 0)
            {
                //Codigo para remover elementos de la listBox
                lstCartelera.Items.RemoveAt(lstCartelera.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento que se encuentre en la lista para proseguir con su eliminación.");
            }
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            
            if (lstCartelera.SelectedIndex >= 0)
            {              
                string selectedItem = lstCartelera.SelectedItem.ToString();
                
                //Utilizar los elementos de una lista para mandarlos a otro textbox
                string[] details = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);

                tbPeliculaRentar.Text = details[0];
                tbCategoriaRentar.Text = details[1];
            }
            else
            {
                MessageBox.Show("Seleccione un elemento que se encuentre en la lista para proseguir con su renta.");
            }
        }

        private void btnAgregarRenta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPeliculaRentar.Text) && !string.IsNullOrWhiteSpace(tbCategoriaRentar.Text) &&
                !string.IsNullOrWhiteSpace(tbUsuarioRenta.Text) && !string.IsNullOrWhiteSpace(tbFechaLimite.Text))
            {
                //Llamado de la clase Renta que es una clase hija con herencia de la clase padre "Pelicula"
                Rentar renta = new Rentar();
                renta.Peliculas = tbPeliculaRentar.Text;
                renta.Categorias = tbCategoriaRentar.Text;
                renta.Usuario = tbUsuarioRenta.Text;

                //Comprobacion de que se ingrese una fecha valida
                if (DateTime.TryParse(tbFechaLimite.Text, out DateTime fechaLimite))
                {
                    renta.FechaLimite = fechaLimite;

                    peliculasRenta.Add(renta);

                    tbPeliculaRentar.Text = "";
                    tbCategoriaRentar.Text = "";
                    tbUsuarioRenta.Text = "";
                    tbFechaLimite.Text = "";

                    //Agregar elementos a una nueva lista
                    string rentaInfo = $"{renta.Peliculas} - {renta.Categorias} - Cliente: {renta.Usuario} - {renta.FechaLimite.ToShortDateString()}";
                    lstRentas.Items.Add(rentaInfo);

                    MessageBox.Show("La renta se agregó exitosamente.");
                }
                else
                {
                    MessageBox.Show("Ingresa una fecha límite válida en el formato correcto (Ejemplo: DD/MM/YY).");
                }
            }
            else
            {
                MessageBox.Show("Ingresa todos los campos necesarios para agregar la renta.");
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (lstCartelera.SelectedIndex >= 0)
            {
                string selectedItem = lstCartelera.SelectedItem.ToString();

                string[] details = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
                tbPeliculaVenta.Text = details[0];
                tbCategoriaVenta.Text = details[1];
            }
            else
            {
                MessageBox.Show("Seleccione un elemento que se encuentre en la lista para proseguir con su venta.");
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPeliculaVenta.Text) && !string.IsNullOrWhiteSpace(tbCategoriaVenta.Text) &&
                !string.IsNullOrWhiteSpace(tbUsuarioVenta.Text))
            {
                Venta venta = new Venta();
                venta.Peliculas = tbPeliculaVenta.Text;
                venta.Categorias = tbCategoriaVenta.Text;
                venta.Usuario = tbUsuarioVenta.Text;

                peliculasVenta.Add(venta);

                tbPeliculaVenta.Text = "";
                tbCategoriaVenta.Text = "";
                tbUsuarioVenta.Text = "";

                string ventaInfo = $"{venta.Peliculas} - {venta.Categorias} - Cliente: {venta.Usuario}";
                lstVenta.Items.Add(ventaInfo);

                MessageBox.Show("La venta se ha guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ingresa todos los campos necesarios para agregar la venta.");
            }
        }
    }
}