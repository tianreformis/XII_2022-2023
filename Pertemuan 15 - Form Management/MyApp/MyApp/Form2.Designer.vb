<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAngka1 = New System.Windows.Forms.TextBox()
        Me.btnHasilKurang = New System.Windows.Forms.Button()
        Me.btnHasilKali = New System.Windows.Forms.Button()
        Me.btnHasilTambah = New System.Windows.Forms.Button()
        Me.btnHasilBagi = New System.Windows.Forms.Button()
        Me.txtAngka2 = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.AutoEllipsis = True
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Kaushan Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(41, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 50)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Menuju Form 1"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Kaushan Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(340, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Angka Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Angka Kedua"
        '
        'txtAngka1
        '
        Me.txtAngka1.Location = New System.Drawing.Point(203, 91)
        Me.txtAngka1.Name = "txtAngka1"
        Me.txtAngka1.Size = New System.Drawing.Size(246, 20)
        Me.txtAngka1.TabIndex = 14
        '
        'btnHasilKurang
        '
        Me.btnHasilKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHasilKurang.Location = New System.Drawing.Point(203, 158)
        Me.btnHasilKurang.Name = "btnHasilKurang"
        Me.btnHasilKurang.Size = New System.Drawing.Size(42, 47)
        Me.btnHasilKurang.TabIndex = 19
        Me.btnHasilKurang.Text = "-"
        Me.btnHasilKurang.UseVisualStyleBackColor = True
        '
        'btnHasilKali
        '
        Me.btnHasilKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHasilKali.Location = New System.Drawing.Point(299, 158)
        Me.btnHasilKali.Name = "btnHasilKali"
        Me.btnHasilKali.Size = New System.Drawing.Size(42, 47)
        Me.btnHasilKali.TabIndex = 20
        Me.btnHasilKali.Text = "*"
        Me.btnHasilKali.UseVisualStyleBackColor = True
        '
        'btnHasilTambah
        '
        Me.btnHasilTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHasilTambah.Location = New System.Drawing.Point(251, 158)
        Me.btnHasilTambah.Name = "btnHasilTambah"
        Me.btnHasilTambah.Size = New System.Drawing.Size(42, 47)
        Me.btnHasilTambah.TabIndex = 21
        Me.btnHasilTambah.Text = "+"
        Me.btnHasilTambah.UseVisualStyleBackColor = True
        '
        'btnHasilBagi
        '
        Me.btnHasilBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHasilBagi.Location = New System.Drawing.Point(347, 158)
        Me.btnHasilBagi.Name = "btnHasilBagi"
        Me.btnHasilBagi.Size = New System.Drawing.Size(42, 47)
        Me.btnHasilBagi.TabIndex = 22
        Me.btnHasilBagi.Text = "/"
        Me.btnHasilBagi.UseVisualStyleBackColor = True
        '
        'txtAngka2
        '
        Me.txtAngka2.Location = New System.Drawing.Point(203, 122)
        Me.txtAngka2.Name = "txtAngka2"
        Me.txtAngka2.Size = New System.Drawing.Size(246, 20)
        Me.txtAngka2.TabIndex = 15
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(203, 211)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(246, 20)
        Me.txtHasil.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Hasil"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 342)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.btnHasilBagi)
        Me.Controls.Add(Me.btnHasilTambah)
        Me.Controls.Add(Me.btnHasilKali)
        Me.Controls.Add(Me.btnHasilKurang)
        Me.Controls.Add(Me.txtAngka2)
        Me.Controls.Add(Me.txtAngka1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAngka1 As System.Windows.Forms.TextBox
    Friend WithEvents btnHasilKurang As System.Windows.Forms.Button
    Friend WithEvents btnHasilKali As System.Windows.Forms.Button
    Friend WithEvents btnHasilTambah As System.Windows.Forms.Button
    Friend WithEvents btnHasilBagi As System.Windows.Forms.Button
    Friend WithEvents txtAngka2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
