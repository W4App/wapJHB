Public Class FormPF

    Private Sub FormPF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Owner.Show()
        Me.Dispose()
    End Sub

    Private Sub FormPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“JHBDataSet.派发浏览”中。您可以根据需要移动或删除它。
        Me.派发浏览TableAdapter.Fill(Me.JHBDataSet.派发浏览)

    End Sub

    Private Sub 派发浏览DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles 派发浏览DataGridView.CellContentClick

    End Sub
End Class