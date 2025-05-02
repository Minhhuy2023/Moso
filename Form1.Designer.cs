namespace Moso
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btDel = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.lbMousePos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btDel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.Color.Red;
            this.btDel.Location = new System.Drawing.Point(174, 6);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(79, 38);
            this.btDel.TabIndex = 1;
            this.btDel.Text = "Xóa\r\nDelete";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btStart.ForeColor = System.Drawing.Color.Magenta;
            this.btStart.Location = new System.Drawing.Point(203, 234);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(135, 75);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btAdd.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.Teal;
            this.btAdd.Location = new System.Drawing.Point(259, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(79, 38);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Thêm\r\nAdd";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.BackColor = System.Drawing.SystemColors.Info;
            this.rtbStatus.ForeColor = System.Drawing.Color.Black;
            this.rtbStatus.Location = new System.Drawing.Point(5, 236);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(192, 52);
            this.rtbStatus.TabIndex = 3;
            this.rtbStatus.Text = "";
            this.rtbStatus.TextChanged += new System.EventHandler(this.rtbStatus_TextChanged);
            // 
            // lbMousePos
            // 
            this.lbMousePos.AutoSize = true;
            this.lbMousePos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMousePos.Location = new System.Drawing.Point(1, 6);
            this.lbMousePos.Name = "lbMousePos";
            this.lbMousePos.Size = new System.Drawing.Size(127, 19);
            this.lbMousePos.TabIndex = 4;
            this.lbMousePos.Text = "MousePosision";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(342, 311);
            this.Controls.Add(this.lbMousePos);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moso";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label lbMousePos;
        private System.Windows.Forms.Timer timer1;
    }
}

