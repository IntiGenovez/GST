Imports System.Threading
Public Class Form1
    Private Sub btn_retaguarda_Click(sender As Object, e As EventArgs) Handles btn_retaguarda.Click
        Try
            frm_retaguarda.Show()
            Me.Close()
        Catch
        End Try
    End Sub

    Private Sub btn_venda_Click(sender As Object, e As EventArgs) Handles btn_venda.Click
        Try
            frm_selecao.Show()
            Me.Close()
        Catch
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conectar_banco()
        Catch
        End Try
    End Sub
End Class
