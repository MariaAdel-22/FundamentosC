﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReferenceCatrasto
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Name="Callejero de la sede electrónica del catastro.Soap", Namespace="http://tempuri.org/OVCServWeb/OVCCallejero", ConfigurationName="ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap")]
    public interface CallejerodelasedeelectrónicadelcatastroSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPRC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPRCResponse> Consulta_DNPRCAsync(ReferenceCatrasto.Consulta_DNPRCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaProvincia", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaProvincia1> ObtenerProvinciasAsync(ReferenceCatrasto.ConsultaProvincia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaMunicipio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaMunicipio1> ObtenerMunicipiosAsync(ReferenceCatrasto.ConsultaMunicipio request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaVia", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaVia1> ObtenerCallejeroAsync(ReferenceCatrasto.ConsultaVia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaNumero", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaNumero1> ObtenerNumereroAsync(ReferenceCatrasto.ConsultaNumero request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPLOC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPLOCResponse> Consulta_DNPLOCAsync(ReferenceCatrasto.Consulta_DNPLOCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPPP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPPPResponse> Consulta_DNPPPAsync(ReferenceCatrasto.Consulta_DNPPPRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPRCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string RefCat;
        
        public Consulta_DNPRCRequest()
        {
        }
        
        public Consulta_DNPRCRequest(string Provincia, string Municipio, string RefCat)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.RefCat = RefCat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPRCResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Consulta_DNP;
        
        public Consulta_DNPRCResponse()
        {
        }
        
        public Consulta_DNPRCResponse(System.Xml.XmlNode Consulta_DNP)
        {
            this.Consulta_DNP = Consulta_DNP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaProvincia
    {
        
        public ConsultaProvincia()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaProvincia1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Provincias;
        
        public ConsultaProvincia1()
        {
        }
        
        public ConsultaProvincia1(System.Xml.XmlNode Provincias)
        {
            this.Provincias = Provincias;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaMunicipio
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        public ConsultaMunicipio()
        {
        }
        
        public ConsultaMunicipio(string Provincia, string Municipio)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaMunicipio1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Municipios;
        
        public ConsultaMunicipio1()
        {
        }
        
        public ConsultaMunicipio1(System.Xml.XmlNode Municipios)
        {
            this.Municipios = Municipios;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaVia
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string TipoVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string NombreVia;
        
        public ConsultaVia()
        {
        }
        
        public ConsultaVia(string Provincia, string Municipio, string TipoVia, string NombreVia)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.TipoVia = TipoVia;
            this.NombreVia = NombreVia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaVia1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Callejero;
        
        public ConsultaVia1()
        {
        }
        
        public ConsultaVia1(System.Xml.XmlNode Callejero)
        {
            this.Callejero = Callejero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaNumero
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string TipoVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string NomVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=4)]
        public string Numero;
        
        public ConsultaNumero()
        {
        }
        
        public ConsultaNumero(string Provincia, string Municipio, string TipoVia, string NomVia, string Numero)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.TipoVia = TipoVia;
            this.NomVia = NomVia;
            this.Numero = Numero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaNumero1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Callejero;
        
        public ConsultaNumero1()
        {
        }
        
        public ConsultaNumero1(System.Xml.XmlNode Callejero)
        {
            this.Callejero = Callejero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPLOCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string Sigla;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string Calle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=4)]
        public string Numero;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=5)]
        public string Bloque;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=6)]
        public string Escalera;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=7)]
        public string Planta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=8)]
        public string Puerta;
        
        public Consulta_DNPLOCRequest()
        {
        }
        
        public Consulta_DNPLOCRequest(string Provincia, string Municipio, string Sigla, string Calle, string Numero, string Bloque, string Escalera, string Planta, string Puerta)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.Sigla = Sigla;
            this.Calle = Calle;
            this.Numero = Numero;
            this.Bloque = Bloque;
            this.Escalera = Escalera;
            this.Planta = Planta;
            this.Puerta = Puerta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPLOCResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Consulta_DNP;
        
        public Consulta_DNPLOCResponse()
        {
        }
        
        public Consulta_DNPLOCResponse(System.Xml.XmlNode Consulta_DNP)
        {
            this.Consulta_DNP = Consulta_DNP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPPPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string Poligono;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string Parcela;
        
        public Consulta_DNPPPRequest()
        {
        }
        
        public Consulta_DNPPPRequest(string Provincia, string Municipio, string Poligono, string Parcela)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.Poligono = Poligono;
            this.Parcela = Parcela;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPPPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Consulta_DNPPP;
        
        public Consulta_DNPPPResponse()
        {
        }
        
        public Consulta_DNPPPResponse(System.Xml.XmlNode Consulta_DNPPP)
        {
            this.Consulta_DNPPP = Consulta_DNPPP;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface CallejerodelasedeelectrónicadelcatastroSoapChannel : ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class CallejerodelasedeelectrónicadelcatastroSoapClient : System.ServiceModel.ClientBase<ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap>, ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient() : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetDefaultBinding(), CallejerodelasedeelectrónicadelcatastroSoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(endpointConfiguration), CallejerodelasedeelectrónicadelcatastroSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPRCResponse> ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap.Consulta_DNPRCAsync(ReferenceCatrasto.Consulta_DNPRCRequest request)
        {
            return base.Channel.Consulta_DNPRCAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPRCResponse> Consulta_DNPRCAsync(string Provincia, string Municipio, string RefCat)
        {
            ReferenceCatrasto.Consulta_DNPRCRequest inValue = new ReferenceCatrasto.Consulta_DNPRCRequest();
            inValue.Provincia = Provincia;
            inValue.Municipio = Municipio;
            inValue.RefCat = RefCat;
            return ((ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap)(this)).Consulta_DNPRCAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaProvincia1> ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap.ObtenerProvinciasAsync(ReferenceCatrasto.ConsultaProvincia request)
        {
            return base.Channel.ObtenerProvinciasAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaProvincia1> ObtenerProvinciasAsync()
        {
            ReferenceCatrasto.ConsultaProvincia inValue = new ReferenceCatrasto.ConsultaProvincia();
            return ((ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap)(this)).ObtenerProvinciasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaMunicipio1> ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap.ObtenerMunicipiosAsync(ReferenceCatrasto.ConsultaMunicipio request)
        {
            return base.Channel.ObtenerMunicipiosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaMunicipio1> ObtenerMunicipiosAsync(string Provincia, string Municipio)
        {
            ReferenceCatrasto.ConsultaMunicipio inValue = new ReferenceCatrasto.ConsultaMunicipio();
            inValue.Provincia = Provincia;
            inValue.Municipio = Municipio;
            return ((ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap)(this)).ObtenerMunicipiosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaVia1> ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap.ObtenerCallejeroAsync(ReferenceCatrasto.ConsultaVia request)
        {
            return base.Channel.ObtenerCallejeroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaVia1> ObtenerCallejeroAsync(string Provincia, string Municipio, string TipoVia, string NombreVia)
        {
            ReferenceCatrasto.ConsultaVia inValue = new ReferenceCatrasto.ConsultaVia();
            inValue.Provincia = Provincia;
            inValue.Municipio = Municipio;
            inValue.TipoVia = TipoVia;
            inValue.NombreVia = NombreVia;
            return ((ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap)(this)).ObtenerCallejeroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaNumero1> ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap.ObtenerNumereroAsync(ReferenceCatrasto.ConsultaNumero request)
        {
            return base.Channel.ObtenerNumereroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReferenceCatrasto.ConsultaNumero1> ObtenerNumereroAsync(string Provincia, string Municipio, string TipoVia, string NomVia, string Numero)
        {
            ReferenceCatrasto.ConsultaNumero inValue = new ReferenceCatrasto.ConsultaNumero();
            inValue.Provincia = Provincia;
            inValue.Municipio = Municipio;
            inValue.TipoVia = TipoVia;
            inValue.NomVia = NomVia;
            inValue.Numero = Numero;
            return ((ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap)(this)).ObtenerNumereroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPLOCResponse> ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap.Consulta_DNPLOCAsync(ReferenceCatrasto.Consulta_DNPLOCRequest request)
        {
            return base.Channel.Consulta_DNPLOCAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPLOCResponse> Consulta_DNPLOCAsync(string Provincia, string Municipio, string Sigla, string Calle, string Numero, string Bloque, string Escalera, string Planta, string Puerta)
        {
            ReferenceCatrasto.Consulta_DNPLOCRequest inValue = new ReferenceCatrasto.Consulta_DNPLOCRequest();
            inValue.Provincia = Provincia;
            inValue.Municipio = Municipio;
            inValue.Sigla = Sigla;
            inValue.Calle = Calle;
            inValue.Numero = Numero;
            inValue.Bloque = Bloque;
            inValue.Escalera = Escalera;
            inValue.Planta = Planta;
            inValue.Puerta = Puerta;
            return ((ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap)(this)).Consulta_DNPLOCAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPPPResponse> ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap.Consulta_DNPPPAsync(ReferenceCatrasto.Consulta_DNPPPRequest request)
        {
            return base.Channel.Consulta_DNPPPAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReferenceCatrasto.Consulta_DNPPPResponse> Consulta_DNPPPAsync(string Provincia, string Municipio, string Poligono, string Parcela)
        {
            ReferenceCatrasto.Consulta_DNPPPRequest inValue = new ReferenceCatrasto.Consulta_DNPPPRequest();
            inValue.Provincia = Provincia;
            inValue.Municipio = Municipio;
            inValue.Poligono = Poligono;
            inValue.Parcela = Parcela;
            return ((ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoap)(this)).Consulta_DNPPPAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap))
            {
                return new System.ServiceModel.EndpointAddress("http://ovc.catastro.meh.es/ovcservweb/ovcswlocalizacionrc/ovccallejero.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CallejerodelasedeelectrónicadelcatastroSoapClient.GetEndpointAddress(EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap);
        }
        
        public enum EndpointConfiguration
        {
            
            Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap,
        }
    }
}