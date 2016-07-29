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
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn32 = New System.Windows.Forms.Button()
        Me.btn31 = New System.Windows.Forms.Button()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.btn23 = New System.Windows.Forms.Button()
        Me.btn22 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblCurrentTurn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn11
        '
        Me.btn11.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn11.Location = New System.Drawing.Point(31, 32)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(180, 125)
        Me.btn11.TabIndex = 0
        Me.btn11.UseVisualStyleBackColor = True
        '
        'btn32
        '
        Me.btn32.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn32.Location = New System.Drawing.Point(403, 163)
        Me.btn32.Name = "btn32"
        Me.btn32.Size = New System.Drawing.Size(180, 125)
        Me.btn32.TabIndex = 1
        Me.btn32.UseVisualStyleBackColor = True
        '
        'btn31
        '
        Me.btn31.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn31.Location = New System.Drawing.Point(403, 32)
        Me.btn31.Name = "btn31"
        Me.btn31.Size = New System.Drawing.Size(180, 125)
        Me.btn31.TabIndex = 2
        Me.btn31.UseVisualStyleBackColor = True
        '
        'btn33
        '
        Me.btn33.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn33.Location = New System.Drawing.Point(403, 294)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(180, 125)
        Me.btn33.TabIndex = 3
        Me.btn33.UseVisualStyleBackColor = True
        '
        'btn23
        '
        Me.btn23.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn23.Location = New System.Drawing.Point(217, 294)
        Me.btn23.Name = "btn23"
        Me.btn23.Size = New System.Drawing.Size(180, 125)
        Me.btn23.TabIndex = 4
        Me.btn23.UseVisualStyleBackColor = True
        '
        'btn22
        '
        Me.btn22.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn22.Location = New System.Drawing.Point(217, 163)
        Me.btn22.Name = "btn22"
        Me.btn22.Size = New System.Drawing.Size(180, 125)
        Me.btn22.TabIndex = 5
        Me.btn22.UseVisualStyleBackColor = True
        '
        'btn21
        '
        Me.btn21.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn21.Location = New System.Drawing.Point(217, 32)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(180, 125)
        Me.btn21.TabIndex = 6
        Me.btn21.UseVisualStyleBackColor = True
        '
        'btn13
        '
        Me.btn13.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn13.Location = New System.Drawing.Point(31, 294)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(180, 125)
        Me.btn13.TabIndex = 7
        Me.btn13.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.btn12.Location = New System.Drawing.Point(31, 163)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(180, 125)
        Me.btn12.TabIndex = 8
        Me.btn12.UseVisualStyleBackColor = True
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.8!)
        Me.lblTurn.Location = New System.Drawing.Point(603, 32)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(182, 32)
        Me.lblTurn.TabIndex = 9
        Me.lblTurn.Text = "Current Turn:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(962, 396)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(118, 23)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start Over"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.8!)
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblStatus.Location = New System.Drawing.Point(699, 163)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(284, 63)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "YOU WIN!"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.8!)
        Me.lblResponse.Location = New System.Drawing.Point(627, 184)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(0, 32)
        Me.lblResponse.TabIndex = 12
        '
        'lblCurrentTurn
        '
        Me.lblCurrentTurn.AutoSize = True
        Me.lblCurrentTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTurn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCurrentTurn.Location = New System.Drawing.Point(808, 32)
        Me.lblCurrentTurn.Name = "lblCurrentTurn"
        Me.lblCurrentTurn.Size = New System.Drawing.Size(35, 32)
        Me.lblCurrentTurn.TabIndex = 13
        Me.lblCurrentTurn.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 437)
        Me.Controls.Add(Me.lblCurrentTurn)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.btn22)
        Me.Controls.Add(Me.btn23)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn31)
        Me.Controls.Add(Me.btn32)
        Me.Controls.Add(Me.btn11)
        Me.Name = "Form1"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn11 As System.Windows.Forms.Button
    Friend WithEvents btn32 As System.Windows.Forms.Button
    Friend WithEvents btn31 As System.Windows.Forms.Button
    Friend WithEvents btn33 As System.Windows.Forms.Button
    Friend WithEvents btn23 As System.Windows.Forms.Button
    Friend WithEvents btn22 As System.Windows.Forms.Button
    Friend WithEvents btn21 As System.Windows.Forms.Button
    Friend WithEvents btn13 As System.Windows.Forms.Button
    Friend WithEvents btn12 As System.Windows.Forms.Button
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblResponse As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTurn As System.Windows.Forms.Label

End Class
