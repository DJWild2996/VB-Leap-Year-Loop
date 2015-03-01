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
        Me.btncheck = New System.Windows.Forms.Button()
        Me.txtyearenter = New System.Windows.Forms.TextBox()
        Me.lbyear = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btncheck
        '
        Me.btncheck.Location = New System.Drawing.Point(12, 32)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(75, 23)
        Me.btncheck.TabIndex = 0
        Me.btncheck.Text = "Check Year"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'txtyearenter
        '
        Me.txtyearenter.Location = New System.Drawing.Point(13, 62)
        Me.txtyearenter.Name = "txtyearenter"
        Me.txtyearenter.Size = New System.Drawing.Size(100, 20)
        Me.txtyearenter.TabIndex = 1
        '
        'lbyear
        '
        Me.lbyear.FormattingEnabled = True
        Me.lbyear.Location = New System.Drawing.Point(139, -1)
        Me.lbyear.Name = "lbyear"
        Me.lbyear.Size = New System.Drawing.Size(217, 290)
        Me.lbyear.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 288)
        Me.Controls.Add(Me.lbyear)
        Me.Controls.Add(Me.txtyearenter)
        Me.Controls.Add(Me.btncheck)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents txtyearenter As System.Windows.Forms.TextBox
    Friend WithEvents lbyear As System.Windows.Forms.ListBox

End Class
