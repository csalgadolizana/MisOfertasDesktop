﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desk.Service_Producto {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Servicios/", ConfigurationName="Service_Producto.ProductoService")]
    public interface ProductoService {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Modificar_productoRequest", ReplyAction="http://Servicios/ProductoService/Modificar_productoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Producto.Modificar_productoResponse Modificar_producto(Desk.Service_Producto.Modificar_productoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Modificar_productoRequest", ReplyAction="http://Servicios/ProductoService/Modificar_productoResponse")]
        System.Threading.Tasks.Task<Desk.Service_Producto.Modificar_productoResponse> Modificar_productoAsync(Desk.Service_Producto.Modificar_productoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Eliminar_productoRequest", ReplyAction="http://Servicios/ProductoService/Eliminar_productoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Producto.Eliminar_productoResponse Eliminar_producto(Desk.Service_Producto.Eliminar_productoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Eliminar_productoRequest", ReplyAction="http://Servicios/ProductoService/Eliminar_productoResponse")]
        System.Threading.Tasks.Task<Desk.Service_Producto.Eliminar_productoResponse> Eliminar_productoAsync(Desk.Service_Producto.Eliminar_productoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Listado_productosRequest", ReplyAction="http://Servicios/ProductoService/Listado_productosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Producto.Listado_productosResponse Listado_productos(Desk.Service_Producto.Listado_productosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Listado_productosRequest", ReplyAction="http://Servicios/ProductoService/Listado_productosResponse")]
        System.Threading.Tasks.Task<Desk.Service_Producto.Listado_productosResponse> Listado_productosAsync(Desk.Service_Producto.Listado_productosRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Crear_productoRequest", ReplyAction="http://Servicios/ProductoService/Crear_productoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Producto.Crear_productoResponse Crear_producto(Desk.Service_Producto.Crear_productoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/ProductoService/Crear_productoRequest", ReplyAction="http://Servicios/ProductoService/Crear_productoResponse")]
        System.Threading.Tasks.Task<Desk.Service_Producto.Crear_productoResponse> Crear_productoAsync(Desk.Service_Producto.Crear_productoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Modificar_producto", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Modificar_productoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int precio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fecha_inicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fecha_actualizacion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ruta_imagen;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_cagegoria;
        
        public Modificar_productoRequest() {
        }
        
        public Modificar_productoRequest(int id, string nombre, string descripcion, int precio, System.DateTime fecha_inicio, System.DateTime fecha_actualizacion, string ruta_imagen, int id_cagegoria) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fecha_inicio = fecha_inicio;
            this.fecha_actualizacion = fecha_actualizacion;
            this.ruta_imagen = ruta_imagen;
            this.id_cagegoria = id_cagegoria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Modificar_productoResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Modificar_productoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public Modificar_productoResponse() {
        }
        
        public Modificar_productoResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Eliminar_producto", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Eliminar_productoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public Eliminar_productoRequest() {
        }
        
        public Eliminar_productoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Eliminar_productoResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Eliminar_productoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public Eliminar_productoResponse() {
        }
        
        public Eliminar_productoResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class producto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime actualizacionField;
        
        private bool actualizacionFieldSpecified;
        
        private categoria categoriaIdCategoriaField;
        
        private string descripcionField;
        
        private decimal idProductoField;
        
        private bool idProductoFieldSpecified;
        
        private string imagenField;
        
        private System.DateTime inicioField;
        
        private bool inicioFieldSpecified;
        
        private string nombreField;
        
        private string precioField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime actualizacion {
            get {
                return this.actualizacionField;
            }
            set {
                this.actualizacionField = value;
                this.RaisePropertyChanged("actualizacion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualizacionSpecified {
            get {
                return this.actualizacionFieldSpecified;
            }
            set {
                this.actualizacionFieldSpecified = value;
                this.RaisePropertyChanged("actualizacionSpecified");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public categoria categoriaIdCategoria {
            get {
                return this.categoriaIdCategoriaField;
            }
            set {
                this.categoriaIdCategoriaField = value;
                this.RaisePropertyChanged("categoriaIdCategoria");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal idProducto {
            get {
                return this.idProductoField;
            }
            set {
                this.idProductoField = value;
                this.RaisePropertyChanged("idProducto");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idProductoSpecified {
            get {
                return this.idProductoFieldSpecified;
            }
            set {
                this.idProductoFieldSpecified = value;
                this.RaisePropertyChanged("idProductoSpecified");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string imagen {
            get {
                return this.imagenField;
            }
            set {
                this.imagenField = value;
                this.RaisePropertyChanged("imagen");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime inicio {
            get {
                return this.inicioField;
            }
            set {
                this.inicioField = value;
                this.RaisePropertyChanged("inicio");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inicioSpecified {
            get {
                return this.inicioFieldSpecified;
            }
            set {
                this.inicioFieldSpecified = value;
                this.RaisePropertyChanged("inicioSpecified");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer", Order=7)]
        public string precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
                this.RaisePropertyChanged("precio");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class categoria : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private decimal idCategoriaField;
        
        private bool idCategoriaFieldSpecified;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal idCategoria {
            get {
                return this.idCategoriaField;
            }
            set {
                this.idCategoriaField = value;
                this.RaisePropertyChanged("idCategoria");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idCategoriaSpecified {
            get {
                return this.idCategoriaFieldSpecified;
            }
            set {
                this.idCategoriaFieldSpecified = value;
                this.RaisePropertyChanged("idCategoriaSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_productos", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_productosRequest {
        
        public Listado_productosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_productosResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_productosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Desk.Service_Producto.producto[] @return;
        
        public Listado_productosResponse() {
        }
        
        public Listado_productosResponse(Desk.Service_Producto.producto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Crear_producto", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Crear_productoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int precio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fecha_inicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fecha_actualizacion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ruta_imagen;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_cagegoria;
        
        public Crear_productoRequest() {
        }
        
        public Crear_productoRequest(int id, string nombre, string descripcion, int precio, System.DateTime fecha_inicio, System.DateTime fecha_actualizacion, string ruta_imagen, int id_cagegoria) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fecha_inicio = fecha_inicio;
            this.fecha_actualizacion = fecha_actualizacion;
            this.ruta_imagen = ruta_imagen;
            this.id_cagegoria = id_cagegoria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Crear_productoResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Crear_productoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public Crear_productoResponse() {
        }
        
        public Crear_productoResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductoServiceChannel : Desk.Service_Producto.ProductoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductoServiceClient : System.ServiceModel.ClientBase<Desk.Service_Producto.ProductoService>, Desk.Service_Producto.ProductoService {
        
        public ProductoServiceClient() {
        }
        
        public ProductoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Producto.Modificar_productoResponse Desk.Service_Producto.ProductoService.Modificar_producto(Desk.Service_Producto.Modificar_productoRequest request) {
            return base.Channel.Modificar_producto(request);
        }
        
        public string Modificar_producto(int id, string nombre, string descripcion, int precio, System.DateTime fecha_inicio, System.DateTime fecha_actualizacion, string ruta_imagen, int id_cagegoria) {
            Desk.Service_Producto.Modificar_productoRequest inValue = new Desk.Service_Producto.Modificar_productoRequest();
            inValue.id = id;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.precio = precio;
            inValue.fecha_inicio = fecha_inicio;
            inValue.fecha_actualizacion = fecha_actualizacion;
            inValue.ruta_imagen = ruta_imagen;
            inValue.id_cagegoria = id_cagegoria;
            Desk.Service_Producto.Modificar_productoResponse retVal = ((Desk.Service_Producto.ProductoService)(this)).Modificar_producto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Producto.Modificar_productoResponse> Desk.Service_Producto.ProductoService.Modificar_productoAsync(Desk.Service_Producto.Modificar_productoRequest request) {
            return base.Channel.Modificar_productoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Producto.Modificar_productoResponse> Modificar_productoAsync(int id, string nombre, string descripcion, int precio, System.DateTime fecha_inicio, System.DateTime fecha_actualizacion, string ruta_imagen, int id_cagegoria) {
            Desk.Service_Producto.Modificar_productoRequest inValue = new Desk.Service_Producto.Modificar_productoRequest();
            inValue.id = id;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.precio = precio;
            inValue.fecha_inicio = fecha_inicio;
            inValue.fecha_actualizacion = fecha_actualizacion;
            inValue.ruta_imagen = ruta_imagen;
            inValue.id_cagegoria = id_cagegoria;
            return ((Desk.Service_Producto.ProductoService)(this)).Modificar_productoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Producto.Eliminar_productoResponse Desk.Service_Producto.ProductoService.Eliminar_producto(Desk.Service_Producto.Eliminar_productoRequest request) {
            return base.Channel.Eliminar_producto(request);
        }
        
        public string Eliminar_producto(int id) {
            Desk.Service_Producto.Eliminar_productoRequest inValue = new Desk.Service_Producto.Eliminar_productoRequest();
            inValue.id = id;
            Desk.Service_Producto.Eliminar_productoResponse retVal = ((Desk.Service_Producto.ProductoService)(this)).Eliminar_producto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Producto.Eliminar_productoResponse> Desk.Service_Producto.ProductoService.Eliminar_productoAsync(Desk.Service_Producto.Eliminar_productoRequest request) {
            return base.Channel.Eliminar_productoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Producto.Eliminar_productoResponse> Eliminar_productoAsync(int id) {
            Desk.Service_Producto.Eliminar_productoRequest inValue = new Desk.Service_Producto.Eliminar_productoRequest();
            inValue.id = id;
            return ((Desk.Service_Producto.ProductoService)(this)).Eliminar_productoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Producto.Listado_productosResponse Desk.Service_Producto.ProductoService.Listado_productos(Desk.Service_Producto.Listado_productosRequest request) {
            return base.Channel.Listado_productos(request);
        }
        
        public Desk.Service_Producto.producto[] Listado_productos() {
            Desk.Service_Producto.Listado_productosRequest inValue = new Desk.Service_Producto.Listado_productosRequest();
            Desk.Service_Producto.Listado_productosResponse retVal = ((Desk.Service_Producto.ProductoService)(this)).Listado_productos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Producto.Listado_productosResponse> Desk.Service_Producto.ProductoService.Listado_productosAsync(Desk.Service_Producto.Listado_productosRequest request) {
            return base.Channel.Listado_productosAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Producto.Listado_productosResponse> Listado_productosAsync() {
            Desk.Service_Producto.Listado_productosRequest inValue = new Desk.Service_Producto.Listado_productosRequest();
            return ((Desk.Service_Producto.ProductoService)(this)).Listado_productosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Producto.Crear_productoResponse Desk.Service_Producto.ProductoService.Crear_producto(Desk.Service_Producto.Crear_productoRequest request) {
            return base.Channel.Crear_producto(request);
        }
        
        public string Crear_producto(int id, string nombre, string descripcion, int precio, System.DateTime fecha_inicio, System.DateTime fecha_actualizacion, string ruta_imagen, int id_cagegoria) {
            Desk.Service_Producto.Crear_productoRequest inValue = new Desk.Service_Producto.Crear_productoRequest();
            inValue.id = id;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.precio = precio;
            inValue.fecha_inicio = fecha_inicio;
            inValue.fecha_actualizacion = fecha_actualizacion;
            inValue.ruta_imagen = ruta_imagen;
            inValue.id_cagegoria = id_cagegoria;
            Desk.Service_Producto.Crear_productoResponse retVal = ((Desk.Service_Producto.ProductoService)(this)).Crear_producto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Producto.Crear_productoResponse> Desk.Service_Producto.ProductoService.Crear_productoAsync(Desk.Service_Producto.Crear_productoRequest request) {
            return base.Channel.Crear_productoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Producto.Crear_productoResponse> Crear_productoAsync(int id, string nombre, string descripcion, int precio, System.DateTime fecha_inicio, System.DateTime fecha_actualizacion, string ruta_imagen, int id_cagegoria) {
            Desk.Service_Producto.Crear_productoRequest inValue = new Desk.Service_Producto.Crear_productoRequest();
            inValue.id = id;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.precio = precio;
            inValue.fecha_inicio = fecha_inicio;
            inValue.fecha_actualizacion = fecha_actualizacion;
            inValue.ruta_imagen = ruta_imagen;
            inValue.id_cagegoria = id_cagegoria;
            return ((Desk.Service_Producto.ProductoService)(this)).Crear_productoAsync(inValue);
        }
    }
}
