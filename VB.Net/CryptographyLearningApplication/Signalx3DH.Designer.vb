<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signalx3DH
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
        Me.CalculateBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AliceDHSession1TB = New System.Windows.Forms.TextBox()
        Me.AliceDHSession2TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AliceDHSession3TB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AliceDHSession4TB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AliceMasterSecretTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BobMasterSecretTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BobDHSession4TB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BobDHSession3TB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BobDHSession2TB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BobDHSession1TB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalculateBTN
        '
        Me.CalculateBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CalculateBTN.ForeColor = System.Drawing.Color.Green
        Me.CalculateBTN.Location = New System.Drawing.Point(17, 775)
        Me.CalculateBTN.Name = "CalculateBTN"
        Me.CalculateBTN.Size = New System.Drawing.Size(233, 80)
        Me.CalculateBTN.TabIndex = 24
        Me.CalculateBTN.Text = "Calculate"
        Me.CalculateBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Alice DH Session 1 "
        '
        'AliceDHSession1TB
        '
        Me.AliceDHSession1TB.Location = New System.Drawing.Point(17, 37)
        Me.AliceDHSession1TB.Name = "AliceDHSession1TB"
        Me.AliceDHSession1TB.ReadOnly = True
        Me.AliceDHSession1TB.Size = New System.Drawing.Size(732, 26)
        Me.AliceDHSession1TB.TabIndex = 26
        '
        'AliceDHSession2TB
        '
        Me.AliceDHSession2TB.Location = New System.Drawing.Point(17, 109)
        Me.AliceDHSession2TB.Name = "AliceDHSession2TB"
        Me.AliceDHSession2TB.ReadOnly = True
        Me.AliceDHSession2TB.Size = New System.Drawing.Size(732, 26)
        Me.AliceDHSession2TB.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Alice DH Session 2"
        '
        'AliceDHSession3TB
        '
        Me.AliceDHSession3TB.Location = New System.Drawing.Point(17, 184)
        Me.AliceDHSession3TB.Name = "AliceDHSession3TB"
        Me.AliceDHSession3TB.ReadOnly = True
        Me.AliceDHSession3TB.Size = New System.Drawing.Size(732, 26)
        Me.AliceDHSession3TB.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Alice DH Session 3"
        '
        'AliceDHSession4TB
        '
        Me.AliceDHSession4TB.Location = New System.Drawing.Point(17, 261)
        Me.AliceDHSession4TB.Name = "AliceDHSession4TB"
        Me.AliceDHSession4TB.ReadOnly = True
        Me.AliceDHSession4TB.Size = New System.Drawing.Size(732, 26)
        Me.AliceDHSession4TB.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Alice DH Session 4"
        '
        'AliceMasterSecretTB
        '
        Me.AliceMasterSecretTB.Location = New System.Drawing.Point(17, 337)
        Me.AliceMasterSecretTB.Name = "AliceMasterSecretTB"
        Me.AliceMasterSecretTB.ReadOnly = True
        Me.AliceMasterSecretTB.Size = New System.Drawing.Size(732, 26)
        Me.AliceMasterSecretTB.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Alice Master Secret"
        '
        'BobMasterSecretTB
        '
        Me.BobMasterSecretTB.Location = New System.Drawing.Point(17, 718)
        Me.BobMasterSecretTB.Name = "BobMasterSecretTB"
        Me.BobMasterSecretTB.ReadOnly = True
        Me.BobMasterSecretTB.Size = New System.Drawing.Size(732, 26)
        Me.BobMasterSecretTB.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 694)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Bob Master Secret"
        '
        'BobDHSession4TB
        '
        Me.BobDHSession4TB.Location = New System.Drawing.Point(17, 642)
        Me.BobDHSession4TB.Name = "BobDHSession4TB"
        Me.BobDHSession4TB.ReadOnly = True
        Me.BobDHSession4TB.Size = New System.Drawing.Size(732, 26)
        Me.BobDHSession4TB.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 618)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Bob DH Session 4"
        '
        'BobDHSession3TB
        '
        Me.BobDHSession3TB.Location = New System.Drawing.Point(17, 565)
        Me.BobDHSession3TB.Name = "BobDHSession3TB"
        Me.BobDHSession3TB.ReadOnly = True
        Me.BobDHSession3TB.Size = New System.Drawing.Size(732, 26)
        Me.BobDHSession3TB.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 541)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Bob DH Session 3"
        '
        'BobDHSession2TB
        '
        Me.BobDHSession2TB.Location = New System.Drawing.Point(17, 490)
        Me.BobDHSession2TB.Name = "BobDHSession2TB"
        Me.BobDHSession2TB.ReadOnly = True
        Me.BobDHSession2TB.Size = New System.Drawing.Size(732, 26)
        Me.BobDHSession2TB.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 466)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Bob DH Session 2"
        '
        'BobDHSession1TB
        '
        Me.BobDHSession1TB.Location = New System.Drawing.Point(17, 418)
        Me.BobDHSession1TB.Name = "BobDHSession1TB"
        Me.BobDHSession1TB.ReadOnly = True
        Me.BobDHSession1TB.Size = New System.Drawing.Size(732, 26)
        Me.BobDHSession1TB.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Bob DH Session 1 "
        '
        'Signalx3DH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 884)
        Me.Controls.Add(Me.BobMasterSecretTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BobDHSession4TB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BobDHSession3TB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BobDHSession2TB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BobDHSession1TB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AliceMasterSecretTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AliceDHSession4TB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AliceDHSession3TB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AliceDHSession2TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AliceDHSession1TB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CalculateBTN)
        Me.Name = "Signalx3DH"
        Me.Text = "Signalx3DH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalculateBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AliceDHSession1TB As TextBox
    Friend WithEvents AliceDHSession2TB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AliceDHSession3TB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AliceDHSession4TB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AliceMasterSecretTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BobMasterSecretTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BobDHSession4TB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BobDHSession3TB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BobDHSession2TB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BobDHSession1TB As TextBox
    Friend WithEvents Label10 As Label
End Class
