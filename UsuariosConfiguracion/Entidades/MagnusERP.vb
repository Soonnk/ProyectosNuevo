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
    Public Property IdProductoEstimacion() As String
        Get
            Return _IdProductoEstimacion
        End Get
        Set(ByVal value As String)
            _IdProductoEstimacion = value
        End Set
    End Property

    Private _IdProductoEstimacionSub As String
    Public Property IdProductoEstimacionSub() As String
        Get
            Return _IdProductoEstimacionSub
        End Get
        Set(ByVal value As String)
            _IdProductoEstimacionSub = value
        End Set
    End Property

    Private _ReporteHojaGeneradora As String
    Public Property ReporteHojaGeneradora() As String
        Get
            Return _ReporteHojaGeneradora
        End Get
        Set(ByVal value As String)
            _ReporteHojaGeneradora = value
        End Set
    End Property

    Private _ReporteEstimacion As String
    Public Property ReporteEstimacion() As String
        Get
            Return _ReporteEstimacion
        End Get
        Set(ByVal value As String)
            _ReporteEstimacion = value
        End Set
    End Property

    Private _ReporteCaratulaEstimacion As String
    Public Property ReporteCaratulaEstimacion() As String
        Get
            Return _ReporteCaratulaEstimacion
        End Get
        Set(ByVal value As String)
            _ReporteCaratulaEstimacion = value
        End Set
    End Property

    Private _ValidacionCredito As Integer
    Public Property ValidacionCredito() As Integer
        Get
            Return _ValidacionCredito
        End Get
        Set(ByVal value As Integer)
            _ValidacionCredito = value
        End Set
    End Property

    Private _PeriodoMaxMin As Integer
    Public Property PeriodoMaxMin() As Integer
        Get
            Return _PeriodoMaxMin
        End Get
        Set(ByVal value As Integer)
            _PeriodoMaxMin = value
        End Set
    End Property

    Private _NumLiquidacion As Integer
    Public Property NumLiquidacion() As Integer
        Get
            Return _NumLiquidacion
        End Get
        Set(ByVal value As Integer)
            _NumLiquidacion = value
        End Set
    End Property

    Private _ConceptosLiquidaciones As String
    Public Property ConceptosLiquidaciones() As String
        Get
            Return _ConceptosLiquidaciones
        End Get
        Set(ByVal value As String)
            _ConceptosLiquidaciones = value
        End Set
    End Property

    Private _CuentasComplemento As Boolean
    Public Property CuentasComplemento() As Boolean
        Get
            Return _CuentasComplemento
        End Get
        Set(ByVal value As Boolean)
            _CuentasComplemento = value
        End Set
    End Property

    Private _DecimalesEntrada As Integer
    Public Property DecimalesEntrada() As Integer
        Get
            Return _DecimalesEntrada
        End Get
        Set(ByVal value As Integer)
            _DecimalesEntrada = value
        End Set
    End Property

    Private _DecimalesSalida As Integer
    Public Property DecimalesSalida() As Integer
        Get
            Return _DecimalesSalida
        End Get
        Set(ByVal value As Integer)
            _DecimalesSalida = value
        End Set
    End Property

    Private _ServicioEmbarque As String
    Public Property ServicioEmbarque() As String
        Get
            Return _ServicioEmbarque
        End Get
        Set(ByVal value As String)
            _ServicioEmbarque = value
        End Set
    End Property

    Private _RevisionPagos As Boolean
    Public Property RevisionPagos() As Boolean
        Get
            Return _RevisionPagos
        End Get
        Set(ByVal value As Boolean)
            _RevisionPagos = value
        End Set
    End Property

    Private _RptEnlaces As String
    Public Property RptEnlaces() As String
        Get
            Return _RptEnlaces
        End Get
        Set(ByVal value As String)
            _RptEnlaces = value
        End Set
    End Property

    Private _AutonumeracionLotes As Boolean
    Public Property AutonumeracionLotes() As Boolean
        Get
            Return _AutonumeracionLotes
        End Get
        Set(ByVal value As Boolean)
            _AutonumeracionLotes = value
        End Set
    End Property

    Private _CantidadTotalLote As Boolean
    Public Property CantidadTotalLote() As Boolean
        Get
            Return _CantidadTotalLote
        End Get
        Set(ByVal value As Boolean)
            _CantidadTotalLote = value
        End Set
    End Property

    Private _EditarComision As Boolean
    Public Property EditarComision() As Boolean
        Get
            Return _EditarComision
        End Get
        Set(ByVal value As Boolean)
            _EditarComision = value
        End Set
    End Property

    Private _PorcentajeEmpresa As Integer
    Public Property PorcentajeEmpresa() As Integer
        Get
            Return _PorcentajeEmpresa
        End Get
        Set(ByVal value As Integer)
            _PorcentajeEmpresa = value
        End Set
    End Property

    Private _PorcentajeOperador As Integer
    Public Property PorcentajeOperador() As Integer
        Get
            Return _PorcentajeOperador
        End Get
        Set(ByVal value As Integer)
            _PorcentajeOperador = value
        End Set
    End Property

    Private _AgruparClavesIguales As Boolean
    Public Property AgruparClavesIguales() As Boolean
        Get
            Return _AgruparClavesIguales
        End Get
        Set(ByVal value As Boolean)
            _AgruparClavesIguales = value
        End Set
    End Property

    Private _manejaMovil As Integer
    Public Property manejaMovil() As Integer
        Get
            Return _manejaMovil
        End Get
        Set(ByVal value As Integer)
            _manejaMovil = value
        End Set
    End Property

    Private _nivelAlmacen As Integer
    Public Property nivelAlmacen() As Integer
        Get
            Return _nivelAlmacen
        End Get
        Set(ByVal value As Integer)
            _nivelAlmacen = value
        End Set
    End Property

    Private _EnlaceVarios As Boolean
    Public Property EnlaceVarios() As Boolean
        Get
            Return _EnlaceVarios
        End Get
        Set(ByVal value As Boolean)
            _EnlaceVarios = value
        End Set
    End Property

    Private _ReporteOEmbarques As String
    Public Property ReporteOEmbarques() As String
        Get
            Return _ReporteOEmbarques
        End Get
        Set(ByVal value As String)
            _ReporteOEmbarques = value
        End Set
    End Property

    Private _ReporteAutorizaciones As String
    Public Property ReporteAutorizaciones() As String
        Get
            Return _ReporteAutorizaciones
        End Get
        Set(ByVal value As String)
            _ReporteAutorizaciones = value
        End Set
    End Property

    Private _ReportePeriodoAutorizaciones As String
    Public Property ReportePeriodoAutorizaciones() As String
        Get
            Return _ReportePeriodoAutorizaciones
        End Get
        Set(ByVal value As String)
            _ReportePeriodoAutorizaciones = value
        End Set
    End Property

    Private _ReportePeriodoEntregasEmbarque As String
    Public Property ReportePeriodoEntregasEmbarque() As String
        Get
            Return _ReportePeriodoEntregasEmbarque
        End Get
        Set(ByVal value As String)
            _ReportePeriodoEntregasEmbarque = value
        End Set
    End Property

    Private _envioProduccion As Boolean
    Public Property envioProduccion() As Boolean
        Get
            Return _envioProduccion
        End Get
        Set(ByVal value As Boolean)
            _envioProduccion = value
        End Set
    End Property

    Private _ReporteInventario As String
    Public Property ReporteInventario() As String
        Get
            Return _ReporteInventario
        End Get
        Set(ByVal value As String)
            _ReporteInventario = value
        End Set
    End Property

    Private _EquivalenciaClientes As Boolean
    Public Property EquivalenciaClientes() As Boolean
        Get
            Return _EquivalenciaClientes
        End Get
        Set(ByVal value As Boolean)
            _EquivalenciaClientes = value
        End Set
    End Property

    Private _ReporteLotesDocumento As String
    Public Property ReporteLotesDocumento() As String
        Get
            Return _ReporteLotesDocumento
        End Get
        Set(ByVal value As String)
            _ReporteLotesDocumento = value
        End Set
    End Property

    Private _controLotes As Boolean
    Public Property controLotes() As Boolean
        Get
            Return _controLotes
        End Get
        Set(ByVal value As Boolean)
            _controLotes = value
        End Set
    End Property

    Private _rptPendientesPorSurtir As String
    Public Property rptPendientesPorSurtir() As String
        Get
            Return _rptPendientesPorSurtir
        End Get
        Set(ByVal value As String)
            _rptPendientesPorSurtir = value
        End Set
    End Property

    Private _ManejaDescuentoComision As Boolean
    Public Property ManejaDescuentoComision() As Boolean
        Get
            Return _ManejaDescuentoComision
        End Get
        Set(ByVal value As Boolean)
            _ManejaDescuentoComision = value
        End Set
    End Property

    Private _EditarTipoPago As Boolean
    Public Property EditarTipoPago() As Boolean
        Get
            Return _EditarTipoPago
        End Get
        Set(ByVal value As Boolean)
            _EditarTipoPago = value
        End Set
    End Property

    Private _ServicioFleteFactura As Boolean
    Public Property ServicioFleteFactura() As Boolean
        Get
            Return _ServicioFleteFactura
        End Get
        Set(ByVal value As Boolean)
            _ServicioFleteFactura = value
        End Set
    End Property

    Private _ProdServicioFlete As String
    Public Property ProdServicioFlete() As String
        Get
            Return _ProdServicioFlete
        End Get
        Set(ByVal value As String)
            _ProdServicioFlete = value
        End Set
    End Property

    Private _LecturaPickingIncrementoUnidad As Boolean
    Public Property LecturaPickingIncrementoUnidad() As Boolean
        Get
            Return _LecturaPickingIncrementoUnidad
        End Get
        Set(ByVal value As Boolean)
            _LecturaPickingIncrementoUnidad = value
        End Set
    End Property

    Private _ContabilizaNivelCuatro As Boolean
    Public Property ContabilizaNivelCuatro() As Boolean
        Get
            Return _ContabilizaNivelCuatro
        End Get
        Set(ByVal value As Boolean)
            _ContabilizaNivelCuatro = value
        End Set
    End Property

    Private _incluirDescuentoPrecioXML As Boolean
    Public Property incluirDescuentoPrecioXML() As Boolean
        Get
            Return _incluirDescuentoPrecioXML
        End Get
        Set(ByVal value As Boolean)
            _incluirDescuentoPrecioXML = value
        End Set
    End Property

    Private _CentroCostosCompras As Boolean
    Public Property CentroCostosCompras() As Boolean
        Get
            Return _CentroCostosCompras
        End Get
        Set(ByVal value As Boolean)
            _CentroCostosCompras = value
        End Set
    End Property

    Private _enlazarParcialPicking As Boolean
    Public Property enlazarParcialPicking() As Boolean
        Get
            Return _enlazarParcialPicking
        End Get
        Set(ByVal value As Boolean)
            _enlazarParcialPicking = value
        End Set
    End Property

    Private _equivalenciasDuplicadas As Boolean
    Public Property equivalenciasDuplicadas() As Boolean
        Get
            Return _equivalenciasDuplicadas
        End Get
        Set(ByVal value As Boolean)
            _equivalenciasDuplicadas = value
        End Set
    End Property

    Private _detallarLotesSIMAC As Boolean
    Public Property detallarLotesSIMAC() As Boolean
        Get
            Return _detallarLotesSIMAC
        End Get
        Set(ByVal value As Boolean)
            _detallarLotesSIMAC = value
        End Set
    End Property

    Private _decimalesPrecio As Integer
    Public Property decimalesPrecio() As Integer
        Get
            Return _decimalesPrecio
        End Get
        Set(ByVal value As Integer)
            _decimalesPrecio = value
        End Set
    End Property

    Private _ventaSoloListaPrecio As Boolean
    Public Property ventaSoloListaPrecio() As Boolean
        Get
            Return _ventaSoloListaPrecio
        End Get
        Set(ByVal value As Boolean)
            _ventaSoloListaPrecio = value
        End Set
    End Property

    Private _envioPedidosSimac As Integer
    Public Property envioPedidosSimac() As Integer
        Get
            Return _envioPedidosSimac
        End Get
        Set(ByVal value As Integer)
            _envioPedidosSimac = value
        End Set
    End Property

    Private _ClientePedido As String
    Public Property ClientePedido() As String
        Get
            Return _ClientePedido
        End Get
        Set(ByVal value As String)
            _ClientePedido = value
        End Set
    End Property

    Private _ReporteLiquidacionMovil As String
    Public Property ReporteLiquidacionMovil() As String
        Get
            Return _ReporteLiquidacionMovil
        End Get
        Set(ByVal value As String)
            _ReporteLiquidacionMovil = value
        End Set
    End Property

    Private _ReporteAdeudoRetornable As String
    Public Property ReporteAdeudoRetornable() As String
        Get
            Return _ReporteAdeudoRetornable
        End Get
        Set(ByVal value As String)
            _ReporteAdeudoRetornable = value
        End Set
    End Property

    Private _ReporteListaPrecios As String
    Public Property ReporteListaPrecios() As String
        Get
            Return _ReporteListaPrecios
        End Get
        Set(ByVal value As String)
            _ReporteListaPrecios = value
        End Set
    End Property

    Private _cantidadPorPrecio As Boolean
    Public Property cantidadPorPrecio() As Boolean
        Get
            Return _cantidadPorPrecio
        End Get
        Set(ByVal value As Boolean)
            _cantidadPorPrecio = value
        End Set
    End Property

    Public Sub New()
        Me._OID = 0
        Me._Empresa = 0
        Me._Sistema = 0
        Me._DBMagnus = ""
        Me._usuarioActivo = 0
        Me._autonumerico = ""
        Me._server1 = ""
        Me._usuario = ""
        Me._manejaRenta = 0
        Me._manejaObras = 0
        Me._manejaTransportes = 0
        Me._pathCer = ""
        Me._pathXml = ""
        Me._rutaReportes = ""
        Me._Lotes = 0
        Me._manejaDesMax = 0
        Me._desMax = 0
        Me._desfinMax = 0
        Me._mostrarExistencia = 0
        Me._edicionMoneda = 0
        Me._edicionTC = 0
        Me._edicionImpuesto = 0
        Me._existenciaBruta = 0
        Me._desXP = 0
        Me._impXP = 0
        Me._numeroDecimalesC = 0
        Me._numeroDecimalesV = 0
        Me._preview = 0
        Me._DesgloseDesc = False
        Me._AgrupaTallasFactura = False
        Me._FormaPago = False
        Me._FoliosConta = False
        Me._ManejarFiscal = False
        Me._RutaEtiqueta = ""
        Me._ReporteTraspaso = ""
        Me._MostrarImagen = False
        Me._Simac = ""
        Me._NDecimalesCosto = ""
        Me._rutaImagenes = ""
        Me._ReporteEmbarque = ""
        Me._ReporteLiquidacion = ""
        Me._ReporteFaltante = ""
        Me._PrecioOferta = ""
        Me._ProductoCompras = ""
        Me._IdConceptoSalidaEnsamble = 0
        Me._IdConceptoEntradaKIT = 0
        Me._ManejaViaje = False
        Me._ReporteViaje = ""
        Me._PorSucursal = False
        Me._ReporteGastoEmbarque = ""
        Me._ElegirFormato = False
        Me._AutoAsignarClave = False
        Me._GeneraEmbarque = False
        Me._ServicioFlete = ""
        Me._ServicioSeguro = ""
        Me._IdEsquemaFlete = 0
        Me._EnvioCorreo = 0
        Me._AutorizarPagos = False
        Me._IdProductoEstimacion = ""
        Me._IdProductoEstimacionSub = ""
        Me._ReporteHojaGeneradora = ""
        Me._ReporteEstimacion = ""
        Me._ReporteCaratulaEstimacion = ""
        Me._ValidacionCredito = 0
        Me._PeriodoMaxMin = 0
        Me._NumLiquidacion = 0
        Me._ConceptosLiquidaciones = ""
        Me._CuentasComplemento = False
        Me._DecimalesEntrada = 0
        Me._DecimalesSalida = 0
        Me._ServicioEmbarque = ""
        Me._RevisionPagos = False
        Me._RptEnlaces = ""
        Me._AutonumeracionLotes = False
        Me._CantidadTotalLote = False
        Me._EditarComision = False
        Me._PorcentajeEmpresa = 0
        Me._PorcentajeOperador = 0
        Me._AgruparClavesIguales = False
        Me._manejaMovil = 0
        Me._nivelAlmacen = 0
        Me._EnlaceVarios = False
        Me._ReporteOEmbarques = ""
        Me._ReporteAutorizaciones = ""
        Me._ReportePeriodoAutorizaciones = ""
        Me._ReportePeriodoEntregasEmbarque = ""
        Me._envioProduccion = False
        Me._ReporteInventario = ""
        Me._EquivalenciaClientes = False
        Me._ReporteLotesDocumento = ""
        Me._controLotes = False
        Me._rptPendientesPorSurtir = ""
        Me._ManejaDescuentoComision = False
        Me._EditarTipoPago = False
        Me._ServicioFleteFactura = False
        Me._ProdServicioFlete = ""
        Me._LecturaPickingIncrementoUnidad = False
        Me._ContabilizaNivelCuatro = False
        Me._incluirDescuentoPrecioXML = False
        Me._CentroCostosCompras = False
        Me._enlazarParcialPicking = False
        Me._equivalenciasDuplicadas = False
        Me._detallarLotesSIMAC = False
        Me._decimalesPrecio = 0
        Me._ventaSoloListaPrecio = False
        Me._envioPedidosSimac = 0
        Me._ClientePedido = ""
        Me._ReporteLiquidacionMovil = ""
        Me._ReporteAdeudoRetornable = ""
        Me._ReporteListaPrecios = ""
        Me._cantidadPorPrecio = False
    End Sub


End Class


