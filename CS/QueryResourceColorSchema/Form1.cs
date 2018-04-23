using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraScheduler;
using System.Collections.Generic;
using DevExpress.XtraScheduler.Drawing;

namespace QueryResourceColorSchema {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            AddResources();

            // Get copies of color schemas that are curremnty used to paint resources.
            PrepareResourceColorSchemas();

            schedulerControl1.LookAndFeel.StyleChanged += new EventHandler(LookAndFeel_StyleChanged);
        }

        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            // Get copies of color schemas to be used to paint resources
            // after the active skin has been changed.
            PrepareResourceColorSchemas();
            
            schedulerControl1.ActiveView.LayoutChanged();
        }
        Dictionary<object, SchedulerColorSchema> resourceColorSchemas = 
            new Dictionary<object, SchedulerColorSchema>();
        protected SchedulerStorage Storage { get { return schedulerControl1.Storage; } }
        protected ResourceStorage Resources { get { return Storage.Resources; } }
        
        void AddResources() {
            Storage.BeginUpdate();
            for (int i = 0; i < 10; i++ ) {
                AddResource(i, "Resource_" + i.ToString());
            }
            Storage.EndUpdate();
        }

        void AddResource(int index, string caption) {
            Resource r = Storage.CreateResource(index.ToString());
            r.Caption = caption;
            Resources.Add(r);
        }

        private void PrepareResourceColorSchemas() {
            this.resourceColorSchemas.Clear();
            int count = Resources.Count;
            SchedulerColorSchemaCollection currentColorSchemas = 
                schedulerControl1.GetResourceColorSchemasCopy();
            int schemaCount = currentColorSchemas.Count;
            for (int i = 0; i < count; i++) {
                Resource resource = schedulerControl1.Storage.Resources[i];
                this.resourceColorSchemas.Add(resource.Id, currentColorSchemas[i % schemaCount]);
            }
        }
        private void schedulerControl1_QueryResourceColorSchema(object sender, 
                                                                QueryResourceColorSchemaEventArgs e) {
            object key = e.Resource.Id;
            if (this.resourceColorSchemas.ContainsKey(key))
                e.ResourceColorSchema = this.resourceColorSchemas[key];

            // Specify the custom color schema for the selected resource 
            // if there are more than one visible resources.
            if (ShouldHighlightResource(e.Resource)) {
                e.ResourceColorSchema = new SchedulerColorSchema(Color.LightCyan);
            }
        }
        protected bool ShouldHighlightResource(Resource resource) {
            if (schedulerControl1.ActiveView.GetResources().Count <= 1)
                return false;

            return schedulerControl1.SelectedResource.Equals(resource);
        }
        Resource selectedResource = Resource.Empty;
        private void schedulerControl1_SelectionChanged(object sender, EventArgs e) {
            if (!selectedResource.Equals(schedulerControl1.SelectedResource)) {
                selectedResource = schedulerControl1.SelectedResource;
                schedulerControl1.ActiveView.LayoutChanged();
            }

        }
        void UpdateSkin(string skinName) {
            schedulerControl1.LookAndFeel.SkinName = skinName;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked)
                UpdateSkin("Caramel");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton)sender).Checked)
                UpdateSkin("DevExpress Style");
        }
    }
}