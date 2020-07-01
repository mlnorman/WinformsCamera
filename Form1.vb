
Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Threading
Imports Infragistics.Win.Misc
Imports Infragistics.Win.UltraWinEditors
Imports OpenCvSharp
Imports OpenCvSharp.Extensions
Imports ZXing
Imports ZXing.Common

Public Class Form1
    Private Shadows capture As VideoCapture
    Private frame As Mat
    Private image As Bitmap
    Private camera As Thread
    Private isCameraRunning As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub CaptureCameraCallback()

        frame = New Mat()
        capture = New VideoCapture(0)
        capture.Open(0)

        If capture.IsOpened() Then
            While isCameraRunning

                capture.Read(frame)
                image = BitmapConverter.ToBitmap(frame)
                If picBox.Image IsNot Nothing Then
                    picBox.Image.Dispose()
                End If
                picBox.Image = image
            End While
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) 
        If String.Equals(btnRun.Text, "Start") Then
            BackgroundWorker1.RunWorkerAsync()
            btnRun.Text = "Stop"
            isCameraRunning = True
        ElseIf String.Equals(btnRun.Text, "Stop") Then
            isCameraRunning = False
            capture.Release()
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub btnSnapshot_Click(sender As Object, e As EventArgs) 
        If isCameraRunning Then
            Try

                'Get Parameter not valid exceptions because this camera is running in a background worker
                ' thats breaking debug.

                Dim snap = new Bitmap(DirectCast(picBox.Image, Image))
                pbScreenshot.Image = snap

                ' Saves the image if you want...
                'Dim myGuid = Guid.NewGuid()
                'Dim filename = String.Format("{0}/pictures/{1}.png", System.Environment.GetEnvironmentVariable("USERPROFILE"), myGuid)
                'snap.Save(filename, ImageFormat.PNG)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("The camera is not capturing...")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CaptureCameraCallback()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        capture.Release()
        btnRun.Text = "Start"
        isCameraRunning = False
        picBox.Image = Nothing
    End Sub

    Private Sub btnSaveScreenshot_Click(sender As Object, e As EventArgs) 
        If pbScreenshot.Image IsNot Nothing Then
            Dim map = new Bitmap(pbScreenshot.Image)
            Dim myGuid = Guid.NewGuid()
            Dim filename = String.Format("{0}/pictures/{1}.png", System.Environment.GetEnvironmentVariable("USERPROFILE"), myGuid)
            map.Save(filename, ImageFormat.PNG)
        Else 
            MessageBox.Show("No snapshot has been taken...")
        End If
    End Sub
End Class
