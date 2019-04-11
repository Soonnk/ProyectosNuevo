<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pAgregarReservaciones
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.gridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
        Me.cmbFormaPago = New DevExpress.XtraScheduler.UI.ResourcesComboBoxControl()
        Me.tpkSalida = New DevExpress.XtraEditors.TimeEdit()
        Me.tpkLlegada = New DevExpress.XtraEditors.TimeEdit()
        Me.dtpSalida = New DevExpress.XtraEditors.DateEdit()
        Me.dtpLlegada = New DevExpress.XtraEditors.DateEdit()
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.cmbHabitacion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.gridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tpkSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tpkLlegada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSalida.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpLlegada.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpLlegada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbHabitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GroupControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(537, 450)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LayoutControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(513, 426)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Reservacion"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.gridDetalle)
        Me.LayoutControl2.Controls.Add(Me.btnGuardar)
        Me.LayoutControl2.Controls.Add(Me.btnAgregar)
        Me.LayoutControl2.Controls.Add(Me.lblTotal)
        Me.LayoutControl2.Controls.Add(Me.cmbFormaPago)
        Me.LayoutControl2.Controls.Add(Me.tpkSalida)
        Me.LayoutControl2.Controls.Add(Me.tpkLlegada)
        Me.LayoutControl2.Controls.Add(Me.dtpSalida)
        Me.LayoutControl2.Controls.Add(Me.dtpLlegada)
        Me.LayoutControl2.Controls.Add(Me.txtId)
        Me.LayoutControl2.Controls.Add(Me.cmbHabitacion)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(2, 20)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(509, 404)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'gridDetalle
        '
        Me.gridDetalle.Location = New System.Drawing.Point(12, 134)
        Me.gridDetalle.MainView = Me.GridView1
        Me.gridDetalle.Name = "gridDetalle"
        Me.gridDetalle.Size = New System.Drawing.Size(485, 215)
        Me.gridDetalle.TabIndex = 13
        Me.gridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.gridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripcion"
        Me.GridColumn2.FieldName = "descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 248
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Precio"
        Me.GridColumn3.FieldName = "precioPorNoche"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 55
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Total de Noches"
        Me.GridColumn4.FieldName = "noches"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 90
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Subtotal"
        Me.GridColumn5.FieldName = "subtotal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 74
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 370)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(485, 22)
        Me.btnGuardar.StyleController = Me.LayoutControl2
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(426, 108)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(71, 22)
        Me.btnAgregar.StyleController = Me.LayoutControl2
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        '
        'lblTotal
        '
        Me.lblTotal.LineVisible = True
        Me.lblTotal.Location = New System.Drawing.Point(473, 353)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(24, 13)
        Me.lblTotal.StyleController = Me.LayoutControl2
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.Location = New System.Drawing.Point(114, 84)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFormaPago.Size = New System.Drawing.Size(383, 20)
        Me.cmbFormaPago.StyleController = Me.LayoutControl2
        Me.cmbFormaPago.TabIndex = 6
        '
        'tpkSalida
        '
        Me.tpkSalida.EditValue = New Date(2019, 4, 10, 0, 0, 0, 0)
        Me.tpkSalida.Location = New System.Drawing.Point(408, 60)
        Me.tpkSalida.Name = "tpkSalida"
        Me.tpkSalida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tpkSalida.Size = New System.Drawing.Size(89, 20)
        Me.tpkSalida.StyleController = Me.LayoutControl2
        Me.tpkSalida.TabIndex = 5
        '
        'tpkLlegada
        '
        Me.tpkLlegada.EditValue = New Date(2019, 4, 10, 0, 0, 0, 0)
        Me.tpkLlegada.Location = New System.Drawing.Point(408, 36)
        Me.tpkLlegada.Name = "tpkLlegada"
        Me.tpkLlegada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tpkLlegada.Size = New System.Drawing.Size(89, 20)
        Me.tpkLlegada.StyleController = Me.LayoutControl2
        Me.tpkLlegada.TabIndex = 3
        '
        'dtpSalida
        '
        Me.dtpSalida.EditValue = Nothing
        Me.dtpSalida.Location = New System.Drawing.Point(114, 60)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpSalida.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpSalida.Size = New System.Drawing.Size(188, 20)
        Me.dtpSalida.StyleController = Me.LayoutControl2
        Me.dtpSalida.TabIndex = 4
        '
        'dtpLlegada
        '
        Me.dtpLlegada.EditValue = Nothing
        Me.dtpLlegada.Location = New System.Drawing.Point(114, 36)
        Me.dtpLlegada.Name = "dtpLlegada"
        Me.dtpLlegada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpLlegada.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpLlegada.Size = New System.Drawing.Size(188, 20)
        Me.dtpLlegada.StyleController = Me.LayoutControl2
        Me.dtpLlegada.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(114, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(138, 20)
        Me.txtId.StyleController = Me.LayoutControl2
        Me.txtId.TabIndex = 1
        '
        'cmbHabitacion
        '
        Me.cmbHabitacion.Location = New System.Drawing.Point(114, 108)
        Me.cmbHabitacion.Name = "cmbHabitacion"
        Me.cmbHabitacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbHabitacion.Size = New System.Drawing.Size(308, 20)
        Me.cmbHabitacion.StyleController = Me.LayoutControl2
        Me.cmbHabitacion.TabIndex = 7
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem12, Me.LayoutControlItem9, Me.LayoutControlItem13})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(509, 404)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtId
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(244, 24)
        Me.LayoutControlItem2.Text = "Folio de Reservacion"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtpLlegada
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem4.Text = "Fecha de Llegada"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtpSalida
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem5.Text = "Fecha de Salida"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.tpkLlegada
        Me.LayoutControlItem6.Location = New System.Drawing.Point(294, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem6.Text = "Hora de Llegada"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.tpkSalida
        Me.LayoutControlItem7.Location = New System.Drawing.Point(294, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem7.Text = "Hora de Salida"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmbFormaPago
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(489, 24)
        Me.LayoutControlItem8.Text = "Forma de Pago"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmbHabitacion
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(414, 26)
        Me.LayoutControlItem11.Text = "Habitacion"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnAgregar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(414, 96)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(75, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(244, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(245, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 341)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(461, 17)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnGuardar
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 358)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(489, 26)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.lblTotal
        Me.LayoutControlItem9.Location = New System.Drawing.Point(461, 341)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(28, 17)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.gridDetalle
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(489, 219)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(537, 450)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GroupControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(517, 430)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'pAgregarReservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "pAgregarReservaciones"
        Me.Text = "pReservaciones"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.gridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tpkSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tpkLlegada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSalida.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpLlegada.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpLlegada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbHabitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dtpLlegada As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tpkSalida As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents tpkLlegada As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dtpSalida As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbFormaPago As DevExpress.XtraScheduler.UI.ResourcesComboBoxControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbHabitacion As DevExpress.XtraEditors.ComboBoxEdit
End Class
