<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elliptic_Curves_Cryptography_Diffie_Hellman
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.YourPKTB = New System.Windows.Forms.TextBox()
        Me.YourSKTB = New System.Windows.Forms.TextBox()
        Me.OtherPeoplePKTB = New System.Windows.Forms.TextBox()
        Me.OtherPeopleSKTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.YourSharedSecretTB = New System.Windows.Forms.TextBox()
        Me.OtherPeopleSharedSecretTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CalculateBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Calculation of Shared Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Your Public Key"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Your Private Key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Other People Public Key"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Other People Private Key"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(415, 26)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://www.youtube.com/watch?v=NmM9HA2MQGI&t"
        '
        'YourPKTB
        '
        Me.YourPKTB.Location = New System.Drawing.Point(147, 52)
        Me.YourPKTB.Name = "YourPKTB"
        Me.YourPKTB.ReadOnly = True
        Me.YourPKTB.Size = New System.Drawing.Size(771, 26)
        Me.YourPKTB.TabIndex = 10
        '
        'YourSKTB
        '
        Me.YourSKTB.Location = New System.Drawing.Point(147, 108)
        Me.YourSKTB.Name = "YourSKTB"
        Me.YourSKTB.ReadOnly = True
        Me.YourSKTB.Size = New System.Drawing.Size(771, 26)
        Me.YourSKTB.TabIndex = 11
        '
        'OtherPeoplePKTB
        '
        Me.OtherPeoplePKTB.Location = New System.Drawing.Point(200, 160)
        Me.OtherPeoplePKTB.Name = "OtherPeoplePKTB"
        Me.OtherPeoplePKTB.ReadOnly = True
        Me.OtherPeoplePKTB.Size = New System.Drawing.Size(771, 26)
        Me.OtherPeoplePKTB.TabIndex = 12
        '
        'OtherPeopleSKTB
        '
        Me.OtherPeopleSKTB.Location = New System.Drawing.Point(200, 213)
        Me.OtherPeopleSKTB.Name = "OtherPeopleSKTB"
        Me.OtherPeopleSKTB.ReadOnly = True
        Me.OtherPeopleSKTB.Size = New System.Drawing.Size(771, 26)
        Me.OtherPeopleSKTB.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Your Shared Secret"
        '
        'YourSharedSecretTB
        '
        Me.YourSharedSecretTB.Location = New System.Drawing.Point(172, 269)
        Me.YourSharedSecretTB.Name = "YourSharedSecretTB"
        Me.YourSharedSecretTB.ReadOnly = True
        Me.YourSharedSecretTB.Size = New System.Drawing.Size(771, 26)
        Me.YourSharedSecretTB.TabIndex = 15
        '
        'OtherPeopleSharedSecretTB
        '
        Me.OtherPeopleSharedSecretTB.Location = New System.Drawing.Point(231, 317)
        Me.OtherPeopleSharedSecretTB.Name = "OtherPeopleSharedSecretTB"
        Me.OtherPeopleSharedSecretTB.ReadOnly = True
        Me.OtherPeopleSharedSecretTB.Size = New System.Drawing.Size(771, 26)
        Me.OtherPeopleSharedSecretTB.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Other People Shared Secret"
        '
        'CalculateBTN
        '
        Me.CalculateBTN.Location = New System.Drawing.Point(20, 362)
        Me.CalculateBTN.Name = "CalculateBTN"
        Me.CalculateBTN.Size = New System.Drawing.Size(164, 48)
        Me.CalculateBTN.TabIndex = 18
        Me.CalculateBTN.Text = "Calculate"
        Me.CalculateBTN.UseVisualStyleBackColor = True
        '
        'Elliptic_Curves_Cryptography_Diffie_Hellman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 647)
        Me.Controls.Add(Me.CalculateBTN)
        Me.Controls.Add(Me.OtherPeopleSharedSecretTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.YourSharedSecretTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OtherPeopleSKTB)
        Me.Controls.Add(Me.OtherPeoplePKTB)
        Me.Controls.Add(Me.YourSKTB)
        Me.Controls.Add(Me.YourPKTB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Elliptic_Curves_Cryptography_Diffie_Hellman"
        Me.Text = "Elliptic_Curves_Cryptography_Diffie_Hellman"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents YourPKTB As TextBox
    Friend WithEvents YourSKTB As TextBox
    Friend WithEvents OtherPeoplePKTB As TextBox
    Friend WithEvents OtherPeopleSKTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents YourSharedSecretTB As TextBox
    Friend WithEvents OtherPeopleSharedSecretTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CalculateBTN As Button
End Class
