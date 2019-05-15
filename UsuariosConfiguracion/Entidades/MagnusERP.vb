Public Class MagnusERP
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property

    Private _Empresa As Integer
    Public Property Empresa() As Integer
        Get
            Return _Empresa
        End Get
        Set(ByVal value As Integer)
            _Empresa = value
        End Set
    End Property

    Private _Sistema As Integer
    Public Property Sistema() As Integer
        Get
            Return _Sistema
        End Get
        Set(ByVal value As Integer)
            _Sistema = value
        End Set
    End Property

    Private _DBMagnus As String
    Public Property DBMagnus() As String
        Get
            Return _DBMagnus
        End Get
        Set(ByVal value As String)
            _DBMagnus = value
        End Set
    End Property
    Private _usuarioActivo As Integer
    Public Property usuarioActivo() As Integer
        Get
            Return _usuarioActivo
        End Get
        Set(ByVal value As Integer)
            _usuarioActivo = value
        End Set
    End Property
    Private _autonumerico As String
    Public Property autonumerico() As String
        Get
            Return _autonumerico
        End Get
        Set(ByVal value As String)
            _autonumerico = value
        End Set
    End Property

    Private _server1 As String
    Public Property server1() As String
        Get
            Return _server1
        End Get
        Set(ByVal value As String)
            _server1 = value
        End Set
    End Property

    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _manejaRenta As Integer
    Public Property manejaRenta() As Integer
        Get
            Return _manejaRenta
        End Get
        Set(ByVal value As Integer)
            _manejaRenta = value
        End Set
    End Property

    Private _manejaObras As Integer
    Public Property manejaObras() As Integer
        Get
            Return _manejaObras
        End Get
        Set(ByVal value As Integer)
            _manejaObras = value
        End Set
    End Property

    Private _manejaTransportes As Integer
    Public Property manejaTransportes() As Integer
        Get
            Return _manejaTransportes
        End Get
        Set(ByVal value As Integer)
            _manejaTransportes = value
        End Set
    End Property

    Private _pathCer As String
    Public Property pathCer() As String
        Get
            Return _pathCer
        End Get
        Set(ByVal value As String)
            _pathCer = value
        End Set
    End Property

    Private _pathXml As String
    Public Property pathXml() As String
        Get
            Return _pathXml
        End Get
        Set(ByVal value As String)
            _pathXml = value
        End Set
    End Property

    Private _rutaReportes As String
    Public Property rutaReportes() As String
        Get
            Return _rutaReportes
        End Get
        Set(ByVal value As String)
            _rutaReportes = value
        End Set
    End Property

    Private _Lotes As Integer
    Public Property Lotes() As Integer
        Get
            Return _Lotes
        End Get
        Set(ByVal value As Integer)
            _Lotes = value
        End Set
    End Property

    Private _manejaDesMax As Integer
    Public Property manejaDesMax() As Integer
        Get
            Return _manejaDesMax
        End Get
        Set(ByVal value As Integer)
            _manejaDesMax = value
        End Set
    End Property

    Private _desMax As Double
    Public Property desMax() As Double
        Get
            Return _desMax
        End Get
        Set(ByVal value As Double)
            _desMax = value
        End Set
    End Property

    Private _desfinMax As Double
    Public Property desfinMax() As Double
        Get
            Return _desfinMax
        End Get
        Set(ByVal value As Double)
            _desfinMax = value
        End Set
    End Property

    Private _mostrarExistencia As Integer
    Public Property mostrarExistencia() As Integer
        Get
            Return _mostrarExistencia
        End Get
        Set(ByVal value As Integer)
            _mostrarExistencia = value
        End Set
    End Property

    Private _edicionMoneda As Integer
    Public Property edicionMoneda() As Integer
        Get
            Return _edicionMoneda
        End Get
        Set(ByVal value As Integer)
            _edicionMoneda = value
        End Set
    End Property

    Private _edicionTC As Integer
    Public Property edicionTC() As Integer
        Get
            Return _edicionTC
        End Get
        Set(ByVal value As Integer)
            _edicionTC = value
        End Set
    End Property

    Private _edicionImpuesto As Integer
    Public Property edicionImpuesto() As Integer
        Get
            Return _edicionImpuesto
        End Get
        Set(ByVal value As Integer)
            _edicionImpuesto = value
        End Set
    End Property

    Private _existenciaBruta As Integer
    Public Property existenciaBruta() As Integer
        Get
            Return _existenciaBruta
        End Get
        Set(ByVal value As Integer)
            _existenciaBruta = value
        End Set
    End Property

    Private _desXP As Integer
    Public Property desXP() As Integer
        Get
            Return _desXP
        End Get
        Set(ByVal value As Integer)
            _desXP = value
        End Set
    End Property

    Private _impXP As Integer
    Public Property impXP() As Integer
        Get
            Return _impXP
        End Get
        Set(ByVal value As Integer)
            _impXP = value
        End Set
    End Property

    Private _numeroDecimalesC As Integer
    Public Property numeroDecimalesC() As Integer
        Get
            Return _numeroDecimalesC
        End Get
        Set(ByVal value As Integer)
            _numeroDecimalesC = value
        End Set
    End Property

    Private _numeroDecimalesV As Integer
    Public Property numeroDecimalesV() As Integer
        Get
            Return _numeroDecimalesV
        End Get
        Set(ByVal value As Integer)
            _numeroDecimalesV = value
        End Set
    End Property

    Private _preview As Integer
    Public Property preview() As Integer
        Get
            Return _preview
        End Get
        Set(ByVal value As Integer)
            _preview = value
        End Set
    End Property

    Private _DesgloseDesc As Boolean
    Public Property DesgloseDesc() As Boolean
        Get
            Return _DesgloseDesc
        End Get
        Set(ByVal value As Boolean)
            _DesgloseDesc = value
        End Set
    End Property

    Private _AgrupaTallasFactura As Boolean
    Public Property AgrupaTallasFactura() As Boolean
        Get
            Return _AgrupaTallasFactura
        End Get
        Set(ByVal value As Boolean)
            _AgrupaTallasFactura = value
        End Set
    End Property

    Private _FormaPago As Boolean
    Public Property FormaPago() As Boolean
        Get
            Return _FormaPago
        End Get
        Set(ByVal value As Boolean)
            _FormaPago = value
        End Set
    End Property

    Private _FoliosConta As Boolean
    Public Property FoliosConta() As Boolean
        Get
            Return _FoliosConta
        End Get
        Set(ByVal value As Boolean)
            _FoliosConta = value
        End Set
    End Property

    Private _ManejarFiscal As Boolean
    Public Property ManejarFiscal() As Boolean
        Get
            Return _ManejarFiscal
        End Get
        Set(ByVal value As Boolean)
            _ManejarFiscal = value
        End Set
    End Property

    Private _RutaEtiqueta As String
    Public Property RutaEtiqueta() As String
        Get
            Return _RutaEtiqueta
        End Get
        Set(ByVal value As String)
            _RutaEtiqueta = value
        End Set
    End Property

    Private _ReporteTraspaso As String
    Public Property ReporteTraspaso() As String
        Get
            Return _ReporteTraspaso
        End Get
        Set(ByVal value As String)
            _ReporteTraspaso = value
        End Set
    End Property

    Private _MostrarImagen As Boolean
    Public Property MostrarImagen() As Boolean
        Get
            Return _MostrarImagen
        End Get
        Set(ByVal value As Boolean)
            _MostrarImagen = value
        End Set
    End Property

    Private _Simac As String
    Public Property Simac() As String
        Get
            Return _Simac
        End Get
        Set(ByVal value As String)
            _Simac = value
        End Set
    End Property

    Private _NDecimalesCosto As String
    Public Property NDecimalesCosto() As String
        Get
            Return _NDecimalesCosto
        End Get
        Set(ByVal value As String)
            _NDecimalesCosto = value
        End Set
    End Property

    Private _rutaImagenes As String
    Public Property rutaImagenes() As String
        Get
            Return _rutaImagenes
        End Get
        Set(ByVal value As String)
            _rutaImagenes = value
        End Set
    End Property

    Private _ReporteEmbarque As String
    Public Property ReporteEmbarque() As String
        Get
            Return _ReporteEmbarque
        End Get
        Set(ByVal value As String)
            _ReporteEmbarque = value
        End Set
    End Property

    Private _ReporteLiquidacion As String
    Public Property ReporteLiquidacion() As String
        Get
            Return _ReporteLiquidacion
        End Get
        Set(ByVal value As String)
            _ReporteLiquidacion = value
        End Set
    End Property

    Private _ReporteFaltante As String
    Public Property ReporteFaltante() As String
        Get
            Return _ReporteFaltante
        End Get
        Set(ByVal value As String)
            _ReporteFaltante = value
        End Set
    End Property

    Private _PrecioOferta As String
    Public Property PrecioOferta() As String
        Get
            Return _PrecioOferta
        End Get
        Set(ByVal value As String)
            _PrecioOferta = value
        End Set
    End Property

    Private _ProductoCompras As String
    Public Property ProductoCompras() As String
        Get
            Return _ProductoCompras
        End Get
        Set(ByVal value As String)
            _ProductoCompras = value
        End Set
    End Property

    Private _IdConceptoSalidaEnsamble As Integer
    Public Property IdConceptoSalidaEnsamble() As Integer
        Get
            Return _IdConceptoSalidaEnsamble
        End Get
        Set(ByVal value As Integer)
            _IdConceptoSalidaEnsamble = value
        End Set
    End Property

    Private _IdConceptoEntradaKIT As Integer
    Public Property IdConceptoEntradaKIT() As Integer
        Get
            Return _IdConceptoEntradaKIT
        End Get
        Set(ByVal value As Integer)
            _IdConceptoEntradaKIT = value
        End Set
    End Property

    Private _ManejaViaje As Boolean
    Public Property ManejaViaje() As Boolean
        Get
            Return _ManejaViaje
        End Get
        Set(ByVal value As Boolean)
            _ManejaViaje = value
        End Set
    End Property

    Private _ReporteViaje As String
    Public Property ReporteViaje() As String
        Get
            Return _ReporteViaje
        End Get
        Set(ByVal value As String)
            _ReporteViaje = value
        End Set
    End Property

    Private _PorSucursal As Boolean
    Public Property PorSucursal() As Boolean
        Get
            Return _PorSucursal
        End Get
        Set(ByVal value As Boolean)
            _PorSucursal = value
        End Set
    End Property

    Private _ReporteGastoEmbarque As String
    Public Property ReporteGastoEmbarque() As String
        Get
            Return _ReporteGastoEmbarque
        End Get
        Set(ByVal value As String)
            _ReporteGastoEmbarque = value
        End Set
    End Property

    Private _ElegirFormato As Boolean
    Public Property ElegirFormato() As Boolean
        Get
            Return _ElegirFormato
        End Get
        Set(ByVal value As Boolean)
            _ElegirFormato = value
        End Set
    End Property

    Private _AutoAsignarClave As Boolean
    Public Property AutoAsignarClave() As Boolean
        Get
            Return _AutoAsignarClave
        End Get
        Set(ByVal value As Boolean)
            _AutoAsignarClave = value
        End Set
    End Property

    Private _GeneraEmbarque As Boolean
    Public Property GeneraEmbarque() As Boolean
        Get
            Return _GeneraEmbarque
        End Get
        Set(ByVal value As Boolean)
            _GeneraEmbarque = value
        End Set
    End Property

    Private _ServicioFlete As String
    Public Property ServicioFlete() As String
        Get
            Return _ServicioFlete
        End Get
        Set(ByVal value As String)
            _ServicioFlete = value
        End Set
    End Property

    Private _ServicioSeguro As String
    Public Property ServicioSeguro() As String
        Get
            Return _ServicioSeguro
        End Get
        Set(ByVal value As String)
            _ServicioSeguro = value
        End Set
    End Property

    Private _IdEsquemaFlete As Integer
    Public Property IdEsquemaFlete() As Integer
        Get
            Return _IdEsquemaFlete
        End Get
        Set(ByVal value As Integer)
            _IdEsquemaFlete = value
        End Set
    End Property

    Private _EnvioCorreo As Integer
    Public Property EnvioCorreo() As Integer
        Get
            Return _EnvioCorreo
        End Get
        Set(ByVal value As Integer)
            _EnvioCorreo = value
        End Set
    End Property

    Private _AutorizarPagos As Boolean
    Public Property AutorizarPagos() As Boolean
        Get
            Return _AutorizarPagos
        End Get
        Set(ByVal value As Boolean)
            _AutorizarPagos = value
        End Set
    End Property

    Private _IdProductoEstimacion As String
    Public Property NewProperty() As String
        Get
            Return _IdProductoEstimacion
        End Get
        Set(ByVal value As String)
            _IdProductoEstimacion = value
        End Set
    End Property


