namespace WinFormsApp_Practice1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btYes_Click = new Button();
            btNo_Click = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(262, 80);
            label1.Name = "label1";
            label1.Size = new Size(281, 22);
            label1.TabIndex = 0;
            label1.Text = "Ви задоволені своєю зарплатою?";
            // 
            // btYes_Click
            // 
            btYes_Click.BackColor = Color.PaleGreen;
            btYes_Click.FlatAppearance.BorderColor = Color.Black;
            btYes_Click.FlatAppearance.MouseDownBackColor = Color.Lime;
            btYes_Click.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btYes_Click.FlatStyle = FlatStyle.Flat;
            btYes_Click.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btYes_Click.ForeColor = Color.DarkGreen;
            btYes_Click.Location = new Point(262, 134);
            btYes_Click.Name = "btYes_Click";
            btYes_Click.Size = new Size(106, 29);
            btYes_Click.TabIndex = 1;
            btYes_Click.Text = "Так!";
            btYes_Click.UseVisualStyleBackColor = false;
            btYes_Click.Click += btYes_Click_Click;
            // 
            // btNo_Click
            // 
            btNo_Click.BackColor = Color.FromArgb(255, 128, 128);
            btNo_Click.FlatAppearance.BorderColor = Color.Black;
            btNo_Click.FlatAppearance.MouseDownBackColor = Color.Red;
            btNo_Click.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btNo_Click.FlatStyle = FlatStyle.Flat;
            btNo_Click.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNo_Click.ForeColor = Color.Maroon;
            btNo_Click.Location = new Point(472, 134);
            btNo_Click.Name = "btNo_Click";
            btNo_Click.Size = new Size(106, 29);
            btNo_Click.TabIndex = 2;
            btNo_Click.Text = "Ні!";
            btNo_Click.UseVisualStyleBackColor = false;
            btNo_Click.MouseMove += btNo_Click_MouseMove;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Cascadia Code", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(14, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.MouseMove += dateTimePicker1_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(80, 223);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 4;
            label2.Text = "Виберіть дату";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 256);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 5;
            label3.Text = "Вибрана дата :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(900, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btNo_Click);
            Controls.Add(btYes_Click);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btYes_Click;
        private Button btNo_Click;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
    }
}