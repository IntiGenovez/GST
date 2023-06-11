Public Class frm_cadastro
    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles Me.Load
        If isUpdate Then
            sql = "select * from tb_clientes where cpf='" & cpf & "'"
            rs = db.Execute(sql)
            txt_nome.Text = rs.Fields(1).Value
            txt_email.Text = rs.Fields(2).Value
            txt_telefone.Text = rs.Fields(3).Value
            txt_cpf.Text = rs.Fields(0).Value
            txt_cpf.Enabled = False
            Me.Text = "Atualizar Cliente"
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If Not txt_cpf.MaskFull Or txt_email.Text = "" Or txt_nome.Text = "" Or Not txt_telefone.MaskFull Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            Exit Sub
        End If
        If isUpdate Then
            sql = "update tb_clientes set nome='" & txt_nome.Text & "', email='" & txt_email.Text &
                  "', telefone='" & txt_telefone.Text & "' where cpf='" & cpf & "'"
            MsgBox("Atualização realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")

        Else
            sql = "insert into tb_clientes values ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" &
                  txt_email.Text & "', '" & txt_telefone.Text & "', 0)"
            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")

        End If
        db.Execute(sql)
        Me.Close()
    End Sub

    Private Sub frm_cadastro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            frm_confirmar.Close()
        Catch
            '
        End Try
    End Sub
End Class