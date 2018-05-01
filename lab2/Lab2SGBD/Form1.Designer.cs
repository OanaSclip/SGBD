namespace Lab2SGBD
{
    partial class Form1
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
            this.parentDataGridView = new System.Windows.Forms.DataGridView();
            this.childDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parentDataGridView
            // 
            this.parentDataGridView.AccessibleName = "Casierie";
            this.parentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.parentDataGridView.Name = "parentDataGridView";
            this.parentDataGridView.ReadOnly = true;
            this.parentDataGridView.Size = new System.Drawing.Size(489, 292);
            this.parentDataGridView.TabIndex = 0;
            // 
            // childDataGridView
            // 
            this.childDataGridView.AccessibleName = "Casierie";
            this.childDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childDataGridView.Location = new System.Drawing.Point(622, 12);
            this.childDataGridView.Name = "childDataGridView";
            this.childDataGridView.ReadOnly = true;
            this.childDataGridView.Size = new System.Drawing.Size(259, 319);
            this.childDataGridView.TabIndex = 1;
            this.childDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childDataGridView_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(622, 351);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(775, 449);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(97, 29);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 164);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.childDataGridView);
            this.Controls.Add(this.parentDataGridView);
            this.Name = "Form1";
            this.Text = "NBA Championship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView parentDataGridView;
        private System.Windows.Forms.DataGridView childDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

