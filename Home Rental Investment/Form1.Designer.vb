<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeRentalInvestmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homeRentalInvestmentForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameTextbox = New System.Windows.Forms.TextBox()
        Me.numYearsLabel = New System.Windows.Forms.Label()
        Me.rentalYearsTextbox = New System.Windows.Forms.TextBox()
        Me.homePriceLabel = New System.Windows.Forms.Label()
        Me.homePriceTextbox = New System.Windows.Forms.TextBox()
        Me.rentalCityLabel = New System.Windows.Forms.Label()
        Me.rentalCityCombobox = New System.Windows.Forms.ComboBox()
        Me.returnInvestmentLabel = New System.Windows.Forms.Label()
        Me.returnOutputLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 319)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(339, 27)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(335, 31)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Home Rental Investment"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(351, 73)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(55, 20)
        Me.nameLabel.TabIndex = 2
        Me.nameLabel.Text = "Name:"
        '
        'nameTextbox
        '
        Me.nameTextbox.Location = New System.Drawing.Point(426, 72)
        Me.nameTextbox.Name = "nameTextbox"
        Me.nameTextbox.Size = New System.Drawing.Size(232, 20)
        Me.nameTextbox.TabIndex = 3
        '
        'numYearsLabel
        '
        Me.numYearsLabel.AutoSize = True
        Me.numYearsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numYearsLabel.Location = New System.Drawing.Point(351, 113)
        Me.numYearsLabel.Name = "numYearsLabel"
        Me.numYearsLabel.Size = New System.Drawing.Size(184, 20)
        Me.numYearsLabel.TabIndex = 4
        Me.numYearsLabel.Text = "Number of Rental Years:"
        '
        'rentalYearsTextbox
        '
        Me.rentalYearsTextbox.Location = New System.Drawing.Point(554, 113)
        Me.rentalYearsTextbox.Name = "rentalYearsTextbox"
        Me.rentalYearsTextbox.Size = New System.Drawing.Size(104, 20)
        Me.rentalYearsTextbox.TabIndex = 5
        '
        'homePriceLabel
        '
        Me.homePriceLabel.AutoSize = True
        Me.homePriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homePriceLabel.Location = New System.Drawing.Point(351, 156)
        Me.homePriceLabel.Name = "homePriceLabel"
        Me.homePriceLabel.Size = New System.Drawing.Size(95, 20)
        Me.homePriceLabel.TabIndex = 6
        Me.homePriceLabel.Text = "Home Price:"
        '
        'homePriceTextbox
        '
        Me.homePriceTextbox.Location = New System.Drawing.Point(465, 156)
        Me.homePriceTextbox.Name = "homePriceTextbox"
        Me.homePriceTextbox.Size = New System.Drawing.Size(193, 20)
        Me.homePriceTextbox.TabIndex = 7
        '
        'rentalCityLabel
        '
        Me.rentalCityLabel.AutoSize = True
        Me.rentalCityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rentalCityLabel.Location = New System.Drawing.Point(351, 203)
        Me.rentalCityLabel.Name = "rentalCityLabel"
        Me.rentalCityLabel.Size = New System.Drawing.Size(90, 20)
        Me.rentalCityLabel.TabIndex = 8
        Me.rentalCityLabel.Text = "Rental City:"
        '
        'rentalCityCombobox
        '
        Me.rentalCityCombobox.FormattingEnabled = True
        Me.rentalCityCombobox.Items.AddRange(New Object() {"Memphis", "Ocala", "Atlanta", "Phoenix", "Ogden"})
        Me.rentalCityCombobox.Location = New System.Drawing.Point(465, 205)
        Me.rentalCityCombobox.Name = "rentalCityCombobox"
        Me.rentalCityCombobox.Size = New System.Drawing.Size(193, 21)
        Me.rentalCityCombobox.TabIndex = 9
        '
        'returnInvestmentLabel
        '
        Me.returnInvestmentLabel.AutoSize = True
        Me.returnInvestmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnInvestmentLabel.Location = New System.Drawing.Point(351, 250)
        Me.returnInvestmentLabel.Name = "returnInvestmentLabel"
        Me.returnInvestmentLabel.Size = New System.Drawing.Size(167, 20)
        Me.returnInvestmentLabel.TabIndex = 10
        Me.returnInvestmentLabel.Text = "Return on Investment:"
        '
        'returnOutputLabel
        '
        Me.returnOutputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnOutputLabel.Location = New System.Drawing.Point(524, 250)
        Me.returnOutputLabel.Name = "returnOutputLabel"
        Me.returnOutputLabel.Size = New System.Drawing.Size(134, 20)
        Me.returnOutputLabel.TabIndex = 11
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(355, 308)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(138, 38)
        Me.calculateButton.TabIndex = 12
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(520, 308)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(138, 38)
        Me.exitButton.TabIndex = 13
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'homeRentalInvestmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(695, 369)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.returnOutputLabel)
        Me.Controls.Add(Me.returnInvestmentLabel)
        Me.Controls.Add(Me.rentalCityCombobox)
        Me.Controls.Add(Me.rentalCityLabel)
        Me.Controls.Add(Me.homePriceTextbox)
        Me.Controls.Add(Me.homePriceLabel)
        Me.Controls.Add(Me.rentalYearsTextbox)
        Me.Controls.Add(Me.numYearsLabel)
        Me.Controls.Add(Me.nameTextbox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "homeRentalInvestmentForm"
        Me.Text = "Home Rental Investment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents nameTextbox As TextBox
    Friend WithEvents numYearsLabel As Label
    Friend WithEvents rentalYearsTextbox As TextBox
    Friend WithEvents homePriceLabel As Label
    Friend WithEvents homePriceTextbox As TextBox
    Friend WithEvents rentalCityLabel As Label
    Friend WithEvents rentalCityCombobox As ComboBox
    Friend WithEvents returnInvestmentLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents returnOutputLabel As Label
End Class
