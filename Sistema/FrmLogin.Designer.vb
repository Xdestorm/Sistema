<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.cbx_Tipo = New MetroSet_UI.Controls.MetroSetComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OK = New MetroSet_UI.Controls.MetroSetButton()
        Me.Cancel = New MetroSet_UI.Controls.MetroSetButton()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(363, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(366, 58)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Location = New System.Drawing.Point(366, 35)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Location = New System.Drawing.Point(366, 84)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'cbx_Tipo
        '
        Me.cbx_Tipo.AllowDrop = True
        Me.cbx_Tipo.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.cbx_Tipo.BackColor = System.Drawing.Color.Transparent
        Me.cbx_Tipo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbx_Tipo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.cbx_Tipo.CausesValidation = False
        Me.cbx_Tipo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cbx_Tipo.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cbx_Tipo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbx_Tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbx_Tipo.FormattingEnabled = True
        Me.cbx_Tipo.ItemHeight = 20
        Me.cbx_Tipo.Location = New System.Drawing.Point(465, 110)
        Me.cbx_Tipo.Name = "cbx_Tipo"
        Me.cbx_Tipo.SelectedItemBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbx_Tipo.SelectedItemForeColor = System.Drawing.Color.White
        Me.cbx_Tipo.Size = New System.Drawing.Size(121, 26)
        Me.cbx_Tipo.Style = MetroSet_UI.Design.Style.Light
        Me.cbx_Tipo.StyleManager = Nothing
        Me.cbx_Tipo.TabIndex = 6
        Me.cbx_Tipo.ThemeAuthor = "Narwin"
        Me.cbx_Tipo.ThemeName = "MetroLite"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(366, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Tipo de usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OK
        '
        Me.OK.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.OK.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.OK.DisabledForeColor = System.Drawing.Color.Gray
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OK.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OK.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OK.HoverTextColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(390, 171)
        Me.OK.Name = "OK"
        Me.OK.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.OK.NormalColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.OK.NormalTextColor = System.Drawing.Color.White
        Me.OK.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.OK.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.OK.PressTextColor = System.Drawing.Color.White
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.Style = MetroSet_UI.Design.Style.Light
        Me.OK.StyleManager = Nothing
        Me.OK.TabIndex = 8
        Me.OK.Text = "Consultar"
        Me.OK.ThemeAuthor = "Narwin"
        Me.OK.ThemeName = "MetroLite"
        '
        'Cancel
        '
        Me.Cancel.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Cancel.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Cancel.DisabledForeColor = System.Drawing.Color.Gray
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cancel.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel.HoverTextColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(492, 171)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Cancel.NormalColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Cancel.NormalTextColor = System.Drawing.Color.White
        Me.Cancel.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Cancel.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Cancel.PressTextColor = System.Drawing.Color.White
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.Style = MetroSet_UI.Design.Style.Light
        Me.Cancel.StyleManager = Nothing
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "Cancelar"
        Me.Cancel.ThemeAuthor = "Narwin"
        Me.Cancel.ThemeName = "MetroLite"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1001, 461)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbx_Tipo)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administración de acceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_Tipo As MetroSet_UI.Controls.MetroSetComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OK As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents Cancel As MetroSet_UI.Controls.MetroSetButton
End Class
