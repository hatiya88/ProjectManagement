Public Class JobForm

    Private project_code As String

    Public Sub SetProjectCode(ByVal pcode As String)

        'プロジェクトコードを保管する
        project_code = pcode

        'スタッフマスタのレコードをデータソースにセットする
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

        '受け取ったプロジェクトコードを使用して、該当するジョブマスタをデータソースにセットする
        Me.Tbl_jobTableAdapter.FillByPcode(Me.Project_jobDataSet.tbl_job, pcode)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'このフォームを閉じる
        Me.Close()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Dim jobno_max As Long = 0

        '現在のジョブナンバーの最大値を取得する

        'データセット内を繰り返す
        For Each drw As DataRow In Me.Project_jobDataSet.tbl_job.Rows()
            '行のRowStateが“削除”のデータをチェックから除外する
            If drw.RowState <> DataRowState.Deleted Then
                'この行のジョブナンバーと現在の最大値を比較する
                If drw("job_number") > jobno_max Then
                    jobno_max = drw("job_number")
                End If
            End If
        Next

        Tbl_jobBindingSource.AddNew()

        Project_codeTextBox.Text = project_code
        Job_numberTextBox.Text = jobno_max + 1
        Complete_flagCheckBox.Checked = False

        'ジョブタイトルにフォーカスをセットする
        Job_titleTextBox.Select()

    End Sub

    'データの検査と編集中のデータの登録
    Private Function CheckEditData() As Boolean
        If Tbl_jobBindingSource.Current Is Nothing Then Return True

        'データの検査（ジョブタイトル）
        With Job_titleTextBox
            '未入力のとき
            If .Text = "" Then
                MsgBox("ジョブタイトルが入力されていません")
                'テキストボックスを選択する
                .Select()
                Return False
            End If

            '桁数チェック
            If Not CheckMaxLengthUnicode("job_title", .Text) Then
                MsgBox("ジョブタイトルは50文字以内で入力してください")
                'テキストボックスを選択する
                .Select()
                Return False
            End If
        End With

        'データの検査（スタッフ）
        With Staff_codeComboBox
            '未選択のとき
            If .Text = "" Then
                MsgBox("スタッフを選択してください")
                'コンボボックスを選択する
                .Select()
                Return False
            End If
        End With

        '編集中の場合があるため、変更内容を保存する
        Try
            Me.Tbl_jobBindingSource.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    'サイズチェックUnicode版（指定された列のサイズと文字列の比較）
    Private Function CheckMaxLengthUnicode(fieldname As String, value As String) As Boolean
        'データセットから列の情報を読み取る
        Dim column As DataColumn =
            Project_jobDataSet.tbl_job.Columns(fieldname)
        '文字数を取得する（Unicode対応）
        Dim length As Integer = value.Length

        '指定された文字数を超えたときにはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Tbl_jobBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_jobBindingNavigatorSaveItem.Click
        '保存ボタンをクリックしたとき

        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        'データセットが更新されていないときには、以下の処理を実行しない
        If Not Me.Project_jobDataSet.HasChanges() Then Return

        If MsgBox("これまでの修正内容をデータベースに保存しますか？", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Return

        Try
            Me.Tbl_jobTableAdapter.Update(Me.Project_jobDataSet.tbl_job)
            MsgBox("データベースに登録しました。")
        Catch ex As Exception
            'エラーが発生した場合
            MsgBox("更新が失敗しました" & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_jobBindingSource.MoveFirst()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_jobBindingSource.MovePrevious()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_jobBindingSource.MoveNext()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_jobBindingSource.MoveLast()
    End Sub
End Class