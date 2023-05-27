Public Class frm_atualizar_combustivel
    Private Sub frm_atualizar_combustivel_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_combustivel.Text = combustivelSelecao
        txt_nome.Text = combustivelSelecao
        lbl_preco.Text = "R$00,00"
        lbl_qtde.Text = "0 litros"
        txt_preco.Text = "00"
        txt_qtde.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Me.Close()
    End Sub

End Class