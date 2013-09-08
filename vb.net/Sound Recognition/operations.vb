Imports System.IO
Imports System.IO.StreamReader
Imports System.IO.StreamWriter

Public Class operations
    Private strText As String
    Private Sub operations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Main.LinkLabel1.Text = "Hide All operations window"
    End Sub

    Private Sub operations_UnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.HandleDestroyed
        On Error Resume Next
        Main.LinkLabel1.Text = "&Open All operations window"
    End Sub

    Private Sub export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export.Click
        On Error Resume Next
        Dim ansr As DialogResult
        ansr = MessageBox.Show("Do you want to overwrite file?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If (ansr = Windows.Forms.DialogResult.Yes) Then
            Dim sw As IO.StreamWriter
            Dim fs As IO.FileStream
            'initiatng filestream
            fs = New FileStream(Directory.GetCurrentDirectory & "\" & "Data.txt", FileMode.Create)
            'initiating streamwriter object
            sw = New StreamWriter(fs)
            'itm objetc created for iteration in combobox collection
            Dim itm As Object
            For Each itm In ListBox2.Items
                'writing item by item to streamwriter 
                sw.WriteLine(itm.ToString)
            Next
            'closing stream writer object and filesystem object 
            sw.Close()
            fs.Close()
            MsgBox("Writing has been done")
        Else
            MsgBox("Writing has been cancelled")
        End If
    End Sub

    Private Sub open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open.Click
        Process.Start("Data.txt")
    End Sub
End Class