Public Class frm_vendas
    Private Sub frm_vendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        'esconde o txt do cpf e exibe o nome do combustivel escolhido
        txt_cpf.Visible = False
        lbl_combustivel.Text = combustivelSelecao

    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        'abre o form de selecao e fecha o atual
        frm_selecao.Show()
        Me.Close()
    End Sub
    Private Sub lbl_cpf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_cpf.LinkClicked
        'toggle da visibilidade do txt_cpf
        If txt_cpf.Visible Then
            txt_cpf.Visible = False
        Else
            txt_cpf.Visible = True
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        'verifica se o combustivel tem estoque
        sql = "select * from tb_combustivel where id_comb=" & idCombustivel
        rs = db.Execute(sql)
        If txt_qtde.Text > rs.Fields(3).Value Then
            MsgBox("Estoque indisponível, estoque máximo no momento de " & rs.Fields(3).Value & " litros", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            Exit Sub
        End If

        'verifica se a qtde foi informada e o cpf não foi
        If txt_qtde.Text <> "" And Not txt_cpf.Visible Then
            'atualiza o estoque de combustivel
            sql = "update tb_combustivel set qtde = " & (rs.Fields(3).Value - txt_qtde.Text).ToString().Replace(",", ".") &
                  " where id_comb = " & idCombustivel
            db.Execute(sql)

            'registra a venda
            sql = "insert into tb_vendas (data, valor, qtde, id_comb, cpf) values ('" & DateTime.Now & "', " &
                   txt_valor.Text.Replace(",", ".") & ", " & txt_qtde.Text.Replace(",", ".") & ", '" & idCombustivel &
                   "', 'Não informado')"
            db.Execute(sql)
            MsgBox("Sua venda foi confirmada com sucesso no valor de R$" &
                   txt_valor.Text, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Finalizado")
            frm_selecao.Show()
            Me.Close()
            'verifica se a qtde foi informada e o cpf foi preechido
        ElseIf txt_qtde.Text <> "" And txt_cpf.Visible And txt_cpf.MaskFull Then
            sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                frm_confirmar.Show()
                Me.Close()
                Exit Sub
            End If

            If rs.Fields(4).Value > 0 Then
                If MsgBox("Você possui um desconto de " & rs.Fields(4).Value & vbNewLine &
                          "Deseja resgatar agora?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Desconto") Then
                    lbl_desconto.Text = rs.Fields(4).Value
                End If
            End If

            'atualiza o estoque de combustivel
            sql = "update tb_combustivel set qtde =" & (rs.Fields(3).Value - txt_qtde.Text).ToString().Replace(",", ".") &
                  " where id_comb=" & idCombustivel
            db.Execute(sql)

            'registra a venda
            sql = "insert into tb_vendas (data, valor, qtde, id_comb, cpf) values ('" & DateTime.Now &
                  "', " & (txt_valor.Text - lbl_desconto.Text).ToString().Replace(",", ".") &
                  ", " & txt_qtde.Text.Replace(",", ".") & ", '" & idCombustivel &
                  "', '" & txt_cpf.Text & "')"
            db.Execute(sql)

            sql = "update tb_clientes set fidelidade = fidelidade + " & (txt_valor.Text * 0.05).ToString().Replace(",", ".") &
                  " where cpf='" & txt_cpf.Text & "'"
            db.Execute(sql)

            MsgBox("Sua venda com CPF foi confirmada com sucesso no valor de R$" &
                   (txt_valor.Text - lbl_desconto.Text), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Finalizado")
            frm_selecao.Show()
            Me.Close()
        Else
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    Private Sub txt_valor_TextChanged(sender As Object, e As EventArgs) Handles txt_valor.TextChanged
        'verifica se o valor é numerico e atualiza o qtde
        Dim valor As Double
        If Double.TryParse(txt_valor.Text, valor) Then
            txt_qtde.Text = (valor / rs.Fields(2).Value).ToString()
        Else
            txt_qtde.Text = ""
        End If
    End Sub

    Private Sub txt_qtde_TextChanged(sender As Object, e As EventArgs) Handles txt_qtde.TextChanged
        'verifica se o qtde é numerico e atualiza o valor
        Dim qtde As Double
        If Double.TryParse(txt_qtde.Text, qtde) Then
            txt_valor.Text = (qtde * rs.Fields(2).Value).ToString()
        Else
            txt_valor.Text = ""
        End If
    End Sub

    'impede input diferente de número
    Private Sub txt_valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Cancela o evento para impedir a inserção do caractere
        End If
    End Sub

    Private Sub txt_qtde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtde.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Cancela o evento para impedir a inserção do caractere
        End If
    End Sub
End Class