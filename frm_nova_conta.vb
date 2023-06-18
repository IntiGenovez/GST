Imports System.Text.RegularExpressions
Public Class frm_nova_conta

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If txt_nome.Text = "" Or txt_senha.Text = "" Or cmb_tipo_conta.SelectedItem = "" Or Not txt_fone.MaskFull Or txt_key.Text = "" Then
                MsgBox("Preencha todos os campos antes de prosseguir", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            ElseIf lbl_senhas_diferentes.Visible Then
                MsgBox("Senhas não conferem", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If
            If isUpdate Then
                sql = "update tb_usuarios set usuario = '" & txt_nome.Text &
                          "', senha='" & txt_senha.Text &
                          "', tipo='" & cmb_tipo_conta.Text &
                          "', telefone='55" & Regex.Replace(txt_fone.Text, "\D", "") &
                          "', apikey='" & txt_key.Text &
                          "' where id_usuario = " & idConta
                db.Execute(sql)
                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                carregar_contas()
                Me.Close()
            Else
                sql = "select * from tb_usuarios where usuario='" & txt_nome.Text & "'"
                rs = db.Execute(sql)
                If Not rs.EOF Then
                    MsgBox("Já existe um usuário cadastrado com esse nome!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                Else

                    sql = "insert into tb_usuarios (usuario, senha, tipo, telefone, apikey, status) values ('" & txt_nome.Text &
                           "', '" & txt_senha.Text & "', '" &
                           cmb_tipo_conta.Text &
                           "', '55" & Regex.Replace(txt_fone.Text, "\D", "") &
                           "', '" & txt_key.Text &
                           "', 1)"
                    db.Execute(sql)
                    MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                    carregar_contas()
                    Me.Close()
                End If
            End If
        Catch
        End Try
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

    Private Sub frm_nova_conta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If isUpdate Then
                sql = "select * from tb_usuarios where id_usuario=" & idConta
                rs = db.Execute(sql)
                txt_nome.Text = rs.Fields(1).Value
                cmb_tipo_conta.Text = rs.Fields(3).Value
                Dim input As String = rs.Fields(5).Value
                Dim output As String = Regex.Replace(input, "^(\d{2})(\d{2})(\d{5})(\d{4})$", "($2) $3-$4")
                txt_fone.Text = output
            End If
        Catch
        End Try
    End Sub
End Class