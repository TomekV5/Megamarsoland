namespace MX3
{
    partial class BigMap
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
            label2 = new Label();
            label1 = new Label();
            confirm = new Button();
            rece = new Button();
            next = new Button();
            l = new TextBox();
            writeN = new Label();
            c = new TextBox();
            writeA = new Label();
            resors = new Label();
            resorstext = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 59);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // confirm
            // 
            confirm.Location = new Point(901, 231);
            confirm.Name = "confirm";
            confirm.Size = new Size(144, 68);
            confirm.TabIndex = 36;
            confirm.Text = "Confirm ";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // rece
            // 
            rece.Location = new Point(824, 157);
            rece.Name = "rece";
            rece.Size = new Size(144, 68);
            rece.TabIndex = 35;
            rece.Text = "Reset";
            rece.UseVisualStyleBackColor = true;
            rece.Click += rece_Click;
            // 
            // next
            // 
            next.Location = new Point(974, 157);
            next.Name = "next";
            next.Size = new Size(144, 68);
            next.TabIndex = 34;
            next.Text = "Show";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // l
            // 
            l.Location = new Point(974, 88);
            l.Name = "l";
            l.Size = new Size(100, 30);
            l.TabIndex = 33;
            // 
            // writeN
            // 
            writeN.AutoSize = true;
            writeN.Location = new Point(838, 91);
            writeN.Name = "writeN";
            writeN.Size = new Size(110, 22);
            writeN.TabIndex = 32;
            writeN.Text = "Write Line";
            // 
            // c
            // 
            c.Location = new Point(974, 44);
            c.Name = "c";
            c.Size = new Size(100, 30);
            c.TabIndex = 31;
            // 
            // writeA
            // 
            writeA.AutoSize = true;
            writeA.Location = new Point(838, 47);
            writeA.Name = "writeA";
            writeA.Size = new Size(130, 22);
            writeA.TabIndex = 30;
            writeA.Text = "Write Collom";
            // 
            // resors
            // 
            resors.AutoSize = true;
            resors.Location = new Point(1019, 332);
            resors.Name = "resors";
            resors.Size = new Size(0, 22);
            resors.TabIndex = 38;
            // 
            // resorstext
            // 
            resorstext.AutoSize = true;
            resorstext.Location = new Point(813, 332);
            resorstext.Name = "resorstext";
            resorstext.Size = new Size(190, 22);
            resorstext.TabIndex = 37;
            resorstext.Text = "Containing resorse";
            // 
            // BigMap
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 660);
            Controls.Add(resors);
            Controls.Add(resorstext);
            Controls.Add(confirm);
            Controls.Add(rece);
            Controls.Add(next);
            Controls.Add(l);
            Controls.Add(writeN);
            Controls.Add(c);
            Controls.Add(writeA);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "BigMap";
            Text = "BigMap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button confirm;
        private Button rece;
        private Button next;
        private TextBox l;
        private Label writeN;
        private TextBox c;
        private Label writeA;
        private Label resors;
        private Label resorstext;
    }
}