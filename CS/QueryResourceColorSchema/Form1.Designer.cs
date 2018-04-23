namespace QueryResourceColorSchema {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCaramel = new System.Windows.Forms.RadioButton();
            this.rbDXStyle = new System.Windows.Forms.RadioButton();
            this.resourcesCheckedListBoxControl1 = new DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl();
            this.resourcesComboBoxControl1 = new DevExpress.XtraScheduler.UI.ResourcesComboBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesComboBoxControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.Location = new System.Drawing.Point(200, 0);
            this.schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsView.ResourceHeaders.RotateCaption = false;
            this.schedulerControl1.Size = new System.Drawing.Size(557, 361);
            this.schedulerControl1.Start = new System.DateTime(2011, 5, 6, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.MonthView.ResourcesPerPage = 2;
            this.schedulerControl1.Views.TimelineView.ResourcesPerPage = 4;
            this.schedulerControl1.Views.WeekView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.QueryResourceColorSchema += new DevExpress.XtraScheduler.QueryResourceColorSchemaEventHandler(this.schedulerControl1_QueryResourceColorSchema);
            this.schedulerControl1.SelectionChanged += new System.EventHandler(this.schedulerControl1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.resourcesCheckedListBoxControl1);
            this.panel1.Controls.Add(this.resourcesComboBoxControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 361);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCaramel);
            this.groupBox1.Controls.Add(this.rbDXStyle);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skin name";
            // 
            // rbCaramel
            // 
            this.rbCaramel.AutoSize = true;
            this.rbCaramel.Location = new System.Drawing.Point(16, 42);
            this.rbCaramel.Name = "rbCaramel";
            this.rbCaramel.Size = new System.Drawing.Size(63, 17);
            this.rbCaramel.TabIndex = 1;
            this.rbCaramel.Text = "Office 2010 Blue";
            this.rbCaramel.UseVisualStyleBackColor = true;
            this.rbCaramel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbDXStyle
            // 
            this.rbDXStyle.AutoSize = true;
            this.rbDXStyle.Checked = true;
            this.rbDXStyle.Location = new System.Drawing.Point(16, 19);
            this.rbDXStyle.Name = "rbDXStyle";
            this.rbDXStyle.Size = new System.Drawing.Size(108, 17);
            this.rbDXStyle.TabIndex = 0;
            this.rbDXStyle.TabStop = true;
            this.rbDXStyle.Text = "DevExpress Style";
            this.rbDXStyle.UseVisualStyleBackColor = true;
            this.rbDXStyle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // resourcesCheckedListBoxControl1
            // 
            this.resourcesCheckedListBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resourcesCheckedListBoxControl1.Location = new System.Drawing.Point(12, 108);
            this.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1";
            this.resourcesCheckedListBoxControl1.SchedulerControl = this.schedulerControl1;
            this.resourcesCheckedListBoxControl1.Size = new System.Drawing.Size(169, 241);
            this.resourcesCheckedListBoxControl1.TabIndex = 0;
            // 
            // resourcesComboBoxControl1
            // 
            this.resourcesComboBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resourcesComboBoxControl1.Location = new System.Drawing.Point(12, 82);
            this.resourcesComboBoxControl1.Name = "resourcesComboBoxControl1";
            this.resourcesComboBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resourcesComboBoxControl1.SchedulerControl = this.schedulerControl1;
            this.resourcesComboBoxControl1.Size = new System.Drawing.Size(169, 20);
            this.resourcesComboBoxControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 361);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "QueryResourceColorSchema";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesCheckedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesComboBoxControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraScheduler.UI.ResourcesComboBoxControl resourcesComboBoxControl1;
        private DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl resourcesCheckedListBoxControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCaramel;
        private System.Windows.Forms.RadioButton rbDXStyle;
    }
}

