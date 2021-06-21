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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdbB40 = New System.Windows.Forms.RadioButton()
        Me.rdbT20 = New System.Windows.Forms.RadioButton()
        Me.rdbM44 = New System.Windows.Forms.RadioButton()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NRIC"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(197, 22)
        Me.txtName.TabIndex = 2
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(150, 90)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(197, 22)
        Me.txtIC.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CATEGORY"
        '
        'rdbB40
        '
        Me.rdbB40.AutoSize = True
        Me.rdbB40.Location = New System.Drawing.Point(150, 149)
        Me.rdbB40.Name = "rdbB40"
        Me.rdbB40.Size = New System.Drawing.Size(54, 21)
        Me.rdbB40.TabIndex = 5
        Me.rdbB40.TabStop = True
        Me.rdbB40.Text = "B40"
        Me.rdbB40.UseVisualStyleBackColor = True
        '
        'rdbT20
        '
        Me.rdbT20.AutoSize = True
        Me.rdbT20.Location = New System.Drawing.Point(150, 176)
        Me.rdbT20.Name = "rdbT20"
        Me.rdbT20.Size = New System.Drawing.Size(54, 21)
        Me.rdbT20.TabIndex = 6
        Me.rdbT20.TabStop = True
        Me.rdbT20.Text = "T20"
        Me.rdbT20.UseVisualStyleBackColor = True
        '
        'rdbM44
        '
        Me.rdbM44.AutoSize = True
        Me.rdbM44.Location = New System.Drawing.Point(150, 203)
        Me.rdbM44.Name = "rdbM44"
        Me.rdbM44.Size = New System.Drawing.Size(56, 21)
        Me.rdbM44.TabIndex = 7
        Me.rdbM44.TabStop = True
        Me.rdbM44.Text = "M44"
        Me.rdbM44.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.Navy
        Me.btnCheck.Location = New System.Drawing.Point(150, 255)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(126, 56)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "CHECK RESULT"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(64, 337)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(56, 18)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(516, 507)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.rdbM44)
        Me.Controls.Add(Me.rdbT20)
        Me.Controls.Add(Me.rdbB40)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Prihatin Perlis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdbB40 As RadioButton
    Friend WithEvents rdbT20 As RadioButton
    Friend WithEvents rdbM44 As RadioButton
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblResult As Label
End Class
