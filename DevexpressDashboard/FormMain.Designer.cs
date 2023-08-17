namespace DevexpressDashboard
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButtonViewer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDesigner = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialogForm = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // simpleButtonViewer
            // 
            this.simpleButtonViewer.Location = new System.Drawing.Point(121, 184);
            this.simpleButtonViewer.Name = "simpleButtonViewer";
            this.simpleButtonViewer.Size = new System.Drawing.Size(225, 107);
            this.simpleButtonViewer.TabIndex = 0;
            this.simpleButtonViewer.Text = "Viewer";
            this.simpleButtonViewer.Click += new System.EventHandler(this.simpleButtonViewer_Click);
            // 
            // simpleButtonDesigner
            // 
            this.simpleButtonDesigner.Location = new System.Drawing.Point(392, 184);
            this.simpleButtonDesigner.Name = "simpleButtonDesigner";
            this.simpleButtonDesigner.Size = new System.Drawing.Size(225, 112);
            this.simpleButtonDesigner.TabIndex = 1;
            this.simpleButtonDesigner.Text = "Designer";
            this.simpleButtonDesigner.Click += new System.EventHandler(this.simpleButtonDesigner_Click);
            // 
            // openFileDialogForm
            // 
            this.openFileDialogForm.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 457);
            this.Controls.Add(this.simpleButtonDesigner);
            this.Controls.Add(this.simpleButtonViewer);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonViewer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDesigner;
        private System.Windows.Forms.OpenFileDialog openFileDialogForm;
    }
}

