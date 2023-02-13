<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtLeftOperand = New System.Windows.Forms.TextBox()
        Me.txtRightOperand = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.leftOperand = New System.Windows.Forms.Label()
        Me.rightOperand = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.expression = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(420, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(222, 233)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 24)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtLeftOperand
        '
        Me.txtLeftOperand.Location = New System.Drawing.Point(222, 113)
        Me.txtLeftOperand.Name = "txtLeftOperand"
        Me.txtLeftOperand.Size = New System.Drawing.Size(100, 23)
        Me.txtLeftOperand.TabIndex = 3
        '
        'txtRightOperand
        '
        Me.txtRightOperand.Location = New System.Drawing.Point(501, 113)
        Me.txtRightOperand.Name = "txtRightOperand"
        Me.txtRightOperand.Size = New System.Drawing.Size(100, 23)
        Me.txtRightOperand.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(359, 117)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 19)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "+ Addition"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(359, 142)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(94, 19)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "- Subtraction"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(359, 167)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "* Multiplication"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(359, 192)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(75, 19)
        Me.RadioButton4.TabIndex = 10
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "/ Division"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(359, 217)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(95, 19)
        Me.RadioButton5.TabIndex = 11
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "% Remainder"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'leftOperand
        '
        Me.leftOperand.AutoSize = True
        Me.leftOperand.Location = New System.Drawing.Point(223, 73)
        Me.leftOperand.Name = "leftOperand"
        Me.leftOperand.Size = New System.Drawing.Size(74, 15)
        Me.leftOperand.TabIndex = 12
        Me.leftOperand.Text = "Left operand"
        '
        'rightOperand
        '
        Me.rightOperand.AutoSize = True
        Me.rightOperand.Location = New System.Drawing.Point(510, 73)
        Me.rightOperand.Name = "rightOperand"
        Me.rightOperand.Size = New System.Drawing.Size(82, 15)
        Me.rightOperand.TabIndex = 13
        Me.rightOperand.Text = "Right operand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Expression"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Result"
        '
        'lblOperator
        '
        Me.lblOperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOperator.Location = New System.Drawing.Point(323, 270)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(143, 23)
        Me.lblOperator.TabIndex = 16
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(501, 163)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplay.TabIndex = 17
        '
        'expression
        '
        Me.expression.Location = New System.Drawing.Point(323, 40)
        Me.expression.Name = "expression"
        Me.expression.Size = New System.Drawing.Size(181, 23)
        Me.expression.TabIndex = 18
        '
        'result
        '
        Me.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result.Location = New System.Drawing.Point(323, 304)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(231, 24)
        Me.result.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.expression)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rightOperand)
        Me.Controls.Add(Me.leftOperand)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtRightOperand)
        Me.Controls.Add(Me.txtLeftOperand)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtLeftOperand As TextBox
    Friend WithEvents txtRightOperand As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents leftOperand As Label
    Friend WithEvents rightOperand As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents expression As Label
    Friend WithEvents result As Label
End Class
