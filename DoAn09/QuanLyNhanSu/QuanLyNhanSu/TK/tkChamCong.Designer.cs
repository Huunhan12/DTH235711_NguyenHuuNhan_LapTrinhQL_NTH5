namespace QuanLyNhanSu.TK
{
    partial class tkChamCong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            rdNCP = new RadioButton();
            rdKN = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            rdNTT = new RadioButton();
            label1 = new Label();
            pnLoad = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rdNCP);
            panel1.Controls.Add(rdKN);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton7);
            panel1.Controls.Add(rdNTT);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 513);
            panel1.TabIndex = 0;
            // 
            // rdNCP
            // 
            rdNCP.AutoSize = true;
            rdNCP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdNCP.Location = new Point(9, 163);
            rdNCP.Name = "rdNCP";
            rdNCP.Size = new Size(259, 27);
            rdNCP.TabIndex = 30;
            rdNCP.TabStop = true;
            rdNCP.Text = "Xem nhân viên nghỉ có phép";
            rdNCP.UseVisualStyleBackColor = true;
            // 
            // rdKN
            // 
            rdKN.AutoSize = true;
            rdKN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdKN.Location = new Point(9, 249);
            rdKN.Name = "rdKN";
            rdKN.Size = new Size(265, 27);
            rdKN.TabIndex = 29;
            rdKN.TabStop = true;
            rdKN.Text = "Số ngày đi làm của nhân viên";
            rdKN.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton6.Location = new Point(9, 335);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(221, 27);
            radioButton6.TabIndex = 28;
            radioButton6.TabStop = true;
            radioButton6.Text = "Xem theo tên nhân viên";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton7.Location = new Point(9, 421);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(200, 27);
            radioButton7.TabIndex = 27;
            radioButton7.TabStop = true;
            radioButton7.Text = "Xem theo phong ban";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // rdNTT
            // 
            rdNTT.AutoSize = true;
            rdNTT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdNTT.Location = new Point(9, 77);
            rdNTT.Name = "rdNTT";
            rdNTT.Size = new Size(225, 27);
            rdNTT.TabIndex = 24;
            rdNTT.TabStop = true;
            rdNTT.Text = "Xem nhân viên nghỉ làm";
            rdNTT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH";
            // 
            // pnLoad
            // 
            pnLoad.Location = new Point(315, 12);
            pnLoad.Name = "pnLoad";
            pnLoad.Size = new Size(865, 513);
            pnLoad.TabIndex = 1;
            // 
            // tkChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnLoad);
            Controls.Add(panel1);
            Name = "tkChamCong";
            Size = new Size(1199, 542);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel pnLoad;
        private RadioButton rdNCP;
        private RadioButton rdKN;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton rdNTT;
    }
}
