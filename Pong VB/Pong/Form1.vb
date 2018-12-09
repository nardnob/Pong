Public Class Form1

    Private screenY As Integer
    Private screenH As Integer

    Private ballX As Integer
    Private ballY As Integer

    Private mobVelY As Double = 6
    Private mobUp As Integer = 1

    Private maxVelInit As Integer = 10
    Private maxVel As Integer = maxVelInit
    Private maxMaxVel As Integer = 30
    Private velX As Integer
    Private velY As Integer
    Private maxVelIncrement As Integer = 2 'The amount to increment the ball's velocity per hit

    'Heights, decreases for the winner proportional to their winning ratio
    Private playerHeightInit As Integer = 96
    Private playerHeight As Integer = playerHeightInit
    Private mobHeightInit As Integer = 96
    Private mobHeight As Integer = mobHeightInit

    Private Const winTop = 30
    Private Const winBottom = 5

    Private scorePlayer As Integer = 0
    Private scoreMob As Integer = 0

    Private restart As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        screenY = pnlBack.Location.Y + pnlBack.Location.Y
        screenH = pnlBack.Size.Height

        ' Add any initialization after the InitializeComponent() call.
        Timer1.Interval = 0.7
        Timer1.Start()

        'Initialize the random number generator
        Randomize()

        'Hide the cursor
        Cursor.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        'Restart the ball's position if required
        If restart Then
            pnlBall.Location = New Point(536, 336)

            'Reset the maxVel
            maxVel = maxVelInit

            'Add a bit of randomness to the ball's direction. Still includes the current maximum velocity
            velX = (maxVel * 0.5 - maxVel * 0.2 + 1) * Rnd() + maxVel * 0.2
            If velX <> 0 Then
                velY = Math.Sqrt(Math.Pow(maxVel, 2) / Math.Pow(velX, 2))
            Else
                velY = maxVel
            End If
            restart = False
        End If

        'Update the location & height of the screen
        screenY = Me.Location.Y + pnlBack.Location.Y
        screenH = pnlBack.Size.Height

        'Update the players' location based on the mouse position w/ respect to screenY
        pnlPlayer.Location = New Point(pnlPlayer.Location.X, MousePosition.Y - screenY - pnlPlayer.Size.Height / 2 - winTop)
        pnlBack.PointToClient(pnlPlayer.Location)

        'Bound the player inside the screen
        If pnlPlayer.Location.Y < 0 Then
            pnlPlayer.Location = New Point(pnlPlayer.Location.X, 0)
        ElseIf pnlPlayer.Location.Y + pnlPlayer.Size.Height > screenH Then
            pnlPlayer.Location = New Point(pnlPlayer.Location.X, screenH - pnlPlayer.Size.Height)
        End If

        'Ball velocity to movement
        pnlBall.Location = New Point(pnlBall.Location.X + velX, pnlBall.Location.Y + velY)
        ballX = pnlBall.Location.X + pnlBall.Size.Width / 2
        ballY = pnlBall.Location.Y + pnlBall.Size.Height / 2

        'Bound the ball vertically
        If ballY + velY < 0 Or ballY + velY > screenH Then
            velY = -velY
        End If

        'Bound the ball horizontally between the player and mob
        If (ballX + velX >= pnlPlayer.Location.X And ballX + velX <= pnlPlayer.Location.X + pnlPlayer.Size.Width) And (ballY + velY >= pnlPlayer.Location.Y And ballY + velY <= pnlPlayer.Location.Y + pnlPlayer.Size.Height) Then

            'Reverse the velX
            velX = -velX

            'Create vel ratios to the current maxVel to then update vel with the new max vel
            Dim ratioX As Double = velX / maxVel
            Dim ratioY As Double = velY / maxVel


            'Increase the max vel to increase difficulty per hit
            maxVel += maxVelIncrement

            If maxVel > maxMaxVel Then
                maxVel = maxMaxVel
            End If

            'Update the current vel using the ratios
            velX = ratioX * maxVel
            velY = ratioY * maxVel

        ElseIf (ballX + velX >= pnlMob.Location.X And ballX + velX <= pnlMob.Location.X + pnlMob.Size.Width) And (ballY + velY >= pnlMob.Location.Y And ballY + velY <= pnlMob.Location.Y + pnlMob.Size.Height) Then

            'Reverse the velX
            velX = -velX

            'Create vel ratios to the current maxVel to then update vel with the new max vel
            Dim ratioX As Double = velX / maxVel
            Dim ratioY As Double = velY / maxVel


            'Increase the max vel to increase difficulty per hit
            maxVel += maxVelIncrement

            If maxVel > maxMaxVel Then
                maxVel = maxMaxVel
            End If

            'Update the current vel using the ratios
            velX = ratioX * maxVel
            velY = ratioY * maxVel

        End If

        'Mob AI intention to follow the ball
        If ballY > pnlMob.Location.Y + pnlMob.Size.Height / 2 And velX > 0 Then
            mobUp = 1
        ElseIf velX > 0 Then
            mobUp = -1
        Else
            mobUp = 0
        End If

        'Mob intention to vel
        pnlMob.Location = New Point(pnlMob.Location.X, pnlMob.Location.Y + mobVelY * mobUp)

        'Bound the mob to the screen
        If pnlMob.Location.Y < 0 Then
            pnlMob.Location = New Point(pnlMob.Location.X, 0)
        ElseIf pnlMob.Location.Y + pnlMob.Size.Height > screenH Then
            pnlMob.Location = New Point(pnlMob.Location.X, screenH - pnlMob.Size.Height)
        End If

        'Check for a score.. Mob then Player
        If ballX < pnlPlayer.Location.X Then
            scoreMob += 1
            lblScoreMob.Text = scoreMob.ToString()
            restart = True
        ElseIf ballX > pnlMob.Location.X + pnlMob.Size.Width Then
            scorePlayer += 1
            lblScorePlayer.Text = scorePlayer.ToString()
            restart = True
        End If

        'Bound the mouse cursor inside the window
        If Cursor.Position.X < Me.Location.X + 10 Then
            Cursor.Position = New Point(Me.Location.X + 10, Cursor.Position.Y)
        ElseIf Cursor.Position.X > Me.Size.Width + Me.Location.X - 10 Then
            Cursor.Position = New Point(Me.Size.Width + Me.Location.X - 10, Cursor.Position.Y)
        End If
        If Cursor.Position.Y < Me.Location.Y + 20 Then
            Cursor.Position = New Point(Cursor.Position.X, Me.Location.Y + 20)
        ElseIf Cursor.Position.Y > Me.Size.Height + Me.Location.Y - 10 Then
            Cursor.Position = New Point(Cursor.Position.X, Me.Size.Height + Me.Location.Y - 10)
        End If

    End Sub

    Private Sub Form1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class
