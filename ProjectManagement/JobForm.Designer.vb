<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Project_codeLabel As System.Windows.Forms.Label
        Dim Job_numberLabel As System.Windows.Forms.Label
        Dim Job_titleLabel As System.Windows.Forms.Label
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobForm))
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Tbl_jobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_jobTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_jobTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_jobBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_jobBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Project_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Job_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Job_titleTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Complete_flagCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Tbl_staffTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_staffTableAdapter()
        Project_codeLabel = New System.Windows.Forms.Label()
        Job_numberLabel = New System.Windows.Forms.Label()
        Job_titleLabel = New System.Windows.Forms.Label()
        Staff_codeLabel = New System.Windows.Forms.Label()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_jobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_jobBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_jobBindingNavigator.SuspendLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Project_codeLabel
        '
        Project_codeLabel.AutoSize = True
        Project_codeLabel.Location = New System.Drawing.Point(12, 45)
        Project_codeLabel.Name = "Project_codeLabel"
        Project_codeLabel.Size = New System.Drawing.Size(89, 12)
        Project_codeLabel.TabIndex = 1
        Project_codeLabel.Text = "プロジェクトコード："
        '
        'Job_numberLabel
        '
        Job_numberLabel.AutoSize = True
        Job_numberLabel.Location = New System.Drawing.Point(12, 70)
        Job_numberLabel.Name = "Job_numberLabel"
        Job_numberLabel.Size = New System.Drawing.Size(52, 12)
        Job_numberLabel.TabIndex = 3
        Job_numberLabel.Text = "ジョブNo.："
        '
        'Job_titleLabel
        '
        Job_titleLabel.AutoSize = True
        Job_titleLabel.Location = New System.Drawing.Point(12, 95)
        Job_titleLabel.Name = "Job_titleLabel"
        Job_titleLabel.Size = New System.Drawing.Size(71, 12)
        Job_titleLabel.TabIndex = 5
        Job_titleLabel.Text = "ジョブタイトル："
        '
        'Staff_codeLabel
        '
        Staff_codeLabel.AutoSize = True
        Staff_codeLabel.Location = New System.Drawing.Point(12, 120)
        Staff_codeLabel.Name = "Staff_codeLabel"
        Staff_codeLabel.Size = New System.Drawing.Size(43, 12)
        Staff_codeLabel.TabIndex = 7
        Staff_codeLabel.Text = "スタッフ："
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_jobBindingSource
        '
        Me.Tbl_jobBindingSource.DataMember = "tbl_job"
        Me.Tbl_jobBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_jobTableAdapter
        '
        Me.Tbl_jobTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_jobTableAdapter = Me.Tbl_jobTableAdapter
        Me.TableAdapterManager.tbl_projectTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_jobBindingNavigator
        '
        Me.Tbl_jobBindingNavigator.AddNewItem = Nothing
        Me.Tbl_jobBindingNavigator.BindingSource = Me.Tbl_jobBindingSource
        Me.Tbl_jobBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_jobBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_jobBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_jobBindingNavigatorSaveItem})
        Me.Tbl_jobBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_jobBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_jobBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_jobBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_jobBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_jobBindingNavigator.Name = "Tbl_jobBindingNavigator"
        Me.Tbl_jobBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_jobBindingNavigator.Size = New System.Drawing.Size(340, 25)
        Me.Tbl_jobBindingNavigator.TabIndex = 0
        Me.Tbl_jobBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'Tbl_jobBindingNavigatorSaveItem
        '
        Me.Tbl_jobBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_jobBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_jobBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_jobBindingNavigatorSaveItem.Name = "Tbl_jobBindingNavigatorSaveItem"
        Me.Tbl_jobBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_jobBindingNavigatorSaveItem.Text = "データの保存"
        '
        'Project_codeTextBox
        '
        Me.Project_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_jobBindingSource, "project_code", True))
        Me.Project_codeTextBox.Location = New System.Drawing.Point(108, 42)
        Me.Project_codeTextBox.Name = "Project_codeTextBox"
        Me.Project_codeTextBox.ReadOnly = True
        Me.Project_codeTextBox.Size = New System.Drawing.Size(61, 19)
        Me.Project_codeTextBox.TabIndex = 2
        '
        'Job_numberTextBox
        '
        Me.Job_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_jobBindingSource, "job_number", True))
        Me.Job_numberTextBox.Location = New System.Drawing.Point(108, 67)
        Me.Job_numberTextBox.Name = "Job_numberTextBox"
        Me.Job_numberTextBox.ReadOnly = True
        Me.Job_numberTextBox.Size = New System.Drawing.Size(32, 19)
        Me.Job_numberTextBox.TabIndex = 4
        '
        'Job_titleTextBox
        '
        Me.Job_titleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_jobBindingSource, "job_title", True))
        Me.Job_titleTextBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Job_titleTextBox.Location = New System.Drawing.Point(108, 92)
        Me.Job_titleTextBox.Name = "Job_titleTextBox"
        Me.Job_titleTextBox.Size = New System.Drawing.Size(211, 19)
        Me.Job_titleTextBox.TabIndex = 6
        '
        'Staff_codeComboBox
        '
        Me.Staff_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_jobBindingSource, "staff_code", True))
        Me.Staff_codeComboBox.DataSource = Me.Tbl_staffBindingSource
        Me.Staff_codeComboBox.DisplayMember = "staff_name"
        Me.Staff_codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Staff_codeComboBox.FormattingEnabled = True
        Me.Staff_codeComboBox.Location = New System.Drawing.Point(108, 117)
        Me.Staff_codeComboBox.Name = "Staff_codeComboBox"
        Me.Staff_codeComboBox.Size = New System.Drawing.Size(121, 20)
        Me.Staff_codeComboBox.TabIndex = 8
        Me.Staff_codeComboBox.ValueMember = "staff_code"
        '
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Complete_flagCheckBox
        '
        Me.Complete_flagCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_jobBindingSource, "complete_flag", True))
        Me.Complete_flagCheckBox.Location = New System.Drawing.Point(240, 117)
        Me.Complete_flagCheckBox.Name = "Complete_flagCheckBox"
        Me.Complete_flagCheckBox.Size = New System.Drawing.Size(79, 24)
        Me.Complete_flagCheckBox.TabIndex = 10
        Me.Complete_flagCheckBox.Text = "完了フラグ"
        Me.Complete_flagCheckBox.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(244, 40)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "戻る"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'JobForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 154)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Project_codeLabel)
        Me.Controls.Add(Me.Project_codeTextBox)
        Me.Controls.Add(Job_numberLabel)
        Me.Controls.Add(Me.Job_numberTextBox)
        Me.Controls.Add(Job_titleLabel)
        Me.Controls.Add(Me.Job_titleTextBox)
        Me.Controls.Add(Staff_codeLabel)
        Me.Controls.Add(Me.Staff_codeComboBox)
        Me.Controls.Add(Me.Complete_flagCheckBox)
        Me.Controls.Add(Me.Tbl_jobBindingNavigator)
        Me.Name = "JobForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ジョブ管理"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_jobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_jobBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_jobBindingNavigator.ResumeLayout(False)
        Me.Tbl_jobBindingNavigator.PerformLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_jobBindingSource As BindingSource
    Friend WithEvents Tbl_jobTableAdapter As project_jobDataSetTableAdapters.tbl_jobTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_jobBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_jobBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Project_codeTextBox As TextBox
    Friend WithEvents Job_numberTextBox As TextBox
    Friend WithEvents Job_titleTextBox As TextBox
    Friend WithEvents Staff_codeComboBox As ComboBox
    Friend WithEvents Complete_flagCheckBox As CheckBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As project_jobDataSetTableAdapters.tbl_staffTableAdapter
End Class
