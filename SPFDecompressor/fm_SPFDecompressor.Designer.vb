<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPFDecompressor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPFDecompressor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gBtnSource = New System.Windows.Forms.Button()
        Me.gTxtSource = New System.Windows.Forms.TextBox()
        Me.gBtnDest = New System.Windows.Forms.Button()
        Me.gTxtDest = New System.Windows.Forms.TextBox()
        Me.gBtnProcess = New System.Windows.Forms.Button()
        Me.glblProgress = New System.Windows.Forms.Label()
        Me.gpgbProgress = New System.Windows.Forms.ProgressBar()
        Me.gBtnCancel = New System.Windows.Forms.Button()
        Me.gBbtnCompress = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Destination..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Source..."
        '
        'gBtnSource
        '
        Me.gBtnSource.Location = New System.Drawing.Point(184, 34)
        Me.gBtnSource.Name = "gBtnSource"
        Me.gBtnSource.Size = New System.Drawing.Size(61, 21)
        Me.gBtnSource.TabIndex = 1
        Me.gBtnSource.Text = "Open..."
        Me.gBtnSource.UseVisualStyleBackColor = True
        '
        'gTxtSource
        '
        Me.gTxtSource.Location = New System.Drawing.Point(14, 34)
        Me.gTxtSource.Name = "gTxtSource"
        Me.gTxtSource.Size = New System.Drawing.Size(163, 21)
        Me.gTxtSource.TabIndex = 2
        '
        'gBtnDest
        '
        Me.gBtnDest.Location = New System.Drawing.Point(458, 34)
        Me.gBtnDest.Name = "gBtnDest"
        Me.gBtnDest.Size = New System.Drawing.Size(61, 21)
        Me.gBtnDest.TabIndex = 1
        Me.gBtnDest.Text = "Open..."
        Me.gBtnDest.UseVisualStyleBackColor = True
        '
        'gTxtDest
        '
        Me.gTxtDest.Location = New System.Drawing.Point(293, 34)
        Me.gTxtDest.Name = "gTxtDest"
        Me.gTxtDest.Size = New System.Drawing.Size(158, 21)
        Me.gTxtDest.TabIndex = 2
        '
        'gBtnProcess
        '
        Me.gBtnProcess.Location = New System.Drawing.Point(284, 128)
        Me.gBtnProcess.Name = "gBtnProcess"
        Me.gBtnProcess.Size = New System.Drawing.Size(117, 21)
        Me.gBtnProcess.TabIndex = 3
        Me.gBtnProcess.Text = "DeCompress"
        Me.gBtnProcess.UseVisualStyleBackColor = True
        '
        'glblProgress
        '
        Me.glblProgress.Location = New System.Drawing.Point(351, 104)
        Me.glblProgress.Name = "glblProgress"
        Me.glblProgress.Size = New System.Drawing.Size(170, 13)
        Me.glblProgress.TabIndex = 4
        Me.glblProgress.Text = "0"
        Me.glblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpgbProgress
        '
        Me.gpgbProgress.Location = New System.Drawing.Point(14, 78)
        Me.gpgbProgress.Name = "gpgbProgress"
        Me.gpgbProgress.Size = New System.Drawing.Size(510, 21)
        Me.gpgbProgress.TabIndex = 5
        '
        'gBtnCancel
        '
        Me.gBtnCancel.Location = New System.Drawing.Point(407, 128)
        Me.gBtnCancel.Name = "gBtnCancel"
        Me.gBtnCancel.Size = New System.Drawing.Size(117, 21)
        Me.gBtnCancel.TabIndex = 6
        Me.gBtnCancel.Text = "Exit"
        Me.gBtnCancel.UseVisualStyleBackColor = True
        '
        'gBbtnCompress
        '
        Me.gBbtnCompress.Location = New System.Drawing.Point(161, 128)
        Me.gBbtnCompress.Name = "gBbtnCompress"
        Me.gBbtnCompress.Size = New System.Drawing.Size(117, 21)
        Me.gBbtnCompress.TabIndex = 7
        Me.gBbtnCompress.Text = "Compress"
        Me.gBbtnCompress.UseVisualStyleBackColor = True
        '
        'SPFDecompressor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 192)
        Me.Controls.Add(Me.gBbtnCompress)
        Me.Controls.Add(Me.glblProgress)
        Me.Controls.Add(Me.gBtnCancel)
        Me.Controls.Add(Me.gpgbProgress)
        Me.Controls.Add(Me.gBtnProcess)
        Me.Controls.Add(Me.gTxtDest)
        Me.Controls.Add(Me.gTxtSource)
        Me.Controls.Add(Me.gBtnDest)
        Me.Controls.Add(Me.gBtnSource)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SPFDecompressor"
        Me.Text = "SPFDecompressor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gBtnSource As System.Windows.Forms.Button
    Friend WithEvents gTxtSource As System.Windows.Forms.TextBox
    Friend WithEvents gBtnDest As System.Windows.Forms.Button
    Friend WithEvents gTxtDest As System.Windows.Forms.TextBox
    Friend WithEvents gBtnProcess As System.Windows.Forms.Button
    Friend WithEvents glblProgress As System.Windows.Forms.Label
    Friend WithEvents gpgbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents gBtnCancel As System.Windows.Forms.Button
    Friend WithEvents gBbtnCompress As Button
End Class
