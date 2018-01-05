<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnToss
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
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblTails = New System.Windows.Forms.Label()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(102, 263)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(110, 23)
        Me.btnT.TabIndex = 0
        Me.btnT.Text = "Toss the Coin"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(364, 263)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picTails
        '
        Me.picTails.Image = Global.Coin_toss.My.Resources.Resources.images
        Me.picTails.Location = New System.Drawing.Point(303, 54)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(195, 134)
        Me.picTails.TabIndex = 3
        Me.picTails.TabStop = False
        '
        'picHeads
        '
        Me.picHeads.Image = Global.Coin_toss.My.Resources.Resources.imgres
        Me.picHeads.Location = New System.Drawing.Point(38, 12)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(223, 213)
        Me.picHeads.TabIndex = 2
        Me.picHeads.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Heads"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tails"
        '
        'lblHead
        '
        Me.lblHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHead.Location = New System.Drawing.Point(172, 298)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(100, 23)
        Me.lblHead.TabIndex = 6
        '
        'lblTails
        '
        Me.lblTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTails.Location = New System.Drawing.Point(387, 298)
        Me.lblTails.Name = "lblTails"
        Me.lblTails.Size = New System.Drawing.Size(100, 23)
        Me.lblTails.TabIndex = 7
        '
        'btnToss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 358)
        Me.Controls.Add(Me.lblTails)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnT)
        Me.Name = "btnToss"
        Me.Text = "Form1"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents lblTails As System.Windows.Forms.Label

End Class
