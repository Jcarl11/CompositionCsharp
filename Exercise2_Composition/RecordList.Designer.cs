namespace Exercise2_Composition {
    partial class RecordList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(0, 0);
            this.listbox.MultiColumn = true;
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(636, 480);
            this.listbox.TabIndex = 0;
            // 
            // RecordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 480);
            this.Controls.Add(this.listbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordList";
            this.ShowIcon = false;
            this.Text = "List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox;
    }
}