﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desk.Service_Ciudad {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Servicios/", ConfigurationName="Service_Ciudad.CiudadService")]
    public interface CiudadService {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/CiudadService/Listado_ciudadesRequest", ReplyAction="http://Servicios/CiudadService/Listado_ciudadesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Ciudad.Listado_ciudadesResponse Listado_ciudades(Desk.Service_Ciudad.Listado_ciudadesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/CiudadService/Listado_ciudadesRequest", ReplyAction="http://Servicios/CiudadService/Listado_ciudadesResponse")]
        System.Threading.Tasks.Task<Desk.Service_Ciudad.Listado_ciudadesResponse> Listado_ciudadesAsync(Desk.Service_Ciudad.Listado_ciudadesRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class ciudad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private decimal idCiudadField;
        
        private bool idCiudadFieldSpecified;
        
        private string nombreField;
        
        private region regionIdRegionField;
        
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
        public decimal idCiudad {
            get {
                return this.idCiudadField;
            }
            set {
                this.idCiudadField = value;
                this.RaisePropertyChanged("idCiudad");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idCiudadSpecified {
            get {
                return this.idCiudadFieldSpecified;
            }
            set {
                this.idCiudadFieldSpecified = value;
                this.RaisePropertyChanged("idCiudadSpecified");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public region regionIdRegion {
            get {
                return this.regionIdRegionField;
            }
            set {
                this.regionIdRegionField = value;
                this.RaisePropertyChanged("regionIdRegion");
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
    public partial class region : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idRegionField;
        
        private bool idRegionFieldSpecified;
        
        private string nombreField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long idRegion {
            get {
                return this.idRegionField;
            }
            set {
                this.idRegionField = value;
                this.RaisePropertyChanged("idRegion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idRegionSpecified {
            get {
                return this.idRegionFieldSpecified;
            }
            set {
                this.idRegionFieldSpecified = value;
                this.RaisePropertyChanged("idRegionSpecified");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_ciudades", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_ciudadesRequest {
        
        public Listado_ciudadesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_ciudadesResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_ciudadesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Desk.Service_Ciudad.ciudad[] @return;
        
        public Listado_ciudadesResponse() {
        }
        
        public Listado_ciudadesResponse(Desk.Service_Ciudad.ciudad[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CiudadServiceChannel : Desk.Service_Ciudad.CiudadService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CiudadServiceClient : System.ServiceModel.ClientBase<Desk.Service_Ciudad.CiudadService>, Desk.Service_Ciudad.CiudadService {
        
        public CiudadServiceClient() {
        }
        
        public CiudadServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CiudadServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CiudadServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CiudadServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Ciudad.Listado_ciudadesResponse Desk.Service_Ciudad.CiudadService.Listado_ciudades(Desk.Service_Ciudad.Listado_ciudadesRequest request) {
            return base.Channel.Listado_ciudades(request);
        }
        
        public Desk.Service_Ciudad.ciudad[] Listado_ciudades() {
            Desk.Service_Ciudad.Listado_ciudadesRequest inValue = new Desk.Service_Ciudad.Listado_ciudadesRequest();
            Desk.Service_Ciudad.Listado_ciudadesResponse retVal = ((Desk.Service_Ciudad.CiudadService)(this)).Listado_ciudades(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Ciudad.Listado_ciudadesResponse> Desk.Service_Ciudad.CiudadService.Listado_ciudadesAsync(Desk.Service_Ciudad.Listado_ciudadesRequest request) {
            return base.Channel.Listado_ciudadesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Ciudad.Listado_ciudadesResponse> Listado_ciudadesAsync() {
            Desk.Service_Ciudad.Listado_ciudadesRequest inValue = new Desk.Service_Ciudad.Listado_ciudadesRequest();
            return ((Desk.Service_Ciudad.CiudadService)(this)).Listado_ciudadesAsync(inValue);
        }
    }
}