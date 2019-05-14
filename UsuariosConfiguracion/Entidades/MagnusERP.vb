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

End Class

'usuarioActivo
'autonumerico
'server
'usuario
'manejaRenta
'manejaObras
'manejaTransportes
'pathCer
'pathXml
'rutaReportes
'Lotes
'manejaDesMax
'desMax
'desfinMax
'mostrarExistencia
'edicionMoneda
'edicionTC
'edicionImpuesto
'existenciaBruta
'desXP
'impXP
'numeroDecimalesC
'numeroDecimalesV
'preview
'DesgloseDesc
'AgrupaTallasFactura
'FormaPago
'FoliosConta
'ManejarFiscal
'RutaEtiqueta
'ReporteTraspaso
'MostrarImagen
'Simac
'NDecimalesCosto
'rutaImagenes
'ReporteEmbarque
'ReporteLiquidacion
'ReporteFaltante
'PrecioOferta
'ProductoCompras
'IdConceptoSalidaEnsamble
'IdConceptoEntradaKIT
'ManejaViaje
'ReporteViaje
'PorSucursal
'ReporteGastoEmbarque
'ElegirFormato
'AutoAsignarClave
'GeneraEmbarque
'ServicioFlete
'ServicioSeguro
'IdEsquemaFlete
'EnvioCorreo
'AutorizarPagos
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
