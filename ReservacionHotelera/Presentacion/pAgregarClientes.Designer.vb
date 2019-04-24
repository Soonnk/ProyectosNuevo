Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pAgregarClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.grconClientes = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.txtPais = New DevExpress.XtraEditors.TextEdit()
        Me.txtEstado = New DevExpress.XtraEditors.TextEdit()
        Me.txtMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellido = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.grconClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grconClientes.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.btnCancelar)
        Me.LayoutControl3.Controls.Add(Me.grconClientes)
        Me.LayoutControl3.Controls.Add(Me.btnGuardar)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(550, 298)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(446, 274)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 22)
        Me.btnCancelar.StyleController = Me.LayoutControl3
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        '
        'grconClientes
        '
        Me.grconClientes.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grconClientes.Appearance.Options.UseFont = True
        Me.grconClientes.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grconClientes.AppearanceCaption.Options.UseFont = True
        Me.grconClientes.Controls.Add(Me.LayoutControl4)
        Me.grconClientes.Location = New System.Drawing.Point(2, 2)
        Me.grconClientes.Name = "grconClientes"
        Me.grconClientes.Size = New System.Drawing.Size(546, 268)
        Me.grconClientes.TabIndex = 4
        Me.grconClientes.Text = "Formulario Clientes"
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.txtTelefono)
        Me.LayoutControl4.Controls.Add(Me.txtCorreo)
        Me.LayoutControl4.Controls.Add(Me.txtPais)
        Me.LayoutControl4.Controls.Add(Me.txtEstado)
        Me.LayoutControl4.Controls.Add(Me.txtMunicipio)
        Me.LayoutControl4.Controls.Add(Me.txtDireccion)
        Me.LayoutControl4.Controls.Add(Me.txtApellido)
        Me.LayoutControl4.Controls.Add(Me.txtNombre)
        Me.LayoutControl4.Controls.Add(Me.txtId)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(2, 20)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(615, 201, 450, 400)
        Me.LayoutControl4.Root = Me.LayoutControlGroup4
        Me.LayoutControl4.Size = New System.Drawing.Size(542, 246)
        Me.LayoutControl4.TabIndex = 0
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(366, 126)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(174, 20)
        Me.txtTelefono.StyleController = Me.LayoutControl4
        Me.txtTelefono.TabIndex = 12
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(366, 102)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(174, 20)
        Me.txtCorreo.StyleController = Me.LayoutControl4
        Me.txtCorreo.TabIndex = 11
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(66, 150)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(232, 20)
        Me.txtPais.StyleController = Me.LayoutControl4
        Me.txtPais.TabIndex = 10
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(66, 126)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(232, 20)
        Me.txtEstado.StyleController = Me.LayoutControl4
        Me.txtEstado.TabIndex = 9
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(66, 102)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(232, 20)
        Me.txtMunicipio.StyleController = Me.LayoutControl4
        Me.txtMunicipio.TabIndex = 8
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(66, 78)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(232, 20)
        Me.txtDireccion.StyleController = Me.LayoutControl4
        Me.txtDireccion.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(317, 26)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(223, 20)
        Me.txtApellido.StyleController = Me.LayoutControl4
        Me.txtApellido.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(66, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(183, 20)
        Me.txtNombre.StyleController = Me.LayoutControl4
        Me.txtNombre.TabIndex = 5
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(66, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(130, 20)
        Me.txtId.StyleController = Me.LayoutControl4
        Me.txtId.TabIndex = 4
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.EmptySpaceItem3, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem6, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.EmptySpaceItem4, Me.EmptySpaceItem7})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(542, 246)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtId
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem8.Text = "Clave cliente"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtNombre
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem9.Text = "Nombre"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtDireccion
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(300, 24)
        Me.LayoutControlItem11.Text = "Dirección"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(198, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(344, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtApellido
        Me.LayoutControlItem10.Location = New System.Drawing.Point(251, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(291, 24)
        Me.LayoutControlItem10.Text = "Apellido"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtMunicipio
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(300, 24)
        Me.LayoutControlItem12.Text = "Municipio"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtEstado
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(300, 24)
        Me.LayoutControlItem13.Text = "Estado"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtPais
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(300, 24)
        Me.LayoutControlItem14.Text = "País"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(300, 76)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(242, 24)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtCorreo
        Me.LayoutControlItem15.Location = New System.Drawing.Point(300, 100)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem15.Text = "Correo"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtTelefono
        Me.LayoutControlItem16.Location = New System.Drawing.Point(300, 124)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(242, 48)
        Me.LayoutControlItem16.Text = "Teléfono"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(542, 28)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 172)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(542, 74)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(336, 274)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(106, 22)
        Me.btnGuardar.StyleController = Me.LayoutControl3
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.EmptySpaceItem8})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(550, 298)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.grconClientes
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(550, 272)
        Me.LayoutControlItem7.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.btnGuardar
        Me.LayoutControlItem17.Location = New System.Drawing.Point(334, 272)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(110, 26)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.btnCancelar
        Me.LayoutControlItem18.Location = New System.Drawing.Point(444, 272)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(106, 26)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 272)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(334, 26)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'pAgregarClientes
        '
        Me.ClientSize = New System.Drawing.Size(550, 298)
        Me.Controls.Add(Me.LayoutControl3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pAgregarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.grconClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grconClientes.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As EmptySpaceItem
    Friend WithEvents TextEdit5 As TextEdit
    Friend WithEvents TextEdit4 As TextEdit
    Friend WithEvents TextEdit3 As TextEdit
    Friend WithEvents TextEdit2 As TextEdit
    Friend WithEvents LayoutControlItem3 As LayoutControlItem
    Friend WithEvents LayoutControlItem4 As LayoutControlItem
    Friend WithEvents LayoutControlItem5 As LayoutControlItem
    Friend WithEvents LayoutControlItem6 As LayoutControlItem
    Friend WithEvents LayoutControl3 As LayoutControl
    Friend WithEvents grconClientes As GroupControl
    Friend WithEvents LayoutControl4 As LayoutControl
    Friend WithEvents LayoutControlGroup4 As LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As LayoutControlItem
    Friend WithEvents txtNombre As TextEdit
    Friend WithEvents txtId As TextEdit
    Friend WithEvents LayoutControlItem8 As LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As LayoutControlItem
    Friend WithEvents txtDireccion As TextEdit
    Friend WithEvents txtApellido As TextEdit
    Friend WithEvents LayoutControlItem10 As LayoutControlItem
    Friend WithEvents LayoutControlItem11 As LayoutControlItem
    Friend WithEvents txtMunicipio As TextEdit
    Friend WithEvents LayoutControlItem12 As LayoutControlItem
    Friend WithEvents txtCorreo As TextEdit
    Friend WithEvents txtPais As TextEdit
    Friend WithEvents txtEstado As TextEdit
    Friend WithEvents LayoutControlItem13 As LayoutControlItem
    Friend WithEvents LayoutControlItem14 As LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As EmptySpaceItem
    Friend WithEvents LayoutControlItem15 As LayoutControlItem
    Friend WithEvents txtTelefono As TextEdit
    Friend WithEvents LayoutControlItem16 As LayoutControlItem
    Friend WithEvents btnGuardar As SimpleButton
    Friend WithEvents EmptySpaceItem4 As EmptySpaceItem
    Friend WithEvents btnCancelar As SimpleButton
    Friend WithEvents EmptySpaceItem7 As EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As LayoutControlItem
    Friend WithEvents LayoutControlItem18 As LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As EmptySpaceItem
End Class
