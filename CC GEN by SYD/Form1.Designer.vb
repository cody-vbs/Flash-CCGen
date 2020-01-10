<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GhostTheme1 = New CC_GEN_by_SYD.GhostTheme()
        Me.PanelScroll = New System.Windows.Forms.Panel()
        Me.LabelScroll = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GhostButtonExport = New CC_GEN_by_SYD.GhostButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxQuantity = New CC_GEN_by_SYD.GhostTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCVV = New CC_GEN_by_SYD.GhostTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxYear = New CC_GEN_by_SYD.GhostComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxMonth = New CC_GEN_by_SYD.GhostComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBin = New CC_GEN_by_SYD.GhostTextBox()
        Me.GhostButtonGenerate = New CC_GEN_by_SYD.GhostButton()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GhostTheme1.SuspendLayout()
        Me.PanelScroll.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Location = New System.Drawing.Point(594, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 23)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Minimize")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(624, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 23)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Close")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(619, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Copy CC")
        '
        'Timer1
        '
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New CC_GEN_by_SYD.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.PanelScroll)
        Me.GhostTheme1.Controls.Add(Me.PictureBox4)
        Me.GhostTheme1.Controls.Add(Me.PictureBox3)
        Me.GhostTheme1.Controls.Add(Me.PictureBox2)
        Me.GhostTheme1.Controls.Add(Me.PictureBox1)
        Me.GhostTheme1.Controls.Add(Me.ListBox1)
        Me.GhostTheme1.Controls.Add(Me.Panel1)
        Me.GhostTheme1.Controls.Add(Me.Label6)
        Me.GhostTheme1.Controls.Add(Me.GhostButtonExport)
        Me.GhostTheme1.Controls.Add(Me.Label5)
        Me.GhostTheme1.Controls.Add(Me.TextBoxQuantity)
        Me.GhostTheme1.Controls.Add(Me.Label4)
        Me.GhostTheme1.Controls.Add(Me.TextBoxCVV)
        Me.GhostTheme1.Controls.Add(Me.Label3)
        Me.GhostTheme1.Controls.Add(Me.ComboBoxYear)
        Me.GhostTheme1.Controls.Add(Me.Label2)
        Me.GhostTheme1.Controls.Add(Me.ComboBoxMonth)
        Me.GhostTheme1.Controls.Add(Me.Label1)
        Me.GhostTheme1.Controls.Add(Me.TextBoxBin)
        Me.GhostTheme1.Controls.Add(Me.GhostButtonGenerate)
        Me.GhostTheme1.Customization = ""
        Me.GhostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GhostTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostTheme1.Image = Nothing
        Me.GhostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.GhostTheme1.Movable = True
        Me.GhostTheme1.Name = "GhostTheme1"
        Me.GhostTheme1.NoRounding = False
        Me.GhostTheme1.ShowIcon = True
        Me.GhostTheme1.Sizable = True
        Me.GhostTheme1.Size = New System.Drawing.Size(664, 378)
        Me.GhostTheme1.SmartBounds = True
        Me.GhostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.GhostTheme1.TabIndex = 0
        Me.GhostTheme1.Text = "Flash CCGen"
        Me.GhostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.Transparent = False
        '
        'PanelScroll
        '
        Me.PanelScroll.BackColor = System.Drawing.Color.Transparent
        Me.PanelScroll.Controls.Add(Me.LabelScroll)
        Me.PanelScroll.Location = New System.Drawing.Point(362, 339)
        Me.PanelScroll.Name = "PanelScroll"
        Me.PanelScroll.Size = New System.Drawing.Size(286, 27)
        Me.PanelScroll.TabIndex = 23
        '
        'LabelScroll
        '
        Me.LabelScroll.AutoSize = True
        Me.LabelScroll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScroll.ForeColor = System.Drawing.Color.Silver
        Me.LabelScroll.Location = New System.Drawing.Point(74, 5)
        Me.LabelScroll.Name = "LabelScroll"
        Me.LabelScroll.Size = New System.Drawing.Size(146, 16)
        Me.LabelScroll.TabIndex = 22
        Me.LabelScroll.Text = "Developed By: SYD"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(282, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 40)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"xxxxxxxxxxxxxxxx"})
        Me.ListBox1.Location = New System.Drawing.Point(350, 61)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(302, 276)
        Me.ListBox1.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(51, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 56)
        Me.Panel1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 37)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Flash CCGen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(347, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "RESULTS"
        '
        'GhostButtonExport
        '
        Me.GhostButtonExport.Color = System.Drawing.Color.Empty
        Me.GhostButtonExport.Colors = New CC_GEN_by_SYD.Bloom(-1) {}
        Me.GhostButtonExport.Customization = ""
        Me.GhostButtonExport.EnableGlass = True
        Me.GhostButtonExport.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButtonExport.Image = Nothing
        Me.GhostButtonExport.Location = New System.Drawing.Point(11, 326)
        Me.GhostButtonExport.Name = "GhostButtonExport"
        Me.GhostButtonExport.NoRounding = False
        Me.GhostButtonExport.Size = New System.Drawing.Size(331, 41)
        Me.GhostButtonExport.TabIndex = 13
        Me.GhostButtonExport.Text = "Export CC"
        Me.GhostButtonExport.Transparent = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(171, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Customization = "/////wAAAP8AAAD/Wlpa/w=="
        Me.TextBoxQuantity.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TextBoxQuantity.Image = Nothing
        Me.TextBoxQuantity.Location = New System.Drawing.Point(177, 242)
        Me.TextBoxQuantity.MaxLength = 32767
        Me.TextBoxQuantity.Multiline = False
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.NoRounding = False
        Me.TextBoxQuantity.ReadOnly = False
        Me.TextBoxQuantity.Size = New System.Drawing.Size(158, 24)
        Me.TextBoxQuantity.TabIndex = 11
        Me.TextBoxQuantity.Text = "10"
        Me.TextBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxQuantity.Transparent = False
        Me.TextBoxQuantity.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CVV"
        '
        'TextBoxCVV
        '
        Me.TextBoxCVV.Customization = "/////wAAAP8AAAD/Wlpa/w=="
        Me.TextBoxCVV.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TextBoxCVV.Image = Nothing
        Me.TextBoxCVV.Location = New System.Drawing.Point(13, 242)
        Me.TextBoxCVV.MaxLength = 32767
        Me.TextBoxCVV.Multiline = False
        Me.TextBoxCVV.Name = "TextBoxCVV"
        Me.TextBoxCVV.NoRounding = False
        Me.TextBoxCVV.ReadOnly = False
        Me.TextBoxCVV.Size = New System.Drawing.Size(158, 24)
        Me.TextBoxCVV.TabIndex = 9
        Me.TextBoxCVV.Text = "Leave blank to randomize"
        Me.TextBoxCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxCVV.Transparent = False
        Me.TextBoxCVV.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(172, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "YEAR"
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ComboBoxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.ItemHeight = 20
        Me.ComboBoxYear.Items.AddRange(New Object() {"Random", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028"})
        Me.ComboBoxYear.Location = New System.Drawing.Point(175, 174)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(146, 26)
        Me.ComboBoxYear.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MONTH"
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ComboBoxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.ItemHeight = 20
        Me.ComboBoxMonth.Items.AddRange(New Object() {"Random", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBoxMonth.Location = New System.Drawing.Point(11, 174)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(146, 26)
        Me.ComboBoxMonth.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BIN"
        '
        'TextBoxBin
        '
        Me.TextBoxBin.Customization = "/////wAAAP8AAAD/Wlpa/w=="
        Me.TextBoxBin.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TextBoxBin.Image = Nothing
        Me.TextBoxBin.Location = New System.Drawing.Point(53, 100)
        Me.TextBoxBin.MaxLength = 32767
        Me.TextBoxBin.Multiline = False
        Me.TextBoxBin.Name = "TextBoxBin"
        Me.TextBoxBin.NoRounding = False
        Me.TextBoxBin.ReadOnly = False
        Me.TextBoxBin.Size = New System.Drawing.Size(287, 24)
        Me.TextBoxBin.TabIndex = 4
        Me.TextBoxBin.Text = "453590"
        Me.TextBoxBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxBin.Transparent = False
        Me.TextBoxBin.UseSystemPasswordChar = False
        '
        'GhostButtonGenerate
        '
        Me.GhostButtonGenerate.Color = System.Drawing.Color.Empty
        Me.GhostButtonGenerate.Colors = New CC_GEN_by_SYD.Bloom(-1) {}
        Me.GhostButtonGenerate.Customization = ""
        Me.GhostButtonGenerate.EnableGlass = True
        Me.GhostButtonGenerate.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButtonGenerate.Image = Nothing
        Me.GhostButtonGenerate.Location = New System.Drawing.Point(11, 282)
        Me.GhostButtonGenerate.Name = "GhostButtonGenerate"
        Me.GhostButtonGenerate.NoRounding = False
        Me.GhostButtonGenerate.Size = New System.Drawing.Size(331, 41)
        Me.GhostButtonGenerate.TabIndex = 1
        Me.GhostButtonGenerate.Text = "Generate"
        Me.GhostButtonGenerate.Transparent = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 378)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GhostTheme1.ResumeLayout(False)
        Me.GhostTheme1.PerformLayout()
        Me.PanelScroll.ResumeLayout(False)
        Me.PanelScroll.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GhostTheme1 As GhostTheme
    Friend WithEvents GhostButtonGenerate As GhostButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxQuantity As GhostTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCVV As GhostTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxYear As GhostComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxMonth As GhostComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBin As GhostTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GhostButtonExport As GhostButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PanelScroll As Panel
    Friend WithEvents LabelScroll As Label
    Friend WithEvents Timer1 As Timer
End Class
