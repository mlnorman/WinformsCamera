
Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Threading
Imports Infragistics.Win
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
    Private camera_id As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label1.Text = "Camera " & camera_id
    End Sub

    Private Sub CaptureCameraCallback()

        dim initalCameraId = camera_id

        if isCameraRunning = False Then isCameraRunning = true

        frame = new Mat()
        'frame = new Mat(new Size(1024, 768), MatType.CV_64FC3)
        capture = New VideoCapture(CaptureDevice.MSMF, camera_id)
        'frame =capture.RetrieveMat() 
        'frame.Resize(new Size(1920,1080))


        capture.Open(camera_id,CaptureDevice.MSMF)
        capture.Set(CaptureProperty.FrameHeight, 1080)
        capture.Set(CaptureProperty.FrameWidth, 1440)
        
        If capture.IsOpened() Then
            While isCameraRunning

                capture.Read(frame)
                If isCameraRunning Then
                    image = frame.ToBitmap()
                    'image.SetResolution(1440, 1080)
                Else
                    image = Nothing
                End If
                If picBox.Image IsNot Nothing Then
                    picBox.Image.Dispose()
                End If
                picBox.Image = image

                if camera_id <> initalCameraId Then
                    isCameraRunning = false
                    capture.Dispose()
                    CaptureCameraCallback()
                end If
            End While
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If String.Equals(btnRun.Text, "Start") Then
            BackgroundWorker1.RunWorkerAsync()
            btnRun.Text = "Stop"
            isCameraRunning = True
            'btnFlipCamera.Enabled = False
        ElseIf String.Equals(btnRun.Text, "Stop") Then
            isCameraRunning = False
            'btnFlipCamera.Enabled = True
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub btnSnapshot_Click(sender As Object, e As EventArgs) Handles btnScreenshot.Click
        If isCameraRunning Then
            Try

                'Get Parameter not valid exceptions because this camera is running in a background worker
                ' thats breaking debug.

                Dim snap = frame.ToBitmap()
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
        isCameraRunning = False
        capture.Release()
        btnRun.Text = "Start"

        picBox.Image = Nothing
    End Sub

    Private Sub btnSaveScreenshot_Click(sender As Object, e As EventArgs) Handles btnSaveScreenshot.Click
        If pbScreenshot.Image IsNot Nothing Then
            Dim map = ResizeImage(pbScreenshot.Image)

            Dim myGuid = Guid.NewGuid()
            Dim filename = String.Format("{0}/pictures/{1}.png", System.Environment.GetEnvironmentVariable("USERPROFILE"), myGuid)
            map.Save(filename, ImageFormat.Png)
        Else
            MessageBox.Show("No snapshot has been taken...")
        End If
    End Sub

    Private Function ResizeImage(img As Bitmap) As Bitmap
        Dim imgMat = img.ToMat()
        ' imgMat = imgMat.Resize(new Size(1024, 768),fx := .5, fy :=.5)
        Return imgMat.ToBitmap()
    End Function

    Private Sub btnFlipCamera_Click(sender As Object, e As EventArgs) Handles btnFlipCamera.Click
        'Dim wasRunning = False
        'If String.Equals(btnRun.Text, "Stop") Then
        '    isCameraRunning = False
        '    BackgroundWorker1.CancelAsync()
        '    wasRunning = True
        'End If

        if camera_id = 1 Then
            camera_id  = 0
        else
            camera_id = 1
        end if
        Label1.Text = "Camera " & camera_id

    End Sub

   
End Class