<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nova_conta
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
        Me.lbl_senhas_diferentes = New System.Windows.Forms.Label()
        Me.btn_ver_senha = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.cmb_tipo_conta = New System.Windows.Forms.ComboBox()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_senhas_diferentes
        '
        Me.lbl_senhas_diferentes.AutoSize = True
        Me.lbl_senhas_diferentes.ForeColor = System.Drawing.Color.Red
        Me.lbl_senhas_diferentes.Location = New System.Drawing.Point(524, 246)
        Me.lbl_senhas_diferentes.Name = "lbl_senhas_diferentes"
        Me.lbl_senhas_diferentes.Size = New System.Drawing.Size(151, 17)
        Me.lbl_senhas_diferentes.TabIndex = 26
        Me.lbl_senhas_diferentes.Text = "Senhas Não Conferem"
        Me.lbl_senhas_diferentes.Visible = False
        '
        'btn_ver_senha
        '
        Me.btn_ver_senha.Image = Global.GST.My.Resources.Resources.olho
        Me.btn_ver_senha.Location = New System.Drawing.Point(642, 189)
        Me.btn_ver_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ver_senha.Name = "btn_ver_senha"
        Me.btn_ver_senha.Size = New System.Drawing.Size(35, 30)
        Me.btn_ver_senha.TabIndex = 25
        Me.btn_ver_senha.UseVisualStyleBackColor = True
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Location = New System.Drawing.Point(248, 266)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_cadastrar.TabIndex = 24
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'cmb_tipo_conta
        '
        Me.cmb_tipo_conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_conta.FormattingEnabled = True
        Me.cmb_tipo_conta.Items.AddRange(New Object() {"Administrador", "Usuário"})
        Me.cmb_tipo_conta.Location = New System.Drawing.Point(53, 270)
        Me.cmb_tipo_conta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_tipo_conta.Name = "cmb_tipo_conta"
        Me.cmb_tipo_conta.Size = New System.Drawing.Size(108, 24)
        Me.cmb_tipo_conta.TabIndex = 23
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(341, 193)
        Me.txt_confirmar_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(259, 22)
        Me.txt_confirmar_senha.TabIndex = 22
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(53, 193)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(240, 22)
        Me.txt_senha.TabIndex = 21
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(53, 105)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(464, 22)
        Me.txt_nome.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tipo de Conta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Confirmar Senha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nome de Usuário"
        '
        'frm_nova_conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 405)
        Me.Controls.Add(Me.lbl_senhas_diferentes)
        Me.Controls.Add(Me.btn_ver_senha)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.cmb_tipo_conta)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_nova_conta"
        Me.Text = "frm_nova_conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_senhas_diferentes As Label
    Friend WithEvents btn_ver_senha As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents cmb_tipo_conta As ComboBox
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
