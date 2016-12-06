Imports System.IO
Imports System.Threading
Imports SPF.Utilities

Public Class SPFDecompressor

    Public Delegate Sub SetProgCallBack(ByVal lintPram As Integer)
    Public Delegate Sub SetLabelCallBack(ByVal lstrPram As String)
    Public Delegate Sub StartCallBack(ByVal lintMax As Integer)
    Public Delegate Sub ExitCallBack()


    Private t1 As System.Threading.Thread
    Dim lstwLog As StreamWriter

    Private Sub gBtnSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gBtnSource.Click
        Dim lfdlg As FolderBrowserDialog = New FolderBrowserDialog()
        If lfdlg.ShowDialog() = DialogResult.OK Then
            gTxtSource.Text = lfdlg.SelectedPath
        End If
    End Sub

    Private Sub gBtnDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gBtnDest.Click
        Dim lfdlg As FolderBrowserDialog = New FolderBrowserDialog()
        If lfdlg.ShowDialog() = DialogResult.OK Then
            gTxtDest.Text = lfdlg.SelectedPath
        End If
    End Sub
    Private Sub gBtnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gBtnProcess.Click
        Try
            lstwLog = New StreamWriter(gTxtDest.Text + "\result.log")
            t1 = New System.Threading.Thread(New ThreadStart(AddressOf process))
            t1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetProgBar(ByVal lintPram As Integer)
        If Me.gpgbProgress.InvokeRequired Then
            Dim dele As New SetProgCallBack(AddressOf SetProgBar)
            Me.Invoke(dele, New Object() {lintPram})
        Else
            Me.gpgbProgress.Value = lintPram
        End If
    End Sub


    Private Sub SetLabel(ByVal lstrPram As String)
        If (Me.glblProgress.InvokeRequired) Then
            Dim dele As New SetLabelCallBack(AddressOf SetLabel)
            Me.Invoke(dele, New Object() {lstrPram})
        Else
            Me.glblProgress.Text = lstrPram
        End If

    End Sub


    Private Sub initControl(ByVal lintMax As Integer)
        Me.gBtnProcess.Text = "processing..."
        Me.gBtnProcess.Enabled = False
        Me.gBtnSource.Enabled = False
        Me.gBtnDest.Enabled = False
        Me.gpgbProgress.Maximum = lintMax + 1
    End Sub

    Private Sub endControl()
        Me.gBtnProcess.Text = "Process"
        Me.gBtnProcess.Enabled = True
        Me.gBtnSource.Enabled = True
        Me.gBtnDest.Enabled = True
    End Sub

    Private Sub [Start](ByVal lintMax As Integer)
        Dim dele As New StartCallBack(AddressOf initControl)
        Me.Invoke(dele, New Object() {lintMax})
    End Sub

    Private Sub [Exit]()
        Dim dele As New ExitCallBack(AddressOf endControl)
        Me.Invoke(dele)
    End Sub


    Private Sub process()
        Try
            Dim iintCnt As Integer = 0
            Dim lstrSource As String = gTxtSource.Text
            Dim lstrDest As String = gTxtDest.Text
            Dim fileEntries As String() = System.IO.Directory.GetFiles(lstrSource, "*", System.IO.SearchOption.AllDirectories)
            Me.[Start](fileEntries.Count.ToString())

            For Each fileName As String In fileEntries
                Try
                    FileUtilities.DeCompressFile(fileName, lstrDest + fileName.Replace(lstrSource, ""))

                    iintCnt = iintCnt + 1
                    SetProgBar(iintCnt)
                    SetLabel(iintCnt.ToString() + "/" + fileEntries.Count.ToString())
                Catch ex As Exception
                    lstwLog.WriteLine("[Error] FileName=" + fileName + ", Reason=" + ex.Message)
                End Try
            Next

            Me.[Exit]()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub gBtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gBtnCancel.Click
        Me.SPFDecompressor_FormClosing(Nothing, Nothing)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub SPFDecompressor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            Dim fi As FileInfo = New FileInfo(gTxtDest.Text + "\result.log")
            If fi.Length = 0 Then
                lstwLog.Close()
                fi.Delete()
            Else
                MessageBox.Show("Error occurred during decompress. See the log for details.(" + gTxtDest.Text + "\result.log" + ")")
            End If
            lstwLog.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gBbtnCompress_Click(sender As Object, e As EventArgs) Handles gBbtnCompress.Click
        Try
            lstwLog = New StreamWriter(gTxtDest.Text + "\result.log")
            t1 = New System.Threading.Thread(New ThreadStart(AddressOf compress))
            t1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub compress()
        Try
            Dim iintCnt As Integer = 0
            Dim lstrSource As String = gTxtSource.Text
            Dim lstrDest As String = gTxtDest.Text
            Dim fileEntries As String() = System.IO.Directory.GetFiles(lstrSource, "*", System.IO.SearchOption.AllDirectories)
            Me.[Start](fileEntries.Count.ToString())

            For Each fileName As String In fileEntries
                Try

                    FileUtilities.CompressFile(fileName, lstrDest + fileName.Replace(lstrSource, ""))

                    iintCnt = iintCnt + 1
                    SetProgBar(iintCnt)
                    SetLabel(iintCnt.ToString() + "/" + fileEntries.Count.ToString())
                Catch ex As Exception
                    lstwLog.WriteLine("[Error] FileName=" + fileName + ", Reason=" + ex.Message)
                End Try
            Next

            Me.[Exit]()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
