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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioA = New System.Windows.Forms.RadioButton()
        Me.radioB = New System.Windows.Forms.RadioButton()
        Me.radioC = New System.Windows.Forms.RadioButton()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioC)
        Me.GroupBox1.Controls.Add(Me.radioB)
        Me.GroupBox1.Controls.Add(Me.radioA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'radioA
        '
        Me.radioA.AutoSize = True
        Me.radioA.Location = New System.Drawing.Point(6, 33)
        Me.radioA.Name = "radioA"
        Me.radioA.Size = New System.Drawing.Size(104, 17)
        Me.radioA.TabIndex = 0
        Me.radioA.TabStop = True
        Me.radioA.Text = "Slove For A Side"
        Me.radioA.UseVisualStyleBackColor = True
        '
        'radioB
        '
        Me.radioB.AutoSize = True
        Me.radioB.Location = New System.Drawing.Point(6, 77)
        Me.radioB.Name = "radioB"
        Me.radioB.Size = New System.Drawing.Size(104, 17)
        Me.radioB.TabIndex = 1
        Me.radioB.TabStop = True
        Me.radioB.Text = "Slove For B Side"
        Me.radioB.UseVisualStyleBackColor = True
        '
        'radioC
        '
        Me.radioC.AutoSize = True
        Me.radioC.Location = New System.Drawing.Point(7, 117)
        Me.radioC.Name = "radioC"
        Me.radioC.Size = New System.Drawing.Size(104, 17)
        Me.radioC.TabIndex = 2
        Me.radioC.TabStop = True
        Me.radioC.Text = "Slove For C Side"
        Me.radioC.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(306, 82)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 1
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(306, 126)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 2
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(306, 166)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 3
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(91, 254)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Calculate"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 340)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioC As System.Windows.Forms.RadioButton
    Friend WithEvents radioB As System.Windows.Forms.RadioButton
    Friend WithEvents radioA As System.Windows.Forms.RadioButton
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
