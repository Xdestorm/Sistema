<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignaciones
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnConsultarAsignaciones = New System.Windows.Forms.Button()
        Me.TxCorreoUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbTipoProductoAsig = New System.Windows.Forms.ComboBox()
        Me.CbMarcasDisp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvUserAsig = New System.Windows.Forms.DataGridView()
        Me.CbModelosAsig = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbProDisp = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvActv = New System.Windows.Forms.DataGridView()
        Me.MetroSetLabel1 = New MetroSet_UI.Controls.MetroSetLabel()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxHost = New System.Windows.Forms.TextBox()
        Me.PBCerrar = New System.Windows.Forms.PictureBox()
        Me.BtnAdmProduc = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Chkb_Multiusuario = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvUserAsig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvActv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnConsultarAsignaciones
        '
        Me.BtnConsultarAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultarAsignaciones.FlatAppearance.BorderSize = 0
        Me.BtnConsultarAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarAsignaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnConsultarAsignaciones.Location = New System.Drawing.Point(375, 79)
        Me.BtnConsultarAsignaciones.Name = "BtnConsultarAsignaciones"
        Me.BtnConsultarAsignaciones.Size = New System.Drawing.Size(61, 22)
        Me.BtnConsultarAsignaciones.TabIndex = 52
        Me.BtnConsultarAsignaciones.Text = "Consultar"
        Me.BtnConsultarAsignaciones.UseVisualStyleBackColor = True
        '
        'TxCorreoUsuario
        '
        Me.TxCorreoUsuario.BackColor = System.Drawing.Color.LightGray
        Me.TxCorreoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxCorreoUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCorreoUsuario.Location = New System.Drawing.Point(136, 78)
        Me.TxCorreoUsuario.Name = "TxCorreoUsuario"
        Me.TxCorreoUsuario.Size = New System.Drawing.Size(233, 22)
        Me.TxCorreoUsuario.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Correo usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 30)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Asignar productos"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(240, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 21)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Tipo:"
        '
        'CbTipoProductoAsig
        '
        Me.CbTipoProductoAsig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbTipoProductoAsig.BackColor = System.Drawing.Color.LightGray
        Me.CbTipoProductoAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbTipoProductoAsig.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbTipoProductoAsig.FormattingEnabled = True
        Me.CbTipoProductoAsig.Location = New System.Drawing.Point(289, 342)
        Me.CbTipoProductoAsig.Name = "CbTipoProductoAsig"
        Me.CbTipoProductoAsig.Size = New System.Drawing.Size(150, 29)
        Me.CbTipoProductoAsig.TabIndex = 55
        '
        'CbMarcasDisp
        '
        Me.CbMarcasDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbMarcasDisp.BackColor = System.Drawing.Color.LightGray
        Me.CbMarcasDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbMarcasDisp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbMarcasDisp.FormattingEnabled = True
        Me.CbMarcasDisp.Location = New System.Drawing.Point(84, 342)
        Me.CbMarcasDisp.Name = "CbMarcasDisp"
        Me.CbMarcasDisp.Size = New System.Drawing.Size(150, 29)
        Me.CbMarcasDisp.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(15, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Marcas:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvUserAsig)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(17, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 60)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos usuario"
        '
        'DgvUserAsig
        '
        Me.DgvUserAsig.AllowUserToAddRows = False
        Me.DgvUserAsig.AllowUserToDeleteRows = False
        Me.DgvUserAsig.AllowUserToResizeColumns = False
        Me.DgvUserAsig.AllowUserToResizeRows = False
        Me.DgvUserAsig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvUserAsig.BackgroundColor = System.Drawing.Color.White
        Me.DgvUserAsig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUserAsig.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DgvUserAsig.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvUserAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUserAsig.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvUserAsig.EnableHeadersVisualStyles = False
        Me.DgvUserAsig.GridColor = System.Drawing.Color.White
        Me.DgvUserAsig.Location = New System.Drawing.Point(3, 16)
        Me.DgvUserAsig.MultiSelect = False
        Me.DgvUserAsig.Name = "DgvUserAsig"
        Me.DgvUserAsig.ReadOnly = True
        Me.DgvUserAsig.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvUserAsig.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DgvUserAsig.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvUserAsig.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvUserAsig.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DgvUserAsig.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvUserAsig.RowTemplate.ReadOnly = True
        Me.DgvUserAsig.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DgvUserAsig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvUserAsig.ShowCellErrors = False
        Me.DgvUserAsig.ShowCellToolTips = False
        Me.DgvUserAsig.ShowEditingIcon = False
        Me.DgvUserAsig.ShowRowErrors = False
        Me.DgvUserAsig.Size = New System.Drawing.Size(979, 41)
        Me.DgvUserAsig.TabIndex = 0
        Me.DgvUserAsig.TabStop = False
        '
        'CbModelosAsig
        '
        Me.CbModelosAsig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbModelosAsig.BackColor = System.Drawing.Color.LightGray
        Me.CbModelosAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbModelosAsig.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbModelosAsig.FormattingEnabled = True
        Me.CbModelosAsig.Location = New System.Drawing.Point(524, 342)
        Me.CbModelosAsig.Name = "CbModelosAsig"
        Me.CbModelosAsig.Size = New System.Drawing.Size(150, 29)
        Me.CbModelosAsig.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(445, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Modelos:"
        '
        'CbProDisp
        '
        Me.CbProDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbProDisp.BackColor = System.Drawing.Color.LightGray
        Me.CbProDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbProDisp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbProDisp.FormattingEnabled = True
        Me.CbProDisp.Location = New System.Drawing.Point(104, 400)
        Me.CbProDisp.Name = "CbProDisp"
        Me.CbProDisp.Size = New System.Drawing.Size(150, 29)
        Me.CbProDisp.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(28, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "N° Serie:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvActv)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(17, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(988, 144)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos asignados a usuario"
        '
        'DgvActv
        '
        Me.DgvActv.AllowUserToAddRows = False
        Me.DgvActv.AllowUserToDeleteRows = False
        Me.DgvActv.AllowUserToResizeColumns = False
        Me.DgvActv.AllowUserToResizeRows = False
        Me.DgvActv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvActv.BackgroundColor = System.Drawing.Color.White
        Me.DgvActv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvActv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DgvActv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvActv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvActv.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvActv.EnableHeadersVisualStyles = False
        Me.DgvActv.GridColor = System.Drawing.Color.White
        Me.DgvActv.Location = New System.Drawing.Point(3, 16)
        Me.DgvActv.MultiSelect = False
        Me.DgvActv.Name = "DgvActv"
        Me.DgvActv.ReadOnly = True
        Me.DgvActv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvActv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DgvActv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvActv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvActv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DgvActv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvActv.RowTemplate.ReadOnly = True
        Me.DgvActv.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DgvActv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvActv.ShowCellErrors = False
        Me.DgvActv.ShowCellToolTips = False
        Me.DgvActv.ShowEditingIcon = False
        Me.DgvActv.ShowRowErrors = False
        Me.DgvActv.Size = New System.Drawing.Size(979, 125)
        Me.DgvActv.TabIndex = 0
        Me.DgvActv.TabStop = False
        '
        'MetroSetLabel1
        '
        Me.MetroSetLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroSetLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MetroSetLabel1.Location = New System.Drawing.Point(264, 316)
        Me.MetroSetLabel1.Name = "MetroSetLabel1"
        Me.MetroSetLabel1.Size = New System.Drawing.Size(278, 23)
        Me.MetroSetLabel1.Style = MetroSet_UI.Design.Style.Light
        Me.MetroSetLabel1.StyleManager = Nothing
        Me.MetroSetLabel1.TabIndex = 67
        Me.MetroSetLabel1.Text = "**********Asignar nuevos productos**********"
        Me.MetroSetLabel1.ThemeAuthor = "Narwin"
        Me.MetroSetLabel1.ThemeName = "MetroLite"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TbDescripcion.BackColor = System.Drawing.Color.LightGray
        Me.TbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcion.Location = New System.Drawing.Point(264, 400)
        Me.TbDescripcion.Multiline = True
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(278, 29)
        Me.TbDescripcion.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(260, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 21)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Descripción del producto:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(53, 451)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 21)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Host:"
        '
        'TxHost
        '
        Me.TxHost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxHost.BackColor = System.Drawing.Color.LightGray
        Me.TxHost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxHost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHost.Location = New System.Drawing.Point(104, 451)
        Me.TxHost.Name = "TxHost"
        Me.TxHost.Size = New System.Drawing.Size(150, 22)
        Me.TxHost.TabIndex = 71
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
        Me.PBCerrar.TabIndex = 59
        Me.PBCerrar.TabStop = False
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
        Me.BtnAdmProduc.TabIndex = 49
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
        Me.BtnProductos.TabIndex = 48
        Me.BtnProductos.Text = "Agregar"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Sistema.My.Resources.Resources.arrow1_40529
        Me.PictureBox1.Location = New System.Drawing.Point(803, 319)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(261, 451)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 21)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Multiusuario?:"
        '
        'Chkb_Multiusuario
        '
        Me.Chkb_Multiusuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chkb_Multiusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Chkb_Multiusuario.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Chkb_Multiusuario.Checked = False
        Me.Chkb_Multiusuario.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Chkb_Multiusuario.ForeColor = System.Drawing.Color.White
        Me.Chkb_Multiusuario.Location = New System.Drawing.Point(375, 453)
        Me.Chkb_Multiusuario.Name = "Chkb_Multiusuario"
        Me.Chkb_Multiusuario.Size = New System.Drawing.Size(20, 20)
        Me.Chkb_Multiusuario.TabIndex = 75
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 435)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(147, 13)
        Me.BunifuCustomLabel1.TabIndex = 76
        Me.BunifuCustomLabel1.Text = "Asignar HOST si corresponde"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(262, 435)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(271, 13)
        Me.BunifuCustomLabel2.TabIndex = 77
        Me.BunifuCustomLabel2.Text = "Seleccionar si producto es usado por mas de un usuario"
        '
        'FrmAsignaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 500)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Chkb_Multiusuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxHost)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbDescripcion)
        Me.Controls.Add(Me.MetroSetLabel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CbProDisp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbModelosAsig)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PBCerrar)
        Me.Controls.Add(Me.CbMarcasDisp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbTipoProductoAsig)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnConsultarAsignaciones)
        Me.Controls.Add(Me.TxCorreoUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAdmProduc)
        Me.Controls.Add(Me.BtnProductos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAsignaciones"
        Me.Text = "FrmAsignaciones"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvUserAsig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvActv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConsultarAsignaciones As Button
    Friend WithEvents TxCorreoUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdmProduc As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbTipoProductoAsig As ComboBox
    Friend WithEvents CbMarcasDisp As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PBCerrar As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvUserAsig As DataGridView
    Friend WithEvents CbModelosAsig As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbProDisp As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvActv As DataGridView
    Friend WithEvents MetroSetLabel1 As MetroSet_UI.Controls.MetroSetLabel
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxHost As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Chkb_Multiusuario As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
