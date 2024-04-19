<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        adtxt = New TextBox()
        soyadtxt = New TextBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        unitxt = New ComboBox()
        fakultetxt = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 20)
        Label1.TabIndex = 0
        Label1.Text = "Ad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 1
        Label2.Text = "Soyad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 2
        Label3.Text = "Üniversite"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 3
        Label4.Text = "Fakulte"
        ' 
        ' adtxt
        ' 
        adtxt.Location = New Point(92, 22)
        adtxt.Name = "adtxt"
        adtxt.Size = New Size(125, 27)
        adtxt.TabIndex = 4
        ' 
        ' soyadtxt
        ' 
        soyadtxt.Location = New Point(92, 59)
        soyadtxt.Name = "soyadtxt"
        soyadtxt.Size = New Size(125, 27)
        soyadtxt.TabIndex = 5
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(288, 45)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(398, 244)
        ListBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(36, 241)
        Button1.Name = "Button1"
        Button1.Size = New Size(187, 27)
        Button1.TabIndex = 9
        Button1.Text = "E Posta Ve Numara Ata"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' unitxt
        ' 
        unitxt.FormattingEnabled = True
        unitxt.Items.AddRange(New Object() {"Anadolu Üniversitesi", "Ondokuz Mayıs Üniversitesi", "Gazi Üniversitesi"})
        unitxt.Location = New Point(92, 110)
        unitxt.Name = "unitxt"
        unitxt.Size = New Size(151, 28)
        unitxt.TabIndex = 10
        ' 
        ' fakultetxt
        ' 
        fakultetxt.FormattingEnabled = True
        fakultetxt.Items.AddRange(New Object() {"Tıp Fakultesi", "Egitim" & ChrW(127) & " Fakultesi", "Hukuk Fakultesi", "Muhendislik Fakultesi"})
        fakultetxt.Location = New Point(92, 157)
        fakultetxt.Name = "fakultetxt"
        fakultetxt.Size = New Size(151, 28)
        fakultetxt.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(fakultetxt)
        Controls.Add(unitxt)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(soyadtxt)
        Controls.Add(adtxt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents adtxt As TextBox
    Friend WithEvents soyadtxt As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents unitxt As ComboBox
    Friend WithEvents fakultetxt As ComboBox
End Class
