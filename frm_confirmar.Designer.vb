<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_confirmar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cadastrar = New System.Windows.Forms.Button()
        Me.txt_corrigir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seu CPF não consta no sistema :("
        '
        'txt_cadastrar
        '
        Me.txt_cadastrar.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadastrar.Location = New System.Drawing.Point(55, 155)
        Me.txt_cadastrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cadastrar.Name = "txt_cadastrar"
        Me.txt_cadastrar.Size = New System.Drawing.Size(224, 49)
        Me.txt_cadastrar.TabIndex = 1
        Me.txt_cadastrar.Text = "Cadastrar"
        Me.txt_cadastrar.UseVisualStyleBackColor = True
        '
        'txt_corrigir
        '
        Me.txt_corrigir.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_corrigir.Location = New System.Drawing.Point(285, 155)
        Me.txt_corrigir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_corrigir.Name = "txt_corrigir"
        Me.txt_corrigir.Size = New System.Drawing.Size(224, 49)
        Me.txt_corrigir.TabIndex = 2
        Me.txt_corrigir.Text = "Corrigir CPF"
        Me.txt_corrigir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gostaria de se cadastrar?"
        '
        'frm_confirmar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 255)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_corrigir)
        Me.Controls.Add(Me.txt_cadastrar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_confirmar"
        Me.Text = "CPF não cadastrado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cadastrar As Button
    Friend WithEvents txt_corrigir As Button
    Friend WithEvents Label2 As Label
End Class
