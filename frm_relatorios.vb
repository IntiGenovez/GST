Public Class frm_relatorios
    Private Sub btn_relat_Click(sender As Object, e As EventArgs) Handles btn_relat.Click

        app.OpenCurrentDatabase(dir_banco)
        If cmb_relat.Text = "Clientes" Then
            app.DoCmd.OpenReport("relat", Microsoft.Office.Interop.Access.AcView.acViewPreview)
        ElseIf cmb_relat.Text = "Vendas" Then
            app.DoCmd.OpenReport("relat", Microsoft.Office.Interop.Access.AcView.acViewPreview)
        ElseIf cmb_relat.Text = "Combustíveis" Then
            app.DoCmd.OpenReport("relat", Microsoft.Office.Interop.Access.AcView.acViewPreview)
        End If
        app.DoCmd.Maximize()
    End Sub

    Private Sub frm_relatorios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        app.CloseCurrentDatabase()
    End Sub
End Class