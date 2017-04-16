Public Class Form6
    Dim rp_ok As Boolean
    Private Sub T_wtjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_wtjuBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_wtjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)

    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Owner.Show()
        Me.Dispose()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.自查问题处理TableAdapter.Fill(Me.JHBDataSet.自查问题处理)
        Me.T_WTJUTableAdapter.FillBy_ziCha(Me.JHBDataSet.T_WTJU)
        Me.ReportViewer1.Dock = DockStyle.None
        Me.ReportViewer1.Visible = False
        rp_ok = False
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Me.T_wtjuDataGridView.Visible = False

        Me.自查问题处理TableAdapter.Fill(Me.JHBDataSet.自查问题处理)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.Visible = True
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.Show()
        Me.ReportViewer1.Refresh()
        rp_ok = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.ReportViewer1.Visible = False
        Me.T_wtjuDataGridView.Visible = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim warns As WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mime As String = Nothing
        Dim encode As String = Nothing
        Dim ext As String = Nothing
        Dim outbytes As Byte()

        If rp_ok = False Then           
            MsgBox("报表未生成,不能导出文件")
            Exit Sub
        End If
        Dim pfName As String
        Dim fsName As String
        Dim result As Windows.Forms.DialogResult
        pfName = "工区自查问题库(" + Format(Now(), "yyyy年M月dd日") + ")"

        Me.SaveFileDialog1.FileName = pfName
        Me.SaveFileDialog1.Filter = "Excel2003(*.xls)|*.xls"
        result = Me.SaveFileDialog1.ShowDialog()
        fsName = Me.SaveFileDialog1.FileName
        If result = 2 Then
            Exit Sub
        Else
            outbytes = Me.ReportViewer1.LocalReport.Render("Excel", Nothing, mime, encode, ext, streamids, warns)
            Dim fs As New IO.FileStream(fsName, IO.FileMode.Create)
            fs.Write(outbytes, 0, outbytes.Length)
            fs.Close()
        End If
    End Sub
End Class