<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DirectionsCombo = New System.Windows.Forms.ComboBox()
        Me.yCoordText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.elevationText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SextantReadingText = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xCoordtext = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.worldText = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DirectionsPicture = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddLocationButton = New System.Windows.Forms.Button()
        Me.UserInputText = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LocationCheckBox = New System.Windows.Forms.ListBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.debugText = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DirectionsPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(7, 19)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 165)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.BackgroundImage = Global.UOSextant.My.Resources.Resources.black_background
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.DirectionsCombo)
        Me.TabPage1.Controls.Add(Me.yCoordText)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.elevationText)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.SextantReadingText)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.xCoordtext)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.worldText)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.DirectionsPicture)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(332, 136)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sextant"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(-7, 136)
        Me.Panel3.MaximumSize = New System.Drawing.Size(349, 10)
        Me.Panel3.MinimumSize = New System.Drawing.Size(349, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(349, 10)
        Me.Panel3.TabIndex = 18
        '
        'DirectionsCombo
        '
        Me.DirectionsCombo.BackColor = System.Drawing.Color.Black
        Me.DirectionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DirectionsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DirectionsCombo.ForeColor = System.Drawing.Color.Gold
        Me.DirectionsCombo.FormattingEnabled = True
        Me.DirectionsCombo.Location = New System.Drawing.Point(161, 101)
        Me.DirectionsCombo.MaxDropDownItems = 20
        Me.DirectionsCombo.Name = "DirectionsCombo"
        Me.DirectionsCombo.Size = New System.Drawing.Size(157, 21)
        Me.DirectionsCombo.TabIndex = 11
        '
        'yCoordText
        '
        Me.yCoordText.AutoSize = True
        Me.yCoordText.BackColor = System.Drawing.Color.Transparent
        Me.yCoordText.Location = New System.Drawing.Point(114, 66)
        Me.yCoordText.MinimumSize = New System.Drawing.Size(76, 13)
        Me.yCoordText.Name = "yCoordText"
        Me.yCoordText.Size = New System.Drawing.Size(76, 13)
        Me.yCoordText.TabIndex = 17
        Me.yCoordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X- Coordinate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y-Coordinate"
        '
        'elevationText
        '
        Me.elevationText.AutoSize = True
        Me.elevationText.BackColor = System.Drawing.Color.Transparent
        Me.elevationText.Location = New System.Drawing.Point(130, 30)
        Me.elevationText.MinimumSize = New System.Drawing.Size(55, 13)
        Me.elevationText.Name = "elevationText"
        Me.elevationText.Size = New System.Drawing.Size(55, 13)
        Me.elevationText.TabIndex = 16
        Me.elevationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Facet"
        '
        'SextantReadingText
        '
        Me.SextantReadingText.AutoSize = True
        Me.SextantReadingText.BackColor = System.Drawing.Color.Transparent
        Me.SextantReadingText.Location = New System.Drawing.Point(12, 105)
        Me.SextantReadingText.MinimumSize = New System.Drawing.Size(140, 13)
        Me.SextantReadingText.Name = "SextantReadingText"
        Me.SextantReadingText.Size = New System.Drawing.Size(140, 13)
        Me.SextantReadingText.TabIndex = 15
        Me.SextantReadingText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(130, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Elevation"
        '
        'xCoordtext
        '
        Me.xCoordtext.AutoSize = True
        Me.xCoordtext.BackColor = System.Drawing.Color.Transparent
        Me.xCoordtext.Location = New System.Drawing.Point(12, 66)
        Me.xCoordtext.MinimumSize = New System.Drawing.Size(76, 13)
        Me.xCoordtext.Name = "xCoordtext"
        Me.xCoordtext.Size = New System.Drawing.Size(76, 13)
        Me.xCoordtext.TabIndex = 14
        Me.xCoordtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sextant Reading"
        '
        'worldText
        '
        Me.worldText.AutoSize = True
        Me.worldText.BackColor = System.Drawing.Color.Transparent
        Me.worldText.Location = New System.Drawing.Point(11, 30)
        Me.worldText.MinimumSize = New System.Drawing.Size(50, 13)
        Me.worldText.Name = "worldText"
        Me.worldText.Size = New System.Drawing.Size(50, 13)
        Me.worldText.TabIndex = 13
        Me.worldText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(235, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Directions To:"
        '
        'DirectionsPicture
        '
        Me.DirectionsPicture.BackColor = System.Drawing.Color.Transparent
        Me.DirectionsPicture.InitialImage = Nothing
        Me.DirectionsPicture.Location = New System.Drawing.Point(258, 12)
        Me.DirectionsPicture.MaximumSize = New System.Drawing.Size(60, 60)
        Me.DirectionsPicture.MinimumSize = New System.Drawing.Size(60, 60)
        Me.DirectionsPicture.Name = "DirectionsPicture"
        Me.DirectionsPicture.Size = New System.Drawing.Size(60, 60)
        Me.DirectionsPicture.TabIndex = 12
        Me.DirectionsPicture.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.UOSextant.My.Resources.Resources.black_background
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.AddLocationButton)
        Me.TabPage2.Controls.Add(Me.UserInputText)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(332, 136)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add Location"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 8)
        Me.Label7.MaximumSize = New System.Drawing.Size(325, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(323, 39)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Enter A Name For The Location In Which Ye Stand And It Shall Be Recorded In Your " &
    "Personal Collection Of Locations. ( 20 Character Max )"
        '
        'AddLocationButton
        '
        Me.AddLocationButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddLocationButton.Location = New System.Drawing.Point(221, 106)
        Me.AddLocationButton.Name = "AddLocationButton"
        Me.AddLocationButton.Size = New System.Drawing.Size(104, 23)
        Me.AddLocationButton.TabIndex = 1
        Me.AddLocationButton.Text = "Add Location"
        Me.AddLocationButton.UseVisualStyleBackColor = False
        '
        'UserInputText
        '
        Me.UserInputText.BackColor = System.Drawing.Color.Black
        Me.UserInputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserInputText.ForeColor = System.Drawing.Color.Gold
        Me.UserInputText.Location = New System.Drawing.Point(162, 80)
        Me.UserInputText.MaxLength = 20
        Me.UserInputText.Name = "UserInputText"
        Me.UserInputText.Size = New System.Drawing.Size(163, 20)
        Me.UserInputText.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.UOSextant.My.Resources.Resources.black_background
        Me.TabPage3.Controls.Add(Me.LocationCheckBox)
        Me.TabPage3.Controls.Add(Me.DeleteButton)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(332, 136)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Remove Location"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LocationCheckBox
        '
        Me.LocationCheckBox.BackColor = System.Drawing.Color.Black
        Me.LocationCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LocationCheckBox.ForeColor = System.Drawing.Color.White
        Me.LocationCheckBox.FormattingEnabled = True
        Me.LocationCheckBox.Location = New System.Drawing.Point(1, 2)
        Me.LocationCheckBox.MaximumSize = New System.Drawing.Size(330, 110)
        Me.LocationCheckBox.MinimumSize = New System.Drawing.Size(330, 110)
        Me.LocationCheckBox.Name = "LocationCheckBox"
        Me.LocationCheckBox.ScrollAlwaysVisible = True
        Me.LocationCheckBox.Size = New System.Drawing.Size(330, 104)
        Me.LocationCheckBox.TabIndex = 2
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteButton.ForeColor = System.Drawing.Color.Gold
        Me.DeleteButton.Location = New System.Drawing.Point(156, 112)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(175, 23)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Delete Selected Location"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.UOSextant.My.Resources.Resources.black_background
        Me.TabPage4.Controls.Add(Me.debugText)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.LinkLabel1)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(332, 136)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "About"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'debugText
        '
        Me.debugText.Location = New System.Drawing.Point(103, 46)
        Me.debugText.Name = "debugText"
        Me.debugText.Size = New System.Drawing.Size(221, 20)
        Me.debugText.TabIndex = 5
        Me.debugText.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(99, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Follow Along In The Adventure:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gold
        Me.LinkLabel1.Location = New System.Drawing.Point(115, 99)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(182, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "The Advenures Of Nightstalker"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Olive
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(120, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nightstalker Of Siege Perilous"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(100, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Created By:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.UOSextant.My.Resources.Resources.uo_banner
        Me.PictureBox1.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Location = New System.Drawing.Point(321, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(15, 16)
        Me.ExitButton.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.MaximumSize = New System.Drawing.Size(11, 186)
        Me.Panel1.MinimumSize = New System.Drawing.Size(11, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(11, 186)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Location = New System.Drawing.Point(342, 1)
        Me.Panel2.MaximumSize = New System.Drawing.Size(12, 186)
        Me.Panel2.MinimumSize = New System.Drawing.Size(12, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 186)
        Me.Panel2.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Location = New System.Drawing.Point(1, 179)
        Me.Panel4.MaximumSize = New System.Drawing.Size(349, 10)
        Me.Panel4.MinimumSize = New System.Drawing.Size(349, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(349, 10)
        Me.Panel4.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.Location = New System.Drawing.Point(11, 40)
        Me.Panel5.MaximumSize = New System.Drawing.Size(334, 5)
        Me.Panel5.MinimumSize = New System.Drawing.Size(334, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(334, 5)
        Me.Panel5.TabIndex = 0
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(355, 190)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(355, 190)
        Me.MinimumSize = New System.Drawing.Size(355, 190)
        Me.Name = "Form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UO Sextant"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DirectionsPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DirectionsCombo As ComboBox
    Friend WithEvents yCoordText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents elevationText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SextantReadingText As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents xCoordtext As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents worldText As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DirectionsPicture As PictureBox
    Friend WithEvents ExitButton As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents AddLocationButton As Button
    Friend WithEvents UserInputText As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Public WithEvents Timer1 As Timer
    Friend WithEvents debugText As TextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents LocationCheckBox As ListBox
End Class
