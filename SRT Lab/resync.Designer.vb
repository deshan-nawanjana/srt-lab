<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resync
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.spc = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.errr = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 91)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You can change the subtitle pyaing position from Resync."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtitle Resync"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(357, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter time in milliseconds. Insert + or - to set the Deferent"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(251, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 41)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Resync"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(106, 146)
        Me.TextBox1.MaxLength = 6
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 27)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'spc
        '
        Me.spc.AutoSize = True
        Me.spc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.spc.Location = New System.Drawing.Point(345, 154)
        Me.spc.Name = "spc"
        Me.spc.Size = New System.Drawing.Size(7, 13)
        Me.spc.TabIndex = 9
        Me.spc.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 28)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Resync : 0 ms"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'errr
        '
        Me.errr.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errr.ForeColor = System.Drawing.Color.Red
        Me.errr.Location = New System.Drawing.Point(6, 180)
        Me.errr.Name = "errr"
        Me.errr.Size = New System.Drawing.Size(362, 23)
        Me.errr.TabIndex = 11
        Me.errr.Text = "ghj"
        Me.errr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(376, 255)
        Me.Controls.Add(Me.errr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.spc)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "resync"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subtitle Resync"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents spc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents errr As System.Windows.Forms.Label
End Class
