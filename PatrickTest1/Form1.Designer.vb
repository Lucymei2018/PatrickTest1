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
        Me.lblTestLabel = New System.Windows.Forms.Label()
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTestLabel
        '
        Me.lblTestLabel.AutoSize = True
        Me.lblTestLabel.Location = New System.Drawing.Point(318, 50)
        Me.lblTestLabel.Name = "lblTestLabel"
        Me.lblTestLabel.Size = New System.Drawing.Size(54, 13)
        Me.lblTestLabel.TabIndex = 0
        Me.lblTestLabel.Text = "TestLabel"
        '
        'btnButton1
        '
        Me.btnButton1.Location = New System.Drawing.Point(318, 103)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(120, 45)
        Me.btnButton1.TabIndex = 1
        Me.btnButton1.Text = "New Button1"
        Me.btnButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.lblTestLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTestLabel As Label
    Friend WithEvents btnButton1 As Button
End Class
