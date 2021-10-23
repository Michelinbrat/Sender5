Imports System.ComponentModel

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbPorts.Items.Add(sp)
        Next
        If My.Computer.Ports.SerialPortNames Is Nothing Then MsgBox("no prts")
        cbPorts.SelectedIndex = 0
        cbBauds.SelectedIndex = 0
        'SetDefaults()
    End Sub
    Private Sub SetDefaults()

        With SerialPort1
            '.PortName = cbPorts.SelectedItem
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            '.BaudRate = cbBauds.SelectedItem
        End With
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        With SerialPort1
            .PortName = cbPorts.SelectedItem
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .BaudRate = cbBauds.SelectedItem
            .ReadTimeout = 2000
            .WriteTimeout = 2000
            .ReadBufferSize = 2000
            .WriteBufferSize = 2000
            .RtsEnable = True
            .DtrEnable = True

        End With

        SerialPort1.Open()
        Display("Serial port opened ", MessageType.Outgoing)
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SerialPort1.Close()
    End Sub


    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim answer As String = Nothing
        Try
            Do
                answer = SerialPort1.ReadLine()
                Display(answer, MessageType.Incoming)
            Loop Until answer = Nothing
        Catch TimeoutException As Exception
            Display("Timeout", MessageType.Outgoing)

        End Try
    End Sub
    Private Function ReadPort() As String

    End Function


End Class
