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
        Service_Usuario.UsuarioServiceClient usuarioService = new Service_Usuario.UsuarioServiceClient();
        Service_Empresa.EmpresaServiceClient empresaService = new Service_Empresa.EmpresaServiceClient();
        Service_Local.LocalServiceClient localService = new Service_Local.LocalServiceClient();
        Service_Region.RegionServiceClient regionService = new Service_Region.RegionServiceClient();
        Service_Cliente.ClienteServiceClient clienteService = new Service_Cliente.ClienteServiceClient();
        Service_Ciudad.CiudadServiceClient ciudadService = new Service_Ciudad.CiudadServiceClient();

        DateTime FechaCreacion;
        DateTime FechaCreacionUsuario;
        DateTime FechaInicioEmpresa;
        int IdUsuariotemp;
        //int IdEmpresatemp;

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
            
            //desabilitar los campos hasta que busque el id local
            txtNombreLocalBuscar.Enabled = false;
            txtDireccionLocalBuscar.Enabled = false;
            cboIdEmpresaBuscar.Enabled = false;
            cboComunaLocalBuscar.Enabled = false;

            

            //desabilitar los campos hasta que busque el id           
            txtTelefono.Enabled = false;
            txtContraseña.Enabled = false;

            //desabilitar los campos hasta que busqie el id locales
            txtNombreLocalBuscar.Enabled = false;
            txtDireccionLocalBuscar.Enabled = false;

            //inlicializar cbbCargoUsuario
            initCboCargoUsuario();

            //Inicializar cboCategorias
            initCboCategoria();
            initCboCategoria2();
            initcboIdEmpresa();
            initcboComuna();
            initcboComunaBuscar();


            //inicializar lista de productos
            initLisProductos();
            

            //iniciar lista de locales
            initLisLocal();

            //inicializar lista de usuarios
            initLisUsuario();
            
            //inicializar lista de empresa
            initLisEmpresa();

            //te falto esta wea 
            initcboIdEmpresaBuscar();


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

        private void initLisUsuario()
        {
            datagridviewUsuario.Columns.Clear();
            datagridviewUsuario.DefaultCellStyle.ForeColor = Color.Black;
            datagridviewUsuario.ColumnCount =8;
            datagridviewUsuario.Columns[0].Name = "ID";
            datagridviewUsuario.Columns[1].Name = "rut";
            datagridviewUsuario.Columns[2].Name = "nombre";
            datagridviewUsuario.Columns[3].Name = "apellido";
            datagridviewUsuario.Columns[4].Name = "sexo";            
            datagridviewUsuario.Columns[5].Name = "Telefono";
            datagridviewUsuario.Columns[6].Name = "cargo";
            datagridviewUsuario.Columns[7].Name = "correo";
            //datagridviewUsuario.Columns[4].Name = "contraseña";

            string[] row = new string[] { "id", "rut" ,"nombre", "apellido", "sexo", "telefono", "cargo", "correo", };
            List<Service_Usuario.usuario> listado = usuarioService.Listado_usuarios().ToList();            
            foreach (var item in listado )                
            {
                string sex = "";
                if (item.personaIdpersona.sexoIdSexo.idSexo == 1)
                {
                    sex = "Masculino";
                }
                else {
                    sex = "Femenino";
                }
                row = new string[] {
                    item.idUsuario.ToString(),
                    item.personaIdpersona.rut,  
                    item.personaIdpersona.nombre,
                    item.personaIdpersona.apellidos,
                    sex,                                      
                    item.telefono.ToString(),
                    item.cargoIdcargo.descripcion,
                    item.correo,
                    
                };
                datagridviewUsuario.Rows.Add(row);
            }
        }
            
        private void initLisLocal()
        {
            dtgListadoLocales.Columns.Clear();
            dtgListadoLocales.DefaultCellStyle.ForeColor = Color.Black;
            dtgListadoLocales.ColumnCount = 5;
            dtgListadoLocales.Columns[0].Name = "ID Local";
            dtgListadoLocales.Columns[1].Name = "Direccion";
            dtgListadoLocales.Columns[2].Name = "Nombre";
            dtgListadoLocales.Columns[3].Name = "Empresa";
            dtgListadoLocales.Columns[4].Name = "Region";
            string[] row = new string[] { "id", "direccion", "nombre", "Empresa" , "Region"};
            List<Service_Local.local> listadoLoc = localService.Listado_local().ToList();
            foreach (var item in listadoLoc)
            {
                row = new string[] {
                    item.idLocal.ToString(),
                    item.direccion,
                    item.nombre,
                    item.empresaIdEmpresa.nombre.ToString(),
                    item.ciudadIdCiudad.nombre.ToString()
                    
                };
                dtgListadoLocales.Rows.Add(row);
            }

        }

        private void initLisEmpresa()
        {
            dtgEmpresa.Columns.Clear();
            dtgEmpresa.DefaultCellStyle.ForeColor = Color.Black;
            dtgEmpresa.ColumnCount = 7;
            dtgEmpresa.Columns[0].Name = "ID";
            dtgEmpresa.Columns[1].Name = "Rut";
            dtgEmpresa.Columns[2].Name = "Nombre";
            dtgEmpresa.Columns[3].Name = "Descripcion";
            dtgEmpresa.Columns[4].Name = "Inicio";
            dtgEmpresa.Columns[5].Name = "Actualizacion";
            dtgEmpresa.Columns[6].Name = "Estado";
            string[] row = new string[] { "id", "rut", "nombre", "descripcion", "inicio", "actualizacion", "estado" };
            List<Service_Empresa.empresa> listado = empresaService.Listado_empresa().ToList();
            foreach (var item in listado)
            {
                //MessageBox.Show("Entro al for" + item.nombre);
                row = new string[] {
                    item.idEmpresa.ToString(),
                    item.rut.ToString(),
                    item.nombre.ToString(),
                    item.descripcion.ToString(),
                    item.inicio.ToString(),
                    item.actualizacion.ToString(),
                    item.estadoIdEstado.ToString()
                };
                dtgEmpresa.Rows.Add(row);
            }
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
            List<Service_Categoria.categoria> listaCategoria = categoriaService.Listado_categorias().ToList();
            foreach (Service_Categoria.categoria item in listaCategoria)
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
                         
        private void btnLimpiarAgregar_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = "";
            txtApellidoPersona.Text = "";
            txtCorreoUsuario.Text = "";
            txtContrasenaUsuario.Text = "";
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
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrLogin lo = new FrLogin();
            lo.ShowDialog();
            this.Close();            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Service_Persona.PersonaServiceClient perso = new Service_Persona.PersonaServiceClient();
                perso.Crear_persona(0, txtNombrePersona.Text, txtApellidoPersona.Text, txtRutPersona.Text, cboSexo.SelectedIndex + 1);
                //perso.Listado_personas();
                Service_Persona.persona persona1 = perso.Listado_personas().OrderByDescending(x => x.idpersona).First();
                MessageBox.Show("Persona Creada Correctamente");

                Service_Usuario.UsuarioServiceClient usu = new Service_Usuario.UsuarioServiceClient();
                usu.CREAR_USUARIO(0, txtCorreoUsuario.Text, txtContrasenaUsuario.Text, int.Parse(txtTelefonoUsuario.Text), DateTime.Parse(dtFechaInicio.Value.ToShortDateString()), DateTime.Parse(dtFechaActualizacion.Value.ToShortDateString()), 1, int.Parse(persona1.idpersona.ToString()), cbbCargoUsuario.SelectedIndex + 1);

            }
            catch (Exception)
            {

                MessageBox.Show("Persona No se a Creado");
            }
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
                    btnBuscarProducto.Enabled = true;
                    txtIdProducto.Enabled = true;
                    break;
                }

            }
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
            txtIdProducto.Text = "";
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreProducto2.Enabled = true;
                txtDescripcion2.Enabled = true;
                txtPrecio2.Enabled = true;
                cboCategorias2.Enabled = true;
                
               // cboCategorias2.Enabled = true;
                btnCrearCategoria2.Enabled = true;
                btnModificarProducto.Enabled = false;
                btnCancelarModificar.Enabled = false;
                txtIdProducto.Enabled = true;

                DateTime date = DateTime.Now;
                int idtemp = int.Parse(txtIdProducto.Text.Trim());
                
                //productoService.Crear_producto(0, txtNombreProducto.Text.Trim(), txtDescripcion.Text, int.Parse(txtPrecio.Text), date, date, "-", cboCategorias.SelectedIndex + 1);
                productoService.Modificar_producto(idtemp, txtNombreProducto2.Text.Trim(), txtDescripcion2.Text, int.Parse(txtPrecio2.Text), FechaCreacion, date, "-", cboCategorias2.SelectedIndex + 1);
                txtIdProducto.Text = "";
                txtNombreProducto2.Text = "";
                txtDescripcion2.Text = "";
                txtPrecio2.Text = "";
                btnBuscarProducto.Enabled = true;
                MessageBox.Show("Se Modificó correctamente");
                cboCategorias2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
            initLisProductos();
        }        

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                txtTelefono.Enabled = true;
                txtContraseña.Enabled = true;
                txtCorreo.Enabled = true;
                btnBuscarUsuario.Enabled = true;

                DateTime date = DateTime.Now;
                usuarioService.Modificar_USUARIO(IdUsuariotemp, txtCorreo.Text.Trim(), txtContraseña.Text.Trim(), int.Parse(txtTelefono.Text.Trim()), FechaCreacionUsuario, date);
                txtCorreo.Text = "";
                txtContraseña.Text = "";
                txtTelefono.Text = "";
                btnBuscarUsuario.Enabled = true;
                MessageBox.Show("Se Modificó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
            initLisProductos();
        }       

        private void button3_Click_1(object sender, EventArgs e)
        {
            initLisUsuario();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            List<Service_Usuario.usuario> listadousu = usuarioService.Listado_usuarios().ToList();
            foreach (var item in listadousu)
            {

                if (item.correo.ToString() == txtCorreo.Text.Trim())
                {
                    IdUsuariotemp = int.Parse(item.idUsuario.ToString());
                    FechaCreacionUsuario = item.fechacreado;
                    txtCorreoUsuario.Text = item.correo.ToString();
                    txtContraseña.Text = item.contrasena.ToString();
                    txtTelefono.Text = item.telefono.ToString();

                    txtContraseña.Enabled = true;
                    txtTelefono.Enabled = true;
                    btnUEliminar.Enabled = true;
                    btnModificarUsuario.Enabled = true;
                    txtCorreo.Enabled = true;
                    btnBuscarUsuario.Enabled = true;
                    break;
                }
            }
        }

        private void btnListarEmpresa_Click(object sender, EventArgs e)
        {
            initLisEmpresa();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            initLisProductos();
        }

        

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            
        }             
        
        private void initcboIdEmpresa()
        {
            cboIdEmpresa.Items.Clear();
            List<Service_Empresa.empresa> listIdEmpresa = empresaService.Listado_empresa().ToList();
            foreach(Service_Empresa.empresa item in listIdEmpresa)
            {
                cboIdEmpresa.Items.Insert(int.Parse(item.idEmpresa.ToString()) - 1, item.nombre);
            }
            cboIdEmpresa.SelectedIndex = 0;              
            
        }

        private void initcboComuna()
        {
            cboComuna.Items.Clear();
            List<Service_Region.region> listRegion = regionService.Listado_regiones().ToList();
            foreach (Service_Region.region item in listRegion)
            {
                cboComuna.Items.Insert(int.Parse(item.idRegion.ToString()) -1,item.nombre);
            }
            cboComuna.SelectedIndex = 0;  

        }

        private void initcboIdEmpresaBuscar()
        {
            cboIdEmpresaBuscar.Items.Clear();
            List<Service_Empresa.empresa> listaIdEmpresa = empresaService.Listado_empresa().ToList();
            foreach (Service_Empresa.empresa item in listaIdEmpresa)
            {                
                cboIdEmpresaBuscar.Items.Insert(int.Parse(item.idEmpresa.ToString()) - 1, item.nombre);
            }
            cboIdEmpresaBuscar.SelectedIndex = 0;

        }

        private void initcboComunaBuscar()
        {
            cboComunaLocalBuscar.Items.Clear();
            List<Service_Region.region> listaRegion = regionService.Listado_regiones().ToList();
            foreach (Service_Region.region item in listaRegion)
            {
                cboComunaLocalBuscar.Items.Insert(int.Parse(item.idRegion.ToString()) - 1, item.nombre);
            }
            cboComunaLocalBuscar.SelectedIndex = 0;

        }

        private void btnGuardarLocal_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now;
                localService.Crear_local(0, txtDireccionLocal.Text.Trim(), txtNombreLocal.Text.Trim(), cboIdEmpresa.SelectedIndex +1, cboComuna.SelectedIndex +1);
                MessageBox.Show("Se Creo el Local Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
            txtDireccionLocal.Text = "";
            txtNombreLocal.Text = "";
            cboIdEmpresa.SelectedIndex = 0;
            cboComuna.SelectedIndex = 0;
            initLisLocal();
            
        }

        private void btnMostrarLocales_Click(object sender, EventArgs e)
        {
            initLisLocal();
        }

        private void btnBuscarLocal_Click(object sender, EventArgs e)
        {
            List<Service_Local.local> ListaLocal = localService.Listado_local().ToList();
            foreach(var item in ListaLocal)
            {
                if(item.idLocal.ToString() == txtIdLocalBuscar.Text.Trim())
                {
                    txtDireccionLocalBuscar.Text = item.direccion;
                    txtNombreLocalBuscar.Text = item.nombre;                    
                    cboIdEmpresaBuscar.SelectedIndex = int.Parse(item.empresaIdEmpresa.idEmpresa.ToString())-1;
                    cboComunaLocalBuscar.SelectedIndex = int.Parse(item.ciudadIdCiudad.idCiudad.ToString())-1;

                    txtDireccionLocalBuscar.Enabled = true;
                    txtNombreLocalBuscar.Enabled = true;
                    cboIdEmpresaBuscar.Enabled = true;
                    cboComunaLocalBuscar.Enabled = true;
                    btnActualizarLocal.Enabled = true;
                    btnBuscarLocal.Enabled = true;
                    txtIdLocalBuscar.Enabled = true;       
                    break;

                }
            }
            return;
        }

        //______________________________--------------
        private void btnActualizarLocal_Click(object sender, EventArgs e)
        {
            try
            {
                txtDireccionLocalBuscar.Enabled = true;
                txtNombreLocalBuscar.Enabled = true;
                cboIdEmpresaBuscar.Enabled = true;
                cboComunaLocalBuscar.Enabled = true;
                txtIdLocalBuscar.Enabled = true;
                btnBuscarLocal.Enabled = true;

                int idloc = int.Parse(txtIdLocalBuscar.Text.Trim());
                cboIdEmpresaBuscar.SelectedIndex = 0;
                cboComunaLocalBuscar.SelectedIndex = 0;
                localService.Modificar_local(idloc, txtDireccionLocalBuscar.Text.Trim(), txtNombreLocalBuscar.Text, cboIdEmpresaBuscar.SelectedIndex + 1, cboComunaLocalBuscar.SelectedIndex + 1);
                txtIdLocalBuscar.Text = "";
                txtDireccionLocalBuscar.Text = "";
                txtNombreLocalBuscar.Text = "";
                cboIdEmpresaBuscar.Text = "";
                cboComunaLocalBuscar.Text = "";
                btnActualizarLocal.Enabled = true;
                MessageBox.Show("Se Modifico Correctamente");
                cboIdEmpresaBuscar.Enabled = true;
                cboComunaLocalBuscar.Enabled = true;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ->" + ex.Message);
            }
            initLisLocal();
                
        }

        private void btnEliminarLocal_Click(object sender, EventArgs e)
        {
            try
            {
                localService.Eliminar_local(int.Parse(txtIdLocalBuscar.Text));
                MessageBox.Show("Local se Elimino Correctamente");
                txtIdLocalBuscar.Text = "";
                txtDireccionLocalBuscar.Text = "";
                txtNombreLocalBuscar.Text = "";
                cboIdEmpresaBuscar.Text = "";
                cboComunaLocalBuscar.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
            return;
        }

        private void btnLimpiarALocal_Click(object sender, EventArgs e)
        {
            txtNombreLocal.Text = "";
            txtDireccionLocal.Text = "";
            cboIdEmpresa.Text = "";
            cboComuna.Text = "";
        }

        private void btnUEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioService.Eliminar_usuario(int.Parse(txtIdUsuarioEliminar.Text));
                MessageBox.Show("Usuario se Elimino Correctamente");
                txtCUEliminar.Text = "";
                txtTUEliminar.Text = "";
                txtIdUsuarioEliminar.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }            
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Service_Usuario.usuario> listausu = usuarioService.Listado_usuarios().ToList();
            foreach (var item in listausu)
            {

                if (item.idUsuario.ToString() == txtIdUsuarioEliminar.Text.Trim())
                {

                    IdUsuariotemp = int.Parse(item.idUsuario.ToString());
                    FechaCreacionUsuario = item.fechacreado;
                    txtIdUsuarioEliminar.Text = item.idUsuario.ToString();
                    txtCUEliminar.Text = item.contrasena.ToString();
                    txtTUEliminar.Text = item.telefono.ToString();


                    txtCUEliminar.Enabled = true;
                    txtTUEliminar.Enabled = true;
                    btnUEliminar.Enabled = true;                      
                    btnBuscarEliminar.Enabled = true;
                    txtIdUsuarioEliminar.Enabled = true;
                    break;
                }
            }
        }
            
        private void btnListarEmpresa_Click_1(object sender, EventArgs e)
        {
            initLisEmpresa();
        }

        private void btnIngresarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                Service_Empresa.EmpresaServiceClient empre1 = new Service_Empresa.EmpresaServiceClient();
                empre1.Crear_empresa( txtRutEmpresa.Text, txtNombreEmpresa.Text, txtDescipcionEmpresa.Text, 1);

                Service_Empresa.empresa empre11 = empre1.Listado_empresa().OrderByDescending(x => x.idEmpresa).First();
                MessageBox.Show("Empresa Creada Correctamente");

                //Service_Empresa.EmpresaServiceClient emp = new Service_Empresa.EmpresaServiceClient();
                //emp.Crear_empresa(0, txtRutEmpresa.Text, txtNombreEmpresa.Text, txtDescripcionEmpresa.Text, DateTime.Parse(dtFechaInicioEmpresa.Value.ToShortDateString()), DateTime.Parse(dtFechaActualizacionEmpresa.Value.ToShortDateString()), 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Empresa No se a Creado");
            }
        }

        private void btnLimpiarEmpresa_Click(object sender, EventArgs e)
        {
            txtRutEmpresa.Text = "";
            txtNombreEmpresa.Text = "";
            txtDescipcionEmpresa.Text = "";
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                txtRutEM.Enabled = false;                
                txtNombreEM.Enabled = true;
                txtDescripcionEM.Enabled = true;

                //Actualizar empresa

                DateTime date = DateTime.Now;
                //int idempre = int.Parse(txtIdEmpresa.Text.Trim());

                string nomEmpre = txtNombreEM.Text;
                string desEmpre = txtDescripcionEM.Text;
                int idempre = int.Parse(txtIdEmpresaModificar.Text.Trim());
                    
                //empresaService.Modificar_empresa(0, txtRutEmpresa.Text, txtNombreEmpresa.Text, txtDescripcionEmpresa.Text,new DateTime(), new DateTime(), 0);
                empresaService.Modificar_empresa(idempre, txtRutEM.Text, txtNombreEM.Text, txtDescripcionEM.Text, 1);
                txtIdEmpresaModificar.Enabled = true;
                txtNombreEM.Text = "";
                txtDescripcionEM.Text = "";
                btnModificarEmpre.Enabled = true;

                MessageBox.Show("Se Modifico Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }
            initLisEmpresa();
        }

       /* private void btnEliminarEmpre_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdEmpresaModificar.Enabled = true;

                int empresa = int.Parse(txtIdEmpresaModificar.Text.Trim());
                empresaService.Modificar_empresa(empresa, txx)

            }*/

        private void btnBuscarEmpre_Click(object sender, EventArgs e)
        {
            List<Service_Empresa.empresa> empresa = empresaService.Listado_empresa().ToList();
            foreach (var item in empresa)
            {
                if (item.idEmpresa.ToString() == txtIdEmpresaModificar.Text.Trim())
                {
                    txtRutEM.Text = item.rut;
                    txtNombreEM.Text = item.nombre;
                    txtDescripcionEM.Text = item.descripcion;
                    txtRutEmpresa.Text = item.rut;
                    FechaInicioEmpresa = item.inicio;

                    //actualizacion Empresa
                    txtNombreEM.Enabled = true;
                    txtDescripcionEM.Enabled = true;
                    btnEliminarEmpre.Enabled = true;
                    btnModificarEmpre.Enabled = true;
                    txtIdEmpresaModificar.Enabled = true;
                    break;

                }
            }
        }
    }
}
    

