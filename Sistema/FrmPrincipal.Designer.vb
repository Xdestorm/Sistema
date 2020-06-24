<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PMVertical = New System.Windows.Forms.Panel()
        Me.BtnAdministracion = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.BtnAsignaciones = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PTop = New System.Windows.Forms.Panel()
        Me.BtnAcceso = New System.Windows.Forms.Button()
        Me.TxbContraseñaUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbInicioUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MetroSetControlBox1 = New MetroSet_UI.Controls.MetroSetControlBox()
        Me.PBMenu = New System.Windows.Forms.PictureBox()
        Me.PContainer = New System.Windows.Forms.Panel()
        Me.TmMenuOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.TmMenuMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PMVertical.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTop.SuspendLayout()
        CType(Me.PBMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PMVertical
        '
        Me.PMVertical.BackColor = System.Drawing.Color.DodgerBlue
        Me.PMVertical.Controls.Add(Me.BtnAdministracion)
        Me.PMVertical.Controls.Add(Me.BtnInventario)
        Me.PMVertical.Controls.Add(Me.BtnAsignaciones)
        Me.PMVertical.Controls.Add(Me.BtnProductos)
        Me.PMVertical.Controls.Add(Me.btnUsuarios)
        Me.PMVertical.Controls.Add(Me.PictureBox1)
        Me.PMVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.PMVertical.Location = New System.Drawing.Point(0, 0)
        Me.PMVertical.Name = "PMVertical"
        Me.PMVertical.Size = New System.Drawing.Size(60, 611)
        Me.PMVertical.TabIndex = 0
        '
        'BtnAdministracion
        '
        Me.BtnAdministracion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdministracion.Enabled = False
        Me.BtnAdministracion.FlatAppearance.BorderSize = 0
        Me.BtnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdministracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdministracion.ForeColor = System.Drawing.Color.White
        Me.BtnAdministracion.Image = Global.Sistema.My.Resources.Resources.compras
        Me.BtnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdministracion.Location = New System.Drawing.Point(0, 554)
        Me.BtnAdministracion.Name = "BtnAdministracion"
        Me.BtnAdministracion.Size = New System.Drawing.Size(250, 45)
        Me.BtnAdministracion.TabIndex = 5
        Me.BtnAdministracion.Text = "Administración"
        Me.BtnAdministracion.UseVisualStyleBackColor = True
        '
        'BtnInventario
        '
        Me.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInventario.Enabled = False
        Me.BtnInventario.FlatAppearance.BorderSize = 0
        Me.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.ForeColor = System.Drawing.Color.White
        Me.BtnInventario.Image = Global.Sistema.My.Resources.Resources.reportes
        Me.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInventario.Location = New System.Drawing.Point(0, 223)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(250, 45)
        Me.BtnInventario.TabIndex = 4
        Me.BtnInventario.Text = "Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'BtnAsignaciones
        '
        Me.BtnAsignaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAsignaciones.Enabled = False
        Me.BtnAsignaciones.FlatAppearance.BorderSize = 0
        Me.BtnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAsignaciones.ForeColor = System.Drawing.Color.White
        Me.BtnAsignaciones.Image = Global.Sistema.My.Resources.Resources.empleados
        Me.BtnAsignaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAsignaciones.Location = New System.Drawing.Point(0, 172)
        Me.BtnAsignaciones.Name = "BtnAsignaciones"
        Me.BtnAsignaciones.Size = New System.Drawing.Size(250, 45)
        Me.BtnAsignaciones.TabIndex = 3
        Me.BtnAsignaciones.Text = "Asignaciones"
        Me.BtnAsignaciones.UseVisualStyleBackColor = True
        '
        'BtnProductos
        '
        Me.BtnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.Enabled = False
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProductos.Image = Global.Sistema.My.Resources.Resources.producto
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(0, 121)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(250, 45)
        Me.BtnProductos.TabIndex = 2
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.Enabled = False
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Image = Global.Sistema.My.Resources.Resources.usuarios
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 70)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(250, 45)
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema.My.Resources.Resources.logotipo_aesgener_blanco
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PTop
        '
        Me.PTop.BackColor = System.Drawing.Color.White
        Me.PTop.Controls.Add(Me.BtnAcceso)
        Me.PTop.Controls.Add(Me.TxbContraseñaUsuario)
        Me.PTop.Controls.Add(Me.Label1)
        Me.PTop.Controls.Add(Me.TxbInicioUsuario)
        Me.PTop.Controls.Add(Me.Label9)
        Me.PTop.Controls.Add(Me.MetroSetControlBox1)
        Me.PTop.Controls.Add(Me.PBMenu)
        Me.PTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTop.Location = New System.Drawing.Point(60, 0)
        Me.PTop.Name = "PTop"
        Me.PTop.Size = New System.Drawing.Size(1224, 50)
        Me.PTop.TabIndex = 1
        '
        'BtnAcceso
        '
        Me.BtnAcceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAcceso.BackColor = System.Drawing.Color.Transparent
        Me.BtnAcceso.BackgroundImage = Global.Sistema.My.Resources.Resources.user
        Me.BtnAcceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAcceso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAcceso.FlatAppearance.BorderSize = 0
        Me.BtnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcceso.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAcceso.Location = New System.Drawing.Point(1061, 11)
        Me.BtnAcceso.Name = "BtnAcceso"
        Me.BtnAcceso.Size = New System.Drawing.Size(22, 22)
        Me.BtnAcceso.TabIndex = 22
        Me.BtnAcceso.UseVisualStyleBackColor = False
        '
        'TxbContraseñaUsuario
        '
        Me.TxbContraseñaUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbContraseñaUsuario.BackColor = System.Drawing.Color.LightGray
        Me.TxbContraseñaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbContraseñaUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbContraseñaUsuario.Location = New System.Drawing.Point(955, 12)
        Me.TxbContraseñaUsuario.Name = "TxbContraseñaUsuario"
        Me.TxbContraseñaUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxbContraseñaUsuario.Size = New System.Drawing.Size(100, 22)
        Me.TxbContraseñaUsuario.TabIndex = 20
        Me.TxbContraseñaUsuario.Text = "Andes.20"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(853, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Contraseña: "
        '
        'TxbInicioUsuario
        '
        Me.TxbInicioUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbInicioUsuario.BackColor = System.Drawing.Color.LightGray
        Me.TxbInicioUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbInicioUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbInicioUsuario.Location = New System.Drawing.Point(652, 11)
        Me.TxbInicioUsuario.Name = "TxbInicioUsuario"
        Me.TxbInicioUsuario.Size = New System.Drawing.Size(195, 22)
        Me.TxbInicioUsuario.TabIndex = 18
        Me.TxbInicioUsuario.Text = "vector.iibacache.c@aes.com"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(575, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Usuario: "
        '
        'MetroSetControlBox1
        '
        Me.MetroSetControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MetroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White
        Me.MetroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray
        Me.MetroSetControlBox1.Location = New System.Drawing.Point(1112, 12)
        Me.MetroSetControlBox1.MaximizeBox = True
        Me.MetroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MetroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.MinimizeBox = True
        Me.MetroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MetroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray
        Me.MetroSetControlBox1.Name = "MetroSetControlBox1"
        Me.MetroSetControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.MetroSetControlBox1.Style = MetroSet_UI.Design.Style.Light
        Me.MetroSetControlBox1.StyleManager = Nothing
        Me.MetroSetControlBox1.TabIndex = 0
        Me.MetroSetControlBox1.Text = "MetroSetControlBox1"
        Me.MetroSetControlBox1.ThemeAuthor = "Narwin"
        Me.MetroSetControlBox1.ThemeName = "MetroLite"
        '
        'PBMenu
        '
        Me.PBMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBMenu.Image = CType(resources.GetObject("PBMenu.Image"), System.Drawing.Image)
        Me.PBMenu.Location = New System.Drawing.Point(6, 3)
        Me.PBMenu.Name = "PBMenu"
        Me.PBMenu.Size = New System.Drawing.Size(35, 35)
        Me.PBMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBMenu.TabIndex = 0
        Me.PBMenu.TabStop = False
        '
        'PContainer
        '
        Me.PContainer.BackColor = System.Drawing.Color.White
        Me.PContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PContainer.ForeColor = System.Drawing.Color.Transparent
        Me.PContainer.Location = New System.Drawing.Point(60, 50)
        Me.PContainer.Name = "PContainer"
        Me.PContainer.Size = New System.Drawing.Size(1224, 561)
        Me.PContainer.TabIndex = 2
        '
        'TmMenuOcultar
        '
        Me.TmMenuOcultar.Interval = 50
        '
        'TmMenuMostrar
        '
        Me.TmMenuMostrar.Interval = 50
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.PContainer)
        Me.Controls.Add(Me.PTop)
        Me.Controls.Add(Me.PMVertical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PMVertical.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTop.ResumeLayout(False)
        Me.PTop.PerformLayout()
        CType(Me.PBMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PMVertical As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PTop As Panel
    Friend WithEvents PBMenu As PictureBox
    Friend WithEvents PContainer As Panel
    Friend WithEvents MetroSetControlBox1 As MetroSet_UI.Controls.MetroSetControlBox
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnAsignaciones As Button
    Friend WithEvents BtnInventario As Button
    Friend WithEvents BtnAdministracion As Button
    Friend WithEvents TxbContraseñaUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbInicioUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAcceso As Button
    Friend WithEvents TmMenuOcultar As Timer
    Friend WithEvents TmMenuMostrar As Timer
End Class
