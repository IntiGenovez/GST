<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_venda = New System.Windows.Forms.Button()
        Me.btn_retaguarda = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_venda
        '
        Me.btn_venda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_venda.Location = New System.Drawing.Point(29, 124)
        Me.btn_venda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_venda.Name = "btn_venda"
        Me.btn_venda.Size = New System.Drawing.Size(207, 42)
        Me.btn_venda.TabIndex = 1
        Me.btn_venda.Text = "Vendas"
        Me.btn_venda.UseVisualStyleBackColor = True
        '
        'btn_retaguarda
        '
        Me.btn_retaguarda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retaguarda.Location = New System.Drawing.Point(269, 124)
        Me.btn_retaguarda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_retaguarda.Name = "btn_retaguarda"
        Me.btn_retaguarda.Size = New System.Drawing.Size(207, 42)
        Me.btn_retaguarda.TabIndex = 2
        Me.btn_retaguarda.Text = "Retaguarda"
        Me.btn_retaguarda.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 204)
        Me.Controls.Add(Me.btn_retaguarda)
        Me.Controls.Add(Me.btn_venda)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Início"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_venda As Button
    Friend WithEvents btn_retaguarda As Button
End Class
