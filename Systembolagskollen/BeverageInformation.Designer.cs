namespace Systembolagskollen
{
    partial class BeverageInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeverageInformation));
            this.gridInformation = new System.Windows.Forms.DataGridView();
            this.bindingSourceForInformation = new System.Windows.Forms.BindingSource(this.components);
            this.btnCloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForInformation)).BeginInit();
            this.SuspendLayout();
            // gridInformation
            // 
            this.gridInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInformation.Location = new System.Drawing.Point(0, 0);
            this.gridInformation.Name = "gridInformation";
            this.gridInformation.Size = new System.Drawing.Size(1112, 455);
            this.gridInformation.TabIndex = 9;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCloseForm.Location = new System.Drawing.Point(518, 468);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 10;
            this.btnCloseForm.Text = "Stäng";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // BeverageInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 503);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.gridInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BeverageInformation";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.BeverageInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridInformation;
        private System.Windows.Forms.BindingSource bindingSourceForInformation;
        private System.Windows.Forms.Button btnCloseForm;
    }
}