Public Class frm_relatorios
    Private Sub frm_relatorios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            app.OpenCurrentDatabase(dir_banco)
        Catch
        End Try
    End Sub
    Private Sub btn_relat_Click(sender As Object, e As EventArgs) Handles btn_relat.Click
        Try
            If cmb_relat.Text = "Clientes" Then
            app.DoCmd.OpenReport("relat_clientes", Microsoft.Office.Interop.Access.AcView.acViewReport)
        ElseIf cmb_relat.Text = "Vendas" Then
            app.DoCmd.OpenReport("relat_vendas", Microsoft.Office.Interop.Access.AcView.acViewReport)
        ElseIf cmb_relat.Text = "Combustíveis" Then
            app.DoCmd.OpenReport("relat_comb", Microsoft.Office.Interop.Access.AcView.acViewReport)
        End If
            app.DoCmd.Maximize()
        Catch
        End Try
    End Sub

    Private Sub frm_relatorios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            app.CloseCurrentDatabase()
        Catch
        End Try
    End Sub
End Class