Public Class frm_selecao
    Private Sub frm_selecao_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Adiciona os combustíveis do db no cmb
            sql = "select * from tb_combustivel order by nome asc"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                cmb_selecao.Items.Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        Catch
        End Try
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            'salva o nome e id do combustivel em variavel e chama o form de vendas
            If cmb_selecao.SelectedItem = "" Then
                MsgBox("Selecione uma opção!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            Else
                combustivelSelecao = cmb_selecao.SelectedItem
                sql = "select * from tb_combustivel where nome='" & combustivelSelecao & "'"
                rs = db.Execute(sql)
                idCombustivel = rs.Fields(0).Value
                frm_vendas.ShowDialog()
            End If
        Catch
        End Try
    End Sub

    Private Sub frm_selecao_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Form1.Show()
        Catch
        End Try
    End Sub
End Class