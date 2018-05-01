namespace Lab1
{
    partial class PlayersDataView
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
            this.PlayerDataView = new System.Windows.Forms.DataGridView();
            this.HallDataView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.PIDHall = new System.Windows.Forms.TextBox();
            this.PointsHall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HallDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerDataView
            // 
            this.PlayerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataView.Location = new System.Drawing.Point(12, 43);
            this.PlayerDataView.Name = "PlayerDataView";
            this.PlayerDataView.Size = new System.Drawing.Size(240, 312);
            this.PlayerDataView.TabIndex = 0;
            this.PlayerDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDataView_CellContentClick);
            // 
            // HallDataView
            // 
            this.HallDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HallDataView.Location = new System.Drawing.Point(404, 123);
            this.HallDataView.Name = "HallDataView";
            this.HallDataView.Size = new System.Drawing.Size(240, 232);
            this.HallDataView.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(287, 215);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(419, 376);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 4;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(540, 376);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // PIDHall
            // 
            this.PIDHall.Location = new System.Drawing.Point(495, 6);
            this.PIDHall.Name = "PIDHall";
            this.PIDHall.Size = new System.Drawing.Size(100, 20);
            this.PIDHall.TabIndex = 10;
            // 
            // PointsHall
            // 
            this.PointsHall.Location = new System.Drawing.Point(495, 48);
            this.PointsHall.Name = "PointsHall";
            this.PointsHall.Size = new System.Drawing.Size(100, 20);
            this.PointsHall.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "id_player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "List Of Players";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hall of Fame";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PlayersDataView
            // 
            this.ClientSize = new System.Drawing.Size(682, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PointsHall);
            this.Controls.Add(this.PIDHall);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HallDataView);
            this.Controls.Add(this.PlayerDataView);
            this.Name = "PlayersDataView";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HallDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerView;
        private System.Windows.Forms.DataGridView HallOfFameView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label HallOfFame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView PlayerDataView;
        private System.Windows.Forms.DataGridView HallDataView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox PIDHall;
        private System.Windows.Forms.TextBox PointsHall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

