<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vendas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_desconto = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.LinkLabel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_combustivel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(36, 128)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(153, 28)
        Me.txt_valor.TabIndex = 0
        '
        'txt_qtde
        '
        Me.txt_qtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde.Location = New System.Drawing.Point(231, 128)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(153, 28)
        Me.txt_qtde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Litros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(497, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Desconto"
        '
        'lbl_desconto
        '
        Me.lbl_desconto.AutoSize = True
        Me.lbl_desconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desconto.Location = New System.Drawing.Point(505, 135)
        Me.lbl_desconto.Name = "lbl_desconto"
        Me.lbl_desconto.Size = New System.Drawing.Size(20, 24)
        Me.lbl_desconto.TabIndex = 5
        Me.lbl_desconto.Text = "0"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(31, 193)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(220, 25)
        Me.lbl_cpf.TabIndex = 6
        Me.lbl_cpf.TabStop = True
        Me.lbl_cpf.Text = "Deseja informar o CPF?"
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(36, 26)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(133, 39)
        Me.btn_voltar.TabIndex = 8
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.Location = New System.Drawing.Point(365, 208)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(130, 40)
        Me.btn_confirmar.TabIndex = 9
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(36, 225)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(243, 22)
        Me.txt_cpf.TabIndex = 10
        '
        'lbl_combustivel
        '
        Me.lbl_combustivel.AutoSize = True
        Me.lbl_combustivel.Location = New System.Drawing.Point(255, 40)
        Me.lbl_combustivel.Name = "lbl_combustivel"
        Me.lbl_combustivel.Size = New System.Drawing.Size(51, 17)
        Me.lbl_combustivel.TabIndex = 11
        Me.lbl_combustivel.Text = "Label4"
        '
        'frm_vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 277)
        Me.Controls.Add(Me.lbl_combustivel)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_desconto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_qtde)
        Me.Controls.Add(Me.txt_valor)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_vendas"
        Me.Text = "frm_vendas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_desconto As Label
    Friend WithEvents lbl_cpf As LinkLabel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_combustivel As Label
End Class
