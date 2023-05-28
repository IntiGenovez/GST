Public Class frm_retaguarda
    Private Sub frm_retaguarda_Load(sender As Object, e As EventArgs) Handles Me.Load
        carregar_combustivel()
        carregar_vendas()
        carregar_contas()
        If TabControl1.TabPages.Contains(TabPage1) Or TabControl1.TabPages.Contains(TabPage2) Or TabControl1.TabPages.Contains(TabPage3) Or TabControl1.TabPages.Contains(TabPage4) Then
            TabControl1.TabPages.Remove(TabPage1)
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage3)
            TabControl1.TabPages.Remove(TabPage4)
            TabControl1.TabPages.Remove(TabPage6)
        End If
    End Sub
    Private Sub cmb_combustivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_combustivel.SelectedIndexChanged
        sql = "select * from tb_combustivel where nome='" & cmb_combustivel.SelectedItem & "'"
        rs = db.Execute(sql)
        lbl_preco.Text = rs.Fields(2).Value
        lbl_qtde.Text = rs.Fields(3).Value
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        If cmb_combustivel.SelectedItem = "" Then
            MsgBox("Informe o tipo de combustível!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        Else
            isUpdate = True
            frm_atualizar_combustivel.ShowDialog()
        End If
    End Sub

    Private Sub dgv_comb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_comb.CellContentClick
        With dgv_comb
            sql = "select * from tb_combustivel where id_comb=" & .CurrentRow.Cells(0).Value
            rs = db.Execute(sql)
            If .CurrentRow.Cells(4).Selected Then
                isUpdate = True
                frm_atualizar_combustivel.ShowDialog()
            ElseIf .CurrentRow.Cells(5).Selected And MsgBox("Deseja mesmo deletar o cadastro?" + vbNewLine &
                                  "Combustível: " & rs.Fields(1).Value, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO") Then
                sql = "delete * from tb_combustivel where id_comb=" & .CurrentRow.Cells(0).Value
                db.Execute(sql)
            End If
            carregar_combustivel()
        End With
    End Sub

    Private Sub btn_acessar_Click(sender As Object, e As EventArgs) Handles btn_acessar.Click
        sql = "select * from tb_usuarios where usuario ='" & txt_usuario.Text & "' and senha='" & txt_senha.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF Then
            MsgBox("Usuário ou senha não existe", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf rs.Fields(4).Value = "Bloqueado" Then
            MsgBox("Seu usuário foi bloqueado pelo administrador", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "BLOQUEADO")
        ElseIf rs.Fields(3).Value = "Administrador" Then
            TabControl1.TabPages.Add(TabPage1)
            TabControl1.TabPages.Add(TabPage2)
            TabControl1.TabPages.Add(TabPage3)
            TabControl1.TabPages.Add(TabPage4)
            TabControl1.TabPages.Add(TabPage6)
            TabControl1.TabPages.Remove(TabPage5)
        Else
            TabControl1.TabPages.Add(TabPage1)
            TabControl1.TabPages.Add(TabPage2)
            TabControl1.TabPages.Add(TabPage3)
            TabControl1.TabPages.Add(TabPage4)
            TabControl1.TabPages.Remove(TabPage5)
        End If
    End Sub

    Private Sub lbl_nova_conta_Click(sender As Object, e As EventArgs) Handles lbl_nova_conta.Click
        isUpdate = False
        frm_nova_conta.ShowDialog()
    End Sub

    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        With dgv_contas
            sql = "select * from tb_usuarios where id_usuario=" & .CurrentRow.Cells(0).Value
            rs = db.Execute(sql)
            If .CurrentRow.Cells(4).Selected Then
                isUpdate = True
                frm_nova_conta.ShowDialog()
            ElseIf .CurrentRow.Cells(5).Selected And MsgBox("Deseja mesmo deletar o usuário?" + vbNewLine &
                                  "Usuário: " & rs.Fields(1).Value, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO") Then
                sql = "delete * from tb_usuarios where id_usuario=" & .CurrentRow.Cells(0).Value
                db.Execute(sql)
            End If
            carregar_combustivel()
        End With
    End Sub

    Private Sub lbl_novo_comb_Click(sender As Object, e As EventArgs) Handles lbl_novo_comb.Click
        isUpdate = False
        frm_atualizar_combustivel.ShowDialog()
    End Sub

    Private Sub lbl_novo_cliente_Click(sender As Object, e As EventArgs) Handles lbl_novo_cliente.Click
        isUpdate = False
        frm_cadastro.ShowDialog()
    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        With dgv_contas
            sql = "select * from tb_clientes where nome=" & .CurrentRow.Cells(0).Value
            rs = db.Execute(sql)
            If .CurrentRow.Cells(3).Selected Then
                isUpdate = True
                frm_cadastro.ShowDialog()
            ElseIf .CurrentRow.Cells(4).Selected And MsgBox("Deseja mesmo deletar o cliente?" + vbNewLine &
                                  "Cliente: " & rs.Fields(1).Value, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO") Then
                sql = "delete * from tb_clientes where nome=" & .CurrentRow.Cells(0).Value
                db.Execute(sql)
            End If
            carregar_combustivel()
        End With
    End Sub
End Class