<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbCorreo = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxUbicacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbEmpresa = New System.Windows.Forms.ComboBox()
        Me.TbAnexo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbEstados = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnAdminUsers = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar = New System.Windows.Forms.PictureBox()
        Me.lbl_maxtext = New MetroSet_UI.Controls.MetroSetLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control de usuarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(22, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Correo: "
        '
        'TbCorreo
        '
        Me.TbCorreo.BackColor = System.Drawing.Color.LightGray
        Me.TbCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbCorreo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCorreo.Location = New System.Drawing.Point(93, 78)
        Me.TbCorreo.Name = "TbCorreo"
        Me.TbCorreo.Size = New System.Drawing.Size(297, 22)
        Me.TbCorreo.TabIndex = 1
        '
        'TbNombre
        '
        Me.TbNombre.BackColor = System.Drawing.Color.LightGray
        Me.TbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombre.Location = New System.Drawing.Point(544, 79)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(200, 22)
        Me.TbNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(463, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre: "
        '
        'TbApellido
        '
        Me.TbApellido.BackColor = System.Drawing.Color.LightGray
        Me.TbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbApellido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbApellido.Location = New System.Drawing.Point(93, 142)
        Me.TbApellido.Name = "TbApellido"
        Me.TbApellido.Size = New System.Drawing.Size(200, 22)
        Me.TbApellido.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(13, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Apellido: "
        '
        'TxUbicacion
        '
        Me.TxUbicacion.BackColor = System.Drawing.Color.LightGray
        Me.TxUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxUbicacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxUbicacion.Location = New System.Drawing.Point(386, 141)
        Me.TxUbicacion.Name = "TxUbicacion"
        Me.TxUbicacion.Size = New System.Drawing.Size(358, 22)
        Me.TxUbicacion.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(299, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ubicación:"
        '
        'CbPlanta
        '
        Me.CbPlanta.BackColor = System.Drawing.Color.LightGray
        Me.CbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbPlanta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(93, 206)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(150, 29)
        Me.CbPlanta.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(27, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Planta: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(249, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Empresa: "
        '
        'CbEmpresa
        '
        Me.CbEmpresa.BackColor = System.Drawing.Color.LightGray
        Me.CbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbEmpresa.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbEmpresa.FormattingEnabled = True
        Me.CbEmpresa.Location = New System.Drawing.Point(332, 206)
        Me.CbEmpresa.Name = "CbEmpresa"
        Me.CbEmpresa.Size = New System.Drawing.Size(150, 29)
        Me.CbEmpresa.TabIndex = 6
        '
        'TbAnexo
        '
        Me.TbAnexo.BackColor = System.Drawing.Color.LightGray
        Me.TbAnexo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbAnexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAnexo.Location = New System.Drawing.Point(554, 209)
        Me.TbAnexo.Name = "TbAnexo"
        Me.TbAnexo.Size = New System.Drawing.Size(100, 22)
        Me.TbAnexo.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(488, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Anexo: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(40, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tipo: "
        '
        'CbTipo
        '
        Me.CbTipo.BackColor = System.Drawing.Color.LightGray
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(93, 277)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(150, 29)
        Me.CbTipo.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Location = New System.Drawing.Point(27, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 21)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Estado: "
        '
        'CbEstados
        '
        Me.CbEstados.BackColor = System.Drawing.Color.LightGray
        Me.CbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbEstados.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbEstados.FormattingEnabled = True
        Me.CbEstados.Location = New System.Drawing.Point(93, 348)
        Me.CbEstados.Name = "CbEstados"
        Me.CbEstados.Size = New System.Drawing.Size(150, 29)
        Me.CbEstados.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(17, 319)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(324, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Nota: Cuando se crea un usuario este queda Activado por defecto."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(17, 393)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(308, 39)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Nota: Cuando administra un usuario solo se activan los campos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          que se p" &
    "ueden modificar, si necesita mover un usuario de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          sitio tiene que info" &
    "rmar al administrador del sistema."
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultar.FlatAppearance.BorderSize = 0
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnConsultar.Location = New System.Drawing.Point(396, 79)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(61, 22)
        Me.BtnConsultar.TabIndex = 27
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnAdminUsers
        '
        Me.BtnAdminUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdminUsers.BackColor = System.Drawing.Color.White
        Me.BtnAdminUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdminUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminUsers.FlatAppearance.BorderSize = 0
        Me.BtnAdminUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminUsers.ForeColor = System.Drawing.Color.Black
        Me.BtnAdminUsers.Image = Global.Sistema.My.Resources.Resources.psettings
        Me.BtnAdminUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdminUsers.Location = New System.Drawing.Point(564, 428)
        Me.BtnAdminUsers.Name = "BtnAdminUsers"
        Me.BtnAdminUsers.Size = New System.Drawing.Size(250, 45)
        Me.BtnAdminUsers.TabIndex = 25
        Me.BtnAdminUsers.Text = "Administrar"
        Me.BtnAdminUsers.UseVisualStyleBackColor = False
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUsuarios.BackColor = System.Drawing.Color.White
        Me.BtnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.ForeColor = System.Drawing.Color.Black
        Me.BtnUsuarios.Image = Global.Sistema.My.Resources.Resources.seo1
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(564, 377)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(250, 45)
        Me.BtnUsuarios.TabIndex = 21
        Me.BtnUsuarios.Text = "Agregar"
        Me.BtnUsuarios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Sistema.My.Resources.Resources.contactlist_theuser_802
        Me.PictureBox1.Location = New System.Drawing.Point(803, 319)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PBCerrar
        '
        Me.PBCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBCerrar.Image = Global.Sistema.My.Resources.Resources.cerrar2
        Me.PBCerrar.Location = New System.Drawing.Point(985, 12)
        Me.PBCerrar.Name = "PBCerrar"
        Me.PBCerrar.Size = New System.Drawing.Size(20, 20)
        Me.PBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBCerrar.TabIndex = 1
        Me.PBCerrar.TabStop = False
        '
        'lbl_maxtext
        '
        Me.lbl_maxtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_maxtext.Location = New System.Drawing.Point(712, 166)
        Me.lbl_maxtext.Name = "lbl_maxtext"
        Me.lbl_maxtext.Size = New System.Drawing.Size(32, 23)
        Me.lbl_maxtext.Style = MetroSet_UI.Design.Style.Light
        Me.lbl_maxtext.StyleManager = Nothing
        Me.lbl_maxtext.TabIndex = 28
        Me.lbl_maxtext.Text = "100"
        Me.lbl_maxtext.ThemeAuthor = "Narwin"
        Me.lbl_maxtext.ThemeName = "MetroLite"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 500)
        Me.Controls.Add(Me.lbl_maxtext)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnAdminUsers)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CbEstados)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnUsuarios)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbTipo)
        Me.Controls.Add(Me.TbAnexo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CbEmpresa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbPlanta)
        Me.Controls.Add(Me.TxUbicacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbApellido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbCorreo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PBCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PBCerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbCorreo As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbApellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxUbicacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CbEmpresa As ComboBox
    Friend WithEvents TbAnexo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents CbEstados As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnAdminUsers As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents lbl_maxtext As MetroSet_UI.Controls.MetroSetLabel
End Class
