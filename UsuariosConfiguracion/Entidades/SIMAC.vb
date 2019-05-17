Public Class SIMAC
    Private _OID As Integer
    Private _SistemaAdmon As String
    Private _Empresa As Integer
    Private _ProductoTerminado As String
    Private _MateriaPrima As String
    Private _MateriaTalla As String
    Private _Fracciones As String
    Private _Procesos As String
    Private _Modelos As String
    Private _Tabla1 As String
    Private _Tabla2 As String
    Private _Tabla3 As String
    Private _Tabla4 As String
    Private _Tabla5 As String
    Private _Tabla6 As String
    Private _FolioPedidoA As Integer
    Private _FolioPedidoB As Integer
    Private _FolioOrdenA As Integer
    Private _FolioOrdenB As Integer
    Private _CantAvance As Boolean
    Private _AutoAvance As Boolean
    Private _FechaAvance As Boolean
    Private _MultiAlmacen As Boolean
    Private _MaterialAlmacen As Integer
    Private _ProductoAlmacen As Integer
    Private _MaxLote As Decimal
    Private _Reporte As Integer
    Private _Sistema As Integer
    Private _DBSimac As String
    Private _ProgBase As Boolean
    Private _ValidaUnidad As Boolean
    Private _AutPedido As Boolean
    Private _DestajosAvance As Boolean
    Private _ValidadSuPedido As Boolean
    Private _EntregaParcial As Boolean
    Private _CalculoDesperdicio As Boolean
    Private _ManejaTenerias As Boolean
    Private _PedProdAutorizado As Boolean
    Private _MinutosSemanales As Integer
    Private _hcCarga As Boolean
    Private _hcDerivados As Boolean
    Private _hcFormulas As Boolean
    Private _hcMateriales As Boolean
    Private _rptFormulas As String
    Private _avancePorProceso As Boolean
    Private _dividirLote As Boolean
    Private _avanceNoValidarProg As Boolean
    Private _rptPreasignacion As String
    Private _Tabla7 As String
    Private _Tabla8 As String
    Private _Tabla9 As String
    Private _Tabla10 As String
    Private _Tabla11 As String
    Private _Tabla12 As String
    Private _rptExplosionFormulas As String
    Private _editarCantidadDestajo As Boolean
    Private _editarCostoDestaje As Boolean

    Public Sub New()
        Me._OID = 0
        Me._SistemaAdmon = ""
        Me._Empresa = 0
        Me._ProductoTerminado = ""
        Me._MateriaPrima = ""
        Me._MateriaTalla = ""
        Me._Fracciones = ""
        Me._Procesos = ""
        Me._Modelos = ""
        Me._Tabla1 = ""
        Me._Tabla2 = ""
        Me._Tabla3 = ""
        Me._Tabla4 = ""
        Me._Tabla5 = ""
        Me._Tabla6 = ""
        Me._Tabla7 = ""
        Me._Tabla8 = ""
        Me._Tabla9 = ""
        Me._Tabla10 = ""
        Me._Tabla11 = ""
        Me._Tabla12 = ""
        Me._FolioPedidoA = 0
        Me._FolioPedidoB = 0
        Me._FolioOrdenA = 0
        Me._FolioOrdenB = 0
        Me._CantAvance = False
        Me._AutoAvance = False
        Me._FechaAvance = False
        Me._MultiAlmacen = False
        Me._MaterialAlmacen = False
        Me._ProductoAlmacen = False
        Me._MaxLote = 0.00
        Me._Sistema = 0
        Me._DBSimac = ""
        Me._ProgBase = False
        Me._ValidaUnidad = False
        Me._AutPedido = False
        Me._DestajosAvance = False

    End Sub

    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Public Property SistemaAdmon() As String
        Get
            Return _SistemaAdmon
        End Get
        Set(ByVal value As String)
            _SistemaAdmon = value
        End Set
    End Property
    Public Property Empresa() As Integer
        Get
            Return _Empresa
        End Get
        Set(ByVal value As Integer)
            _Empresa = value
        End Set
    End Property
    Public Property ProductoTerminado() As String
        Get
            Return _ProductoTerminado
        End Get
        Set(ByVal value As String)
            _ProductoTerminado = value
        End Set
    End Property
    Public Property MateriaPrima() As String
        Get
            Return _MateriaPrima
        End Get
        Set(ByVal value As String)
            _MateriaPrima = value
        End Set
    End Property
    Public Property MateriaTalla() As String
        Get
            Return _MateriaTalla
        End Get
        Set(ByVal value As String)
            _MateriaTalla = value
        End Set
    End Property
    Public Property Fracciones() As String
        Get
            Return _Fracciones
        End Get
        Set(ByVal value As String)
            _Fracciones = value
        End Set
    End Property
    Public Property Procesos() As String
        Get
            Return _Procesos
        End Get
        Set(ByVal value As String)
            _Procesos = value
        End Set
    End Property
    Public Property Modelos() As String
        Get
            Return _Modelos
        End Get
        Set(ByVal value As String)
            _Modelos = value
        End Set
    End Property
    Public Property Tabla1() As String
        Get
            Return _Tabla1
        End Get
        Set(ByVal value As String)
            _Tabla1 = value
        End Set
    End Property
    Public Property Tabla2() As String
        Get
            Return _Tabla2
        End Get
        Set(ByVal value As String)
            _Tabla2 = value
        End Set
    End Property
    Public Property Tabla3() As String
        Get
            Return _Tabla3
        End Get
        Set(ByVal value As String)
            _Tabla3 = value
        End Set
    End Property
    Public Property Tabla4() As String
        Get
            Return _Tabla4
        End Get
        Set(ByVal value As String)
            _Tabla4 = value
        End Set
    End Property
    Public Property Tabla5() As String
        Get
            Return _Tabla5
        End Get
        Set(ByVal value As String)
            _Tabla5 = value
        End Set
    End Property
    Public Property Tabla6() As String
        Get
            Return _Tabla6
        End Get
        Set(ByVal value As String)
            _Tabla6 = value
        End Set
    End Property
    Public Property FolioPedidoA() As Integer
        Get
            Return _FolioPedidoA
        End Get
        Set(ByVal value As Integer)
            _FolioPedidoA = value
        End Set
    End Property
    Public Property FolioPedidoB() As Integer
        Get
            Return _FolioPedidoB
        End Get
        Set(ByVal value As Integer)
            _FolioPedidoB = value
        End Set
    End Property
    Public Property FolioOrdenA() As Integer
        Get
            Return _FolioOrdenA
        End Get
        Set(ByVal value As Integer)
            _FolioOrdenA = value
        End Set
    End Property
    Public Property FolioOrdenB() As Integer
        Get
            Return _FolioOrdenB
        End Get
        Set(ByVal value As Integer)
            _FolioOrdenB = value
        End Set
    End Property
    Public Property CantAvance() As Boolean
        Get
            Return _CantAvance
        End Get
        Set(ByVal value As Boolean)
            _CantAvance = value
        End Set
    End Property
    Public Property AutoAvance() As Boolean
        Get
            Return _AutoAvance
        End Get
        Set(ByVal value As Boolean)
            _AutoAvance = value
        End Set
    End Property
    Public Property FechaAvance() As Boolean
        Get
            Return _FechaAvance
        End Get
        Set(ByVal value As Boolean)
            _FechaAvance = value
        End Set
    End Property
    Public Property MultiAlmacen() As Boolean
        Get
            Return _MultiAlmacen
        End Get
        Set(ByVal value As Boolean)
            _MultiAlmacen = value
        End Set
    End Property
    Public Property MaterialAlmacen() As Integer
        Get
            Return _MaterialAlmacen
        End Get
        Set(ByVal value As Integer)
            _MaterialAlmacen = value
        End Set
    End Property
    Public Property ProductoAlmacen() As Integer
        Get
            Return _ProductoAlmacen
        End Get
        Set(ByVal value As Integer)
            _ProductoAlmacen = value
        End Set
    End Property
    Public Property MaxLote() As Decimal
        Get
            Return _MaxLote
        End Get
        Set(ByVal value As Decimal)
            _MaxLote = value
        End Set
    End Property
    Public Property Reporte() As Integer
        Get
            Return _Reporte
        End Get
        Set(ByVal value As Integer)
            _Reporte = value
        End Set
    End Property
    Public Property Sistema() As Integer
        Get
            Return _Sistema
        End Get
        Set(ByVal value As Integer)
            _Sistema = value
        End Set
    End Property
    Public Property DBSimac() As String
        Get
            Return _DBSimac
        End Get
        Set(ByVal value As String)
            _DBSimac = value
        End Set
    End Property
    Public Property ProgBase() As Boolean
        Get
            Return _ProgBase
        End Get
        Set(ByVal value As Boolean)
            _ProgBase = value
        End Set
    End Property
    Public Property ValidaUnidad() As Boolean
        Get
            Return _ValidaUnidad
        End Get
        Set(ByVal value As Boolean)
            _ValidaUnidad = value
        End Set
    End Property
    Public Property AutPedido() As Boolean
        Get
            Return _AutPedido
        End Get
        Set(ByVal value As Boolean)
            _AutPedido = value
        End Set
    End Property
    Public Property DestajosAvance() As Boolean
        Get
            Return _DestajosAvance
        End Get
        Set(ByVal value As Boolean)
            _DestajosAvance = value
        End Set
    End Property
    Public Property ValidadSuPedido() As Boolean
        Get
            Return _ValidadSuPedido
        End Get
        Set(ByVal value As Boolean)
            _ValidadSuPedido = value
        End Set
    End Property
    Public Property EntregaParcial() As Boolean
        Get
            Return _EntregaParcial
        End Get
        Set(ByVal value As Boolean)
            _EntregaParcial = value
        End Set
    End Property
    Public Property CalculoDesperdicio() As Boolean
        Get
            Return _CalculoDesperdicio
        End Get
        Set(ByVal value As Boolean)
            _CalculoDesperdicio = value
        End Set
    End Property
    Public Property ManejaTenerias() As Boolean
        Get
            Return _ManejaTenerias
        End Get
        Set(ByVal value As Boolean)
            _ManejaTenerias = value
        End Set
    End Property
    Public Property PedProdAutorizado() As Boolean
        Get
            Return _PedProdAutorizado
        End Get
        Set(ByVal value As Boolean)
            _PedProdAutorizado = value
        End Set
    End Property
    Public Property MinutosSemanales() As Integer
        Get
            Return _MinutosSemanales
        End Get
        Set(ByVal value As Integer)
            _MinutosSemanales = value
        End Set
    End Property
    Public Property hcCarga() As Boolean
        Get
            Return _hcCarga
        End Get
        Set(ByVal value As Boolean)
            _hcCarga = value
        End Set
    End Property
    Public Property hcDerivados() As Boolean
        Get
            Return _hcDerivados
        End Get
        Set(ByVal value As Boolean)
            _hcDerivados = value
        End Set
    End Property
    Public Property hcFormulas() As Boolean
        Get
            Return _hcFormulas
        End Get
        Set(ByVal value As Boolean)
            _hcFormulas = value
        End Set
    End Property
    Public Property hcMateriales() As Boolean
        Get
            Return _hcMateriales
        End Get
        Set(ByVal value As Boolean)
            _hcMateriales = value
        End Set
    End Property
    Public Property rptFormulas() As String
        Get
            Return _rptFormulas
        End Get
        Set(ByVal value As String)
            _rptFormulas = value
        End Set
    End Property
    Public Property avancePorProceso() As Boolean
        Get
            Return _avancePorProceso
        End Get
        Set(ByVal value As Boolean)
            _avancePorProceso = value
        End Set
    End Property
    Public Property dividirLote() As Boolean
        Get
            Return _dividirLote
        End Get
        Set(ByVal value As Boolean)
            _dividirLote = value
        End Set
    End Property
    Public Property avanceNoValidarProg() As Boolean
        Get
            Return _avanceNoValidarProg
        End Get
        Set(ByVal value As Boolean)
            _avanceNoValidarProg = value
        End Set
    End Property
    Public Property rptPreasignacion() As String
        Get
            Return _rptPreasignacion
        End Get
        Set(ByVal value As String)
            _rptPreasignacion = value
        End Set
    End Property
    Public Property Tabla7() As String
        Get
            Return _Tabla7
        End Get
        Set(ByVal value As String)
            _Tabla7 = value
        End Set
    End Property
    Public Property Tabla8() As String
        Get
            Return _Tabla8
        End Get
        Set(ByVal value As String)
            _Tabla8 = value
        End Set
    End Property
    Public Property Tabla9() As String
        Get
            Return _Tabla9
        End Get
        Set(ByVal value As String)
            _Tabla9 = value
        End Set
    End Property
    Public Property Tabla10() As String
        Get
            Return _Tabla10
        End Get
        Set(ByVal value As String)
            _Tabla10 = value
        End Set
    End Property


    Public Property Tabla11() As String
        Get
            Return _Tabla11
        End Get
        Set(ByVal value As String)
            _Tabla11 = value
        End Set
    End Property


    Public Property Tabla12() As String
        Get
            Return _Tabla12
        End Get
        Set(ByVal value As String)
            _Tabla12 = value
        End Set
    End Property
    Public Property rptExplosionFormulas() As String
        Get
            Return _rptExplosionFormulas
        End Get
        Set(ByVal value As String)
            _rptExplosionFormulas = value
        End Set
    End Property
    Public Property editarCantidadDestajo() As Boolean
        Get
            Return _editarCantidadDestajo
        End Get
        Set(ByVal value As Boolean)
            _editarCantidadDestajo = value
        End Set
    End Property
    Public Property editarCostoDestaje() As Boolean
        Get
            Return _editarCostoDestaje
        End Get
        Set(ByVal value As Boolean)
            _editarCostoDestaje = value
        End Set
    End Property


End Class
