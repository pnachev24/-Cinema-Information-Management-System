namespace DataGridViewControl_Filtering
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
            roomType = new ComboBox();
            dataGridView1 = new DataGridView();
            status = new ComboBox();
            availability = new ComboBox();
            button1 = new Button();
            clear = new Button();
            checkIn = new Button();
            usernameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            roomNo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roomType
            // 
            roomType.FormattingEnabled = true;
            roomType.Items.AddRange(new object[] { "Standard", "Premium", "VIP", "Deluxe", "Executive" });
            roomType.Location = new Point(252, 72);
            roomType.Name = "roomType";
            roomType.Size = new Size(121, 23);
            roomType.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(191, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(367, 207);
            dataGridView1.TabIndex = 1;
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Open", "Closed" });
            status.Location = new Point(618, 72);
            status.Name = "status";
            status.Size = new Size(121, 23);
            status.TabIndex = 2;
            // 
            // availability
            // 
            availability.FormattingEnabled = true;
            availability.Items.AddRange(new object[] { "Available", "Booked" });
            availability.Location = new Point(437, 72);
            availability.Name = "availability";
            availability.Size = new Size(121, 23);
            availability.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(116, 368);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clear
            // 
            clear.Location = new Point(232, 368);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 5;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // checkIn
            // 
            checkIn.Location = new Point(517, 368);
            checkIn.Name = "checkIn";
            checkIn.Size = new Size(75, 23);
            checkIn.TabIndex = 6;
            checkIn.Text = "check-in";
            checkIn.UseVisualStyleBackColor = true;
            checkIn.Click += checkIn_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(359, 18);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 15);
            usernameLabel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 49);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 49);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 9;
            label2.Text = "Availability Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 54);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 10;
            label3.Text = "Open/Closed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 49);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 12;
            label4.Text = "Cinema Hall";
            // 
            // roomNo
            // 
            roomNo.FormattingEnabled = true;
            roomNo.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111" });
            roomNo.Location = new Point(70, 72);
            roomNo.Name = "roomNo";
            roomNo.Size = new Size(121, 23);
            roomNo.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(roomNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameLabel);
            Controls.Add(checkIn);
            Controls.Add(clear);
            Controls.Add(button1);
            Controls.Add(availability);
            Controls.Add(status);
            Controls.Add(dataGridView1);
            Controls.Add(roomType);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox roomType;
        private DataGridView dataGridView1;
        private ComboBox status;
        private ComboBox availability;
        private Button button1;
        private Button clear;
        private Button checkIn;
        private Label usernameLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox roomNo;
    }
}