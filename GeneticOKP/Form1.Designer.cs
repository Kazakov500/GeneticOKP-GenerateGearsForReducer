namespace GeneticOKP
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.btn_ShowPool = new System.Windows.Forms.Button();
            this.btn_Show_good = new System.Windows.Forms.Button();
            this.tb_i_n = new System.Windows.Forms.TextBox();
            this.tb_iter_count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Step = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Start.Location = new System.Drawing.Point(114, 303);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 64);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Z1";
            // 
            // rtb_Log
            // 
            this.rtb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.Location = new System.Drawing.Point(1, 0);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(270, 297);
            this.rtb_Log.TabIndex = 2;
            this.rtb_Log.Text = "";
            // 
            // btn_ShowPool
            // 
            this.btn_ShowPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowPool.Location = new System.Drawing.Point(196, 303);
            this.btn_ShowPool.Name = "btn_ShowPool";
            this.btn_ShowPool.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowPool.TabIndex = 21;
            this.btn_ShowPool.Text = "Show pool";
            this.btn_ShowPool.UseVisualStyleBackColor = true;
            this.btn_ShowPool.Click += new System.EventHandler(this.btn_ShowPool_Click);
            // 
            // btn_Show_good
            // 
            this.btn_Show_good.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Show_good.Location = new System.Drawing.Point(196, 344);
            this.btn_Show_good.Name = "btn_Show_good";
            this.btn_Show_good.Size = new System.Drawing.Size(75, 23);
            this.btn_Show_good.TabIndex = 22;
            this.btn_Show_good.Text = "Show_Good";
            this.btn_Show_good.UseVisualStyleBackColor = true;
            this.btn_Show_good.Click += new System.EventHandler(this.btn_Show_good_Click);
            // 
            // tb_i_n
            // 
            this.tb_i_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_i_n.Location = new System.Drawing.Point(43, 303);
            this.tb_i_n.Name = "tb_i_n";
            this.tb_i_n.Size = new System.Drawing.Size(65, 20);
            this.tb_i_n.TabIndex = 23;
            this.tb_i_n.Text = "400";
            // 
            // tb_iter_count
            // 
            this.tb_iter_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_iter_count.Location = new System.Drawing.Point(43, 325);
            this.tb_iter_count.Name = "tb_iter_count";
            this.tb_iter_count.Size = new System.Drawing.Size(65, 20);
            this.tb_iter_count.TabIndex = 24;
            this.tb_iter_count.Text = "10000";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "i";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "iter";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "step";
            // 
            // tb_Step
            // 
            this.tb_Step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Step.Location = new System.Drawing.Point(43, 347);
            this.tb_Step.Name = "tb_Step";
            this.tb_Step.Size = new System.Drawing.Size(65, 20);
            this.tb_Step.TabIndex = 27;
            this.tb_Step.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 373);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_Step);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_iter_count);
            this.Controls.Add(this.tb_i_n);
            this.Controls.Add(this.btn_Show_good);
            this.Controls.Add(this.btn_ShowPool);
            this.Controls.Add(this.rtb_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Genetic Gears";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Button btn_ShowPool;
        private System.Windows.Forms.Button btn_Show_good;
        private System.Windows.Forms.TextBox tb_i_n;
        private System.Windows.Forms.TextBox tb_iter_count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Step;
    }
}

