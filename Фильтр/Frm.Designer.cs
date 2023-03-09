namespace Фильтр
{
    partial class Frm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb = new System.Windows.Forms.Label();
            this.TXT = new System.Windows.Forms.RichTextBox();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.TB5 = new System.Windows.Forms.TrackBar();
            this.lbTB5 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbTB2 = new System.Windows.Forms.Label();
            this.TB2 = new System.Windows.Forms.TrackBar();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbTB3 = new System.Windows.Forms.Label();
            this.TB3 = new System.Windows.Forms.TrackBar();
            this.lb4 = new System.Windows.Forms.Label();
            this.lbTB4 = new System.Windows.Forms.Label();
            this.TB4 = new System.Windows.Forms.TrackBar();
            this.btGraph = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb
            // 
            this.Lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lb.ForeColor = System.Drawing.Color.Black;
            this.Lb.Location = new System.Drawing.Point(0, 0);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(605, 482);
            this.Lb.TabIndex = 0;
            this.Lb.Click += new System.EventHandler(this.Lb_Click);
            // 
            // TXT
            // 
            this.TXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXT.Location = new System.Drawing.Point(1, 1);
            this.TXT.Name = "TXT";
            this.TXT.ReadOnly = true;
            this.TXT.Size = new System.Drawing.Size(604, 366);
            this.TXT.TabIndex = 3;
            this.TXT.Text = "";
            this.TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Checked = true;
            this.RB1.Location = new System.Drawing.Point(3, 3);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(93, 17);
            this.RB1.TabIndex = 4;
            this.RB1.TabStop = true;
            this.RB1.Text = "Сглаживание";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.Click += new System.EventHandler(this.RB_Click);
            this.RB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(3, 26);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(98, 17);
            this.RB2.TabIndex = 5;
            this.RB2.Text = "Интерполяция";
            this.RB2.UseVisualStyleBackColor = true;
            this.RB2.Click += new System.EventHandler(this.RB_Click);
            this.RB2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(3, 49);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(103, 17);
            this.RB3.TabIndex = 6;
            this.RB3.Text = "Экстраполяция";
            this.RB3.UseVisualStyleBackColor = true;
            this.RB3.Click += new System.EventHandler(this.RB_Click);
            this.RB3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // TB5
            // 
            this.TB5.BackColor = System.Drawing.SystemColors.Control;
            this.TB5.Location = new System.Drawing.Point(311, 6);
            this.TB5.Maximum = 210;
            this.TB5.Minimum = 10;
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(171, 45);
            this.TB5.TabIndex = 7;
            this.TB5.TickFrequency = 10;
            this.TB5.Value = 10;
            this.TB5.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB5.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lbTB5
            // 
            this.lbTB5.AutoSize = true;
            this.lbTB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB5.Location = new System.Drawing.Point(315, 32);
            this.lbTB5.Name = "lbTB5";
            this.lbTB5.Size = new System.Drawing.Size(157, 13);
            this.lbTB5.TabIndex = 8;
            this.lbTB5.Text = "10     50      100       150      200";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.Color.Transparent;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5.Location = new System.Drawing.Point(244, 13);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(31, 16);
            this.lb5.TabIndex = 9;
            this.lb5.Text = "Tm:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(3, 7);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(32, 16);
            this.lb2.TabIndex = 12;
            this.lb2.Text = "Kсг:";
            // 
            // lbTB2
            // 
            this.lbTB2.AutoSize = true;
            this.lbTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB2.Location = new System.Drawing.Point(65, 31);
            this.lbTB2.Name = "lbTB2";
            this.lbTB2.Size = new System.Drawing.Size(157, 12);
            this.lbTB2.TabIndex = 11;
            this.lbTB2.Text = " 0        5       10     15     20     25     30     35";
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.SystemColors.Control;
            this.TB2.Location = new System.Drawing.Point(58, 3);
            this.TB2.Maximum = 35;
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(171, 45);
            this.TB2.TabIndex = 10;
            this.TB2.TickFrequency = 5;
            this.TB2.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB2.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(2, 60);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(36, 16);
            this.lb3.TabIndex = 15;
            this.lb3.Text = "Tин:";
            // 
            // lbTB3
            // 
            this.lbTB3.AutoSize = true;
            this.lbTB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB3.Location = new System.Drawing.Point(66, 81);
            this.lbTB3.Name = "lbTB3";
            this.lbTB3.Size = new System.Drawing.Size(157, 12);
            this.lbTB3.TabIndex = 14;
            this.lbTB3.Text = " 0        5       10     15     20     25     30     35";
            // 
            // TB3
            // 
            this.TB3.BackColor = System.Drawing.SystemColors.Control;
            this.TB3.Location = new System.Drawing.Point(58, 53);
            this.TB3.Maximum = 35;
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(171, 45);
            this.TB3.TabIndex = 13;
            this.TB3.TickFrequency = 5;
            this.TB3.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB3.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.Color.Transparent;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4.Location = new System.Drawing.Point(245, 57);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(30, 16);
            this.lb4.TabIndex = 18;
            this.lb4.Text = "Kф:";
            // 
            // lbTB4
            // 
            this.lbTB4.AutoSize = true;
            this.lbTB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB4.Location = new System.Drawing.Point(318, 74);
            this.lbTB4.Name = "lbTB4";
            this.lbTB4.Size = new System.Drawing.Size(160, 12);
            this.lbTB4.TabIndex = 17;
            this.lbTB4.Text = "0   .1   .2   .3   .4  .5   .6  .7   .8  .9   1   1.1";
            // 
            // TB4
            // 
            this.TB4.BackColor = System.Drawing.SystemColors.Control;
            this.TB4.Location = new System.Drawing.Point(311, 48);
            this.TB4.Maximum = 110;
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(171, 45);
            this.TB4.TabIndex = 16;
            this.TB4.TickFrequency = 10;
            this.TB4.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB4.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // btGraph
            // 
            this.btGraph.Location = new System.Drawing.Point(5, 1);
            this.btGraph.Name = "btGraph";
            this.btGraph.Size = new System.Drawing.Size(103, 49);
            this.btGraph.TabIndex = 19;
            this.btGraph.Text = "Построить";
            this.btGraph.UseVisualStyleBackColor = true;
            this.btGraph.Click += new System.EventHandler(this.btGraph_Click);
            this.btGraph.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.Location = new System.Drawing.Point(115, 3);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(196, 17);
            this.CB.TabIndex = 20;
            this.CB.Text = "Замедленный режим построения";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RB1);
            this.panel1.Controls.Add(this.RB2);
            this.panel1.Controls.Add(this.RB3);
            this.panel1.Location = new System.Drawing.Point(2, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 73);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTB2);
            this.panel2.Controls.Add(this.TB2);
            this.panel2.Controls.Add(this.lbTB3);
            this.panel2.Controls.Add(this.TB3);
            this.panel2.Controls.Add(this.lb3);
            this.panel2.Controls.Add(this.lb4);
            this.panel2.Controls.Add(this.lb2);
            this.panel2.Controls.Add(this.lbTB5);
            this.panel2.Controls.Add(this.lbTB4);
            this.panel2.Controls.Add(this.TB5);
            this.panel2.Controls.Add(this.lb5);
            this.panel2.Controls.Add(this.TB4);
            this.panel2.Location = new System.Drawing.Point(112, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 101);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.CB);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btGraph);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 127);
            this.panel3.TabIndex = 23;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TXT);
            this.Controls.Add(this.Lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(621, 519);
            this.MinimumSize = new System.Drawing.Size(621, 165);
            this.Name = "Frm";
            this.Text = "Фильтр";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb;
        private System.Windows.Forms.RichTextBox TXT;
        private System.Windows.Forms.Label lbTB5;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbTB2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbTB3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lbTB4;
        public System.Windows.Forms.RadioButton RB1;
        public System.Windows.Forms.RadioButton RB2;
        public System.Windows.Forms.RadioButton RB3;
        public System.Windows.Forms.TrackBar TB5;
        public System.Windows.Forms.TrackBar TB2;
        public System.Windows.Forms.TrackBar TB3;
        public System.Windows.Forms.TrackBar TB4;
        private System.Windows.Forms.Button btGraph;
        public System.Windows.Forms.CheckBox CB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

