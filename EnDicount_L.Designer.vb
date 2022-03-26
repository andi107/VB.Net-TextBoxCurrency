<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnDicount_L
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtCur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCur
        '
        Me.txtCur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCur.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCur.Location = New System.Drawing.Point(0, 1)
        Me.txtCur.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCur.Name = "txtCur"
        Me.txtCur.Size = New System.Drawing.Size(150, 31)
        Me.txtCur.TabIndex = 1
        Me.txtCur.Text = "0"
        Me.txtCur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EnDicount_L
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtCur)
        Me.Name = "EnDicount_L"
        Me.Size = New System.Drawing.Size(150, 33)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCur As System.Windows.Forms.TextBox

End Class
