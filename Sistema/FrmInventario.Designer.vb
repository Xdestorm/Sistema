<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConsultarAsignaciones = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbSitios = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvInv = New System.Windows.Forms.DataGridView()
        Me.btnConsultaDisponibles = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PbbuttonExcel = New System.Windows.Forms.PictureBox()
        Me.PBCerrar = New System.Windows.Forms.PictureBox()
        Me.txt_host = New MetroSet_UI.Controls.MetroSetTextBox()
        Me.btn_host = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbbuttonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(221, 30)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Reportes de inventario"
        '
        'BtnConsultarAsignaciones
        '
        Me.BtnConsultarAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultarAsignaciones.FlatAppearance.BorderSize = 0
        Me.BtnConsultarAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarAsignaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnConsultarAsignaciones.Location = New System.Drawing.Point(291, 46)
        Me.BtnConsultarAsignaciones.Name = "BtnConsultarAsignaciones"
        Me.BtnConsultarAsignaciones.Size = New System.Drawing.Size(112, 22)
        Me.BtnConsultarAsignaciones.TabIndex = 64
        Me.BtnConsultarAsignaciones.Text = "Consultar asignados"
        Me.BtnConsultarAsignaciones.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(10, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 21)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Seleccione sitio:"
        '
        'CbSitios
        '
        Me.CbSitios.BackColor = System.Drawing.Color.LightGray
        Me.CbSitios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbSitios.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CbSitios.FormattingEnabled = True
        Me.CbSitios.Location = New System.Drawing.Point(135, 42)
        Me.CbSitios.Name = "CbSitios"
        Me.CbSitios.Size = New System.Drawing.Size(150, 29)
        Me.CbSitios.TabIndex = 65
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvInv)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(17, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(988, 359)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventario "
        '
        'DgvInv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DgvInv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvInv.BackgroundColor = System.Drawing.Color.White
        Me.DgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvInv.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvInv.Location = New System.Drawing.Point(7, 20)
        Me.DgvInv.Name = "DgvInv"
        Me.DgvInv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvInv.RowTemplate.ReadOnly = True
        Me.DgvInv.Size = New System.Drawing.Size(975, 333)
        Me.DgvInv.TabIndex = 0
        '
        'btnConsultaDisponibles
        '
        Me.btnConsultaDisponibles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultaDisponibles.FlatAppearance.BorderSize = 0
        Me.btnConsultaDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaDisponibles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConsultaDisponibles.Location = New System.Drawing.Point(409, 46)
        Me.btnConsultaDisponibles.Name = "btnConsultaDisponibles"
        Me.btnConsultaDisponibles.Size = New System.Drawing.Size(117, 22)
        Me.btnConsultaDisponibles.TabIndex = 67
        Me.btnConsultaDisponibles.Text = "Consultar disponibles"
        Me.btnConsultaDisponibles.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(864, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Exportar"
        '
        'PbbuttonExcel
        '
        Me.PbbuttonExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbbuttonExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbbuttonExcel.Image = Global.Sistema.My.Resources.Resources.excel_icon
        Me.PbbuttonExcel.Location = New System.Drawing.Point(938, 55)
        Me.PbbuttonExcel.Name = "PbbuttonExcel"
        Me.PbbuttonExcel.Size = New System.Drawing.Size(40, 37)
        Me.PbbuttonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbbuttonExcel.TabIndex = 68
        Me.PbbuttonExcel.TabStop = False
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
        Me.PBCerrar.TabIndex = 60
        Me.PBCerrar.TabStop = False
        '
        'txt_host
        '
        Me.txt_host.AutoCompleteCustomSource = Nothing
        Me.txt_host.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txt_host.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txt_host.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.txt_host.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_host.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.txt_host.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txt_host.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_host.HoverColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txt_host.Image = Nothing
        Me.txt_host.Lines = Nothing
        Me.txt_host.Location = New System.Drawing.Point(546, 41)
        Me.txt_host.MaxLength = 32767
        Me.txt_host.Multiline = False
        Me.txt_host.Name = "txt_host"
        Me.txt_host.ReadOnly = False
        Me.txt_host.Size = New System.Drawing.Size(135, 30)
        Me.txt_host.Style = MetroSet_UI.Design.Style.Light
        Me.txt_host.StyleManager = Nothing
        Me.txt_host.TabIndex = 70
        Me.txt_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_host.ThemeAuthor = "Narwin"
        Me.txt_host.ThemeName = "MetroLite"
        Me.txt_host.UseSystemPasswordChar = False
        Me.txt_host.WatermarkText = ""
        '
        'btn_host
        '
        Me.btn_host.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_host.FlatAppearance.BorderSize = 0
        Me.btn_host.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_host.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_host.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_host.Location = New System.Drawing.Point(687, 46)
        Me.btn_host.Name = "btn_host"
        Me.btn_host.Size = New System.Drawing.Size(112, 22)
        Me.btn_host.TabIndex = 71
        Me.btn_host.Text = "Consultar HOST"
        Me.btn_host.UseVisualStyleBackColor = True
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 500)
        Me.Controls.Add(Me.btn_host)
        Me.Controls.Add(Me.txt_host)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PbbuttonExcel)
        Me.Controls.Add(Me.btnConsultaDisponibles)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CbSitios)
        Me.Controls.Add(Me.BtnConsultarAsignaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInventario"
        Me.Text = "FrmInventario"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbbuttonExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBCerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnConsultarAsignaciones As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CbSitios As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvInv As DataGridView
    Friend WithEvents btnConsultaDisponibles As Button
    Friend WithEvents PbbuttonExcel As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_host As MetroSet_UI.Controls.MetroSetTextBox
    Friend WithEvents btn_host As Button
End Class
