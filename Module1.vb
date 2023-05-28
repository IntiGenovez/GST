﻿Module Module1
    Public combustivelSelecao, sql, cpf As String
    Public idCombustivel As Integer
    Public isUpdate As Boolean
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dir_banco = Application.StartupPath & "\db\gstdb.mdb"
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco)
        Catch ex As Exception
            MsgBox("Conexão Falha", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Falha")
        End Try
    End Sub
    Sub desconctar_banco()
        Try
            db.Close()
        Catch ex As Exception
            MsgBox("Conexão Falha", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Falha")
        End Try
    End Sub

    Sub carregar_combustivel()
        'Adiciona os combustíveis do db no cmb
        sql = "select * from tb_combustivel order by nome asc"
        rs = db.Execute(sql)
        With frm_retaguarda
            .cmb_combustivel.Items.Clear()
            .lbl_preco.Text = ""
            .lbl_qtde.Text = ""
            .dgv_comb.Rows.Clear()
            Do While rs.EOF = False
                .cmb_combustivel.Items.Add(rs.Fields(1).Value)
                .dgv_comb.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_vendas()
        'Adiciona os combustíveis do db no cmb
        sql = "select * from tb_vendas order by data asc"
        rs = db.Execute(sql)
        With frm_retaguarda
            .dgv_vendas.Rows.Clear()
            Do While rs.EOF = False
                .dgv_vendas.Rows.Add(rs.Fields(5).Value, rs.Fields(4).Value, rs.Fields(2).Value * rs.Fields(3).Value, rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_contas()
        sql = "select * from tb_usuarios order by id_usuario asc"
        rs = db.Execute(sql)
        With frm_retaguarda.dgv_contas
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(3).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_clientes()
        sql = "select * from tb_clientes order by nome asc"
        rs = db.Execute(sql)
        With frm_retaguarda.dgv_clientes
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
End Module
