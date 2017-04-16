<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.自查问题处理BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JHBDataSet = New wapJHB.JHBDataSet()
        Me.T_wtjuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.T_wtjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.T_wtjuBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.T_wtjuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.T_WTJUTableAdapter = New wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter()
        Me.TableAdapterManager = New wapJHB.JHBDataSetTableAdapters.TableAdapterManager()
        Me.自查问题处理TableAdapter = New wapJHB.JHBDataSetTableAdapters.自查问题处理TableAdapter()
        Me.tzdContentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tzdContentTableAdapter = New wapJHB.JHBDataSetTableAdapters.tzdContentTableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.自查问题处理BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_wtjuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_wtjuBindingNavigator.SuspendLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_wtjuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tzdContentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '自查问题处理BindingSource
        '
        Me.自查问题处理BindingSource.DataMember = "自查问题处理"
        Me.自查问题处理BindingSource.DataSource = Me.JHBDataSet
        '
        'JHBDataSet
        '
        Me.JHBDataSet.DataSetName = "JHBDataSet"
        Me.JHBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_wtjuBindingNavigator
        '
        Me.T_wtjuBindingNavigator.AddNewItem = Nothing
        Me.T_wtjuBindingNavigator.BindingSource = Me.T_wtjuBindingSource
        Me.T_wtjuBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.T_wtjuBindingNavigator.DeleteItem = Nothing
        Me.T_wtjuBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.T_wtjuBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.T_wtjuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.T_wtjuBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton3})
        Me.T_wtjuBindingNavigator.Location = New System.Drawing.Point(0, 726)
        Me.T_wtjuBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_wtjuBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_wtjuBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_wtjuBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_wtjuBindingNavigator.Name = "T_wtjuBindingNavigator"
        Me.T_wtjuBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_wtjuBindingNavigator.Size = New System.Drawing.Size(1262, 27)
        Me.T_wtjuBindingNavigator.TabIndex = 0
        Me.T_wtjuBindingNavigator.Text = "BindingNavigator1"
        '
        'T_wtjuBindingSource
        '
        Me.T_wtjuBindingSource.DataMember = "t_wtju"
        Me.T_wtjuBindingSource.DataSource = Me.JHBDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 24)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "总项数"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "移到第一条记录"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一条记录"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "当前位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一条记录"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "移到最后一条记录"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'T_wtjuBindingNavigatorSaveItem
        '
        Me.T_wtjuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.T_wtjuBindingNavigatorSaveItem.Image = CType(resources.GetObject("T_wtjuBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T_wtjuBindingNavigatorSaveItem.Name = "T_wtjuBindingNavigatorSaveItem"
        Me.T_wtjuBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.T_wtjuBindingNavigatorSaveItem.Text = "保存数据"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(43, 24)
        Me.ToolStripButton1.Text = "报表"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(43, 24)
        Me.ToolStripButton2.Text = "返回"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(98, 24)
        Me.ToolStripButton3.Text = "生成EXCEl表"
        '
        'T_wtjuDataGridView
        '
        Me.T_wtjuDataGridView.AutoGenerateColumns = False
        Me.T_wtjuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_wtjuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.T_wtjuDataGridView.DataSource = Me.T_wtjuBindingSource
        Me.T_wtjuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.T_wtjuDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.T_wtjuDataGridView.Name = "T_wtjuDataGridView"
        Me.T_wtjuDataGridView.RowTemplate.Height = 27
        Me.T_wtjuDataGridView.Size = New System.Drawing.Size(1262, 726)
        Me.T_wtjuDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "问题编号"
        Me.DataGridViewTextBoxColumn1.HeaderText = "问题编号"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "设备名称"
        Me.DataGridViewTextBoxColumn2.HeaderText = "设备名称"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "存在问题"
        Me.DataGridViewTextBoxColumn3.HeaderText = "存在问题"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "整治方案"
        Me.DataGridViewTextBoxColumn4.HeaderText = "整治方案"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "计划时间"
        DataGridViewCellStyle1.Format = "M"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "计划时间"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "整治情况"
        Me.DataGridViewTextBoxColumn6.HeaderText = "整治情况"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "完成情况"
        Me.DataGridViewTextBoxColumn7.HeaderText = "完成情况"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "参加整治负责人签字"
        Me.DataGridViewTextBoxColumn8.HeaderText = "参加整治负责人签字"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "发现问题时间"
        DataGridViewCellStyle2.Format = "M"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn10.HeaderText = "发现问题时间"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "销记"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "销记"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "销记时间"
        DataGridViewCellStyle3.Format = "M"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn11.HeaderText = "销记时间"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "问题等级"
        Me.DataGridViewTextBoxColumn12.HeaderText = "问题等级"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "站名"
        Me.DataGridViewTextBoxColumn13.HeaderText = "站名"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 59
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.自查问题处理BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "wapJHB.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(785, 372)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(443, 161)
        Me.ReportViewer1.TabIndex = 2
        '
        'T_WTJUTableAdapter
        '
        Me.T_WTJUTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_pfjuTableAdapter = Nothing
        Me.TableAdapterManager.T_WTJUTableAdapter = Me.T_WTJUTableAdapter
        Me.TableAdapterManager.tzdContentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = wapJHB.JHBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        '自查问题处理TableAdapter
        '
        Me.自查问题处理TableAdapter.ClearBeforeFill = True
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
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1262, 753)
        Me.Controls.Add(Me.T_wtjuDataGridView)
        Me.Controls.Add(Me.T_wtjuBindingNavigator)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "问题登销(无配合)"
        CType(Me.自查问题处理BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_wtjuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_wtjuBindingNavigator.ResumeLayout(False)
        Me.T_wtjuBindingNavigator.PerformLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_wtjuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tzdContentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JHBDataSet As wapJHB.JHBDataSet
    Friend WithEvents T_wtjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_WTJUTableAdapter As wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter
    Friend WithEvents TableAdapterManager As wapJHB.JHBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_wtjuBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents T_wtjuBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents T_wtjuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents 自查问题处理BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 自查问题处理TableAdapter As wapJHB.JHBDataSetTableAdapters.自查问题处理TableAdapter
    Friend WithEvents tzdContentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tzdContentTableAdapter As wapJHB.JHBDataSetTableAdapters.tzdContentTableAdapter
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
