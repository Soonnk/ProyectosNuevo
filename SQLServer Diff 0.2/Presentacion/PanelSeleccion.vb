Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtURL1.Enabled = False
        txtURL2.Enabled = False

        txtURL1.Text = ""
        txtURL2.Text = ""
        txtUsuario1.Text = ""
        txtUsuario2.Text = ""
        txtPass1.Text = ""
        txtPass2.Text = ""

        LlenarServidores()
    End Sub

    Private Sub cmbDB1_Click(sender As Object, e As EventArgs) Handles cmbDB1.Click
        If (Not txtURL1.EditValue.Equals("") And Not txtUsuario1.EditValue.Equals("") And Not txtPass1.EditValue.Equals("")) Then
            LlenarDBs(sender)
        Else
            MsgBox("Faltan campos para conectar con el servidor")
        End If
    End Sub

    Private Sub cmbDB2_Click(sender As Object, e As EventArgs) Handles cmbDB2.Click
        If (Not txtURL2.EditValue.Equals("") And Not txtUsuario2.EditValue.Equals("") And Not txtPass2.EditValue.Equals("")) Then
            LlenarDBs(sender)
        Else
            MsgBox("Faltan campos para conectar con el servidor")
        End If
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim ventanaComparador = New DiffPrincipal()
        ventanaComparador.ConexionModelo = New Negocio.Loader.Conexion(
            txtURL1.EditValue.ToString(),
            txtUsuario1.EditValue.ToString(),
            txtPass1.EditValue.ToString(),
            cmbDB1.SelectedText
        )
        ventanaComparador.ConexionDestino = New Negocio.Loader.Conexion(
            txtURL2.EditValue.ToString(),
            txtUsuario2.EditValue.ToString(),
            txtPass2.EditValue.ToString(),
            cmbDB2.SelectedText
        )
        ventanaComparador.Show()
        ventanaComparador.Padre = Me
        Me.Hide()
    End Sub

    Private Sub LlenarServidores()
        Dim instancias = Negocio.Loader.CargarInstanciasLocales

        cmbServidor1.Properties.BeginUpdate()
        cmbServidor2.Properties.BeginUpdate()

        cmbServidor1.Properties.Items.AddRange(instancias)
        cmbServidor2.Properties.Items.AddRange(instancias)

        cmbServidor1.Properties.Items.Add("Servidor Remoto")
        cmbServidor2.Properties.Items.Add("Servidor Remoto")

        cmbServidor1.Properties.EndUpdate()
        cmbServidor2.Properties.EndUpdate()
    End Sub

    Private Sub LlenarDBs(sender As Object)
        Try
            Dim con = New Negocio.Loader.Conexion(txtURL1.EditValue.ToString, txtUsuario1.EditValue.ToString, txtPass1.EditValue.ToString)

            Dim lista As String() = Negocio.Loader.CargarDatabases(con)

            Dim cmb As DevExpress.XtraEditors.ComboBoxEdit = CType(sender, DevExpress.XtraEditors.ComboBoxEdit)

            cmb.Properties.Items.Clear()

            cmb.Properties.Items.AddRange(lista)

            cmb.ShowPopup()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbServidor1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServidor1.SelectedIndexChanged
        If cmbServidor1.SelectedText.Equals("Servidor Remoto") Then
            txtURL1.Text = ""
            txtURL1.Enabled = True
        Else
            txtURL1.Text = cmbServidor1.SelectedText
            txtURL1.Enabled = False
        End If
    End Sub

    Private Sub cmbServidor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServidor2.SelectedIndexChanged
        If cmbServidor2.SelectedText.Equals("Servidor Remoto") Then
            txtURL2.Text = ""
            txtURL2.Enabled = True
        Else
            txtURL2.Text = cmbServidor1.SelectedText
            txtURL2.Enabled = False
        End If
    End Sub

    Private Sub cmbDB1_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDB1.KeyDown
        If e.KeyCode = Keys.Down Then
            If (cmbDB1.Properties.Items.Count < 1) Then
                LlenarDBs(cmbDB1)
            End If
        End If
    End Sub
    Private Sub cmbDB2_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDB2.KeyDown
        If e.KeyCode = Keys.Down Then
            If (cmbDB2.Properties.Items.Count < 1) Then
                LlenarDBs(cmbDB2)
            End If
        End If
    End Sub
End Class