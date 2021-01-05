<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffConvertForm
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
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.StaffCodeAfterComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffCodeBeforeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExecuteButton
        '
        Me.ExecuteButton.Location = New System.Drawing.Point(197, 16)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(75, 23)
        Me.ExecuteButton.TabIndex = 9
        Me.ExecuteButton.Text = "実行"
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'StaffCodeAfterComboBox
        '
        Me.StaffCodeAfterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StaffCodeAfterComboBox.FormattingEnabled = True
        Me.StaffCodeAfterComboBox.Location = New System.Drawing.Point(56, 44)
        Me.StaffCodeAfterComboBox.Name = "StaffCodeAfterComboBox"
        Me.StaffCodeAfterComboBox.Size = New System.Drawing.Size(121, 20)
        Me.StaffCodeAfterComboBox.TabIndex = 8
        '
        'StaffCodeBeforeComboBox
        '
        Me.StaffCodeBeforeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StaffCodeBeforeComboBox.FormattingEnabled = True
        Me.StaffCodeBeforeComboBox.Location = New System.Drawing.Point(56, 18)
        Me.StaffCodeBeforeComboBox.Name = "StaffCodeBeforeComboBox"
        Me.StaffCodeBeforeComboBox.Size = New System.Drawing.Size(121, 20)
        Me.StaffCodeBeforeComboBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "変更後"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "変更前"
        '
        'StaffConvertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 81)
        Me.Controls.Add(Me.ExecuteButton)
        Me.Controls.Add(Me.StaffCodeAfterComboBox)
        Me.Controls.Add(Me.StaffCodeBeforeComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffConvertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "スタッフの一括置換"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExecuteButton As Button
    Friend WithEvents StaffCodeAfterComboBox As ComboBox
    Friend WithEvents StaffCodeBeforeComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
