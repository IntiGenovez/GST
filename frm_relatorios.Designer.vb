<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorios
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_relat = New System.Windows.Forms.ComboBox()
        Me.btn_relat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Atualizar Estoque:"
        '
        'cmb_relat
        '
        Me.cmb_relat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_relat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_relat.FormattingEnabled = True
        Me.cmb_relat.Items.AddRange(New Object() {"Vendas", "Combustíveis", "Clientes"})
        Me.cmb_relat.Location = New System.Drawing.Point(183, 137)
        Me.cmb_relat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_relat.Name = "cmb_relat"
        Me.cmb_relat.Size = New System.Drawing.Size(121, 28)
        Me.cmb_relat.TabIndex = 17
        '
        'btn_relat
        '
        Me.btn_relat.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relat.Location = New System.Drawing.Point(153, 188)
        Me.btn_relat.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_relat.Name = "btn_relat"
        Me.btn_relat.Size = New System.Drawing.Size(191, 48)
        Me.btn_relat.TabIndex = 19
        Me.btn_relat.Text = "ACESSAR"
        Me.btn_relat.UseVisualStyleBackColor = True
        '
        'frm_relatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 278)
        Me.Controls.Add(Me.btn_relat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_relat)
        Me.Name = "frm_relatorios"
        Me.Text = "frm_relatorios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_relat As ComboBox
    Friend WithEvents btn_relat As Button
End Class
