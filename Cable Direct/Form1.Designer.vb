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
        Me.BusinessRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ResidentialRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PremiumListBox1 = New System.Windows.Forms.ListBox()
        Me.ConnectionsListBox2 = New System.Windows.Forms.ListBox()
        Me.CalculateButton1 = New System.Windows.Forms.Button()
        Me.ExitButton2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DueLabel4 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'BusinessRadioButton1
        '
        Me.BusinessRadioButton1.AutoSize = true
        Me.BusinessRadioButton1.Location = New System.Drawing.Point(12, 29)
        Me.BusinessRadioButton1.Name = "BusinessRadioButton1"
        Me.BusinessRadioButton1.Size = New System.Drawing.Size(67, 17)
        Me.BusinessRadioButton1.TabIndex = 0
        Me.BusinessRadioButton1.TabStop = true
        Me.BusinessRadioButton1.Text = "&Business"
        Me.BusinessRadioButton1.UseVisualStyleBackColor = true
        '
        'ResidentialRadioButton2
        '
        Me.ResidentialRadioButton2.AutoSize = true
        Me.ResidentialRadioButton2.Location = New System.Drawing.Point(12, 71)
        Me.ResidentialRadioButton2.Name = "ResidentialRadioButton2"
        Me.ResidentialRadioButton2.Size = New System.Drawing.Size(77, 17)
        Me.ResidentialRadioButton2.TabIndex = 1
        Me.ResidentialRadioButton2.TabStop = true
        Me.ResidentialRadioButton2.Text = "&Residential"
        Me.ResidentialRadioButton2.UseVisualStyleBackColor = true
        '
        'PremiumListBox1
        '
        Me.PremiumListBox1.FormattingEnabled = true
        Me.PremiumListBox1.Items.AddRange(New Object() {"lstPremium"})
        Me.PremiumListBox1.Location = New System.Drawing.Point(185, 40)
        Me.PremiumListBox1.Name = "PremiumListBox1"
        Me.PremiumListBox1.Size = New System.Drawing.Size(60, 69)
        Me.PremiumListBox1.TabIndex = 3
        '
        'ConnectionsListBox2
        '
        Me.ConnectionsListBox2.FormattingEnabled = true
        Me.ConnectionsListBox2.Items.AddRange(New Object() {"lstConnections"})
        Me.ConnectionsListBox2.Location = New System.Drawing.Point(330, 40)
        Me.ConnectionsListBox2.Name = "ConnectionsListBox2"
        Me.ConnectionsListBox2.ScrollAlwaysVisible = true
        Me.ConnectionsListBox2.Size = New System.Drawing.Size(60, 69)
        Me.ConnectionsListBox2.TabIndex = 4
        '
        'CalculateButton1
        '
        Me.CalculateButton1.Location = New System.Drawing.Point(249, 158)
        Me.CalculateButton1.Name = "CalculateButton1"
        Me.CalculateButton1.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton1.TabIndex = 5
        Me.CalculateButton1.Text = "Ca&culate"
        Me.CalculateButton1.UseVisualStyleBackColor = true
        '
        'ExitButton2
        '
        Me.ExitButton2.Location = New System.Drawing.Point(330, 158)
        Me.ExitButton2.Name = "ExitButton2"
        Me.ExitButton2.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton2.TabIndex = 6
        Me.ExitButton2.Text = "E&xit"
        Me.ExitButton2.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(182, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Premium channels:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(327, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&Connections:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(9, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total due:"
        '
        'DueLabel4
        '
        Me.DueLabel4.BackColor = System.Drawing.SystemColors.Info
        Me.DueLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DueLabel4.Location = New System.Drawing.Point(12, 158)
        Me.DueLabel4.Name = "DueLabel4"
        Me.DueLabel4.Size = New System.Drawing.Size(100, 23)
        Me.DueLabel4.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 241)
        Me.Controls.Add(Me.DueLabel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton2)
        Me.Controls.Add(Me.CalculateButton1)
        Me.Controls.Add(Me.ConnectionsListBox2)
        Me.Controls.Add(Me.PremiumListBox1)
        Me.Controls.Add(Me.ResidentialRadioButton2)
        Me.Controls.Add(Me.BusinessRadioButton1)
        Me.Name = "Form1"
        Me.Text = "Cable Direct"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents BusinessRadioButton1 As RadioButton
    Friend WithEvents ResidentialRadioButton2 As RadioButton
    Friend WithEvents PremiumListBox1 As ListBox
    Friend WithEvents ConnectionsListBox2 As ListBox
    Friend WithEvents CalculateButton1 As Button
    Friend WithEvents ExitButton2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DueLabel4 As Label
End Class
