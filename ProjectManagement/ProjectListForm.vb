Public Class ProjectListForm

    Class CustomerItem
        Public CustomerCode As String   '顧客コード
        Public CustomerName As String   '顧客名
        Public Rank As String           'ランク
    End Class

    Private m_Customers As New List(Of CustomerItem)

    Private Sub ProjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString)

            'データコマンドを作成する
            Using command As SqlClient.SqlCommand = connection.CreateCommand()

                'コネクションを開く
                connection.Open()

                'データリーダーの宣言
                Dim dr As SqlClient.SqlDataReader

                '### 顧客のコンボボックスの設定　###
                'データコマンドの定義
                command.CommandText = "SELECT customer_code, customer_name, rank FROM tbl_customer ORDER BY customer_code"

                'データリーダーからのデータの読み出し
                dr = command.ExecuteReader()
                Do While dr.Read
                    'CustomerItemクラスに読み出したデータをセットする
                    Dim item As New CustomerItem
                    item.CustomerCode = dr("customer_code")
                    item.CustomerName = dr("customer_name")
                    item.Rank = dr("rank").ToString

                    'm_CustomersコレクションにCustomerItemクラスを追加する
                    m_Customers.Add(item)
                Loop

                'データリーダーを閉じる
                dr.Close()

                'コネクションを閉じる
                connection.Close()

                'コンボボックスで既定の状態として、先頭の（すべて）を選択する
                CustomerComboBox.SelectedIndex = 0

                '［ランク］コンボボックスの既定値として［全］を選択する
                'この処理でイベントが発生し、［顧客］コンボボックスの一覧が生成される
                RankComboBox.SelectedIndex = 0
            End Using

        End Using

        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String

        'プロジェクト名の条件指定（部分一致）と条件式の作成
        If ProjectNameTextBox.Text <> "" Then
            fs = "project_name Like N'%" & escape_string(ProjectNameTextBox.Text) & "%'"
        End If

        '顧客の条件指定と条件式の作成
        If CustomerComboBox.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "customer_code = '" &
                Strings.Left(CustomerComboBox.Text, 7) & "'"
        End If

        '完了フラグの条件指定と条件式の作成
        If Not CompleteCheckBox.Checked Then
            If fs <> "" Then
                fs &= " AND "
            End If

            '未完了データのみにする
            fs &= "complete_flag = 0"
        End If

        'SQLステートメントの定義
        sql = "SELECT * FROM vw_projectlist"

        '条件が指定されているときにはWHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs
        End If

        'データアダプターにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(
            sql, My.Settings.project_jobConnectionString)

        'データテーブルをクリアする
        Me.Project_jobDataSet.vw_projectlist.Clear()

        'データテーブルにデータアダプターを介してデータをセットする
        da.Fill(Me.Project_jobDataSet.vw_projectlist)
    End Sub

    Function escape_string(src As String) As String
        Dim s As String = src

        s = s.Replace("'", "''")
        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s
    End Function

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'このフォームを閉じる
        Me.Close()
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Dim frm As New ProjectForm() '［プロジェクト管理］フォーム

        '新規モードの準備を行う
        frm.SetNewMode()

        '［プロジェクト管理］フォームを表示する
        frm.ShowDialog(Me)

        '新規登録の処理から戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub

    Private Sub CardButton_Click(sender As Object, e As EventArgs) Handles CardButton.Click
        'データグリッドビューが空のときは終了する
        If ProjectListDataGridView.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim code As String

        'データグリッドビューの行番号を取得する
        row = ProjectListDataGridView.CurrentRow.Index
        '行番号からプロジェクトコードを取得する
        code = ProjectListDataGridView.Item(0, row).Value.ToString()

        Dim frm As New ProjectForm '［プロジェクト管理］フォーム

        '［プロジェクト管理］フォームのSetEditModeプロシージャを呼び出して、
        '指定したプロジェクトコードのデータを表示する
        frm.SetEditMode(code)

        '［プロジェクト管理］フォームを表示する
        frm.ShowDialog(Me)

        '［プロジェクト管理］フォームから戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub

    Private Sub RankComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RankComboBox.SelectedIndexChanged
        '［顧客］コンボボックスの一覧を作り直す
        SetCustomerComboBox()
    End Sub

    Private Sub OrderCodeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OrderCodeRadioButton.CheckedChanged
        '［顧客］コンボボックスの一覧を作り直す
        SetCustomerComboBox()
    End Sub

    Private Sub OrderNameRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OrderNameRadioButton.CheckedChanged
        '［顧客］コンボボックスの一覧を作り直す
        SetCustomerComboBox()
    End Sub

    '［顧客］コンボボックスの一覧の生成
    Private Sub SetCustomerComboBox()
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        'コンボボックスの項目をクリアする
        CustomerComboBox.Items.Clear()
        '先頭に（すべて）を追加する
        CustomerComboBox.Items.Add("（すべて）")

        '選択したランクを取得する
        Dim rank As Integer = RankComboBox.SelectedIndex

        '顧客データの配列を宣言する
        Dim customerarray() As CustomerItem = Nothing

        '条件によって、顧客データの配列を生成する
        If rank = 0 Then
            'ランクが「全」の場合（Where句なし）
            If OrderCodeRadioButton.Checked Then
                'コード順が選択されているとき
                customerarray = (From a In m_Customers Order By a.CustomerCode).ToArray
            ElseIf OrderNameRadioButton.Checked Then
                '名前順が選択されているとき
                customerarray = (From a In m_Customers Order By a.CustomerName).ToArray
            End If

        Else
            'ランクが「A」～「C」の場合（ランクによるWhere句あり）
            If OrderCodeRadioButton.Checked Then
                'コード順が選択されているとき
                customerarray = (From a In m_Customers
                                 Where a.Rank = RankComboBox.SelectedItem
                                 Order By a.CustomerCode).ToArray
            ElseIf OrderNameRadioButton.Checked Then
                '名前順が選択されているとき
                customerarray = (From a In m_Customers
                                 Where a.Rank = RankComboBox.SelectedItem
                                 Order By a.CustomerName).ToArray
            End If
        End If

        '配列からデータを取得して、コンボボックスに追加する
        For Each c In customerarray
            CustomerComboBox.Items.Add(c.CustomerCode & ":" & c.CustomerName)
        Next

        '先頭の（すべて）を選択する
        CustomerComboBox.SelectedIndex = 0

        '待機カーソル（砂時計）を戻す
        Me.Cursor = Cursors.Default
    End Sub

End Class