﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desk.Service_Empresa {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Servicios/", ConfigurationName="Service_Empresa.EmpresaService")]
    public interface EmpresaService {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Eliminar_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Eliminar_empresaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Empresa.Eliminar_empresaResponse Eliminar_empresa(Desk.Service_Empresa.Eliminar_empresaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Eliminar_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Eliminar_empresaResponse")]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Eliminar_empresaResponse> Eliminar_empresaAsync(Desk.Service_Empresa.Eliminar_empresaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Modificar_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Modificar_empresaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Empresa.Modificar_empresaResponse Modificar_empresa(Desk.Service_Empresa.Modificar_empresaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Modificar_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Modificar_empresaResponse")]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Modificar_empresaResponse> Modificar_empresaAsync(Desk.Service_Empresa.Modificar_empresaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Listado_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Listado_empresaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Empresa.Listado_empresaResponse Listado_empresa(Desk.Service_Empresa.Listado_empresaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Listado_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Listado_empresaResponse")]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Listado_empresaResponse> Listado_empresaAsync(Desk.Service_Empresa.Listado_empresaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Crear_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Crear_empresaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Empresa.Crear_empresaResponse Crear_empresa(Desk.Service_Empresa.Crear_empresaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/EmpresaService/Crear_empresaRequest", ReplyAction="http://Servicios/EmpresaService/Crear_empresaResponse")]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Crear_empresaResponse> Crear_empresaAsync(Desk.Service_Empresa.Crear_empresaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Eliminar_empresa", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Eliminar_empresaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public Eliminar_empresaRequest() {
        }
        
        public Eliminar_empresaRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Eliminar_empresaResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Eliminar_empresaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public Eliminar_empresaResponse() {
        }
        
        public Eliminar_empresaResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Modificar_empresa", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Modificar_empresaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idd;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rut;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_estado;
        
        public Modificar_empresaRequest() {
        }
        
        public Modificar_empresaRequest(int idd, string rut, string nombre, string descripcion, int id_estado) {
            this.idd = idd;
            this.rut = rut;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.id_estado = id_estado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Modificar_empresaResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Modificar_empresaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public Modificar_empresaResponse() {
        }
        
        public Modificar_empresaResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2117.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class empresa : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime actualizacionField;
        
        private bool actualizacionFieldSpecified;
        
        private string descripcionField;
        
        private estado estadoIdEstadoField;
        
        private decimal idEmpresaField;
        
        private bool idEmpresaFieldSpecified;
        
        private System.DateTime inicioField;
        
        private bool inicioFieldSpecified;
        
        private string nombreField;
        
        private string rutField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public estado estadoIdEstado {
            get {
                return this.estadoIdEstadoField;
            }
            set {
                this.estadoIdEstadoField = value;
                this.RaisePropertyChanged("estadoIdEstado");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal idEmpresa {
            get {
                return this.idEmpresaField;
            }
            set {
                this.idEmpresaField = value;
                this.RaisePropertyChanged("idEmpresa");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idEmpresaSpecified {
            get {
                return this.idEmpresaFieldSpecified;
            }
            set {
                this.idEmpresaFieldSpecified = value;
                this.RaisePropertyChanged("idEmpresaSpecified");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string rut {
            get {
                return this.rutField;
            }
            set {
                this.rutField = value;
                this.RaisePropertyChanged("rut");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2117.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class estado : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private decimal idEstadoField;
        
        private bool idEstadoFieldSpecified;
        
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
        public decimal idEstado {
            get {
                return this.idEstadoField;
            }
            set {
                this.idEstadoField = value;
                this.RaisePropertyChanged("idEstado");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idEstadoSpecified {
            get {
                return this.idEstadoFieldSpecified;
            }
            set {
                this.idEstadoFieldSpecified = value;
                this.RaisePropertyChanged("idEstadoSpecified");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_empresa", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_empresaRequest {
        
        public Listado_empresaRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_empresaResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_empresaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Desk.Service_Empresa.empresa[] @return;
        
        public Listado_empresaResponse() {
        }
        
        public Listado_empresaResponse(Desk.Service_Empresa.empresa[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Crear_empresa", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Crear_empresaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rut;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_estado;
        
        public Crear_empresaRequest() {
        }
        
        public Crear_empresaRequest(string rut, string nombre, string descripcion, int id_estado) {
            this.rut = rut;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.id_estado = id_estado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Crear_empresaResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Crear_empresaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public Crear_empresaResponse() {
        }
        
        public Crear_empresaResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EmpresaServiceChannel : Desk.Service_Empresa.EmpresaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpresaServiceClient : System.ServiceModel.ClientBase<Desk.Service_Empresa.EmpresaService>, Desk.Service_Empresa.EmpresaService {
        
        public EmpresaServiceClient() {
        }
        
        public EmpresaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpresaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpresaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpresaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Empresa.Eliminar_empresaResponse Desk.Service_Empresa.EmpresaService.Eliminar_empresa(Desk.Service_Empresa.Eliminar_empresaRequest request) {
            return base.Channel.Eliminar_empresa(request);
        }
        
        public string Eliminar_empresa(int id) {
            Desk.Service_Empresa.Eliminar_empresaRequest inValue = new Desk.Service_Empresa.Eliminar_empresaRequest();
            inValue.id = id;
            Desk.Service_Empresa.Eliminar_empresaResponse retVal = ((Desk.Service_Empresa.EmpresaService)(this)).Eliminar_empresa(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Eliminar_empresaResponse> Desk.Service_Empresa.EmpresaService.Eliminar_empresaAsync(Desk.Service_Empresa.Eliminar_empresaRequest request) {
            return base.Channel.Eliminar_empresaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Empresa.Eliminar_empresaResponse> Eliminar_empresaAsync(int id) {
            Desk.Service_Empresa.Eliminar_empresaRequest inValue = new Desk.Service_Empresa.Eliminar_empresaRequest();
            inValue.id = id;
            return ((Desk.Service_Empresa.EmpresaService)(this)).Eliminar_empresaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Empresa.Modificar_empresaResponse Desk.Service_Empresa.EmpresaService.Modificar_empresa(Desk.Service_Empresa.Modificar_empresaRequest request) {
            return base.Channel.Modificar_empresa(request);
        }
        
        public string Modificar_empresa(int idd, string rut, string nombre, string descripcion, int id_estado) {
            Desk.Service_Empresa.Modificar_empresaRequest inValue = new Desk.Service_Empresa.Modificar_empresaRequest();
            inValue.idd = idd;
            inValue.rut = rut;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.id_estado = id_estado;
            Desk.Service_Empresa.Modificar_empresaResponse retVal = ((Desk.Service_Empresa.EmpresaService)(this)).Modificar_empresa(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Modificar_empresaResponse> Desk.Service_Empresa.EmpresaService.Modificar_empresaAsync(Desk.Service_Empresa.Modificar_empresaRequest request) {
            return base.Channel.Modificar_empresaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Empresa.Modificar_empresaResponse> Modificar_empresaAsync(int idd, string rut, string nombre, string descripcion, int id_estado) {
            Desk.Service_Empresa.Modificar_empresaRequest inValue = new Desk.Service_Empresa.Modificar_empresaRequest();
            inValue.idd = idd;
            inValue.rut = rut;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.id_estado = id_estado;
            return ((Desk.Service_Empresa.EmpresaService)(this)).Modificar_empresaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Empresa.Listado_empresaResponse Desk.Service_Empresa.EmpresaService.Listado_empresa(Desk.Service_Empresa.Listado_empresaRequest request) {
            return base.Channel.Listado_empresa(request);
        }
        
        public Desk.Service_Empresa.empresa[] Listado_empresa() {
            Desk.Service_Empresa.Listado_empresaRequest inValue = new Desk.Service_Empresa.Listado_empresaRequest();
            Desk.Service_Empresa.Listado_empresaResponse retVal = ((Desk.Service_Empresa.EmpresaService)(this)).Listado_empresa(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Listado_empresaResponse> Desk.Service_Empresa.EmpresaService.Listado_empresaAsync(Desk.Service_Empresa.Listado_empresaRequest request) {
            return base.Channel.Listado_empresaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Empresa.Listado_empresaResponse> Listado_empresaAsync() {
            Desk.Service_Empresa.Listado_empresaRequest inValue = new Desk.Service_Empresa.Listado_empresaRequest();
            return ((Desk.Service_Empresa.EmpresaService)(this)).Listado_empresaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Empresa.Crear_empresaResponse Desk.Service_Empresa.EmpresaService.Crear_empresa(Desk.Service_Empresa.Crear_empresaRequest request) {
            return base.Channel.Crear_empresa(request);
        }
        
        public string Crear_empresa(string rut, string nombre, string descripcion, int id_estado) {
            Desk.Service_Empresa.Crear_empresaRequest inValue = new Desk.Service_Empresa.Crear_empresaRequest();
            inValue.rut = rut;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.id_estado = id_estado;
            Desk.Service_Empresa.Crear_empresaResponse retVal = ((Desk.Service_Empresa.EmpresaService)(this)).Crear_empresa(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Empresa.Crear_empresaResponse> Desk.Service_Empresa.EmpresaService.Crear_empresaAsync(Desk.Service_Empresa.Crear_empresaRequest request) {
            return base.Channel.Crear_empresaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Empresa.Crear_empresaResponse> Crear_empresaAsync(string rut, string nombre, string descripcion, int id_estado) {
            Desk.Service_Empresa.Crear_empresaRequest inValue = new Desk.Service_Empresa.Crear_empresaRequest();
            inValue.rut = rut;
            inValue.nombre = nombre;
            inValue.descripcion = descripcion;
            inValue.id_estado = id_estado;
            return ((Desk.Service_Empresa.EmpresaService)(this)).Crear_empresaAsync(inValue);
        }
    }
}
