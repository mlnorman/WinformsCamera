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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.pbScreenshot = New System.Windows.Forms.PictureBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnScreenshot = New System.Windows.Forms.Button()
        Me.btnSaveScreenshot = New System.Windows.Forms.Button()
        Me.btnFlipCamera = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbScreenshot,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = true
        Me.BackgroundWorker1.WorkerSupportsCancellation = true
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(12, 12)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(581, 470)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 3
        Me.picBox.TabStop = false
        '
        'pbScreenshot
        '
        Me.pbScreenshot.Location = New System.Drawing.Point(599, 12)
        Me.pbScreenshot.Name = "pbScreenshot"
        Me.pbScreenshot.Size = New System.Drawing.Size(581, 470)
        Me.pbScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbScreenshot.TabIndex = 8
        Me.pbScreenshot.TabStop = false
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(287, 578)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 10
        Me.btnRun.Text = "Start"
        Me.btnRun.UseVisualStyleBackColor = true
        '
        'btnScreenshot
        '
        Me.btnScreenshot.Location = New System.Drawing.Point(568, 578)
        Me.btnScreenshot.Name = "btnScreenshot"
        Me.btnScreenshot.Size = New System.Drawing.Size(75, 23)
        Me.btnScreenshot.TabIndex = 11
        Me.btnScreenshot.Text = "Screenshot"
        Me.btnScreenshot.UseVisualStyleBackColor = true
        '
        'btnSaveScreenshot
        '
        Me.btnSaveScreenshot.Location = New System.Drawing.Point(841, 578)
        Me.btnSaveScreenshot.Name = "btnSaveScreenshot"
        Me.btnSaveScreenshot.Size = New System.Drawing.Size(152, 23)
        Me.btnSaveScreenshot.TabIndex = 12
        Me.btnSaveScreenshot.Text = "Save Screenshot"
        Me.btnSaveScreenshot.UseVisualStyleBackColor = true
        '
        'btnFlipCamera
        '
        Me.btnFlipCamera.Location = New System.Drawing.Point(12, 578)
        Me.btnFlipCamera.Name = "btnFlipCamera"
        Me.btnFlipCamera.Size = New System.Drawing.Size(90, 23)
        Me.btnFlipCamera.TabIndex = 13
        Me.btnFlipCamera.Text = "Flip Camera"
        Me.btnFlipCamera.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 619)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Camera"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 641)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFlipCamera)
        Me.Controls.Add(Me.btnSaveScreenshot)
        Me.Controls.Add(Me.btnScreenshot)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.pbScreenshot)
        Me.Controls.Add(Me.picBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbScreenshot,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents picBox As PictureBox
    Friend WithEvents pbScreenshot As PictureBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnScreenshot As Button
    Friend WithEvents btnSaveScreenshot As Button
    Friend WithEvents btnFlipCamera As Button
    Friend WithEvents Label1 As Label
End Class
