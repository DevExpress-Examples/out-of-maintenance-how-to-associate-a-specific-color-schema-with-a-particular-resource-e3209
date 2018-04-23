Namespace QueryResourceColorSchema
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbCaramel = New System.Windows.Forms.RadioButton()
            Me.rbDXStyle = New System.Windows.Forms.RadioButton()
            Me.resourcesCheckedListBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl()
            Me.resourcesComboBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesComboBoxControl()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            DirectCast(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(200, 0)
            Me.schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsView.ResourceHeaders.RotateCaption = False
            Me.schedulerControl1.Size = New System.Drawing.Size(557, 361)
            Me.schedulerControl1.Start = New Date(2011, 5, 6, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl1.Views.TimelineView.ResourcesPerPage = 4
            Me.schedulerControl1.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.resourcesCheckedListBoxControl1)
            Me.panel1.Controls.Add(Me.resourcesComboBoxControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(200, 361)
            Me.panel1.TabIndex = 1
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.rbCaramel)
            Me.groupBox1.Controls.Add(Me.rbDXStyle)
            Me.groupBox1.Location = New System.Drawing.Point(12, 10)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(169, 66)
            Me.groupBox1.TabIndex = 3
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Skin name"
            ' 
            ' rbCaramel
            ' 
            Me.rbCaramel.AutoSize = True
            Me.rbCaramel.Location = New System.Drawing.Point(16, 42)
            Me.rbCaramel.Name = "rbCaramel"
            Me.rbCaramel.Size = New System.Drawing.Size(63, 17)
            Me.rbCaramel.TabIndex = 1
            Me.rbCaramel.Text = "Office 2010 Blue"
            Me.rbCaramel.UseVisualStyleBackColor = True
            ' 
            ' rbDXStyle
            ' 
            Me.rbDXStyle.AutoSize = True
            Me.rbDXStyle.Checked = True
            Me.rbDXStyle.Location = New System.Drawing.Point(16, 19)
            Me.rbDXStyle.Name = "rbDXStyle"
            Me.rbDXStyle.Size = New System.Drawing.Size(108, 17)
            Me.rbDXStyle.TabIndex = 0
            Me.rbDXStyle.TabStop = True
            Me.rbDXStyle.Text = "DevExpress Style"
            Me.rbDXStyle.UseVisualStyleBackColor = True
            ' 
            ' resourcesCheckedListBoxControl1
            ' 
            Me.resourcesCheckedListBoxControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.resourcesCheckedListBoxControl1.Location = New System.Drawing.Point(12, 108)
            Me.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1"
            Me.resourcesCheckedListBoxControl1.SchedulerControl = Me.schedulerControl1
            Me.resourcesCheckedListBoxControl1.Size = New System.Drawing.Size(169, 241)
            Me.resourcesCheckedListBoxControl1.TabIndex = 0
            ' 
            ' resourcesComboBoxControl1
            ' 
            Me.resourcesComboBoxControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.resourcesComboBoxControl1.Location = New System.Drawing.Point(12, 82)
            Me.resourcesComboBoxControl1.Name = "resourcesComboBoxControl1"
            Me.resourcesComboBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.resourcesComboBoxControl1.SchedulerControl = Me.schedulerControl1
            Me.resourcesComboBoxControl1.Size = New System.Drawing.Size(169, 20)
            Me.resourcesComboBoxControl1.TabIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(757, 361)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "QueryResourceColorSchema"
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            DirectCast(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private panel1 As System.Windows.Forms.Panel
        Private resourcesComboBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesComboBoxControl
        Private resourcesCheckedListBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents rbCaramel As System.Windows.Forms.RadioButton
        Private WithEvents rbDXStyle As System.Windows.Forms.RadioButton
    End Class
End Namespace

