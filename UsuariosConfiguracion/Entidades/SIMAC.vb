Public Class SIMAC
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property

    Private _SistemaAdmon As String
    Public Property SistemaAdmon() As String
        Get
            Return _SistemaAdmon
        End Get
        Set(ByVal value As String)
            _SistemaAdmon = value
        End Set
    End Property

    Private _NoEmpresa As String
    Public Property NoEmpresa() As String
        Get
            Return _NoEmpresa
        End Get
        Set(ByVal value As String)
            _NoEmpresa = value
        End Set
    End Property

    Private _ProductoTerminado As String
    Public Property ProductoTerminado() As String
        Get
            Return _ProductoTerminado
        End Get
        Set(ByVal value As String)
            _ProductoTerminado = value
        End Set
    End Property

    Private _MateriaPrima As String
    Public Property MateriaPrima() As String
        Get
            Return _MateriaPrima
        End Get
        Set(ByVal value As String)
            _MateriaPrima = value
        End Set
    End Property

    Private _MateriaTalla As String
    Public Property MateriaTalla() As String
        Get
            Return _MateriaTalla
        End Get
        Set(ByVal value As String)
            _MateriaTalla = value
        End Set
    End Property

    Private _Fracciones As String
    Public Property Fracciones() As String
        Get
            Return _Fracciones
        End Get
        Set(ByVal value As String)
            _Fracciones = value
        End Set
    End Property

    Private _Procesos As String
    Public Property Procesos() As String
        Get
            Return _Procesos
        End Get
        Set(ByVal value As String)
            _Procesos = value
        End Set
    End Property

    Private _Modelos As String
    Public Property Modelos() As String
        Get
            Return _Modelos
        End Get
        Set(ByVal value As String)
            _Modelos = value
        End Set
    End Property

    Private _Tabla1 As String
    Public Property Tabla1() As String
        Get
            Return _Tabla1
        End Get
        Set(ByVal value As String)
            _Tabla1 = value
        End Set
    End Property

    Private _Tabla2 As String
    Public Property Tabla2() As String
        Get
            Return _Tabla2
        End Get
        Set(ByVal value As String)
            _Tabla2 = value
        End Set
    End Property

    Private _Tabla3 As String
    Public Property Tabla3() As String
        Get
            Return _Tabla3
        End Get
        Set(ByVal value As String)
            _Tabla3 = value
        End Set
    End Property

    Private _Tabla4 As String
    Public Property Tabla4() As String
        Get
            Return _Tabla4
        End Get
        Set(ByVal value As String)
            _Tabla4 = value
        End Set
    End Property

    Private _Tabla5 As String
    Public Property Tabla5() As String
        Get
            Return _Tabla5
        End Get
        Set(ByVal value As String)
            _Tabla5 = value
        End Set
    End Property

    Private _Tabla6 As String
    Public Property Tabla6() As String
        Get
            Return _Tabla6
        End Get
        Set(ByVal value As String)
            _Tabla6 = value
        End Set
    End Property

    Private _FolioPedidoA As Integer
    Public Property FolioPedidoA() As Integer
        Get
            Return _FolioPedidoA
        End Get
        Set(ByVal value As Integer)
            _FolioPedidoA = value
        End Set
    End Property

    Private _FolioPedidoB As Integer
    Public Property FolioPedidoB() As Integer
        Get
            Return _FolioPedidoB
        End Get
        Set(ByVal value As Integer)
            _FolioPedidoB = value
        End Set
    End Property

    Private _FolioOrdenA As Integer
    Public Property FolioOrdenA() As Integer
        Get
            Return _FolioOrdenA
        End Get
        Set(ByVal value As Integer)
            _FolioOrdenA = value
        End Set
    End Property

    Private _FolioOrdenB As Integer
    Public Property FolioOrdenB() As Integer
        Get
            Return _FolioOrdenB
        End Get
        Set(ByVal value As Integer)
            _FolioOrdenB = value
        End Set
    End Property

    Private _CantAvance As Boolean
    Public Property CantAvance() As Boolean
        Get
            Return _CantAvance
        End Get
        Set(ByVal value As Boolean)
            _CantAvance = value
        End Set
    End Property

    Private _AutoAvance As Boolean
    Public Property AutoAvance() As Boolean
        Get
            Return _AutoAvance
        End Get
        Set(ByVal value As Boolean)
            _AutoAvance = value
        End Set
    End Property

    Private _FechaAvance As Boolean
    Public Property FechaAvance() As Boolean
        Get
            Return _FechaAvance
        End Get
        Set(ByVal value As Boolean)
            _FechaAvance = value
        End Set
    End Property

    Private _MultiAlmacen As Boolean
    Public Property MultiAlmacen() As Boolean
        Get
            Return _MultiAlmacen
        End Get
        Set(ByVal value As Boolean)
            _MultiAlmacen = value
        End Set
    End Property

    Private _MaterialAlmacen As Integer
    Public Property MaterialAlmacen() As Integer
        Get
            Return _MaterialAlmacen
        End Get
        Set(ByVal value As Integer)
            _MaterialAlmacen = value
        End Set
    End Property

    Private _ProductoAlmacen As Integer
    Public Property ProductoAlmacen() As Integer
        Get
            Return _ProductoAlmacen
        End Get
        Set(ByVal value As Integer)
            _ProductoAlmacen = value
        End Set
    End Property

    Private _MaxLote As Decimal
    Public Property MaxLote() As Decimal
        Get
            Return _MaxLote
        End Get
        Set(ByVal value As Decimal)
            _MaxLote = value
        End Set
    End Property

    Private _Reporte As Integer
    Public Property Reporte() As Integer
        Get
            Return _Reporte
        End Get
        Set(ByVal value As Integer)
            _Reporte = value
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

    Private _DBSimac As String
    Public Property DBSimac() As String
        Get
            Return _DBSimac
        End Get
        Set(ByVal value As String)
            _DBSimac = value
        End Set
    End Property

    Private _ProgBase As Boolean
    Public Property ProgBase() As Boolean
        Get
            Return _ProgBase
        End Get
        Set(ByVal value As Boolean)
            _ProgBase = value
        End Set
    End Property

    Private _ValidaUnidad As Boolean
    Public Property ValidaUnidad() As Boolean
        Get
            Return _ValidaUnidad
        End Get
        Set(ByVal value As Boolean)
            _ValidaUnidad = value
        End Set
    End Property

    Private _AutPedido As Boolean
    Public Property AutPedido() As Boolean
        Get
            Return _AutPedido
        End Get
        Set(ByVal value As Boolean)
            _AutPedido = value
        End Set
    End Property

    Private _DestajosAvance As Boolean
    Public Property DestajosAvance() As Boolean
        Get
            Return _DestajosAvance
        End Get
        Set(ByVal value As Boolean)
            _DestajosAvance = value
        End Set
    End Property

    Private _ValidadSuPedido As Boolean
    Public Property ValidadSuPedido() As Boolean
        Get
            Return _ValidadSuPedido
        End Get
        Set(ByVal value As Boolean)
            _ValidadSuPedido = value
        End Set
    End Property

    Private _EntregaParcial As Boolean
    Public Property EntregaParcial() As Boolean
        Get
            Return _EntregaParcial
        End Get
        Set(ByVal value As Boolean)
            _EntregaParcial = value
        End Set
    End Property

    Private _CalculoDesperdicio As Boolean
    Public Property CalculoDesperdicio() As Boolean
        Get
            Return _CalculoDesperdicio
        End Get
        Set(ByVal value As Boolean)
            _CalculoDesperdicio = value
        End Set
    End Property

    Private _ManejaTenerias As Boolean
    Public Property ManejaTenerias() As Boolean
        Get
            Return _ManejaTenerias
        End Get
        Set(ByVal value As Boolean)
            _ManejaTenerias = value
        End Set
    End Property

    Private _PedProdAutorizado As Boolean
    Public Property PedProdAutorizado() As Boolean
        Get
            Return _PedProdAutorizado
        End Get
        Set(ByVal value As Boolean)
            _PedProdAutorizado = value
        End Set
    End Property

    Private _MinutosSemanales As Integer
    Public Property MinutosSemanales() As Integer
        Get
            Return _MinutosSemanales
        End Get
        Set(ByVal value As Integer)
            _MinutosSemanales = value
        End Set
    End Property

    Private _hcCarga As Boolean
    Public Property hcCarga() As Boolean
        Get
            Return _hcCarga
        End Get
        Set(ByVal value As Boolean)
            _hcCarga = value
        End Set
    End Property

    Private _hcDerivados As Boolean
    Public Property hcDerivados() As Boolean
        Get
            Return _hcDerivados
        End Get
        Set(ByVal value As Boolean)
            _hcDerivados = value
        End Set
    End Property

    Private _hcFormulas As Boolean
    Public Property hcFormulas() As Boolean
        Get
            Return _hcFormulas
        End Get
        Set(ByVal value As Boolean)
            _hcFormulas = value
        End Set
    End Property

    Private _hcMateriales As Boolean
    Public Property hcMateriales() As Boolean
        Get
            Return _hcMateriales
        End Get
        Set(ByVal value As Boolean)
            _hcMateriales = value
        End Set
    End Property

    Private _rptFormulas As String
    Public Property rptFormulas() As String
        Get
            Return _rptFormulas
        End Get
        Set(ByVal value As String)
            _rptFormulas = value
        End Set
    End Property

    Private _avancePorProceso As Boolean
    Public Property avancePorProceso() As Boolean
        Get
            Return _avancePorProceso
        End Get
        Set(ByVal value As Boolean)
            _avancePorProceso = value
        End Set
    End Property

    Private _dividirLote As Boolean
    Public Property dividirLote() As Boolean
        Get
            Return _dividirLote
        End Get
        Set(ByVal value As Boolean)
            _dividirLote = value
        End Set
    End Property

    Private _avanceNoValidarProg As Boolean
    Public Property avanceNoValidarProg() As Boolean
        Get
            Return _avanceNoValidarProg
        End Get
        Set(ByVal value As Boolean)
            _avanceNoValidarProg = value
        End Set
    End Property

    Private _rptPreasignacion As String
    Public Property rptPreasignacion() As String
        Get
            Return _rptPreasignacion
        End Get
        Set(ByVal value As String)
            _rptPreasignacion = value
        End Set
    End Property

    Private _Tabla7 As String
    Public Property Tabla7() As String
        Get
            Return _Tabla7
        End Get
        Set(ByVal value As String)
            _Tabla7 = value
        End Set
    End Property

    Private _Tabla8 As String
    Public Property Tabla8() As String
        Get
            Return _Tabla8
        End Get
        Set(ByVal value As String)
            _Tabla8 = value
        End Set
    End Property

    Private _Tabla9 As String
    Public Property Tabla9() As String
        Get
            Return _Tabla9
        End Get
        Set(ByVal value As String)
            _Tabla9 = value
        End Set
    End Property

    Private _Tabla10 As String
    Public Property Tabla10() As String
        Get
            Return _Tabla10
        End Get
        Set(ByVal value As String)
            _Tabla10 = value
        End Set
    End Property

    Private _Tabla11 As String
    Public Property Tabla11() As String
        Get
            Return _Tabla11
        End Get
        Set(ByVal value As String)
            _Tabla11 = value
        End Set
    End Property

    Private _Tabla12 As String
    Public Property Tabla12() As String
        Get
            Return _Tabla12
        End Get
        Set(ByVal value As String)
            _Tabla12 = value
        End Set
    End Property

    Private _rptExplosionFormulas As String
    Public Property rptExplosionFormulas() As String
        Get
            Return _rptExplosionFormulas
        End Get
        Set(ByVal value As String)
            _rptExplosionFormulas = value
        End Set
    End Property


    Private _editarCantidadDestajo As Boolean
    Public Property editarCantidadDestajo() As Boolean
        Get
            Return _editarCantidadDestajo
        End Get
        Set(ByVal value As Boolean)
            _editarCantidadDestajo = value
        End Set
    End Property

    Private _editarCostoDestaje As Boolean
    Public Property editarCostoDestaje() As Boolean
        Get
            Return _editarCostoDestaje
        End Get
        Set(ByVal value As Boolean)
            _editarCostoDestaje = value
        End Set
    End Property


End Class
