using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.View
{
    public partial class FrHomeAdmin : Form
    {

        Service_Categoria.CategoriaServiceClient categoriaService = new Service_Categoria.CategoriaServiceClient();
        Service_Cargo.CargoServiceClient cargo = new Service_Cargo.CargoServiceClient();
        Service_Producto.ProductoServiceClient productoService = new Service_Producto.ProductoServiceClient();

        DateTime FechaCreacion;

        public FrHomeAdmin()
        {
            InitializeComponent();

            //habilitar campos para agregar categoria
            labelCategoria.Hide();
            btnNoAgregarCat.Hide();
            txtNombreCategoria.Hide();
            btnAñadirCategoria.Hide();

            //habilitar campos para agregar categoria
            labelCategoria2.Hide();
            btnNoAgregarCat2.Hide();
            txtNombreCategoria2.Hide();
            btnAñadirCategoria2.Hide();

            //desabilitar los campos hasta que busque el id
            txtNombreProducto2.Enabled = false;
            txtDescripcion2.Enabled = false;
            txtPrecio2.Enabled = false;
            cboCategorias2.Enabled = false;
            cboCategorias2.Enabled = false;
            btnCrearCategoria2.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnCancelarModificar.Enabled = false;


            //inlicializar cbbCargoUsuario
            initCboCargoUsuario();

            //Inicializar cboCategorias
            initCboCategoria();
            initCboCategoria2();

            //inicializar lista de productos
            initLisProductos();
        }

        private void initLisProductos()
        {
            dtgvListaProductos.Columns.Clear();
            dtgvListaProductos.DefaultCellStyle.ForeColor = Color.Black;
            dtgvListaProductos.ColumnCount = 5;
            dtgvListaProductos.Columns[0].Name = "ID";
            dtgvListaProductos.Columns[1].Name = "Nombre de producto";
            dtgvListaProductos.Columns[2].Name = "Descripcion";
            dtgvListaProductos.Columns[3].Name = "Precio";
            dtgvListaProductos.Columns[4].Name = "Nombre de Categoria";
            string[] row = new string[] { "id", "nombre", "desc", "precio", "categoria" };
            List<Service_Producto.producto> listado = productoService.Listado_productos().ToList();
            foreach (var item in listado)
            {
                row = new string[] {
                    item.idProducto.ToString(),
                    item.nombre,
                    item.descripcion,
                    item.precio.ToString(),
                    item.categoriaIdCategoria.descripcion
                };
                dtgvListaProductos.Rows.Add(row);
            }
        }

        private void btnLimpiarAgregar_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = "";
            txtApellidoPersona.Text = "";
            txtCorreoUsuario.Text = "";
            txtCorreoUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
            txtRutPersona.Text = "";
            cboSexo.Text = "";
            dtFechaInicio.Value = DateTime.Now;
            dtFechaActualizacion.Value = DateTime.Now;
            cbbCargoUsuario.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCorreoUsuario.Text = "";
            txtContrasenaUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
            dtFechaInicio.Value = DateTime.Now;
            dtFechaActualizacion.Value = DateTime.Now;

        }


        private void btnLimpiarAE_Click_1(object sender, EventArgs e)
        {
            txtRutEmpresa.Text = "";
            txtNombreEmpresa.Text = "";
            txtDescripcionEmpresa.Text = "";
            dtFechaInicioEmpresa.Value = DateTime.Now;
            dtFechaActualizacionEmpresa.Value = DateTime.Now;
            txtEstado.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Service_Persona.PersonaServiceClient perso = new Service_Persona.PersonaServiceClient();
            perso.Crear_persona(0, txtNombrePersona.Text, txtApellidoPersona.Text, txtRutPersona.Text, cboSexo.SelectedIndex + 1);
            //perso.Listado_personas();
            Service_Persona.persona persona1 = perso.Listado_personas().OrderByDescending(x => x.idpersona).First();
            MessageBox.Show("Persona " + persona1.idpersona);

            Service_Usuario.UsuarioServiceClient usu = new Service_Usuario.UsuarioServiceClient();
            usu.CREAR_USUARIO(0, txtCorreoUsuario.Text, txtContrasenaUsuario.Text, int.Parse(txtTelefonoUsuario.Text), DateTime.Parse(dtFechaInicio.Value.ToShortDateString()), DateTime.Parse(dtFechaActualizacion.Value.ToShortDateString()), 1, int.Parse(persona1.idpersona.ToString()), cbbCargoUsuario.SelectedIndex + 1);

        }

        private void btnGuardaEmpresa_Click(object sender, EventArgs e)
        {
            Service_Empresa.EmpresaServiceClient empre = new Service_Empresa.EmpresaServiceClient();
            //empre.Crear_empresa(0, txtRutEmpresa.Text, txtNombreEmpresa.Text, txtDescripcionEmpresa.Text, DateTime.Parse(dtFechaInicioEmpresa.Value.ToShortDateString()), DateTime.Parse(dtFechaActualizacionEmpresa.Value.ToShortDateString()),txtEstado.Text);

            Service_Empresa.empresa empre1 = empre.Listado_empresa().OrderByDescending(x => x.idEmpresa).First();
            MessageBox.Show("Empresa " + empre1.idEmpresa);
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            labelCategoria.Show();
            btnNoAgregarCat.Show();
            txtNombreCategoria.Show();
            btnAñadirCategoria.Show();

            txtNombreProducto.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            cboCategorias.Enabled = false;
            cboCategorias.Enabled = false;
            btnCrearCategoria.Enabled = false;
            btnCrearProducto.Enabled = false;
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbCargoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void initCboCargoUsuario()
        {
            cbbCargoUsuario.Items.Clear();
            List<Service_Cargo.cargo> lisCargos = cargo.Listado_cargos().ToList();
            foreach (Service_Cargo.cargo item in lisCargos)
            {
                cbbCargoUsuario.Items.Insert(int.Parse(item.idcargo.ToString()) - 1, item.descripcion);
            }
            cbbCargoUsuario.SelectedIndex = 0;
        }

        private void initCboCategoria()
        {
            cboCategorias.Items.Clear();
            List<Service_Categoria.categoria> listaCategorias = categoriaService.Listado_categorias().ToList();
            foreach (Service_Categoria.categoria item in listaCategorias)
            {
                cboCategorias.Items.Insert(int.Parse(item.idCategoria.ToString()) - 1, item.descripcion);
            }
            cboCategorias.SelectedIndex = 0;
        }

        private void initCboCategoria2()
        {
            cboCategorias2.Items.Clear();
            List<Service_Categoria.categoria> listaCategorias = categoriaService.Listado_categorias().ToList();
            foreach (Service_Categoria.categoria item in listaCategorias)
            {
                cboCategorias2.Items.Insert(int.Parse(item.idCategoria.ToString()) - 1, item.descripcion);
            }
            cboCategorias2.SelectedIndex = 0;
        }

        private void btnNoAgregarCat_Click(object sender, EventArgs e)
        {
            btnNoAgregarCat.Hide();
            labelCategoria.Hide();
            btnNoAgregarCat.Hide();
            txtNombreCategoria.Hide();
            btnAñadirCategoria.Hide();
            txtNombreProducto.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            cboCategorias.Enabled = true;
            btnCrearCategoria.Enabled = true;
            btnCrearProducto.Enabled = true;

        }

        private void btnAñadirCategoria_Click(object sender, EventArgs e)
        {
            labelCategoria.Hide();
            btnNoAgregarCat.Hide();
            txtNombreCategoria.Hide();
            btnAñadirCategoria.Hide();
            try
            {
                String retorno = categoriaService.Crear_categoria(0, txtNombreCategoria.Text);
                MessageBox.Show(" Listo ");
                txtNombreCategoria.Text = "";
                initCboCategoria();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error -> " + err.Message);
            }
            txtNombreProducto.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            cboCategorias.Enabled = true;
            btnCrearCategoria.Enabled = true;
            btnCrearProducto.Enabled = true;
            initCboCategoria();
            initCboCategoria2();
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now;
                productoService.Crear_producto(0, txtNombreProducto.Text.Trim(), txtDescripcion.Text, int.Parse(txtPrecio.Text), date, date, "-", cboCategorias.SelectedIndex + 1);
                MessageBox.Show("Se Creo el producto correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cboCategorias.SelectedIndex = 0;
            initLisProductos();
        }

        private void dtgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Service_Producto.producto> listado = productoService.Listado_productos().ToList();
            foreach (var item in listado)
            {
                if (item.idProducto.ToString() == txtIdProducto.Text.Trim())
                {
                    FechaCreacion = item.inicio;
                    txtNombreProducto2.Text = item.nombre;
                    txtDescripcion2.Text = item.descripcion;
                    txtPrecio2.Text = item.precio.ToString();
                    cboCategorias2.SelectedIndex = int.Parse(item.categoriaIdCategoria.idCategoria.ToString()) - 1;
                    txtNombreProducto2.Enabled = true;
                    txtDescripcion2.Enabled = true;
                    txtPrecio2.Enabled = true;
                    cboCategorias2.Enabled = true;
                    cboCategorias2.Enabled = true;
                    btnCrearCategoria2.Enabled = true;
                    btnModificarProducto.Enabled = true;
                    btnCancelarModificar.Enabled = true;
                    btnBuscarProducto.Enabled = false;
                    txtIdProducto.Enabled = false;
                    break;
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCategoria2_Click(object sender, EventArgs e)
        {
            labelCategoria2.Show();
            btnNoAgregarCat2.Show();
            txtNombreCategoria2.Show();
            btnAñadirCategoria2.Show();

            txtNombreProducto2.Enabled = false;
            txtDescripcion2.Enabled = false;
            txtPrecio2.Enabled = false;
            cboCategorias2.Enabled = false;
            cboCategorias2.Enabled = false;
            btnCrearCategoria2.Enabled = false;
            btnModificarProducto.Enabled = false;
        }

        private void btnNoAgregarCat2_Click(object sender, EventArgs e)
        {
            btnNoAgregarCat2.Hide();
            labelCategoria2.Hide();
            btnNoAgregarCat2.Hide();
            txtNombreCategoria2.Hide();
            btnAñadirCategoria2.Hide();
        }

        private void btnAñadirCategoria2_Click(object sender, EventArgs e)
        {
            labelCategoria2.Hide();
            btnNoAgregarCat2.Hide();
            txtNombreCategoria2.Hide();
            btnAñadirCategoria2.Hide();
            try
            {
                String retorno = categoriaService.Crear_categoria(0, txtNombreCategoria.Text);
                MessageBox.Show(" Listo ");
                txtNombreCategoria.Text = "";
                initCboCategoria2();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error -> " + err.Message);
            }
            txtNombreProducto2.Enabled = true;
            txtDescripcion2.Enabled = true;
            txtPrecio2.Enabled = true;
            cboCategorias2.Enabled = true;
            btnCrearCategoria2.Enabled = true;
            btnModificarProducto.Enabled = true;
            initCboCategoria();
            initCboCategoria2();
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            txtNombreProducto2.Text = "";
            txtDescripcion2.Text = "";
            txtPrecio2.Text = "";
            cboCategorias2.SelectedIndex = 0;
            txtNombreProducto2.Enabled = false;
            txtDescripcion2.Enabled = false;
            txtPrecio2.Enabled = false;
            cboCategorias2.Enabled = false;
            cboCategorias2.Enabled = false;
            btnCrearCategoria2.Enabled = false;
            btnModificarProducto.Enabled = false;
            btnCancelarModificar.Enabled = false;
            txtIdProducto.Enabled = true;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreProducto2.Enabled = true;
                txtDescripcion2.Enabled = true;
                txtPrecio2.Enabled = true;
                cboCategorias2.Enabled = true;
                cboCategorias2.Enabled = true;
                btnCrearCategoria2.Enabled = true;
                btnModificarProducto.Enabled = false;
                btnCancelarModificar.Enabled = false;
                txtIdProducto.Enabled = true;

                DateTime date = DateTime.Now;
                int idtemp = int.Parse(txtIdProducto.Text.Trim());
                cboCategorias2.SelectedIndex = 0;
                //productoService.Crear_producto(0, txtNombreProducto.Text.Trim(), txtDescripcion.Text, int.Parse(txtPrecio.Text), date, date, "-", cboCategorias.SelectedIndex + 1);
                productoService.Modificar_producto(idtemp, txtNombreProducto2.Text.Trim(), txtDescripcion2.Text, int.Parse(txtPrecio2.Text), FechaCreacion, date, "-", cboCategorias2.SelectedIndex + 1);
                txtIdProducto.Text = "";
                txtNombreProducto2.Text = "";
                txtDescripcion2.Text = "";
                txtPrecio2.Text = "";
                btnBuscarProducto.Enabled = true;
                MessageBox.Show("Se Modificó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
            initLisProductos();
        }
    }
}
