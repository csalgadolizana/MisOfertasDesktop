﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desk.Service_Region {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Servicios/", ConfigurationName="Service_Region.RegionService")]
    public interface RegionService {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/RegionService/Listado_regionesRequest", ReplyAction="http://Servicios/RegionService/Listado_regionesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Desk.Service_Region.Listado_regionesResponse Listado_regiones(Desk.Service_Region.Listado_regionesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/RegionService/Listado_regionesRequest", ReplyAction="http://Servicios/RegionService/Listado_regionesResponse")]
        System.Threading.Tasks.Task<Desk.Service_Region.Listado_regionesResponse> Listado_regionesAsync(Desk.Service_Region.Listado_regionesRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2117.0")]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_regiones", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_regionesRequest {
        
        public Listado_regionesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listado_regionesResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class Listado_regionesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Desk.Service_Region.region[] @return;
        
        public Listado_regionesResponse() {
        }
        
        public Listado_regionesResponse(Desk.Service_Region.region[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RegionServiceChannel : Desk.Service_Region.RegionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegionServiceClient : System.ServiceModel.ClientBase<Desk.Service_Region.RegionService>, Desk.Service_Region.RegionService {
        
        public RegionServiceClient() {
        }
        
        public RegionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desk.Service_Region.Listado_regionesResponse Desk.Service_Region.RegionService.Listado_regiones(Desk.Service_Region.Listado_regionesRequest request) {
            return base.Channel.Listado_regiones(request);
        }
        
        public Desk.Service_Region.region[] Listado_regiones() {
            Desk.Service_Region.Listado_regionesRequest inValue = new Desk.Service_Region.Listado_regionesRequest();
            Desk.Service_Region.Listado_regionesResponse retVal = ((Desk.Service_Region.RegionService)(this)).Listado_regiones(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desk.Service_Region.Listado_regionesResponse> Desk.Service_Region.RegionService.Listado_regionesAsync(Desk.Service_Region.Listado_regionesRequest request) {
            return base.Channel.Listado_regionesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desk.Service_Region.Listado_regionesResponse> Listado_regionesAsync() {
            Desk.Service_Region.Listado_regionesRequest inValue = new Desk.Service_Region.Listado_regionesRequest();
            return ((Desk.Service_Region.RegionService)(this)).Listado_regionesAsync(inValue);
        }
    }
}
