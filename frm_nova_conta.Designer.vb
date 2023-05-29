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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_nova_conta))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_senhas_diferentes
        '
        Me.lbl_senhas_diferentes.AutoSize = True
        Me.lbl_senhas_diferentes.ForeColor = System.Drawing.Color.Red
        Me.lbl_senhas_diferentes.Location = New System.Drawing.Point(398, 242)
        Me.lbl_senhas_diferentes.Name = "lbl_senhas_diferentes"
        Me.lbl_senhas_diferentes.Size = New System.Drawing.Size(195, 16)
        Me.lbl_senhas_diferentes.TabIndex = 26
        Me.lbl_senhas_diferentes.Text = "AS SENHAS NÃO CONFEREM"
        Me.lbl_senhas_diferentes.Visible = False
        '
        'btn_ver_senha
        '
        Me.btn_ver_senha.Image = Global.GST.My.Resources.Resources.olho
        Me.btn_ver_senha.Location = New System.Drawing.Point(573, 198)
        Me.btn_ver_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ver_senha.Name = "btn_ver_senha"
        Me.btn_ver_senha.Size = New System.Drawing.Size(35, 30)
        Me.btn_ver_senha.TabIndex = 25
        Me.btn_ver_senha.UseVisualStyleBackColor = True
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(422, 316)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(130, 50)
        Me.btn_cadastrar.TabIndex = 24
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'cmb_tipo_conta
        '
        Me.cmb_tipo_conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_conta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_conta.FormattingEnabled = True
        Me.cmb_tipo_conta.Items.AddRange(New Object() {"Administrador", "Usuário"})
        Me.cmb_tipo_conta.Location = New System.Drawing.Point(136, 270)
        Me.cmb_tipo_conta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_tipo_conta.Name = "cmb_tipo_conta"
        Me.cmb_tipo_conta.Size = New System.Drawing.Size(126, 28)
        Me.cmb_tipo_conta.TabIndex = 23
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(401, 199)
        Me.txt_confirmar_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(151, 27)
        Me.txt_confirmar_senha.TabIndex = 22
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(95, 199)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(133, 27)
        Me.txt_senha.TabIndex = 21
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(156, 143)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(396, 27)
        Me.txt_nome.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 22)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tipo de Conta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Confirmar Senha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nome de Usuário"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 34)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "CADASTRO DE USUÁRIO:"
        '
        'frm_nova_conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 405)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