End Class


'IdProductoEstimacion
'IdProductoEstimacionSub
'ReporteHojaGeneradora
'ReporteEstimacion
'ReporteCaratulaEstimacion
'ValidacionCredito
'PeriodoMaxMin
'NumLiquidacion
'ConceptosLiquidaciones
'CuentasComplemento
'DecimalesEntrada
'DecimalesSalida
'ServicioEmbarque
'RevisionPagos
'RptEnlaces
'AutonumeracionLotes
'CantidadTotalLote
'EditarComision
'PorcentajeEmpresa
'PorcentajeOperador
'AgruparClavesIguales
'manejaMovil
'nivelAlmacen
'EnlaceVarios
'ReporteOEmbarques
'ReporteAutorizaciones
'ReportePeriodoAutorizaciones
'ReportePeriodoEntregasEmbarque
'envioProduccion
'ReporteInventario
'EquivalenciaClientes
'ReporteLotesDocumento
'controLotes
'rptPendientesPorSurtir
'ManejaDescuentoComision
'EditarTipoPago
'ServicioFleteFactura
'ProdServicioFlete
'LecturaPickingIncrementoUnidad
'ContabilizaNivelCuatro
'incluirDescuentoPrecioXML
'CentroCostosCompras
'enlazarParcialPicking
'equivalenciasDuplicadas
'detallarLotesSIMAC
'decimalesPrecio
'ventaSoloListaPrecio
'envioPedidosSimac
'ClientePedido
'ReporteLiquidacionMovil
'ReporteAdeudoRetornable
'ReporteListaPrecios
'cantidadPorPrecio
