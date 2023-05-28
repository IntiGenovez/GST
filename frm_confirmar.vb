Public Class frm_confirmar
    Private Sub txt_corrigir_Click(sender As Object, e As EventArgs) Handles txt_corrigir.Click
        frm_vendas.txt_cpf.Focus()
        Me.Close()
    End Sub

    Private Sub txt_cadastrar_Click(sender As Object, e As EventArgs) Handles txt_cadastrar.Click
        isUpdate = False
        frm_cadastro.Show()
    End Sub

    Private Sub frm_confirmar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frm_vendas.Show()
    End Sub
End Class