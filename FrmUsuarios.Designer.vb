<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblciudad = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.lblgenero = New System.Windows.Forms.Label()
        Me.Lblemail = New System.Windows.Forms.Label()
        Me.Lbltel = New System.Windows.Forms.Label()
        Me.Cmbgenero = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboCiudad = New System.Windows.Forms.ComboBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(49, 51)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(49, 81)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 1
        Me.lblnombre.Text = "Nombre"
        '
        'lblciudad
        '
        Me.lblciudad.AutoSize = True
        Me.lblciudad.Location = New System.Drawing.Point(49, 109)
        Me.lblciudad.Name = "lblciudad"
        Me.lblciudad.Size = New System.Drawing.Size(40, 13)
        Me.lblciudad.TabIndex = 2
        Me.lblciudad.Text = "Ciudad"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Location = New System.Drawing.Point(99, 51)
        Me.txtID.MaxLength = 5
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(72, 20)
        Me.txtID.TabIndex = 3
        '
        'txtname
        '
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.Location = New System.Drawing.Point(99, 74)
        Me.txtname.MaxLength = 60
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(233, 20)
        Me.txtname.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemail.Location = New System.Drawing.Point(676, 44)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(139, 20)
        Me.txtemail.TabIndex = 11
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(676, 21)
        Me.txttel.MaxLength = 13
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(139, 20)
        Me.txttel.TabIndex = 9
        '
        'lblgenero
        '
        Me.lblgenero.AutoSize = True
        Me.lblgenero.Location = New System.Drawing.Point(626, 79)
        Me.lblgenero.Name = "lblgenero"
        Me.lblgenero.Size = New System.Drawing.Size(42, 13)
        Me.lblgenero.TabIndex = 8
        Me.lblgenero.Text = "Genero"
        '
        'Lblemail
        '
        Me.Lblemail.AutoSize = True
        Me.Lblemail.Location = New System.Drawing.Point(626, 51)
        Me.Lblemail.Name = "Lblemail"
        Me.Lblemail.Size = New System.Drawing.Size(32, 13)
        Me.Lblemail.TabIndex = 7
        Me.Lblemail.Text = "Email"
        '
        'Lbltel
        '
        Me.Lbltel.AutoSize = True
        Me.Lbltel.Location = New System.Drawing.Point(626, 21)
        Me.Lbltel.Name = "Lbltel"
        Me.Lbltel.Size = New System.Drawing.Size(49, 13)
        Me.Lbltel.TabIndex = 6
        Me.Lbltel.Text = "Telefono"
        '
        'Cmbgenero
        '
        Me.Cmbgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbgenero.FormattingEnabled = True
        Me.Cmbgenero.Items.AddRange(New Object() {"MASCULINO", "FEMENINO", "OTRO"})
        Me.Cmbgenero.Location = New System.Drawing.Point(676, 79)
        Me.Cmbgenero.Name = "Cmbgenero"
        Me.Cmbgenero.Size = New System.Drawing.Size(139, 21)
        Me.Cmbgenero.TabIndex = 12
        Me.Cmbgenero.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboCiudad)
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.Cmbgenero)
        Me.GroupBox1.Controls.Add(Me.Lbltel)
        Me.GroupBox1.Controls.Add(Me.Lblemail)
        Me.GroupBox1.Controls.Add(Me.lblgenero)
        Me.GroupBox1.Controls.Add(Me.txttel)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(815, 139)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'ComboCiudad
        '
        Me.ComboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCiudad.FormattingEnabled = True
        Me.ComboCiudad.Items.AddRange(New Object() {"BOGOTA"})
        Me.ComboCiudad.Location = New System.Drawing.Point(73, 79)
        Me.ComboCiudad.Name = "ComboCiudad"
        Me.ComboCiudad.Size = New System.Drawing.Size(233, 21)
        Me.ComboCiudad.TabIndex = 2
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(421, 37)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(94, 41)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "Limpiar"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(231, 28)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 0
        Me.btnbuscar.Text = "Buscar ID"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(25, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(816, 202)
        Me.DataGridView1.TabIndex = 14
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 48)
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Image = CType(resources.GetObject("BorrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Image = CType(resources.GetObject("SeleccionarTodoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(25, 166)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(95, 50)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "Borrar"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(126, 166)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(106, 50)
        Me.btnrefresh.TabIndex = 16
        Me.btnrefresh.Text = "Refrescar"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdate.Location = New System.Drawing.Point(645, 166)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 50)
        Me.btnupdate.TabIndex = 17
        Me.btnupdate.Text = "Actualizar"
        Me.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(746, 166)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 50)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "Guardar"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(269, 195)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 20)
        Me.TextBox1.TabIndex = 20
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(269, 172)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(166, 17)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Buscar por nombre o Palabra "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblciudad)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmUsuarios"
        Me.Text = "CRUD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblciudad As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttel As TextBox
    Friend WithEvents lblgenero As Label
    Friend WithEvents Lblemail As Label
    Friend WithEvents Lbltel As Label
    Friend WithEvents Cmbgenero As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btndelete As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboCiudad As ComboBox
End Class
