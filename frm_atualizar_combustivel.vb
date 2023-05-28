Public Class frm_atualizar_combustivel
    Private Sub frm_atualizar_combustivel_Load(sender As Object, e As EventArgs) Handles Me.Load
        idCombustivel = rs.Fields(0).Value
        lbl_combustivel.Text = rs.Fields(1).Value
        txt_nome.Text = rs.Fields(1).Value
        lbl_preco.Text = rs.Fields(2).Value
        txt_preco.Text = rs.Fields(2).Value
        lbl_qtde.Text = rs.Fields(3).Value
        If rs.Fields(4).Value = "Ativo" Then
            cmb_status.SelectedIndex = 0
        Else
            cmb_status.SelectedIndex = 1
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If (txt_nome.Text = "" Or txt_preco.Text = "") Or (cmb_tipo.Text = "" And txt_qtde.Text <> "") Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            Exit Sub
        End If

        If txt_qtde.Text <> "" Then
            sql = "update tb_combustivel set nome = '" & txt_nome.Text &
                "', preco=" & txt_preco.Text &
                ", qtde=" & lbl_qtde.Text - txt_qtde.Text &
                ", status='" & cmb_status.Text &
                "' where id_comb = " & idCombustivel
        Else
            sql = "update tb_combustivel set nome = '" & txt_nome.Text &
                "', preco=" & txt_preco.Text &
                ", status='" & cmb_status.Text &
                "' where id_comb = " & idCombustivel
        End If
        db.Execute(sql)
        carregar_combustivel()
        Me.Close()
    End Sub

End Class