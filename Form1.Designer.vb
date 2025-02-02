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
        Me.LBLone = New System.Windows.Forms.Label()
        Me.LBLtwo = New System.Windows.Forms.Label()
        Me.LBLthree = New System.Windows.Forms.Label()
        Me.BTNquit = New System.Windows.Forms.Button()
        Me.CMBone = New System.Windows.Forms.ComboBox()
        Me.CMBtwo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LBLone
        '
        Me.LBLone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLone.Location = New System.Drawing.Point(230, 43)
        Me.LBLone.Name = "LBLone"
        Me.LBLone.Size = New System.Drawing.Size(312, 39)
        Me.LBLone.TabIndex = 0
        Me.LBLone.Text = "World Time Converter"
        '
        'LBLtwo
        '
        Me.LBLtwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtwo.Location = New System.Drawing.Point(38, 112)
        Me.LBLtwo.Name = "LBLtwo"
        Me.LBLtwo.Size = New System.Drawing.Size(97, 34)
        Me.LBLtwo.TabIndex = 1
        Me.LBLtwo.Text = "Location:"
        '
        'LBLthree
        '
        Me.LBLthree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLthree.Location = New System.Drawing.Point(38, 291)
        Me.LBLthree.Name = "LBLthree"
        Me.LBLthree.Size = New System.Drawing.Size(123, 34)
        Me.LBLthree.TabIndex = 2
        Me.LBLthree.Text = "Destination:"
        '
        'BTNquit
        '
        Me.BTNquit.Location = New System.Drawing.Point(610, 348)
        Me.BTNquit.Name = "BTNquit"
        Me.BTNquit.Size = New System.Drawing.Size(157, 80)
        Me.BTNquit.TabIndex = 3
        Me.BTNquit.Text = "Quit"
        Me.BTNquit.UseVisualStyleBackColor = True
        '
        'CMBone
        '
        Me.CMBone.FormattingEnabled = True
        Me.CMBone.Location = New System.Drawing.Point(323, 186)
        Me.CMBone.Name = "CMBone"
        Me.CMBone.Size = New System.Drawing.Size(121, 24)
        Me.CMBone.TabIndex = 4
        '
        'CMBtwo
        '
        Me.CMBtwo.FormattingEnabled = True
        Me.CMBtwo.Location = New System.Drawing.Point(323, 348)
        Me.CMBtwo.Name = "CMBtwo"
        Me.CMBtwo.Size = New System.Drawing.Size(121, 24)
        Me.CMBtwo.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CMBtwo)
        Me.Controls.Add(Me.CMBone)
        Me.Controls.Add(Me.BTNquit)
        Me.Controls.Add(Me.LBLthree)
        Me.Controls.Add(Me.LBLtwo)
        Me.Controls.Add(Me.LBLone)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LBLone As Label
    Friend WithEvents LBLtwo As Label
    Friend WithEvents LBLthree As Label
    Friend WithEvents BTNquit As Button
    Friend WithEvents CMBone As ComboBox
    Friend WithEvents CMBtwo As ComboBox
End Class
