<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.CbMarcas = New System.Windows.Forms.ComboBox()
        Me.TxServiceTag = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbModelos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbTiposProd = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbEstadosProd = New System.Windows.Forms.ComboBox()
        Me.CbSitiosProd = New System.Windows.Forms.ComboBox()
        Me.CbContratos = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnConsultarProducto = New System.Windows.Forms.Button()
        Me.BtnAdmProduc = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PBCerrar = New System.Windows.Forms.PictureBox()
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
        Me.Label1.Size = New System.Drawing.Size(209, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control de productos"
        '
        'CbMarcas
        '
        Me.CbMarcas.BackColor = System.Drawing.Color.LightGray
        Me.CbMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbMarcas.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbMarcas.FormattingEnabled = True
        Me.CbMarcas.Location = New System.Drawing.Point(385, 75)
        Me.CbMarcas.Name = "CbMarcas"
        Me.CbMarcas.Size = New System.Drawing.Size(150, 29)
        Me.CbMarcas.TabIndex = 30
        '
        'TxServiceTag
        '
        Me.TxServiceTag.BackColor = System.Drawing.Color.LightGray
        Me.TxServiceTag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxServiceTag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxServiceTag.Location = New System.Drawing.Point(113, 78)
        Me.TxServiceTag.Name = "TxServiceTag"
        Me.TxServiceTag.Size = New System.Drawing.Size(137, 22)
        Me.TxServiceTag.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Service Tag: "
        '
        'TbDescripcion
        '
        Me.TbDescripcion.BackColor = System.Drawing.Color.LightGray
        Me.TbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcion.Location = New System.Drawing.Point(17, 293)
        Me.TbDescripcion.Multiline = True
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(296, 94)
        Me.TbDescripcion.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(323, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(753, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Modelo:"
        '
        'CbModelos
        '
        Me.CbModelos.BackColor = System.Drawing.Color.LightGray
        Me.CbModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbModelos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbModelos.FormattingEnabled = True
        Me.CbModelos.Location = New System.Drawing.Point(825, 75)
        Me.CbModelos.Name = "CbModelos"
        Me.CbModelos.Size = New System.Drawing.Size(150, 29)
        Me.CbModelos.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(541, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tipos:"
        '
        'CbTiposProd
        '
        Me.CbTiposProd.BackColor = System.Drawing.Color.LightGray
        Me.CbTiposProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbTiposProd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbTiposProd.FormattingEnabled = True
        Me.CbTiposProd.Location = New System.Drawing.Point(597, 75)
        Me.CbTiposProd.Name = "CbTiposProd"
        Me.CbTiposProd.Size = New System.Drawing.Size(150, 29)
        Me.CbTiposProd.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(13, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Descripción del producto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(13, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 21)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Estado de producto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(541, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 21)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Tipo de contrato:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(323, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 21)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Planta:"
        '
        'CbEstadosProd
        '
        Me.CbEstadosProd.BackColor = System.Drawing.Color.LightGray
        Me.CbEstadosProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbEstadosProd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbEstadosProd.FormattingEnabled = True
        Me.CbEstadosProd.Location = New System.Drawing.Point(163, 141)
        Me.CbEstadosProd.Name = "CbEstadosProd"
        Me.CbEstadosProd.Size = New System.Drawing.Size(150, 29)
        Me.CbEstadosProd.TabIndex = 41
        '
        'CbSitiosProd
        '
        Me.CbSitiosProd.BackColor = System.Drawing.Color.LightGray
        Me.CbSitiosProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbSitiosProd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbSitiosProd.FormattingEnabled = True
        Me.CbSitiosProd.Location = New System.Drawing.Point(385, 141)
        Me.CbSitiosProd.Name = "CbSitiosProd"
        Me.CbSitiosProd.Size = New System.Drawing.Size(150, 29)
        Me.CbSitiosProd.TabIndex = 42
        '
        'CbContratos
        '
        Me.CbContratos.BackColor = System.Drawing.Color.LightGray
        Me.CbContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbContratos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbContratos.FormattingEnabled = True
        Me.CbContratos.Location = New System.Drawing.Point(673, 141)
        Me.CbContratos.Name = "CbContratos"
        Me.CbContratos.Size = New System.Drawing.Size(150, 29)
        Me.CbContratos.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(17, 393)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(258, 26)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Nota: Si necesita administrar un producto ya creado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           comuniquese con e" &
    "l administrador del sistema."
        '
        'BtnConsultarProducto
        '
        Me.BtnConsultarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultarProducto.FlatAppearance.BorderSize = 0
        Me.BtnConsultarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnConsultarProducto.Location = New System.Drawing.Point(256, 79)
        Me.BtnConsultarProducto.Name = "BtnConsultarProducto"
        Me.BtnConsultarProducto.Size = New System.Drawing.Size(61, 22)
        Me.BtnConsultarProducto.TabIndex = 45
        Me.BtnConsultarProducto.Text = "Consultar"
        Me.BtnConsultarProducto.UseVisualStyleBackColor = True
        '
        'BtnAdmProduc
        '
        Me.BtnAdmProduc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdmProduc.BackColor = System.Drawing.Color.White
        Me.BtnAdmProduc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdmProduc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdmProduc.FlatAppearance.BorderSize = 0
        Me.BtnAdmProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmProduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmProduc.ForeColor = System.Drawing.Color.Black
        Me.BtnAdmProduc.Image = Global.Sistema.My.Resources.Resources.psettings
        Me.BtnAdmProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdmProduc.Location = New System.Drawing.Point(564, 428)
        Me.BtnAdmProduc.Name = "BtnAdmProduc"
        Me.BtnAdmProduc.Size = New System.Drawing.Size(250, 45)
        Me.BtnAdmProduc.TabIndex = 27
        Me.BtnAdmProduc.Text = "Administrar"
        Me.BtnAdmProduc.UseVisualStyleBackColor = False
        '
        'BtnProductos
        '
        Me.BtnProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnProductos.BackColor = System.Drawing.Color.White
        Me.BtnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.Black
        Me.BtnProductos.Image = Global.Sistema.My.Resources.Resources.seo1
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(564, 377)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(250, 45)
        Me.BtnProductos.TabIndex = 26
        Me.BtnProductos.Text = "Agregar"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Sistema.My.Resources.Resources.business_package_box_accept_productorpackagetoaccept_negocio_paquet_2334
        Me.PictureBox1.Location = New System.Drawing.Point(803, 319)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
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
        Me.PBCerrar.TabIndex = 2
        Me.PBCerrar.TabStop = False
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 500)
        Me.Controls.Add(Me.BtnConsultarProducto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CbContratos)
        Me.Controls.Add(Me.CbSitiosProd)
        Me.Controls.Add(Me.CbEstadosProd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbTiposProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbModelos)
        Me.Controls.Add(Me.TbDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbMarcas)
        Me.Controls.Add(Me.TxServiceTag)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAdmProduc)
        Me.Controls.Add(Me.BtnProductos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PBCerrar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductos"
        Me.Text = "FrmProductos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PBCerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAdmProduc As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents CbMarcas As ComboBox
    Friend WithEvents TxServiceTag As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbModelos As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbTiposProd As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CbEstadosProd As ComboBox
    Friend WithEvents CbSitiosProd As ComboBox
    Friend WithEvents CbContratos As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnConsultarProducto As Button
End Class
