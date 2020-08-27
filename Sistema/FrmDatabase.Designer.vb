<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatabase))
        Me.TxbDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.btn_Examinar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_Respaldar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_Restaurar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txb_nombrebackup = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txb_direccionRestaurar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_examinarRest = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbl_backup = New System.Windows.Forms.Label()
        Me.lbl_restore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxbDireccion
        '
        Me.TxbDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxbDireccion.BackColor = System.Drawing.Color.LightGray
        Me.TxbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbDireccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbDireccion.Location = New System.Drawing.Point(342, 86)
        Me.TxbDireccion.Name = "TxbDireccion"
        Me.TxbDireccion.Size = New System.Drawing.Size(260, 22)
        Me.TxbDireccion.TabIndex = 20
        '
        'lblDireccion
        '
        Me.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDireccion.Location = New System.Drawing.Point(247, 86)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(89, 21)
        Me.lblDireccion.TabIndex = 21
        Me.lblDireccion.Text = "*Dirección: "
        '
        'btn_Examinar
        '
        Me.btn_Examinar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Examinar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Examinar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Examinar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Examinar.BorderRadius = 0
        Me.btn_Examinar.ButtonText = "Examinar"
        Me.btn_Examinar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Examinar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Examinar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Examinar.Iconimage = CType(resources.GetObject("btn_Examinar.Iconimage"), System.Drawing.Image)
        Me.btn_Examinar.Iconimage_right = Nothing
        Me.btn_Examinar.Iconimage_right_Selected = Nothing
        Me.btn_Examinar.Iconimage_Selected = Nothing
        Me.btn_Examinar.IconMarginLeft = 0
        Me.btn_Examinar.IconMarginRight = 0
        Me.btn_Examinar.IconRightVisible = True
        Me.btn_Examinar.IconRightZoom = 0R
        Me.btn_Examinar.IconVisible = True
        Me.btn_Examinar.IconZoom = 90.0R
        Me.btn_Examinar.IsTab = False
        Me.btn_Examinar.Location = New System.Drawing.Point(637, 86)
        Me.btn_Examinar.Name = "btn_Examinar"
        Me.btn_Examinar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Examinar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_Examinar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Examinar.selected = False
        Me.btn_Examinar.Size = New System.Drawing.Size(150, 50)
        Me.btn_Examinar.TabIndex = 22
        Me.btn_Examinar.Text = "Examinar"
        Me.btn_Examinar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Examinar.Textcolor = System.Drawing.Color.White
        Me.btn_Examinar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_Respaldar
        '
        Me.btn_Respaldar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Respaldar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Respaldar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Respaldar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Respaldar.BorderRadius = 0
        Me.btn_Respaldar.ButtonText = "Respaldar"
        Me.btn_Respaldar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Respaldar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Respaldar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Respaldar.Iconimage = CType(resources.GetObject("btn_Respaldar.Iconimage"), System.Drawing.Image)
        Me.btn_Respaldar.Iconimage_right = Nothing
        Me.btn_Respaldar.Iconimage_right_Selected = Nothing
        Me.btn_Respaldar.Iconimage_Selected = Nothing
        Me.btn_Respaldar.IconMarginLeft = 0
        Me.btn_Respaldar.IconMarginRight = 0
        Me.btn_Respaldar.IconRightVisible = True
        Me.btn_Respaldar.IconRightZoom = 0R
        Me.btn_Respaldar.IconVisible = True
        Me.btn_Respaldar.IconZoom = 90.0R
        Me.btn_Respaldar.IsTab = False
        Me.btn_Respaldar.Location = New System.Drawing.Point(637, 142)
        Me.btn_Respaldar.Name = "btn_Respaldar"
        Me.btn_Respaldar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Respaldar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_Respaldar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Respaldar.selected = False
        Me.btn_Respaldar.Size = New System.Drawing.Size(150, 50)
        Me.btn_Respaldar.TabIndex = 27
        Me.btn_Respaldar.Text = "Respaldar"
        Me.btn_Respaldar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Respaldar.Textcolor = System.Drawing.Color.White
        Me.btn_Respaldar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_Restaurar
        '
        Me.btn_Restaurar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Restaurar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_Restaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Restaurar.BorderRadius = 0
        Me.btn_Restaurar.ButtonText = "Restaurar"
        Me.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restaurar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Restaurar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Restaurar.Iconimage = CType(resources.GetObject("btn_Restaurar.Iconimage"), System.Drawing.Image)
        Me.btn_Restaurar.Iconimage_right = Nothing
        Me.btn_Restaurar.Iconimage_right_Selected = Nothing
        Me.btn_Restaurar.Iconimage_Selected = Nothing
        Me.btn_Restaurar.IconMarginLeft = 0
        Me.btn_Restaurar.IconMarginRight = 0
        Me.btn_Restaurar.IconRightVisible = True
        Me.btn_Restaurar.IconRightZoom = 0R
        Me.btn_Restaurar.IconVisible = True
        Me.btn_Restaurar.IconZoom = 90.0R
        Me.btn_Restaurar.IsTab = False
        Me.btn_Restaurar.Location = New System.Drawing.Point(637, 356)
        Me.btn_Restaurar.Name = "btn_Restaurar"
        Me.btn_Restaurar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Restaurar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_Restaurar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Restaurar.selected = False
        Me.btn_Restaurar.Size = New System.Drawing.Size(150, 50)
        Me.btn_Restaurar.TabIndex = 28
        Me.btn_Restaurar.Text = "Restaurar"
        Me.btn_Restaurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Restaurar.Textcolor = System.Drawing.Color.White
        Me.btn_Restaurar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txb_nombrebackup
        '
        Me.txb_nombrebackup.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txb_nombrebackup.BackColor = System.Drawing.Color.LightGray
        Me.txb_nombrebackup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txb_nombrebackup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_nombrebackup.Location = New System.Drawing.Point(342, 114)
        Me.txb_nombrebackup.Name = "txb_nombrebackup"
        Me.txb_nombrebackup.Size = New System.Drawing.Size(260, 22)
        Me.txb_nombrebackup.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(254, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "*Nombre: "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txb_direccionRestaurar
        '
        Me.txb_direccionRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txb_direccionRestaurar.BackColor = System.Drawing.Color.LightGray
        Me.txb_direccionRestaurar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txb_direccionRestaurar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_direccionRestaurar.Location = New System.Drawing.Point(342, 300)
        Me.txb_direccionRestaurar.Name = "txb_direccionRestaurar"
        Me.txb_direccionRestaurar.Size = New System.Drawing.Size(260, 22)
        Me.txb_direccionRestaurar.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(247, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "*Dirección: "
        '
        'btn_examinarRest
        '
        Me.btn_examinarRest.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_examinarRest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_examinarRest.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_examinarRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_examinarRest.BorderRadius = 0
        Me.btn_examinarRest.ButtonText = "Examinar"
        Me.btn_examinarRest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_examinarRest.DisabledColor = System.Drawing.Color.Gray
        Me.btn_examinarRest.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_examinarRest.Iconimage = CType(resources.GetObject("btn_examinarRest.Iconimage"), System.Drawing.Image)
        Me.btn_examinarRest.Iconimage_right = Nothing
        Me.btn_examinarRest.Iconimage_right_Selected = Nothing
        Me.btn_examinarRest.Iconimage_Selected = Nothing
        Me.btn_examinarRest.IconMarginLeft = 0
        Me.btn_examinarRest.IconMarginRight = 0
        Me.btn_examinarRest.IconRightVisible = True
        Me.btn_examinarRest.IconRightZoom = 0R
        Me.btn_examinarRest.IconVisible = True
        Me.btn_examinarRest.IconZoom = 90.0R
        Me.btn_examinarRest.IsTab = False
        Me.btn_examinarRest.Location = New System.Drawing.Point(637, 300)
        Me.btn_examinarRest.Name = "btn_examinarRest"
        Me.btn_examinarRest.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_examinarRest.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_examinarRest.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_examinarRest.selected = False
        Me.btn_examinarRest.Size = New System.Drawing.Size(150, 50)
        Me.btn_examinarRest.TabIndex = 33
        Me.btn_examinarRest.Text = "Examinar"
        Me.btn_examinarRest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_examinarRest.Textcolor = System.Drawing.Color.White
        Me.btn_examinarRest.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbl_backup
        '
        Me.lbl_backup.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_backup.AutoSize = True
        Me.lbl_backup.BackColor = System.Drawing.Color.Transparent
        Me.lbl_backup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_backup.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_backup.Location = New System.Drawing.Point(338, 62)
        Me.lbl_backup.Name = "lbl_backup"
        Me.lbl_backup.Size = New System.Drawing.Size(24, 21)
        Me.lbl_backup.TabIndex = 34
        Me.lbl_backup.Text = "**"
        '
        'lbl_restore
        '
        Me.lbl_restore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_restore.AutoSize = True
        Me.lbl_restore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_restore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_restore.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_restore.Location = New System.Drawing.Point(338, 276)
        Me.lbl_restore.Name = "lbl_restore"
        Me.lbl_restore.Size = New System.Drawing.Size(24, 21)
        Me.lbl_restore.TabIndex = 35
        Me.lbl_restore.Text = "**"
        '
        'FrmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1001, 461)
        Me.Controls.Add(Me.lbl_restore)
        Me.Controls.Add(Me.lbl_backup)
        Me.Controls.Add(Me.btn_examinarRest)
        Me.Controls.Add(Me.txb_direccionRestaurar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txb_nombrebackup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Restaurar)
        Me.Controls.Add(Me.btn_Respaldar)
        Me.Controls.Add(Me.btn_Examinar)
        Me.Controls.Add(Me.TxbDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDatabase"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Base de datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxbDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents btn_Examinar As BunifuFlatButton
    Friend WithEvents btn_Respaldar As BunifuFlatButton
    Friend WithEvents btn_Restaurar As BunifuFlatButton
    Friend WithEvents txb_nombrebackup As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txb_direccionRestaurar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_examinarRest As BunifuFlatButton
    Friend WithEvents lbl_backup As Label
    Friend WithEvents lbl_restore As Label
End Class
