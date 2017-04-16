<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.JHBDataSet = New wapJHB.JHBDataSet()
        Me.tzdContentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tzdContentTableAdapter = New wapJHB.JHBDataSetTableAdapters.tzdContentTableAdapter()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tzdContentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tzdContentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "wapJHB.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(115, 29)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(575, 386)
        Me.ReportViewer1.TabIndex = 0
        '
        'JHBDataSet
        '
        Me.JHBDataSet.DataSetName = "JHBDataSet"
        Me.JHBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tzdContentBindingSource
        '
        Me.tzdContentBindingSource.DataMember = "tzdContent"
        Me.tzdContentBindingSource.DataSource = Me.JHBDataSet
        '
        'tzdContentTableAdapter
        '
        Me.tzdContentTableAdapter.ClearBeforeFill = True
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 487)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "test"
        Me.Text = "test"
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tzdContentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tzdContentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JHBDataSet As wapJHB.JHBDataSet
    Friend WithEvents tzdContentTableAdapter As wapJHB.JHBDataSetTableAdapters.tzdContentTableAdapter
End Class
