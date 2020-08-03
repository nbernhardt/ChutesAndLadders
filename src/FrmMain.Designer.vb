<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.EventLog = New System.Windows.Forms.ListBox()
        Me.BtnSpin = New System.Windows.Forms.Button()
        Me.NumPlayers = New System.Windows.Forms.TextBox()
        Me.BtnStartGame = New System.Windows.Forms.Button()
        Me.BoardPanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BoardPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventLog
        '
        Me.EventLog.FormattingEnabled = True
        Me.EventLog.Items.AddRange(New Object() {"Welcome to Chutes and Ladders! Default Game is set to 2 players.", ""})
        Me.EventLog.Location = New System.Drawing.Point(12, 418)
        Me.EventLog.Name = "EventLog"
        Me.EventLog.Size = New System.Drawing.Size(400, 134)
        Me.EventLog.TabIndex = 1
        '
        'BtnSpin
        '
        Me.BtnSpin.Location = New System.Drawing.Point(418, 212)
        Me.BtnSpin.Name = "BtnSpin"
        Me.BtnSpin.Size = New System.Drawing.Size(500, 200)
        Me.BtnSpin.TabIndex = 2
        Me.BtnSpin.Text = "SPIN!"
        Me.BtnSpin.UseVisualStyleBackColor = True
        '
        'NumPlayers
        '
        Me.NumPlayers.Location = New System.Drawing.Point(418, 529)
        Me.NumPlayers.Name = "NumPlayers"
        Me.NumPlayers.Size = New System.Drawing.Size(501, 20)
        Me.NumPlayers.TabIndex = 3
        Me.NumPlayers.Text = "2"
        Me.NumPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnStartGame
        '
        Me.BtnStartGame.Location = New System.Drawing.Point(418, 12)
        Me.BtnStartGame.Name = "BtnStartGame"
        Me.BtnStartGame.Size = New System.Drawing.Size(500, 200)
        Me.BtnStartGame.TabIndex = 4
        Me.BtnStartGame.Text = "Start Game"
        Me.BtnStartGame.UseVisualStyleBackColor = True
        '
        'BoardPanel
        '
        Me.BoardPanel.BackgroundImage = CType(resources.GetObject("BoardPanel.BackgroundImage"), System.Drawing.Image)
        Me.BoardPanel.Controls.Add(Me.PictureBox5)
        Me.BoardPanel.Controls.Add(Me.PictureBox4)
        Me.BoardPanel.Controls.Add(Me.PictureBox3)
        Me.BoardPanel.Controls.Add(Me.PictureBox2)
        Me.BoardPanel.Controls.Add(Me.PictureBox1)
        Me.BoardPanel.Location = New System.Drawing.Point(12, 12)
        Me.BoardPanel.Name = "BoardPanel"
        Me.BoardPanel.Size = New System.Drawing.Size(400, 400)
        Me.BoardPanel.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.ChutesAndLadders.My.Resources.Resources.YellowPlayerTile
        Me.PictureBox5.Location = New System.Drawing.Point(-40, 360)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.ChutesAndLadders.My.Resources.Resources.PurplePlayerTile
        Me.PictureBox4.Location = New System.Drawing.Point(-40, 360)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.ChutesAndLadders.My.Resources.Resources.GrayPlayerTile
        Me.PictureBox3.Location = New System.Drawing.Point(-40, 360)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.ChutesAndLadders.My.Resources.Resources.BluePlayerTile
        Me.PictureBox2.Location = New System.Drawing.Point(-40, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ChutesAndLadders.My.Resources.Resources.BlackPlayerTile
        Me.PictureBox1.Location = New System.Drawing.Point(-40, 360)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of Players:"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(417, 418)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(501, 49)
        Me.BtnReset.TabIndex = 6
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 561)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStartGame)
        Me.Controls.Add(Me.NumPlayers)
        Me.Controls.Add(Me.BtnSpin)
        Me.Controls.Add(Me.EventLog)
        Me.Controls.Add(Me.BoardPanel)
        Me.Name = "FrmMain"
        Me.Text = "Chutes and Ladders"
        Me.BoardPanel.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BoardPanel As Panel
    Friend WithEvents EventLog As ListBox
    Friend WithEvents BtnSpin As Button
    Friend WithEvents NumPlayers As TextBox
    Friend WithEvents BtnStartGame As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnReset As Button
End Class
