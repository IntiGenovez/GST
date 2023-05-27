<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_selecao
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
        Me.cmb_selecao = New System.Windows.Forms.ComboBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe o combustível"
        '
        'cmb_selecao
        '
        Me.cmb_selecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_selecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_selecao.FormattingEnabled = True
        Me.cmb_selecao.Location = New System.Drawing.Point(52, 86)
        Me.cmb_selecao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_selecao.Name = "cmb_selecao"
        Me.cmb_selecao.Size = New System.Drawing.Size(299, 28)
        Me.cmb_selecao.TabIndex = 1
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(127, 132)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(144, 46)
        Me.btn_confirmar.TabIndex = 2
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'frm_selecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 201)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.cmb_selecao)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_selecao"
        Me.Text = "frm_selecao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_selecao As ComboBox
    Friend WithEvents btn_confirmar As Button
End Class
