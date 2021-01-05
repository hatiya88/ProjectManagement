<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UserButton = New System.Windows.Forms.Button()
        Me.StaffConvertButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SectionButton = New System.Windows.Forms.Button()
        Me.CustomerButton = New System.Windows.Forms.Button()
        Me.StaffButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProjectButton = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(467, 9)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(97, 32)
        Me.QuitButton.TabIndex = 9
        Me.QuitButton.Text = "終了"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.UserButton)
        Me.Panel3.Controls.Add(Me.StaffConvertButton)
        Me.Panel3.Controls.Add(Me.ExportButton)
        Me.Panel3.Location = New System.Drawing.Point(384, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 250)
        Me.Panel3.TabIndex = 8
        '
        'UserButton
        '
        Me.UserButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UserButton.ForeColor = System.Drawing.Color.Green
        Me.UserButton.Location = New System.Drawing.Point(9, 163)
        Me.UserButton.Name = "UserButton"
        Me.UserButton.Size = New System.Drawing.Size(160, 70)
        Me.UserButton.TabIndex = 2
        Me.UserButton.Text = "ユーザー管理"
        Me.UserButton.UseVisualStyleBackColor = True
        '
        'StaffConvertButton
        '
        Me.StaffConvertButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StaffConvertButton.ForeColor = System.Drawing.Color.Green
        Me.StaffConvertButton.Location = New System.Drawing.Point(9, 88)
        Me.StaffConvertButton.Name = "StaffConvertButton"
        Me.StaffConvertButton.Size = New System.Drawing.Size(160, 70)
        Me.StaffConvertButton.TabIndex = 1
        Me.StaffConvertButton.Text = "スタッフの一括置換"
        Me.StaffConvertButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ExportButton.ForeColor = System.Drawing.Color.Green
        Me.ExportButton.Location = New System.Drawing.Point(9, 12)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(160, 70)
        Me.ExportButton.TabIndex = 0
        Me.ExportButton.Text = "顧客データの" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "エクスポート"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.SectionButton)
        Me.Panel2.Controls.Add(Me.CustomerButton)
        Me.Panel2.Controls.Add(Me.StaffButton)
        Me.Panel2.Location = New System.Drawing.Point(198, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 250)
        Me.Panel2.TabIndex = 7
        '
        'SectionButton
        '
        Me.SectionButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SectionButton.ForeColor = System.Drawing.Color.Purple
        Me.SectionButton.Location = New System.Drawing.Point(10, 163)
        Me.SectionButton.Name = "SectionButton"
        Me.SectionButton.Size = New System.Drawing.Size(160, 70)
        Me.SectionButton.TabIndex = 2
        Me.SectionButton.Text = "部署マスター"
        Me.SectionButton.UseVisualStyleBackColor = True
        '
        'CustomerButton
        '
        Me.CustomerButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CustomerButton.ForeColor = System.Drawing.Color.Purple
        Me.CustomerButton.Location = New System.Drawing.Point(10, 88)
        Me.CustomerButton.Name = "CustomerButton"
        Me.CustomerButton.Size = New System.Drawing.Size(160, 70)
        Me.CustomerButton.TabIndex = 1
        Me.CustomerButton.Text = "顧客マスター"
        Me.CustomerButton.UseVisualStyleBackColor = True
        '
        'StaffButton
        '
        Me.StaffButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StaffButton.ForeColor = System.Drawing.Color.Purple
        Me.StaffButton.Location = New System.Drawing.Point(10, 12)
        Me.StaffButton.Name = "StaffButton"
        Me.StaffButton.Size = New System.Drawing.Size(160, 70)
        Me.StaffButton.TabIndex = 0
        Me.StaffButton.Text = "スタッフマスター"
        Me.StaffButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "プロジェクト管理システム"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ProjectButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 250)
        Me.Panel1.TabIndex = 5
        '
        'ProjectButton
        '
        Me.ProjectButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ProjectButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProjectButton.Location = New System.Drawing.Point(10, 12)
        Me.ProjectButton.Name = "ProjectButton"
        Me.ProjectButton.Size = New System.Drawing.Size(160, 70)
        Me.ProjectButton.TabIndex = 0
        Me.ProjectButton.Text = "プロジェクト管理"
        Me.ProjectButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 306)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "メインメニュー"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuitButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UserButton As Button
    Friend WithEvents StaffConvertButton As Button
    Friend WithEvents ExportButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SectionButton As Button
    Friend WithEvents CustomerButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProjectButton As Button
End Class
