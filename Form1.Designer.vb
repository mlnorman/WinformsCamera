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
        Me.btnRun = New Infragistics.Win.Misc.UltraButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSnapshot = New Infragistics.Win.Misc.UltraButton()
        Me.pbScreenshot = New System.Windows.Forms.PictureBox()
        Me.btnSaveScreenshot = New Infragistics.Win.Misc.UltraButton()
        CType(Me.picBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbScreenshot,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(230, 581)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Start"
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
        Me.picBox.Size = New System.Drawing.Size(581, 506)
        Me.picBox.TabIndex = 3
        Me.picBox.TabStop = false
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(433, 585)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(175, 20)
        Me.txtBarcode.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(380, 588)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Barcode"
        '
        'btnSnapshot
        '
        Me.btnSnapshot.Location = New System.Drawing.Point(703, 581)
        Me.btnSnapshot.Name = "btnSnapshot"
        Me.btnSnapshot.Size = New System.Drawing.Size(75, 23)
        Me.btnSnapshot.TabIndex = 7
        Me.btnSnapshot.Text = "Snapshot"
        '
        'pbScreenshot
        '
        Me.pbScreenshot.Location = New System.Drawing.Point(599, 12)
        Me.pbScreenshot.Name = "pbScreenshot"
        Me.pbScreenshot.Size = New System.Drawing.Size(581, 506)
        Me.pbScreenshot.TabIndex = 8
        Me.pbScreenshot.TabStop = false
        '
        'btnSaveScreenshot
        '
        Me.btnSaveScreenshot.Location = New System.Drawing.Point(879, 581)
        Me.btnSaveScreenshot.Name = "btnSaveScreenshot"
        Me.btnSaveScreenshot.Size = New System.Drawing.Size(108, 23)
        Me.btnSaveScreenshot.TabIndex = 9
        Me.btnSaveScreenshot.Text = "Save Screenshot"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 641)
        Me.Controls.Add(Me.btnSaveScreenshot)
        Me.Controls.Add(Me.pbScreenshot)
        Me.Controls.Add(Me.btnSnapshot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.btnRun)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbScreenshot,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnRun As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents picBox As PictureBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSnapshot As Infragistics.Win.Misc.UltraButton
    Friend WithEvents pbScreenshot As PictureBox
    Friend WithEvents btnSaveScreenshot As Infragistics.Win.Misc.UltraButton
End Class
