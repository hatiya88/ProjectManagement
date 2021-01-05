Public Class MenuForm

    Dim frm_pr As ProjectListForm   '［プロジェクト一覧］フォーム
    Dim frm_st As StaffForm         '［スタッフマスター管理］フォーム
    Dim frm_cs As CustomerForm      '［顧客マスター管理］フォーム
    Dim frm_sc As SectionForm       '［部署マスター管理］フォーム
    Dim frm_su As StaffConvertForm  '［スタッフの一括更新］フォーム
    Dim frm_us As UserForm          '［ユーザー管理］フォーム

    Private Sub StaffButton_Click(sender As Object, e As EventArgs) Handles StaffButton.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_st Is Nothing OrElse frm_st.IsDisposed() Then
            frm_st = New StaffForm()
        End If

        'フォームを表示する
        frm_st.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If AdminFlag <> True Then
            '管理者権限を持たないユーザーの場合
            StaffConvertButton.Enabled = False
            UserButton.Enabled = False
        End If
    End Sub

    Private Sub CustomerButton_Click(sender As Object, e As EventArgs) Handles CustomerButton.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_cs Is Nothing OrElse frm_cs.IsDisposed() Then
            frm_cs = New CustomerForm()
        End If

        'フォームを表示する
        frm_cs.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Dim sr As IO.StreamWriter

        Dim exfolder As String
        Dim linetext As String

        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '保存先フォルダーの指定
        exfolder = IO.Path.Combine(Application.StartupPath, "データ出力")

        'フォルダーが存在しない場合には作成する
        If Not IO.Directory.Exists(exfolder) Then
            IO.Directory.CreateDirectory(exfolder)
        End If

        'ファイルを作成する
        sr = New IO.StreamWriter(IO.Path.Combine(exfolder, "顧客データ.csv"),
                                 False, System.Text.Encoding.GetEncoding("UTF-8"))

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString)

            'データコマンドを定義する
            Using command As New SqlClient.SqlCommand("SELECT * FROM tbl_customer",
                                                      connection)

                'コネクションを開く
                connection.Open()

                'データリーダーの生成
                Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

                'データの分だけ処理を繰り返す
                Do While dr.Read
                    '書き込むデータの生成（カンマ区切り）
                    linetext = dblqot_string(dr("customer_code")) & ","
                    linetext &= dblqot_string(dr("customer_name")) & ","
                    linetext &= dblqot_string(dr("zipcode")) & ","
                    linetext &= dblqot_string(dr("address")) & ","
                    linetext &= dblqot_string(dr("person")) & ","
                    linetext &= dblqot_string(dr("tel")) & ","
                    linetext &= dblqot_string(dr("input_date"))

                    'ファイルの書き込み
                    sr.WriteLine(linetext)
                Loop

                'データリーダーを閉じる
                dr.Close()
                'コネクションを閉じる
                connection.Close()
            End Using

        End Using

        'ファイルを閉じる
        sr.Close()

        '待機カーソル（砂時計）を戻す
        Me.Cursor = Cursors.Default

        MsgBox("顧客データを以下のフォルダーにエクスポートしました。" &
               vbCrLf & vbCrLf & exfolder)
    End Sub

    'ダブルクォーテーションの処理
    Function dblqot_string(src As Object) As String
        If IsDBNull(src) Then
            'データがNull値のときには""を返す
            Return """"""
        End If

        '"を""に置き換えて、文字列の前後に"を付ける
        Return """" & CStr(src).Replace("""", """""") & """"
    End Function

    Private Sub ProjectButton_Click(sender As Object, e As EventArgs) Handles ProjectButton.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_pr Is Nothing OrElse frm_pr.IsDisposed() Then
            frm_pr = New ProjectListForm()
        End If

        'フォームを表示する
        frm_pr.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SectionButton_Click(sender As Object, e As EventArgs) Handles SectionButton.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_sc Is Nothing OrElse frm_sc.IsDisposed() Then
            frm_sc = New SectionForm()
        End If

        'フォームを表示する
        frm_sc.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub UserButton_Click(sender As Object, e As EventArgs) Handles UserButton.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_us Is Nothing OrElse frm_us.IsDisposed() Then
            frm_us = New UserForm()
        End If

        'フォームを表示する
        frm_us.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StaffConvertButton_Click(sender As Object, e As EventArgs) Handles StaffConvertButton.Click
        '待機カーソル（砂時計）を表示する
        Me.Cursor = Cursors.WaitCursor

        '対象フォームのインスタンスが存在しないときに新しいインスタンスを生成する
        If frm_su Is Nothing OrElse frm_su.IsDisposed() Then
            frm_su = New StaffConvertForm()
        End If

        'フォームを表示する
        frm_su.ShowDialog()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default
    End Sub
End Class