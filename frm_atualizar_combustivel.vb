Public Class frm_atualizar_combustivel
    Private Sub frm_atualizar_combustivel_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_nome.Text = ""
        txt_preco.Text = ""
        txt_qtde.Text = ""
        If isUpdate Then
            idCombustivel = rs.Fields(0).Value
            lbl_combustivel.Text = rs.Fields(1).Value
            txt_nome.Text = rs.Fields(1).Value
            lbl_preco.Text = rs.Fields(2).Value
            txt_preco.Text = rs.Fields(2).Value
            lbl_qtde.Text = rs.Fields(3).Value
            If rs.Fields(4).Value = 1 Then
                cmb_status.SelectedIndex = 0
            Else
                cmb_status.SelectedIndex = 1
            End If
        Else
            cmb_tipo.Enabled = False
            cmb_tipo.SelectedIndex = 1
            cmb_status.Enabled = False
            cmb_status.SelectedIndex = 0
            lbl_combustivel.Text = ""
            lbl_preco.Text = ""
            lbl_qtde.Text = ""
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If isUpdate Then
            Dim novoCombustivel As Double
            If (txt_nome.Text = "" Or txt_preco.Text = "") Or (cmb_tipo.Text = "" And txt_qtde.Text <> "") Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If
            If cmb_tipo.Text = "Perda" Then
                novoCombustivel = lbl_qtde.Text - txt_qtde.Text
            Else
                novoCombustivel = lbl_qtde.Text + txt_qtde.Text
            End If

            If txt_qtde.Text <> "" Then
                sql = "update tb_combustivel set nome = '" & txt_nome.Text &
                "', preco=" & txt_preco.Text &
                ", qtde=" & novoCombustivel &
                ", status='" & cmb_status.SelectedIndex + 1 &
                "' where id_comb = " & idCombustivel
            Else
                sql = "update tb_combustivel set nome = '" & txt_nome.Text &
                "', preco=" & txt_preco.Text &
                ", status='" & cmb_status.SelectedIndex + 1 &
                "' where id_comb = " & idCombustivel
            End If
        Else
            If txt_nome.Text = "" Or txt_preco.Text = "" Or txt_qtde.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If
            sql = "insert into tb_combustivel (nome, preco, qtde, status) values ('" &
                txt_nome.Text &
                "', " & txt_preco.Text &
                ", " & txt_qtde.Text & ", '1')"
        End If
        db.Execute(sql)
        carregar_combustivel()
        Me.Close()
    End Sub
End Class