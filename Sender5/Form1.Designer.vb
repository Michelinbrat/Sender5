<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cbPorts = New System.Windows.Forms.ComboBox()
        Me.cbBauds = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        '
        'cbPorts
        '
        Me.cbPorts.FormattingEnabled = True
        Me.cbPorts.Location = New System.Drawing.Point(12, 12)
        Me.cbPorts.Name = "cbPorts"
        Me.cbPorts.Size = New System.Drawing.Size(86, 21)
        Me.cbPorts.TabIndex = 0
        '
        'cbBauds
        '
        Me.cbBauds.FormattingEnabled = True
        Me.cbBauds.Items.AddRange(New Object() {"115200", "250000"})
        Me.cbBauds.Location = New System.Drawing.Point(104, 12)
        Me.cbBauds.Name = "cbBauds"
        Me.cbBauds.Size = New System.Drawing.Size(129, 21)
        Me.cbBauds.TabIndex = 1
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(239, 11)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(85, 22)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Location = New System.Drawing.Point(491, 11)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.Size = New System.Drawing.Size(302, 409)
        Me.rtbDisplay.TabIndex = 3
        Me.rtbDisplay.Text = ""
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(361, 12)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(93, 43)
        Me.btnRead.TabIndex = 4
        Me.btnRead.Text = "btnRead"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.rtbDisplay)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cbBauds)
        Me.Controls.Add(Me.cbPorts)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents cbPorts As ComboBox
    Friend WithEvents cbBauds As ComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents rtbDisplay As RichTextBox
    Friend WithEvents btnRead As Button
End Class
