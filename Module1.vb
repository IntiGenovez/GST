Module Module1
    Public combustivelSelecao, sql As String
    Public idCombustivel As Integer
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
End Module
