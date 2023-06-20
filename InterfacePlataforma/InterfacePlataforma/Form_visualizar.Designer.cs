namespace InterfacePlataforma
{
    partial class Form_visualizar
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
            this.pb_heatmap = new System.Windows.Forms.PictureBox();
            this.bt_temp = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.bt_left = new System.Windows.Forms.Button();
            this.lb_nameFile = new System.Windows.Forms.Label();
            this.pb_scale = new System.Windows.Forms.PictureBox();
            this.lb_max = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_pressureTitle = new System.Windows.Forms.Label();
            this.lb_pressureValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_heatmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_heatmap
            // 
            this.pb_heatmap.Location = new System.Drawing.Point(130, 40);
            this.pb_heatmap.Name = "pb_heatmap";
            this.pb_heatmap.Size = new System.Drawing.Size(240, 480);
            this.pb_heatmap.TabIndex = 0;
            this.pb_heatmap.TabStop = false;
            this.pb_heatmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pb_heatmap_MouseMove);
            // 
            // bt_temp
            // 
            this.bt_temp.Location = new System.Drawing.Point(210, 582);
            this.bt_temp.Name = "bt_temp";
            this.bt_temp.Size = new System.Drawing.Size(75, 23);
            this.bt_temp.TabIndex = 1;
            this.bt_temp.Text = "Get Data";
            this.bt_temp.UseVisualStyleBackColor = true;
            this.bt_temp.Click += new System.EventHandler(this.Bt_temp_Click);
            // 
            // bt_right
            // 
            this.bt_right.Location = new System.Drawing.Point(372, 543);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(75, 23);
            this.bt_right.TabIndex = 2;
            this.bt_right.Text = ">";
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.Click += new System.EventHandler(this.Bt_right_Click);
            // 
            // bt_left
            // 
            this.bt_left.Location = new System.Drawing.Point(51, 543);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(75, 23);
            this.bt_left.TabIndex = 3;
            this.bt_left.Text = "<";
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.Click += new System.EventHandler(this.Bt_left_Click);
            // 
            // lb_nameFile
            // 
            this.lb_nameFile.AutoSize = true;
            this.lb_nameFile.Location = new System.Drawing.Point(91, 14);
            this.lb_nameFile.Name = "lb_nameFile";
            this.lb_nameFile.Size = new System.Drawing.Size(35, 13);
            this.lb_nameFile.TabIndex = 4;
            this.lb_nameFile.Text = "Name";
            // 
            // pb_scale
            // 
            this.pb_scale.Location = new System.Drawing.Point(19, 39);
            this.pb_scale.Name = "pb_scale";
            this.pb_scale.Size = new System.Drawing.Size(50, 481);
            this.pb_scale.TabIndex = 5;
            this.pb_scale.TabStop = false;
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Location = new System.Drawing.Point(31, 14);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(27, 13);
            this.lb_max.TabIndex = 6;
            this.lb_max.Text = "Max";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Location = new System.Drawing.Point(31, 523);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(24, 13);
            this.lb_min.TabIndex = 7;
            this.lb_min.Text = "Min";
            // 
            // lb_pressureTitle
            // 
            this.lb_pressureTitle.AutoSize = true;
            this.lb_pressureTitle.Location = new System.Drawing.Point(166, 548);
            this.lb_pressureTitle.Name = "lb_pressureTitle";
            this.lb_pressureTitle.Size = new System.Drawing.Size(79, 13);
            this.lb_pressureTitle.TabIndex = 8;
            this.lb_pressureTitle.Text = "Pressure (kPa):";
            // 
            // lb_pressureValue
            // 
            this.lb_pressureValue.AutoSize = true;
            this.lb_pressureValue.Location = new System.Drawing.Point(251, 548);
            this.lb_pressureValue.Name = "lb_pressureValue";
            this.lb_pressureValue.Size = new System.Drawing.Size(34, 13);
            this.lb_pressureValue.TabIndex = 9;
            this.lb_pressureValue.Text = "Value";
            // 
            // Form_visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 617);
            this.Controls.Add(this.lb_pressureValue);
            this.Controls.Add(this.lb_pressureTitle);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.pb_scale);
            this.Controls.Add(this.lb_nameFile);
            this.Controls.Add(this.bt_left);
            this.Controls.Add(this.bt_right);
            this.Controls.Add(this.bt_temp);
            this.Controls.Add(this.pb_heatmap);
            this.Name = "Form_visualizar";
            this.Text = "Visualize Data";
            this.Load += new System.EventHandler(this.Form_visualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_heatmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_heatmap;
        private System.Windows.Forms.Button bt_temp;
        private System.Windows.Forms.Button bt_right;
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Label lb_nameFile;
        private System.Windows.Forms.PictureBox pb_scale;
        public System.Windows.Forms.Label lb_max;
        public System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_pressureTitle;
        private System.Windows.Forms.Label lb_pressureValue;
    }
}