Public Class CONSULTA
    Dim func As New Consultar
    Dim dt As New DataTable
    Private Sub CONSULTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub mostrar1()
        Try
            Dim func As New Consultar
            dt = func.FnConsultar

            If dt.Rows.Count <> 0 Then
                dgvConsulta.DataSource = dt
            Else
                dgvConsulta.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        mostrar1()
        btnSalir.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        frmPRINCIPAL.Show()
    End Sub
End Class