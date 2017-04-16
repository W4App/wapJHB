Public Class FormXJ

    Private Sub FormXJ_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Owner.Show()
        Me.Dispose()
    End Sub

    Private Sub FormXJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“JHBDataSet.已销记问题”中。您可以根据需要移动或删除它。
        Me.已销记问题TableAdapter.Fill(Me.JHBDataSet.已销记问题)

    End Sub

    Private Sub 已销记问题BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 已销记问题BindingNavigatorSaveItem.Click
        'Me.已销记问题BindingSource.EndEdit()
        ' Me.已销记问题TableAdapter.UpdateQuery_xj()
    End Sub
End Class