Public Class test

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“JHBDataSet.tzdContent”中。您可以根据需要移动或删除它。
        Me.tzdContentTableAdapter.Fill(Me.JHBDataSet.tzdContent)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class