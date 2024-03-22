namespace DataGridViewControl_Filtering
{
    partial class check_in
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
            guestName = new TextBox();
            phoneNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkInDate = new DateTimePicker();
            checkOutDate = new DateTimePicker();
            label3 = new Label();
            roomNumber = new ComboBox();
            reserve = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // guestName
            // 
            guestName.Location = new Point(46, 48);
            guestName.Name = "guestName";
            guestName.Size = new Size(100, 23);
            guestName.TabIndex = 0;
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(304, 48);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(100, 23);
            phoneNumber.TabIndex = 1;
            phoneNumber.Validating += phoneNumber_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 110);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "check-in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 110);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "check-out";
            // 
            // checkInDate
            // 
            checkInDate.Location = new Point(25, 138);
            checkInDate.Name = "checkInDate";
            checkInDate.Size = new Size(200, 23);
            checkInDate.TabIndex = 4;
            // 
            // checkOutDate
            // 
            checkOutDate.Location = new Point(260, 138);
            checkOutDate.Name = "checkOutDate";
            checkOutDate.Size = new Size(200, 23);
            checkOutDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 199);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Cinema Room";
            // 
            // roomNumber
            // 
            roomNumber.FormattingEnabled = true;
            roomNumber.Location = new Point(46, 228);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(121, 23);
            roomNumber.TabIndex = 7;
            // 
            // reserve
            // 
            reserve.Location = new Point(213, 232);
            reserve.Name = "reserve";
            reserve.Size = new Size(75, 23);
            reserve.TabIndex = 8;
            reserve.Text = "reserve";
            reserve.UseVisualStyleBackColor = true;
            reserve.Click += reserve_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 26);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 26);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 10;
            label5.Text = "Phone Number";
            // 
            // check_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(reserve);
            Controls.Add(roomNumber);
            Controls.Add(label3);
            Controls.Add(checkOutDate);
            Controls.Add(checkInDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phoneNumber);
            Controls.Add(guestName);
            Name = "check_in";
            Text = "check_in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox guestName;
        private TextBox phoneNumber;
        private Label label1;
        private Label label2;
        private DateTimePicker checkInDate;
        private DateTimePicker checkOutDate;
        private Label label3;
        private ComboBox roomNumber;
        private Button reserve;
        private Label label4;
        private Label label5;
    }
}