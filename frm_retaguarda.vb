Public Class frm_retaguarda
    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        If cmb_combustivel.SelectedItem = "" Then
            MsgBox("Informe o tipo de combustível!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        Else
            combustivelSelecao = cmb_combustivel.SelectedItem
            frm_atualizar_combustivel.Show()
            Me.Close()
        End If
    End Sub
End Class