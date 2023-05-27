Imports System.Threading
Public Class Form1
    Private Sub btn_retaguarda_Click(sender As Object, e As EventArgs) Handles btn_retaguarda.Click
        frm_retaguarda.Show()
        Me.Close()
    End Sub

    Private Sub btn_venda_Click(sender As Object, e As EventArgs) Handles btn_venda.Click
        frm_selecao.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        conectar_banco()
    End Sub
End Class
