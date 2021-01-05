Public Class UserForm
    Private Sub Tbl_staffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_staffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_staffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

    End Sub

    Private Sub Tbl_staffDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_staffDataGridView.DataError
        MsgBox("データの登録時にエラーが発生しました。" & vbCrLf _
            & vbCrLf & e.Exception.Message)
    End Sub
End Class