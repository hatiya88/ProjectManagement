Public Class SectionForm
    Private Sub Tbl_sectionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_sectionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_sectionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub SectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_section' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_sectionTableAdapter.Fill(Me.Project_jobDataSet.tbl_section)

    End Sub

    Private Sub Tbl_sectionDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_sectionDataGridView.DataError
        MsgBox("データの登録時にエラーが発生しました。" & vbCrLf _
            & vbCrLf & e.Exception.Message)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            With Tbl_sectionDataGridView
                'データグリッドビューのセルの選択を解除する
                .ClearSelection()
                'データグリッドビューの最終行先頭列に移動する
                .CurrentCell = .Rows(.NewRowIndex).Cells(0)
                '編集モードに遷移する
                .BeginEdit(False)
            End With
        Catch ex As Exception
            '例外時のエラーメッセージ
            MsgBox(ex.Message)
            Return
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        '削除するデータが存在しない場合への対応

        '現在の行が無効な場合は終了する
        If Tbl_sectionBindingSource.Current Is Nothing Then Return

        Dim drv As DataRowView = Tbl_sectionBindingSource.Current

        With Tbl_sectionBindingSource
            If Not drv.IsNew() Then
                'データグリッドビューの行が新規行以外のときには削除する
                .RemoveCurrent()
            End If
        End With
    End Sub
End Class