Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.IO.Ports
'Note use of Interop wrapper
Imports SpeechLib

Partial Public Class Main
    'The grammar that we're recognizing
    Dim grammar As ISpeechRecoGrammar
    'The recognizer context
    Dim WithEvents RecoContext As SpSharedRecoContext
    Dim comm As New CommManager
    Private stopBits, parity As Array ' arrays to access the enumerations in System.IO.Ports
    Private validStopBits As New ArrayList() ' ArrayLists hold the valid values for this machine
    Private validParity As New ArrayList()
    Dim res = 0
    'This will be called many times, as data is analyzed
    Sub OnHypothesis(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal Result As ISpeechRecoResult) Handles RecoContext.Hypothesis
        'Don't allow the user to stop the recognition until it has completed.
        btnstop.Enabled = False
        If statuslbl.Text <> "Status: Receiving" Then
            statuslbl.Text = "Status: Receiving"
        End If
    End Sub
    'This will be called once, after entire file is analyzed
    Private Sub OnRecognition(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechRecognitionType, ByVal Result As ISpeechRecoResult) Handles RecoContext.Recognition
        'Create a new string, and assign the recognized text to it.
        Dim recoResult As String = Result.PhraseInfo.GetText
        statuslbl.Text = "Status: Finished Dictating"
        btnstop.Enabled = False
    End Sub

    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        'First check to see if reco has been loaded before. If not lets load it. 
        Try
            SerialPort1.Open()
            If (RecoContext Is Nothing) Then
                RecoContext = New SpSharedRecoContextClass                'Create a new Reco Context Class 
                grammar = RecoContext.CreateGrammar(1)                    'Setup the Grammar 
                grammar.DictationLoad()                                   'Load the Grammar 
                statuslbl.Text = "Status: Recognition Started"
                grammar.DictationSetState(SpeechRuleState.SGDSActive)   'Turns on the Recognition. This is Vitally important 
            End If

            ListBox1.Items.Clear()
            Label21.Text = "0"
            btnstart.Enabled = False
            btnstop.Enabled = True
            cboPort.Enabled = False
            cboBaud.Enabled = False
            cboParity.Enabled = False
            cboData.Enabled = False
            cboStop.Enabled = False
            PictureBox1.BackgroundImage = My.Resources.media_play_green
            txtbox.Text = "Port is opened"
            operations.ListBox2.Items.Add("Port [" + cboPort.SelectedItem.ToString + "] opened at " + Date.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop.Click
        'Turns off the Recognition
        Try
            SerialPort1.Close()
            grammar.DictationSetState(SpeechRuleState.SGDSInactive) ' It will go dormant. 
            statuslbl.Text = "Status: Recognition Stopped"          'Change the label to let the user know whats up 
            btnstart.Enabled = True
            btnstop.Enabled = False
            cboPort.Enabled = True
            cboBaud.Enabled = True
            cboParity.Enabled = True
            cboData.Enabled = True
            cboStop.Enabled = True
            PictureBox1.BackgroundImage = My.Resources.media_stop_red
            txtbox.Text = "Port is closed"
            operations.ListBox2.Items.Add("Port [" + cboPort.SelectedItem.ToString + "] closed at " + Date.Now)
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try

    End Sub

    Private Sub lstbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbox.SelectedIndexChanged
        Try
            Select Case lstbox.SelectedItem
                Case "one"
                    SerialPort1.WriteLine(100)
                    txtbox.Text = "Your car Stopped"
                    ListBox1.Items.Add(lstbox.SelectedItem + "       (Stop)")
                    operations.ListBox2.Items.Add(lstbox.SelectedItem + "       (Stop)")
                Case "four"
                    SerialPort1.WriteLine(124)
                    txtbox.Text = "Turn right"
                    ListBox1.Items.Add(lstbox.SelectedItem + "      (Right)")
                    operations.ListBox2.Items.Add(lstbox.SelectedItem + "      (Right)")
                Case "five"
                    SerialPort1.WriteLine(248)
                    txtbox.Text = "Move backward"
                    ListBox1.Items.Add(lstbox.SelectedItem + "       (Down)")
                    operations.ListBox2.Items.Add(lstbox.SelectedItem + "       (Down)")
                Case "seven"
                    SerialPort1.WriteLine(148)
                    txtbox.Text = "Turn Left"
                    ListBox1.Items.Add(lstbox.SelectedItem + "    (Left)")
                    operations.ListBox2.Items.Add(lstbox.SelectedItem + "    (Left)")
                Case "eight"
                    SerialPort1.WriteLine(224)
                    txtbox.Text = "Move forward"
                    ListBox1.Items.Add(lstbox.SelectedItem + "     (Up)")
                    operations.ListBox2.Items.Add(lstbox.SelectedItem + "     (Up)")
            End Select
            Label21.Text = ListBox1.Items.Count
            operations.Label1.Text = operations.ListBox2.Items.Count
            statuslbl.Text = "Status: Finished Dictating"
            btnstop.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnstart.Enabled = True
        btnstop.Enabled = False
        Try
            LoadValues()
            SetDefaults()
            SerialPort1.Close()
            Timer1.Start()
            MsgBox("WELCOME  [ " + System.Environment.UserName + " ]" & vbCrLf & vbCrLf & _
            "You are using:  (" & SerialPort1.PortName.ToString & ")   with " & vbCrLf & _
            "    Baud-Rate  :  " & SerialPort1.BaudRate.ToString & " ," & vbCrLf & _
            "    Parity          :  " & SerialPort1.Parity.ToString & " ," & vbCrLf & _
            "    Data-Bits    :  " & SerialPort1.DataBits.ToString & " ," & vbCrLf & _
            "    Stop-Bits    :  " & SerialPort1.StopBits.ToString & "" & vbCrLf & vbCrLf & _
            "If you want to edit these options," & vbCrLf & "          go to (config. port) in the program" _
            & vbCrLf & "----------------------------------------------------" _
            & vbCrLf & "Note: Click Start to open port and Start recognition", MsgBoxStyle.Exclamation)
            operations.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_UnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.HandleDestroyed
        SerialPort1.Close()
    End Sub

    Private Sub cboPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPort.SelectedIndexChanged
        SerialPort1.PortName = cboPort.SelectedItem
    End Sub

    Private Sub cboBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBaud.SelectedIndexChanged
        SerialPort1.BaudRate = cboBaud.SelectedItem
    End Sub

    Private Sub cboParity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboParity.SelectedIndexChanged
        SerialPort1.Parity = CType(validParity(cboParity.SelectedIndex), System.IO.Ports.Parity)
    End Sub

    Private Sub cboData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboData.SelectedIndexChanged
        SerialPort1.DataBits = cboData.SelectedItem
    End Sub

    Private Sub cboStop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStop.SelectedIndexChanged
        SerialPort1.StopBits = CType(validStopBits(cboStop.SelectedIndex), System.IO.Ports.StopBits)
    End Sub

    Private Sub SetDefaults()
        cboPort.SelectedIndex = 0
        cboBaud.SelectedIndex = 5
        cboParity.SelectedIndex = 0
        cboData.SelectedIndex = 3
        cboStop.SelectedIndex = 0
    End Sub

    Private Sub LoadValues()
        comm.SetPortNameValues(cboPort)
        ' Populate the parity with valid options
        cboParity.SelectedText = SerialPort1.Parity.ToString()
        Dim currentParitySetting As System.IO.Ports.Parity = SerialPort1.Parity
        parity = [Enum].GetValues(GetType(System.IO.Ports.Parity))
        Dim ptype As System.IO.Ports.Parity
        For Each ptype In parity
            ' test to make sure the machine supports the setting
            Try
                SerialPort1.Parity = ptype
                validParity.Add(ptype)
                cboParity.Items.Add(ptype)
            Catch ' ignore this entry
            End Try
        Next ptype
        ' Populate the stop bits box with all valid options.
        cboStop.SelectedText = SerialPort1.StopBits.ToString()
        Dim currentStopBitSetting As System.IO.Ports.StopBits = SerialPort1.StopBits
        stopBits = [Enum].GetValues(GetType(System.IO.Ports.StopBits))
        Dim sbtype As System.IO.Ports.StopBits
        For Each sbtype In stopBits
            ' test to make sure the machine supports the setting
            Try
                SerialPort1.StopBits = sbtype
                validStopBits.Add(sbtype)
                cboStop.Items.Add(sbtype)
            Catch ' ignore this entry as invalid
            End Try
        Next sbtype
        SerialPort1.StopBits = currentStopBitSetting
    End Sub

    Private Sub serialPort_DataReceive(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ' Read the buffer 
        'MsgBox("value has been sent is :  " + SerialPort1.ReadLine())
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Leave
        Dim ansr As DialogResult
        ansr = MessageBox.Show("Do you want to use these settings?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If (ansr = Windows.Forms.DialogResult.Yes) Then
            res = 0
        Else
            res = 1
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        If (res = 1) Then
            TabControl1.SelectedTab = TabPage2
            res = 0
        End If
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        If (res = 1) Then
            TabControl1.SelectedTab = TabPage2
            res = 0
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = "C.Y.C.B.S.  " + Date.Now
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pstop.Click
        pstop.BorderStyle = BorderStyle.Fixed3D
        lstbox.SetSelected(0, True)
        pstop.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pright.Click
        pright.BorderStyle = BorderStyle.Fixed3D
        lstbox.SetSelected(1, True)
        pright.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pdown.Click
        pdown.BorderStyle = BorderStyle.Fixed3D
        lstbox.SetSelected(2, True)
        pdown.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pleft.Click
        pleft.BorderStyle = BorderStyle.Fixed3D
        lstbox.SetSelected(3, True)
        pleft.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pup.Click
        pup.BorderStyle = BorderStyle.Fixed3D
        lstbox.SetSelected(4, True)
        pup.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            If LinkLabel1.Text = "&Open All operations window" Then
                operations.Show()
                LinkLabel1.Text = "Hide All operations window"
            Else
                operations.Hide()
                LinkLabel1.Text = "&Open All operations window"
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
