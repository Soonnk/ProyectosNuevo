<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pConsultarClientes
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IdCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Apellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Municipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Pais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Correo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 450)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(800, 450)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IdCliente, Me.Nombre, Me.Apellido, Me.Direccion, Me.Municipio, Me.Estado, Me.Pais, Me.Telefono, Me.Correo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'IdCliente
        '
        Me.IdCliente.Caption = "idCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.Visible = True
        Me.IdCliente.VisibleIndex = 0
        '
        'Nombre
        '
        Me.Nombre.Caption = "nombre"
        Me.Nombre.FieldName = "nombre"
        Me.Nombre.FieldNameSortGroup = "nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        '
        'Apellido
        '
        Me.Apellido.Caption = "apellido"
        Me.Apellido.FieldName = "apellido"
        Me.Apellido.FieldNameSortGroup = "apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Visible = True
        Me.Apellido.VisibleIndex = 2
        '
        'Direccion
        '
        Me.Direccion.Caption = "direccion"
        Me.Direccion.FieldName = "direccion"
        Me.Direccion.FieldNameSortGroup = "direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Visible = True
        Me.Direccion.VisibleIndex = 3
        '
        'Municipio
        '
        Me.Municipio.Caption = "municipio"
        Me.Municipio.FieldName = "municipio"
        Me.Municipio.FieldNameSortGroup = "municipio"
        Me.Municipio.Name = "Municipio"
        Me.Municipio.Visible = True
        Me.Municipio.VisibleIndex = 4
        '
        'Estado
        '
        Me.Estado.Caption = "estado"
        Me.Estado.FieldName = "estado"
        Me.Estado.FieldNameSortGroup = "estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Visible = True
        Me.Estado.VisibleIndex = 5
        '
        'Pais
        '
        Me.Pais.Caption = "pais"
        Me.Pais.FieldName = "pais"
        Me.Pais.FieldNameSortGroup = "pais"
        Me.Pais.Name = "Pais"
        Me.Pais.Visible = True
        Me.Pais.VisibleIndex = 6
        '
        'Telefono
        '
        Me.Telefono.Caption = "telefono"
        Me.Telefono.FieldName = "telefono"
        Me.Telefono.FieldNameSortGroup = "telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Visible = True
        Me.Telefono.VisibleIndex = 7
        '
        'Correo
        '
        Me.Correo.Caption = "correo"
        Me.Correo.FieldName = "correo"
        Me.Correo.FieldNameSortGroup = "correo"
        Me.Correo.Name = "Correo"
        Me.Correo.Visible = True
        Me.Correo.VisibleIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(800, 450)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(800, 450)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'pConsultarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "pConsultarClientes"
        Me.Text = "pConsultarClientes"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Apellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Municipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Correo As DevExpress.XtraGrid.Columns.GridColumn
End Class
