<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.txthoadons = New System.Windows.Forms.Button()
        Me.txtchitiethoadons = New System.Windows.Forms.Button()
        Me.txtsanphams = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txthoadons
        '
        Me.txthoadons.Location = New System.Drawing.Point(9, 150)
        Me.txthoadons.Name = "txthoadons"
        Me.txthoadons.Size = New System.Drawing.Size(78, 34)
        Me.txthoadons.TabIndex = 0
        Me.txthoadons.Text = "Hóa đơn"
        Me.txthoadons.UseVisualStyleBackColor = True
        '
        'txtchitiethoadons
        '
        Me.txtchitiethoadons.Location = New System.Drawing.Point(136, 150)
        Me.txtchitiethoadons.Name = "txtchitiethoadons"
        Me.txtchitiethoadons.Size = New System.Drawing.Size(144, 34)
        Me.txtchitiethoadons.TabIndex = 0
        Me.txtchitiethoadons.Text = "Chi tiết hóa đơn"
        Me.txtchitiethoadons.UseVisualStyleBackColor = True
        '
        'txtsanphams
        '
        Me.txtsanphams.Location = New System.Drawing.Point(310, 150)
        Me.txtsanphams.Name = "txtsanphams"
        Me.txtsanphams.Size = New System.Drawing.Size(78, 34)
        Me.txtsanphams.TabIndex = 0
        Me.txtsanphams.Text = "Sản phẩm"
        Me.txtsanphams.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(131, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Namvvpk00197"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(403, 254)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsanphams)
        Me.Controls.Add(Me.txtchitiethoadons)
        Me.Controls.Add(Me.txthoadons)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txthoadons As System.Windows.Forms.Button
    Friend WithEvents txtchitiethoadons As System.Windows.Forms.Button
    Friend WithEvents txtsanphams As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
