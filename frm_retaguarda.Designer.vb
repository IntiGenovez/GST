<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_retaguarda
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
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.lbl_nova_conta = New System.Windows.Forms.ToolStripLabel()
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.Column21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_acessar = New System.Windows.Forms.Button()
        Me.btn_ver_senha = New System.Windows.Forms.Button()
        Me.lbl_recuperar = New System.Windows.Forms.LinkLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_vendas = New System.Windows.Forms.DataGridView()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lbl_novo_comb = New System.Windows.Forms.ToolStripLabel()
        Me.dgv_comb = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.lbl_novo_cliente = New System.Windows.Forms.ToolStripLabel()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmb_combustivel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_preco = New System.Windows.Forms.Label()
        Me.lbl_qtde = New System.Windows.Forms.Label()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btn_relat = New System.Windows.Forms.Button()
        Me.TabPage6.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_comb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = Global.GST.My.Resources.Resources.editar
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 124
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Excluir"
        Me.DataGridViewImageColumn2.Image = Global.GST.My.Resources.Resources.excluir
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 123
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgv_contas)
        Me.TabPage6.Controls.Add(Me.ToolStrip3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 33)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(925, 416)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Contas"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_nova_conta})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(919, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'lbl_nova_conta
        '
        Me.lbl_nova_conta.Name = "lbl_nova_conta"
        Me.lbl_nova_conta.Size = New System.Drawing.Size(85, 22)
        Me.lbl_nova_conta.Text = "Nova conta"
        '
        'dgv_contas
        '
        Me.dgv_contas.AllowUserToAddRows = False
        Me.dgv_contas.AllowUserToDeleteRows = False
        Me.dgv_contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21})
        Me.dgv_contas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_contas.Location = New System.Drawing.Point(3, 28)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.ReadOnly = True
        Me.dgv_contas.RowHeadersWidth = 51
        Me.dgv_contas.RowTemplate.Height = 24
        Me.dgv_contas.Size = New System.Drawing.Size(919, 385)
        Me.dgv_contas.TabIndex = 3
        '
        'Column21
        '
        Me.Column21.FalseValue = "Inativo"
        Me.Column21.HeaderText = "Bloquear"
        Me.Column21.MinimumWidth = 6
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.TrueValue = "Ativo"
        '
        'Column20
        '
        Me.Column20.HeaderText = "Excluir"
        Me.Column20.Image = Global.GST.My.Resources.Resources.excluir
        Me.Column20.MinimumWidth = 6
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        '
        'Column19
        '
        Me.Column19.HeaderText = "Editar"
        Me.Column19.Image = Global.GST.My.Resources.Resources.editar
        Me.Column19.MinimumWidth = 6
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        '
        'Column18
        '
        Me.Column18.HeaderText = "Tipo de Conta"
        Me.Column18.MinimumWidth = 6
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.HeaderText = "Status"
        Me.Column17.MinimumWidth = 6
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "Usuário"
        Me.Column16.MinimumWidth = 6
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "ID"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lbl_recuperar)
        Me.TabPage5.Controls.Add(Me.btn_ver_senha)
        Me.TabPage5.Controls.Add(Me.btn_acessar)
        Me.TabPage5.Controls.Add(Me.txt_senha)
        Me.TabPage5.Controls.Add(Me.txt_usuario)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 33)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(925, 416)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Login"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(282, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Usuário"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Senha"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(372, 107)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(204, 27)
        Me.txt_usuario.TabIndex = 7
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(372, 164)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(204, 27)
        Me.txt_senha.TabIndex = 8
        '
        'btn_acessar
        '
        Me.btn_acessar.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acessar.Location = New System.Drawing.Point(286, 223)
        Me.btn_acessar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_acessar.Name = "btn_acessar"
        Me.btn_acessar.Size = New System.Drawing.Size(352, 38)
        Me.btn_acessar.TabIndex = 9
        Me.btn_acessar.Text = "Acessar"
        Me.btn_acessar.UseVisualStyleBackColor = True
        '
        'btn_ver_senha
        '
        Me.btn_ver_senha.Image = Global.GST.My.Resources.Resources.olho
        Me.btn_ver_senha.Location = New System.Drawing.Point(603, 164)
        Me.btn_ver_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ver_senha.Name = "btn_ver_senha"
        Me.btn_ver_senha.Size = New System.Drawing.Size(35, 30)
        Me.btn_ver_senha.TabIndex = 26
        Me.btn_ver_senha.UseVisualStyleBackColor = True
        '
        'lbl_recuperar
        '
        Me.lbl_recuperar.AutoSize = True
        Me.lbl_recuperar.Location = New System.Drawing.Point(677, 272)
        Me.lbl_recuperar.Name = "lbl_recuperar"
        Me.lbl_recuperar.Size = New System.Drawing.Size(149, 24)
        Me.lbl_recuperar.TabIndex = 27
        Me.lbl_recuperar.TabStop = True
        Me.lbl_recuperar.Text = "Esqueci minha senha"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgv_vendas)
        Me.TabPage4.Controls.Add(Me.ToolStrip2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Size = New System.Drawing.Size(925, 416)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Vendas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripComboBox1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(919, 28)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(49, 25)
        Me.ToolStripLabel2.Text = "Filtros"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'dgv_vendas
        '
        Me.dgv_vendas.AllowUserToAddRows = False
        Me.dgv_vendas.AllowUserToDeleteRows = False
        Me.dgv_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.dgv_vendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_vendas.Location = New System.Drawing.Point(3, 30)
        Me.dgv_vendas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_vendas.Name = "dgv_vendas"
        Me.dgv_vendas.ReadOnly = True
        Me.dgv_vendas.RowHeadersWidth = 51
        Me.dgv_vendas.RowTemplate.Height = 24
        Me.dgv_vendas.Size = New System.Drawing.Size(919, 384)
        Me.dgv_vendas.TabIndex = 1
        '
        'Column13
        '
        Me.Column13.HeaderText = "Data"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Subtotal"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Combustível"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Cliente"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv_comb)
        Me.TabPage3.Controls.Add(Me.ToolStrip1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(925, 416)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Combustíveis"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_novo_comb})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(919, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lbl_novo_comb
        '
        Me.lbl_novo_comb.Name = "lbl_novo_comb"
        Me.lbl_novo_comb.Size = New System.Drawing.Size(194, 22)
        Me.lbl_novo_comb.Text = "Adicionar novo combustível"
        '
        'dgv_comb
        '
        Me.dgv_comb.AllowUserToAddRows = False
        Me.dgv_comb.AllowUserToDeleteRows = False
        Me.dgv_comb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_comb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_comb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgv_comb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_comb.Location = New System.Drawing.Point(3, 27)
        Me.dgv_comb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_comb.Name = "dgv_comb"
        Me.dgv_comb.ReadOnly = True
        Me.dgv_comb.RowHeadersWidth = 51
        Me.dgv_comb.RowTemplate.Height = 24
        Me.dgv_comb.Size = New System.Drawing.Size(919, 387)
        Me.dgv_comb.TabIndex = 1
        '
        'Column9
        '
        Me.Column9.HeaderText = "Excluir"
        Me.Column9.Image = Global.GST.My.Resources.Resources.excluir
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Editar"
        Me.Column8.Image = Global.GST.My.Resources.Resources.editar
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Estoque"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Preço"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nome"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Código"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_clientes)
        Me.TabPage2.Controls.Add(Me.ToolStrip4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(925, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Clientes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip4
        '
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_novo_cliente})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(919, 25)
        Me.ToolStrip4.TabIndex = 0
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'lbl_novo_cliente
        '
        Me.lbl_novo_cliente.Name = "lbl_novo_cliente"
        Me.lbl_novo_cliente.Size = New System.Drawing.Size(95, 22)
        Me.lbl_novo_cliente.Text = "Novo Cliente"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column22, Me.Column3, Me.Column4})
        Me.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_clientes.Location = New System.Drawing.Point(3, 27)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersWidth = 51
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(919, 387)
        Me.dgv_clientes.TabIndex = 1
        '
        'Column4
        '
        Me.Column4.HeaderText = "Excluir"
        Me.Column4.Image = Global.GST.My.Resources.Resources.excluir
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Editar"
        Me.Column3.Image = Global.GST.My.Resources.Resources.editar
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column22
        '
        Me.Column22.HeaderText = "Fidelidade"
        Me.Column22.MinimumWidth = 6
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "E-mail"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_relat)
        Me.TabPage1.Controls.Add(Me.btn_atualizar)
        Me.TabPage1.Controls.Add(Me.lbl_qtde)
        Me.TabPage1.Controls.Add(Me.lbl_preco)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmb_combustivel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(925, 416)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Preços e Estoque"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmb_combustivel
        '
        Me.cmb_combustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_combustivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_combustivel.FormattingEnabled = True
        Me.cmb_combustivel.Location = New System.Drawing.Point(304, 138)
        Me.cmb_combustivel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_combustivel.Name = "cmb_combustivel"
        Me.cmb_combustivel.Size = New System.Drawing.Size(264, 28)
        Me.cmb_combustivel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecione o combustível"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Preço atual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(478, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estoque atual"
        '
        'lbl_preco
        '
        Me.lbl_preco.AutoSize = True
        Me.lbl_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco.Location = New System.Drawing.Point(300, 218)
        Me.lbl_preco.Name = "lbl_preco"
        Me.lbl_preco.Size = New System.Drawing.Size(75, 20)
        Me.lbl_preco.TabIndex = 4
        Me.lbl_preco.Text = "R$ 00,00"
        '
        'lbl_qtde
        '
        Me.lbl_qtde.AutoSize = True
        Me.lbl_qtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtde.Location = New System.Drawing.Point(478, 218)
        Me.lbl_qtde.Name = "lbl_qtde"
        Me.lbl_qtde.Size = New System.Drawing.Size(66, 20)
        Me.lbl_qtde.TabIndex = 5
        Me.lbl_qtde.Text = "0 Litros"
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atualizar.Location = New System.Drawing.Point(381, 266)
        Me.btn_atualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(187, 42)
        Me.btn_atualizar.TabIndex = 6
        Me.btn_atualizar.Text = "Atualizar Dados"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(933, 453)
        Me.TabControl1.TabIndex = 0
        '
        'btn_relat
        '
        Me.btn_relat.Location = New System.Drawing.Point(745, 353)
        Me.btn_relat.Name = "btn_relat"
        Me.btn_relat.Size = New System.Drawing.Size(140, 48)
        Me.btn_relat.TabIndex = 7
        Me.btn_relat.Text = "Ver relatórios"
        Me.btn_relat.UseVisualStyleBackColor = True
        '
        'frm_retaguarda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 464)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_retaguarda"
        Me.Text = "frm_retaguarda"
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_comb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dgv_contas As DataGridView
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewImageColumn
    Friend WithEvents Column20 As DataGridViewImageColumn
    Friend WithEvents Column21 As DataGridViewCheckBoxColumn
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents lbl_nova_conta As ToolStripLabel
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lbl_recuperar As LinkLabel
    Friend WithEvents btn_ver_senha As Button
    Friend WithEvents btn_acessar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgv_vendas As DataGridView
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgv_comb As DataGridView
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lbl_novo_comb As ToolStripLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents lbl_novo_cliente As ToolStripLabel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_relat As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents lbl_qtde As Label
    Friend WithEvents lbl_preco As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_combustivel As ComboBox
    Friend WithEvents TabControl1 As TabControl
End Class
