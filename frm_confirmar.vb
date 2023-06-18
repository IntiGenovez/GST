Public Class frm_confirmar
    Private Sub txt_corrigir_Click(sender As Object, e As EventArgs) Handles txt_corrigir.Click
        Try
            frm_vendas.txt_cpf.Focus()
            Me.Close()
        Catch
        End Try
    End Sub

    Private Sub txt_cadastrar_Click(sender As Object, e As EventArgs) Handles txt_cadastrar.Click
        Try
            isUpdate = False
            frm_cadastro.Show()
        Catch
        End Try
    End Sub

    Private Sub frm_confirmar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            frm_vendas.Show()
        Catch
        End Try
    End Sub
End Class