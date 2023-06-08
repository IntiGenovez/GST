Public Class frm_nova_conta
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If txt_nome.Text = "" Or txt_senha.Text = "" Or cmb_tipo_conta.SelectedItem = "" Or Not txt_fone.MaskFull Or txt_key.text = "" Then
            MsgBox("Preencha todos os campos antes de prosseguir", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        ElseIf lbl_senhas_diferentes.Visible Then
            MsgBox("Senhas não conferem", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        sql = "select * from tb_usuarios where usuario='" & txt_nome.Text & "'"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            MsgBox("Já existe um usuário cadastrado com esse nome!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        Else
            sql = "insert into tb_usuarios (usuario, senha, tipo, status) values ('" & txt_nome.Text & "', '" & txt_senha.Text & "', '" & cmb_tipo_conta.Text & "', 1)"
            db.Execute(sql)
            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
            carregar_contas()
            Me.Close()
        End If
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged
        Try
            If txt_senha.Text <> txt_confirmar_senha.Text Then
                lbl_senhas_diferentes.Visible = True
            Else
                lbl_senhas_diferentes.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Erro ao mudar a visibilidade da senha", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")

        End Try
    End Sub
    Private Sub txt_confirmar_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_confirmar_senha.TextChanged
        Try
            If txt_senha.Text <> txt_confirmar_senha.Text Then
                lbl_senhas_diferentes.Visible = True
            Else
                lbl_senhas_diferentes.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_ver_senha_Click(sender As Object, e As EventArgs) Handles btn_ver_senha.Click
        Try
            If Not txt_senha.PasswordChar = "*" Then
                txt_senha.PasswordChar = "*"
                txt_confirmar_senha.PasswordChar = "*"
                btn_ver_senha.Image = My.Resources.olho_aberto
            Else
                txt_senha.PasswordChar = ""
                txt_confirmar_senha.PasswordChar = ""
                btn_ver_senha.Image = My.Resources.olho
            End If
        Catch ex As Exception
            MsgBox("Erro ao mudar a visibilidade da senha", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub
End Class