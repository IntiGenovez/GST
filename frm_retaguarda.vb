Public Class frm_retaguarda
    Private Sub frm_retaguarda_Load(sender As Object, e As EventArgs) Handles Me.Load
        carregar_combustivel()
        carregar_vendas()
        If TabControl1.TabPages.Contains(TabPage1) Or TabControl1.TabPages.Contains(TabPage2) Or TabControl1.TabPages.Contains(TabPage3) Or TabControl1.TabPages.Contains(TabPage4) Then
            TabControl1.TabPages.Remove(TabPage1)
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage4)
            TabControl1.TabPages.Remove(TabPage3)
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
            frm_atualizar_combustivel.ShowDialog()
        End If
    End Sub

    Private Sub dgv_comb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_comb.CellContentClick
        With dgv_comb
            sql = "select * from tb_combustivel where id_comb=" & .CurrentRow.Cells(0).Value
            rs = db.Execute(sql)
            If .CurrentRow.Cells(4).Selected = True Then
                frm_atualizar_combustivel.ShowDialog()
            ElseIf .CurrentRow.Cells(5).Selected = True And MsgBox("Deseja mesmo deletar o cadastro?" + vbNewLine &
                                  "Combustível: " & rs.Fields(1).Value, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO") Then
                sql = "delete * from tb_combustivel where id_comb=" & .CurrentRow.Cells(0).Value
                db.Execute(sql)
            End If
            carregar_combustivel()
        End With
    End Sub
End Class