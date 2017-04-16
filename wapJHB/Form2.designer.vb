<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim 问题编号Label As System.Windows.Forms.Label
        Dim 设备名称Label As System.Windows.Forms.Label
        Dim 存在问题Label As System.Windows.Forms.Label
        Dim 发现问题时间Label As System.Windows.Forms.Label
        Dim 整治方案Label As System.Windows.Forms.Label
        Dim 留存Label As System.Windows.Forms.Label
        Dim 计划时间Label As System.Windows.Forms.Label
        Dim 站名Label As System.Windows.Forms.Label
        Dim 问题等级Label As System.Windows.Forms.Label
        Dim 天窗需求Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.T_wtju_pf = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.T_wtjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JHBDataSet = New wapJHB.JHBDataSet()
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripLabel()
        Me.问题编号Label1 = New System.Windows.Forms.Label()
        Me.设备名称Label1 = New System.Windows.Forms.Label()
        Me.存在问题TextBox = New System.Windows.Forms.TextBox()
        Me.发现问题时间Label1 = New System.Windows.Forms.Label()
        Me.整治方案TextBox = New System.Windows.Forms.TextBox()
        Me.留存CheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.jhDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LJDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.计划时间TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TzdContentDataGridView = New System.Windows.Forms.DataGridView()
        Me.TzdContentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.站名ComboBox = New System.Windows.Forms.ComboBox()
        Me.问题等级Label1 = New System.Windows.Forms.Label()
        Me.T_pfjuDataGridView = New System.Windows.Forms.DataGridView()
        Me.T_pfjuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_pfjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JHBDataSet1 = New wapJHB.JHBDataSet()
        Me.T_WTJUTableAdapter = New wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter()
        Me.TableAdapterManager = New wapJHB.JHBDataSetTableAdapters.TableAdapterManager()
        Me.T_pfjuTableAdapter = New wapJHB.JHBDataSetTableAdapters.t_pfjuTableAdapter()
        Me.TzdContentTableAdapter = New wapJHB.JHBDataSetTableAdapters.tzdContentTableAdapter()
        Me.天窗需求Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.存在问题 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.天窗需求 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.整治方案 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        问题编号Label = New System.Windows.Forms.Label()
        设备名称Label = New System.Windows.Forms.Label()
        存在问题Label = New System.Windows.Forms.Label()
        发现问题时间Label = New System.Windows.Forms.Label()
        整治方案Label = New System.Windows.Forms.Label()
        留存Label = New System.Windows.Forms.Label()
        计划时间Label = New System.Windows.Forms.Label()
        站名Label = New System.Windows.Forms.Label()
        问题等级Label = New System.Windows.Forms.Label()
        天窗需求Label = New System.Windows.Forms.Label()
        CType(Me.T_wtju_pf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_wtju_pf.SuspendLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TzdContentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TzdContentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_pfjuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_pfjuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_pfjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JHBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '问题编号Label
        '
        问题编号Label.AutoSize = True
        问题编号Label.Location = New System.Drawing.Point(90, 131)
        问题编号Label.Name = "问题编号Label"
        问题编号Label.Size = New System.Drawing.Size(75, 15)
        问题编号Label.TabIndex = 1
        问题编号Label.Text = "问题编号:"
        '
        '设备名称Label
        '
        设备名称Label.AutoSize = True
        设备名称Label.Location = New System.Drawing.Point(90, 161)
        设备名称Label.Name = "设备名称Label"
        设备名称Label.Size = New System.Drawing.Size(75, 15)
        设备名称Label.TabIndex = 3
        设备名称Label.Text = "设备名称:"
        '
        '存在问题Label
        '
        存在问题Label.AutoSize = True
        存在问题Label.Location = New System.Drawing.Point(90, 197)
        存在问题Label.Name = "存在问题Label"
        存在问题Label.Size = New System.Drawing.Size(75, 15)
        存在问题Label.TabIndex = 5
        存在问题Label.Text = "存在问题:"
        '
        '发现问题时间Label
        '
        发现问题时间Label.AutoSize = True
        发现问题时间Label.Location = New System.Drawing.Point(90, 298)
        发现问题时间Label.Name = "发现问题时间Label"
        发现问题时间Label.Size = New System.Drawing.Size(105, 15)
        发现问题时间Label.TabIndex = 7
        发现问题时间Label.Text = "发现问题时间:"
        '
        '整治方案Label
        '
        整治方案Label.AutoSize = True
        整治方案Label.Location = New System.Drawing.Point(90, 405)
        整治方案Label.Name = "整治方案Label"
        整治方案Label.Size = New System.Drawing.Size(75, 15)
        整治方案Label.TabIndex = 10
        整治方案Label.Text = "整治方案:"
        '
        '留存Label
        '
        留存Label.AutoSize = True
        留存Label.Location = New System.Drawing.Point(90, 534)
        留存Label.Name = "留存Label"
        留存Label.Size = New System.Drawing.Size(45, 15)
        留存Label.TabIndex = 12
        留存Label.Text = "留存:"
        '
        '计划时间Label
        '
        计划时间Label.AutoSize = True
        计划时间Label.Location = New System.Drawing.Point(90, 466)
        计划时间Label.Name = "计划时间Label"
        计划时间Label.Size = New System.Drawing.Size(75, 15)
        计划时间Label.TabIndex = 16
        计划时间Label.Text = "计划时间:"
        '
        '站名Label
        '
        站名Label.AutoSize = True
        站名Label.Location = New System.Drawing.Point(90, 96)
        站名Label.Name = "站名Label"
        站名Label.Size = New System.Drawing.Size(45, 15)
        站名Label.TabIndex = 25
        站名Label.Text = "站名:"
        '
        '问题等级Label
        '
        问题等级Label.AutoSize = True
        问题等级Label.Location = New System.Drawing.Point(90, 351)
        问题等级Label.Name = "问题等级Label"
        问题等级Label.Size = New System.Drawing.Size(75, 15)
        问题等级Label.TabIndex = 27
        问题等级Label.Text = "问题等级:"
        '
        '天窗需求Label
        '
        天窗需求Label.AutoSize = True
        天窗需求Label.Location = New System.Drawing.Point(274, 352)
        天窗需求Label.Name = "天窗需求Label"
        天窗需求Label.Size = New System.Drawing.Size(75, 15)
        天窗需求Label.TabIndex = 29
        天窗需求Label.Text = "天窗需求:"
        '
        'T_wtju_pf
        '
        Me.T_wtju_pf.AddNewItem = Nothing
        Me.T_wtju_pf.BindingSource = Me.T_wtjuBindingSource
        Me.T_wtju_pf.CountItem = Me.BindingNavigatorCountItem
        Me.T_wtju_pf.DeleteItem = Nothing
        Me.T_wtju_pf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.T_wtju_pf.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.T_wtju_pf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.T_wtjuBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripTextBox1})
        Me.T_wtju_pf.Location = New System.Drawing.Point(0, 732)
        Me.T_wtju_pf.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_wtju_pf.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_wtju_pf.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_wtju_pf.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_wtju_pf.Name = "T_wtju_pf"
        Me.T_wtju_pf.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_wtju_pf.Size = New System.Drawing.Size(1258, 27)
        Me.T_wtju_pf.TabIndex = 0
        Me.T_wtju_pf.Text = "BindingNavigator1"
        '
        'T_wtjuBindingSource
        '
        Me.T_wtjuBindingSource.DataMember = "t_wtju"
        Me.T_wtjuBindingSource.DataSource = Me.JHBDataSet
        '
        'JHBDataSet
        '
        Me.JHBDataSet.DataSetName = "JHBDataSet"
        Me.JHBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AutoToolTip = True
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(106, 24)
        Me.ToolStripTextBox1.Text = "info:消息提示!"
        Me.ToolStripTextBox1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        '问题编号Label1
        '
        Me.问题编号Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.问题编号Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "问题编号", True))
        Me.问题编号Label1.Location = New System.Drawing.Point(171, 131)
        Me.问题编号Label1.Name = "问题编号Label1"
        Me.问题编号Label1.Size = New System.Drawing.Size(145, 23)
        Me.问题编号Label1.TabIndex = 2
        Me.问题编号Label1.Text = "Label1"
        '
        '设备名称Label1
        '
        Me.设备名称Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.设备名称Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "设备名称", True))
        Me.设备名称Label1.Location = New System.Drawing.Point(171, 161)
        Me.设备名称Label1.Name = "设备名称Label1"
        Me.设备名称Label1.Size = New System.Drawing.Size(357, 23)
        Me.设备名称Label1.TabIndex = 4
        Me.设备名称Label1.Text = "Label1"
        '
        '存在问题TextBox
        '
        Me.存在问题TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "存在问题", True))
        Me.存在问题TextBox.Location = New System.Drawing.Point(171, 197)
        Me.存在问题TextBox.Multiline = True
        Me.存在问题TextBox.Name = "存在问题TextBox"
        Me.存在问题TextBox.ReadOnly = True
        Me.存在问题TextBox.Size = New System.Drawing.Size(357, 79)
        Me.存在问题TextBox.TabIndex = 6
        '
        '发现问题时间Label1
        '
        Me.发现问题时间Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.发现问题时间Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "发现问题时间", True))
        Me.发现问题时间Label1.Location = New System.Drawing.Point(201, 298)
        Me.发现问题时间Label1.Name = "发现问题时间Label1"
        Me.发现问题时间Label1.Size = New System.Drawing.Size(160, 23)
        Me.发现问题时间Label1.TabIndex = 8
        Me.发现问题时间Label1.Text = "Label1"
        '
        '整治方案TextBox
        '
        Me.整治方案TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "整治方案", True))
        Me.整治方案TextBox.Location = New System.Drawing.Point(171, 405)
        Me.整治方案TextBox.Name = "整治方案TextBox"
        Me.整治方案TextBox.Size = New System.Drawing.Size(357, 25)
        Me.整治方案TextBox.TabIndex = 11
        '
        '留存CheckBox
        '
        Me.留存CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.T_wtjuBindingSource, "留存", True))
        Me.留存CheckBox.Location = New System.Drawing.Point(171, 530)
        Me.留存CheckBox.Name = "留存CheckBox"
        Me.留存CheckBox.Size = New System.Drawing.Size(54, 24)
        Me.留存CheckBox.TabIndex = 13
        Me.留存CheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(244, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 50)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "派发"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'jhDateTimePicker
        '
        Me.jhDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.jhDateTimePicker.Location = New System.Drawing.Point(171, 465)
        Me.jhDateTimePicker.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.jhDateTimePicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.jhDateTimePicker.Name = "jhDateTimePicker"
        Me.jhDateTimePicker.Size = New System.Drawing.Size(190, 25)
        Me.jhDateTimePicker.TabIndex = 15
        Me.jhDateTimePicker.Value = New Date(2016, 11, 29, 0, 0, 0, 0)
        '
        'LJDateTimePicker
        '
        Me.LJDateTimePicker.CausesValidation = False
        Me.LJDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LJDateTimePicker.Location = New System.Drawing.Point(195, 617)
        Me.LJDateTimePicker.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.LJDateTimePicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.LJDateTimePicker.Name = "LJDateTimePicker"
        Me.LJDateTimePicker.Size = New System.Drawing.Size(166, 25)
        Me.LJDateTimePicker.TabIndex = 16
        Me.LJDateTimePicker.Value = New Date(2016, 11, 22, 0, 0, 0, 0)
        '
        '计划时间TextBox
        '
        Me.计划时间TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "计划时间", True))
        Me.计划时间TextBox.Location = New System.Drawing.Point(171, 465)
        Me.计划时间TextBox.Name = "计划时间TextBox"
        Me.计划时间TextBox.Size = New System.Drawing.Size(145, 25)
        Me.计划时间TextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "信息库问题派发"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 617)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "联合检查日期"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(568, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "派发详表:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(568, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "通知单详表:"
        '
        'TextBox1
        '
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Location = New System.Drawing.Point(193, 617)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 25)
        Me.TextBox1.TabIndex = 24
        '
        'TzdContentDataGridView
        '
        Me.TzdContentDataGridView.AllowUserToAddRows = False
        Me.TzdContentDataGridView.AllowUserToDeleteRows = False
        Me.TzdContentDataGridView.AutoGenerateColumns = False
        Me.TzdContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TzdContentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.设备名称, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.整治方案, Me.DataGridViewTextBoxColumn11})
        Me.TzdContentDataGridView.DataSource = Me.TzdContentBindingSource
        Me.TzdContentDataGridView.Location = New System.Drawing.Point(572, 353)
        Me.TzdContentDataGridView.Name = "TzdContentDataGridView"
        Me.TzdContentDataGridView.ReadOnly = True
        Me.TzdContentDataGridView.RowHeadersWidth = 10
        Me.TzdContentDataGridView.RowTemplate.Height = 27
        Me.TzdContentDataGridView.Size = New System.Drawing.Size(643, 359)
        Me.TzdContentDataGridView.TabIndex = 24
        '
        'TzdContentBindingSource
        '
        Me.TzdContentBindingSource.DataMember = "tzdContent"
        Me.TzdContentBindingSource.DataSource = Me.JHBDataSet
        '
        '站名ComboBox
        '
        Me.站名ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.T_wtjuBindingSource, "站名", True))
        Me.站名ComboBox.FormattingEnabled = True
        Me.站名ComboBox.Items.AddRange(New Object() {"安康", "石庙沟"})
        Me.站名ComboBox.Location = New System.Drawing.Point(171, 93)
        Me.站名ComboBox.Name = "站名ComboBox"
        Me.站名ComboBox.Size = New System.Drawing.Size(145, 23)
        Me.站名ComboBox.TabIndex = 26
        '
        '问题等级Label1
        '
        Me.问题等级Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "问题等级", True))
        Me.问题等级Label1.Location = New System.Drawing.Point(168, 352)
        Me.问题等级Label1.Name = "问题等级Label1"
        Me.问题等级Label1.Size = New System.Drawing.Size(100, 23)
        Me.问题等级Label1.TabIndex = 28
        Me.问题等级Label1.Text = "Label5"
        '
        'T_pfjuDataGridView
        '
        Me.T_pfjuDataGridView.AllowUserToAddRows = False
        Me.T_pfjuDataGridView.AllowUserToDeleteRows = False
        Me.T_pfjuDataGridView.AutoGenerateColumns = False
        Me.T_pfjuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_pfjuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn4, Me.存在问题, Me.天窗需求, Me.DataGridViewTextBoxColumn10})
        Me.T_pfjuDataGridView.DataSource = Me.T_pfjuBindingSource1
        Me.T_pfjuDataGridView.Location = New System.Drawing.Point(572, 117)
        Me.T_pfjuDataGridView.Name = "T_pfjuDataGridView"
        Me.T_pfjuDataGridView.ReadOnly = True
        Me.T_pfjuDataGridView.RowHeadersWidth = 10
        Me.T_pfjuDataGridView.RowTemplate.Height = 27
        Me.T_pfjuDataGridView.Size = New System.Drawing.Size(643, 172)
        Me.T_pfjuDataGridView.TabIndex = 28
        '
        'T_pfjuBindingSource1
        '
        Me.T_pfjuBindingSource1.DataMember = "t_pfju"
        Me.T_pfjuBindingSource1.DataSource = Me.JHBDataSet
        '
        'T_pfjuBindingSource
        '
        Me.T_pfjuBindingSource.DataMember = "t_pfju"
        Me.T_pfjuBindingSource.DataSource = Me.JHBDataSet1
        '
        'JHBDataSet1
        '
        Me.JHBDataSet1.DataSetName = "JHBDataSet"
        Me.JHBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'T_pfjuTableAdapter
        '
        Me.T_pfjuTableAdapter.ClearBeforeFill = True
        '
        'TzdContentTableAdapter
        '
        Me.TzdContentTableAdapter.ClearBeforeFill = True
        '
        '天窗需求Label1
        '
        Me.天窗需求Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "天窗需求", True))
        Me.天窗需求Label1.Location = New System.Drawing.Point(350, 352)
        Me.天窗需求Label1.Name = "天窗需求Label1"
        Me.天窗需求Label1.Size = New System.Drawing.Size(178, 23)
        Me.天窗需求Label1.TabIndex = 30
        Me.天窗需求Label1.Text = "Label5"
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "派发日期"
        DataGridViewCellStyle2.Format = "M"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "派发日期"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "计划整治时间"
        DataGridViewCellStyle3.Format = "M"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "计划整治时间"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "站名"
        Me.DataGridViewTextBoxColumn9.HeaderText = "站名"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "设备名称"
        Me.DataGridViewTextBoxColumn4.HeaderText = "设备名称"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        '存在问题
        '
        Me.存在问题.DataPropertyName = "存在问题"
        Me.存在问题.HeaderText = "存在问题"
        Me.存在问题.Name = "存在问题"
        Me.存在问题.ReadOnly = True
        '
        '天窗需求
        '
        Me.天窗需求.DataPropertyName = "天窗需求"
        Me.天窗需求.HeaderText = "天窗需求"
        Me.天窗需求.Name = "天窗需求"
        Me.天窗需求.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "派发记录ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "派发记录ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "发放日期"
        DataGridViewCellStyle1.Format = "M"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "发放日期"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        '设备名称
        '
        Me.设备名称.DataPropertyName = "设备名称"
        Me.设备名称.HeaderText = "设备名称"
        Me.设备名称.Name = "设备名称"
        Me.设备名称.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "内容"
        Me.DataGridViewTextBoxColumn8.HeaderText = "内容"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "天窗需求"
        Me.DataGridViewTextBoxColumn6.HeaderText = "天窗需求"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "配合单位名"
        Me.DataGridViewTextBoxColumn7.HeaderText = "配合单位名"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        '整治方案
        '
        Me.整治方案.DataPropertyName = "整治方案"
        Me.整治方案.HeaderText = "整治方案"
        Me.整治方案.Name = "整治方案"
        Me.整治方案.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "周数"
        Me.DataGridViewTextBoxColumn11.HeaderText = "周数"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 759)
        Me.Controls.Add(天窗需求Label)
        Me.Controls.Add(Me.天窗需求Label1)
        Me.Controls.Add(Me.T_pfjuDataGridView)
        Me.Controls.Add(问题等级Label)
        Me.Controls.Add(Me.问题等级Label1)
        Me.Controls.Add(站名Label)
        Me.Controls.Add(Me.站名ComboBox)
        Me.Controls.Add(Me.TzdContentDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.计划时间TextBox)
        Me.Controls.Add(计划时间Label)
        Me.Controls.Add(Me.LJDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(留存Label)
        Me.Controls.Add(Me.留存CheckBox)
        Me.Controls.Add(整治方案Label)
        Me.Controls.Add(Me.整治方案TextBox)
        Me.Controls.Add(发现问题时间Label)
        Me.Controls.Add(Me.发现问题时间Label1)
        Me.Controls.Add(存在问题Label)
        Me.Controls.Add(Me.存在问题TextBox)
        Me.Controls.Add(设备名称Label)
        Me.Controls.Add(Me.设备名称Label1)
        Me.Controls.Add(问题编号Label)
        Me.Controls.Add(Me.问题编号Label1)
        Me.Controls.Add(Me.T_wtju_pf)
        Me.Controls.Add(Me.jhDateTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "派发"
        CType(Me.T_wtju_pf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_wtju_pf.ResumeLayout(False)
        Me.T_wtju_pf.PerformLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TzdContentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TzdContentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_pfjuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_pfjuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_pfjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JHBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JHBDataSet As wapJHB.JHBDataSet
    Friend WithEvents T_wtjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_WTJUTableAdapter As wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter
    Friend WithEvents TableAdapterManager As wapJHB.JHBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_wtju_pf As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents 问题编号Label1 As System.Windows.Forms.Label
    Friend WithEvents 设备名称Label1 As System.Windows.Forms.Label
    Friend WithEvents 存在问题TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 发现问题时间Label1 As System.Windows.Forms.Label
    Friend WithEvents 整治方案TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 留存CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents jhDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LJDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents 计划时间TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents T_pfjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_pfjuTableAdapter As wapJHB.JHBDataSetTableAdapters.t_pfjuTableAdapter
    Friend WithEvents TzdContentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TzdContentTableAdapter As wapJHB.JHBDataSetTableAdapters.tzdContentTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TzdContentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 站名ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 问题等级Label1 As System.Windows.Forms.Label
    Friend WithEvents JHBDataSet1 As wapJHB.JHBDataSet
    Friend WithEvents T_pfjuBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents T_pfjuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents 天窗需求Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 设备名称 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 整治方案 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 存在问题 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 天窗需求 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
