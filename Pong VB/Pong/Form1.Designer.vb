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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlPlayer = New System.Windows.Forms.Panel()
        Me.pnlMob = New System.Windows.Forms.Panel()
        Me.pnlBall = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBack = New System.Windows.Forms.Panel()
        Me.lblScoreMob = New System.Windows.Forms.Label()
        Me.lblScorePlayer = New System.Windows.Forms.Label()
        Me.pnlBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPlayer
        '
        Me.pnlPlayer.BackColor = System.Drawing.Color.White
        Me.pnlPlayer.Location = New System.Drawing.Point(12, 12)
        Me.pnlPlayer.Name = "pnlPlayer"
        Me.pnlPlayer.Size = New System.Drawing.Size(10, 93)
        Me.pnlPlayer.TabIndex = 0
        '
        'pnlMob
        '
        Me.pnlMob.BackColor = System.Drawing.Color.White
        Me.pnlMob.Location = New System.Drawing.Point(1035, 567)
        Me.pnlMob.Name = "pnlMob"
        Me.pnlMob.Size = New System.Drawing.Size(10, 93)
        Me.pnlMob.TabIndex = 1
        '
        'pnlBall
        '
        Me.pnlBall.BackColor = System.Drawing.Color.White
        Me.pnlBall.Location = New System.Drawing.Point(536, 336)
        Me.pnlBall.Name = "pnlBall"
        Me.pnlBall.Size = New System.Drawing.Size(10, 10)
        Me.pnlBall.TabIndex = 1
        '
        'Timer1
        '
        '
        'pnlBack
        '
        Me.pnlBack.BackColor = System.Drawing.Color.Transparent
        Me.pnlBack.Controls.Add(Me.lblScoreMob)
        Me.pnlBack.Controls.Add(Me.lblScorePlayer)
        Me.pnlBack.ForeColor = System.Drawing.Color.Transparent
        Me.pnlBack.Location = New System.Drawing.Point(0, 0)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(1057, 673)
        Me.pnlBack.TabIndex = 2
        '
        'lblScoreMob
        '
        Me.lblScoreMob.AutoSize = True
        Me.lblScoreMob.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreMob.Location = New System.Drawing.Point(630, 27)
        Me.lblScoreMob.Name = "lblScoreMob"
        Me.lblScoreMob.Size = New System.Drawing.Size(30, 31)
        Me.lblScoreMob.TabIndex = 1
        Me.lblScoreMob.Text = "0"
        '
        'lblScorePlayer
        '
        Me.lblScorePlayer.AutoSize = True
        Me.lblScorePlayer.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScorePlayer.Location = New System.Drawing.Point(430, 27)
        Me.lblScorePlayer.Name = "lblScorePlayer"
        Me.lblScorePlayer.Size = New System.Drawing.Size(30, 31)
        Me.lblScorePlayer.TabIndex = 0
        Me.lblScorePlayer.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1057, 672)
        Me.Controls.Add(Me.pnlBall)
        Me.Controls.Add(Me.pnlMob)
        Me.Controls.Add(Me.pnlPlayer)
        Me.Controls.Add(Me.pnlBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "VB Pong"
        Me.pnlBack.ResumeLayout(False)
        Me.pnlBack.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPlayer As System.Windows.Forms.Panel

    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlMob As System.Windows.Forms.Panel
    Friend WithEvents pnlBall As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlBack As System.Windows.Forms.Panel
    Friend WithEvents lblScoreMob As System.Windows.Forms.Label
    Friend WithEvents lblScorePlayer As System.Windows.Forms.Label

End Class
