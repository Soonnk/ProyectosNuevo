<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnEmpresas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSistemas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMagnusERP = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMagnusCONTA = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSIMAC = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMagnusGo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.btnActividades = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNuevoSuperior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditarSuperior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelarSuperior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardarSuperior = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnEmpresas, Me.btnSistemas, Me.btnMagnusERP, Me.btnMagnusCONTA, Me.btnSIMAC, Me.btnMagnusGo, Me.btnUsuarios, Me.btnActividades, Me.btnNuevoSuperior, Me.btnEditarSuperior, Me.btnCancelarSuperior, Me.btnGuardarSuperior})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.btnNuevoSuperior)
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.btnEditarSuperior)
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.btnGuardarSuperior)
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.btnCancelarSuperior)
        Me.RibbonControl1.Size = New System.Drawing.Size(800, 141)
        '
        'btnEmpresas
        '
        Me.btnEmpresas.Caption = "Empresas"
        Me.btnEmpresas.Id = 1
        Me.btnEmpresas.ImageOptions.LargeImage = CType(resources.GetObject("btnEmpresas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEmpresas.Name = "btnEmpresas"
        Me.btnEmpresas.Tag = CType(1110, Short)
        '
        'btnSistemas
        '
        Me.btnSistemas.Caption = "Sistemas"
        Me.btnSistemas.Id = 2
        Me.btnSistemas.ImageOptions.LargeImage = CType(resources.GetObject("btnSistemas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSistemas.Name = "btnSistemas"
        Me.btnSistemas.Tag = CType(1120, Short)
        '
        'btnMagnusERP
        '
        Me.btnMagnusERP.Caption = "Magnus ERP"
        Me.btnMagnusERP.Id = 3
        Me.btnMagnusERP.ImageOptions.LargeImage = CType(resources.GetObject("btnMagnusERP.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMagnusERP.Name = "btnMagnusERP"
        Me.btnMagnusERP.Tag = CType(1210, Short)
        '
        'btnMagnusCONTA
        '
        Me.btnMagnusCONTA.Caption = "Magnus CONTA"
        Me.btnMagnusCONTA.Id = 4
        Me.btnMagnusCONTA.ImageOptions.LargeImage = CType(resources.GetObject("btnMagnusCONTA.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMagnusCONTA.Name = "btnMagnusCONTA"
        Me.btnMagnusCONTA.Tag = CType(1220, Short)
        '
        'btnSIMAC
        '
        Me.btnSIMAC.Caption = "SIMAC"
        Me.btnSIMAC.Id = 5
        Me.btnSIMAC.ImageOptions.LargeImage = CType(resources.GetObject("btnSIMAC.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSIMAC.Name = "btnSIMAC"
        Me.btnSIMAC.Tag = CType(1230, Short)
        '
        'btnMagnusGo
        '
        Me.btnMagnusGo.Caption = "Magnus Go!"
        Me.btnMagnusGo.Id = 6
        Me.btnMagnusGo.ImageOptions.LargeImage = CType(resources.GetObject("btnMagnusGo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMagnusGo.Name = "btnMagnusGo"
        Me.btnMagnusGo.Tag = CType(1240, Short)
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Caption = "Usuarios"
        Me.btnUsuarios.Id = 7
        Me.btnUsuarios.ImageOptions.Image = CType(resources.GetObject("btnUsuarios.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageOptions.LargeImage = CType(resources.GetObject("btnUsuarios.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUsuarios.Name = "btnUsuarios"
        '
        'btnActividades
        '
        Me.btnActividades.Caption = "Actividades"
        Me.btnActividades.Id = 8
        Me.btnActividades.ImageOptions.LargeImage = CType(resources.GetObject("btnActividades.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnActividades.Name = "btnActividades"
        '
        'btnNuevoSuperior
        '
        Me.btnNuevoSuperior.Caption = "Nuevo"
        Me.btnNuevoSuperior.Id = 9
        Me.btnNuevoSuperior.ImageOptions.Image = CType(resources.GetObject("btnNuevoSuperior.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevoSuperior.ImageOptions.LargeImage = CType(resources.GetObject("btnNuevoSuperior.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNuevoSuperior.Name = "btnNuevoSuperior"
        '
        'btnEditarSuperior
        '
        Me.btnEditarSuperior.Caption = "Editar"
        Me.btnEditarSuperior.Id = 10
        Me.btnEditarSuperior.ImageOptions.Image = CType(resources.GetObject("btnEditarSuperior.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditarSuperior.ImageOptions.LargeImage = CType(resources.GetObject("btnEditarSuperior.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEditarSuperior.Name = "btnEditarSuperior"
        '
        'btnCancelarSuperior
        '
        Me.btnCancelarSuperior.Caption = "Cancelar"
        Me.btnCancelarSuperior.Id = 11
        Me.btnCancelarSuperior.ImageOptions.Image = CType(resources.GetObject("btnCancelarSuperior.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelarSuperior.ImageOptions.LargeImage = CType(resources.GetObject("btnCancelarSuperior.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCancelarSuperior.Name = "btnCancelarSuperior"
        '
        'btnGuardarSuperior
        '
        Me.btnGuardarSuperior.Caption = "Guardar"
        Me.btnGuardarSuperior.Id = 12
        Me.btnGuardarSuperior.ImageOptions.Image = CType(resources.GetObject("btnGuardarSuperior.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardarSuperior.ImageOptions.LargeImage = CType(resources.GetObject("btnGuardarSuperior.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnGuardarSuperior.Name = "btnGuardarSuperior"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = CType(1000, Short)
        Me.RibbonPage1.Text = "Configuración"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEmpresas)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSistemas)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Tag = CType(1100, Short)
        Me.RibbonPageGroup1.Text = "Empresas"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnMagnusERP)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnMagnusCONTA)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSIMAC)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnMagnusGo)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Tag = CType(1200, Short)
        Me.RibbonPageGroup2.Text = "Sistemas"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Tag = CType(2000, Short)
        Me.RibbonPage2.Text = "Usuarios"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnUsuarios)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnActividades)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Usuario"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "mdiPrincipal"
        Me.Text = "Usuarios y Configuración"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnEmpresas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSistemas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMagnusERP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMagnusCONTA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSIMAC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMagnusGo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnActividades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnNuevoSuperior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditarSuperior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelarSuperior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardarSuperior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
End Class
