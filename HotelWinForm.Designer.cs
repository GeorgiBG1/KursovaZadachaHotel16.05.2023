namespace KursovaHotel
{
    partial class HotelWinForm
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
            lblMiddleName = new Label();
            txtBoxMiddleName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtBoxLastName = new TextBox();
            lblEGN = new Label();
            txtBoxEGN = new TextBox();
            lblPhoneNumber = new Label();
            txtBoxPhoneNumber = new TextBox();
            lblEmail = new Label();
            txtBoxEmail = new TextBox();
            lblAge = new Label();
            btnBookedOn = new Button();
            btnExpiredOn = new Button();
            lblTotalPrice = new Label();
            btnSaveRes = new Button();
            btnBack = new Button();
            btnNext = new Button();
            radioBtnOneRes = new RadioButton();
            radioBtnGroupRes = new RadioButton();
            lblDuration = new Label();
            btnSelectRoom = new Button();
            lblDateStart = new Label();
            lblDateEnd = new Label();
            txtBoxFirstName = new TextBox();
            numUpDownAge = new NumericUpDown();
            btnSelectMenus = new Button();
            monthCalendar = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // lblMiddleName
            // 
            lblMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(139, 69);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(365, 23);
            lblMiddleName.TabIndex = 26;
            lblMiddleName.Text = "Презиме на клиента";
            lblMiddleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxMiddleName
            // 
            txtBoxMiddleName.Location = new Point(139, 95);
            txtBoxMiddleName.Name = "txtBoxMiddleName";
            txtBoxMiddleName.Size = new Size(365, 23);
            txtBoxMiddleName.TabIndex = 27;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(139, 121);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(365, 23);
            lblLastName.TabIndex = 28;
            lblLastName.Text = "Фамилия на клиента";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(139, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(365, 23);
            lblFirstName.TabIndex = 29;
            lblFirstName.Text = "Първо име на клиента";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(139, 147);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(365, 23);
            txtBoxLastName.TabIndex = 30;
            // 
            // lblEGN
            // 
            lblEGN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEGN.Location = new Point(139, 173);
            lblEGN.Name = "lblEGN";
            lblEGN.Size = new Size(365, 23);
            lblEGN.TabIndex = 31;
            lblEGN.Text = "ЕГН на клиента";
            lblEGN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxEGN
            // 
            txtBoxEGN.Location = new Point(139, 200);
            txtBoxEGN.Name = "txtBoxEGN";
            txtBoxEGN.Size = new Size(365, 23);
            txtBoxEGN.TabIndex = 32;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(139, 226);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(365, 23);
            lblPhoneNumber.TabIndex = 33;
            lblPhoneNumber.Text = "Телефонен номер на клиента";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(139, 252);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(365, 23);
            txtBoxPhoneNumber.TabIndex = 34;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(139, 278);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(365, 23);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Имейл адрес";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(139, 304);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(365, 23);
            txtBoxEmail.TabIndex = 36;
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(137, 330);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(170, 23);
            lblAge.TabIndex = 38;
            lblAge.Text = "Възраст на клиента";
            lblAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBookedOn
            // 
            btnBookedOn.BackColor = SystemColors.Control;
            btnBookedOn.Enabled = false;
            btnBookedOn.Location = new Point(139, 443);
            btnBookedOn.Name = "btnBookedOn";
            btnBookedOn.Size = new Size(170, 23);
            btnBookedOn.TabIndex = 40;
            btnBookedOn.Text = "Дата на пристигане";
            btnBookedOn.UseVisualStyleBackColor = false;
            btnBookedOn.Click += btnBookedOn_Click;
            // 
            // btnExpiredOn
            // 
            btnExpiredOn.Location = new Point(329, 443);
            btnExpiredOn.Name = "btnExpiredOn";
            btnExpiredOn.Size = new Size(175, 23);
            btnExpiredOn.TabIndex = 41;
            btnExpiredOn.Text = "Дата на заминаване";
            btnExpiredOn.UseVisualStyleBackColor = true;
            btnExpiredOn.Click += btnExpiredOn_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(137, 489);
            lblTotalPrice.Margin = new Padding(2, 0, 2, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(106, 29);
            lblTotalPrice.TabIndex = 43;
            lblTotalPrice.Text = "Обща Цена:";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSaveRes
            // 
            btnSaveRes.BackColor = SystemColors.Control;
            btnSaveRes.Location = new Point(405, 570);
            btnSaveRes.Name = "btnSaveRes";
            btnSaveRes.Size = new Size(127, 43);
            btnSaveRes.TabIndex = 47;
            btnSaveRes.Text = "Завършване на регистрацията";
            btnSaveRes.UseVisualStyleBackColor = false;
            btnSaveRes.Click += btnSaveRes_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Enabled = false;
            btnBack.Location = new Point(128, 571);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 42);
            btnBack.TabIndex = 48;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.Control;
            btnNext.Enabled = false;
            btnNext.Location = new Point(261, 570);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 43);
            btnNext.TabIndex = 49;
            btnNext.Text = "Следващ";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // radioBtnOneRes
            // 
            radioBtnOneRes.AutoSize = true;
            radioBtnOneRes.Checked = true;
            radioBtnOneRes.Location = new Point(137, 521);
            radioBtnOneRes.Name = "radioBtnOneRes";
            radioBtnOneRes.Size = new Size(150, 19);
            radioBtnOneRes.TabIndex = 50;
            radioBtnOneRes.TabStop = true;
            radioBtnOneRes.Text = "Единична регистрация";
            radioBtnOneRes.UseVisualStyleBackColor = true;
            radioBtnOneRes.CheckedChanged += radioBtnOneRes_CheckedChanged_1;
            // 
            // radioBtnGroupRes
            // 
            radioBtnGroupRes.AutoSize = true;
            radioBtnGroupRes.Location = new Point(137, 546);
            radioBtnGroupRes.Name = "radioBtnGroupRes";
            radioBtnGroupRes.Size = new Size(142, 19);
            radioBtnGroupRes.TabIndex = 51;
            radioBtnGroupRes.Text = "Групова регистрация";
            radioBtnGroupRes.UseVisualStyleBackColor = true;
            radioBtnGroupRes.CheckedChanged += radioBtnGroupRes_CheckedChanged;
            // 
            // lblDuration
            // 
            lblDuration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuration.Location = new Point(137, 466);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(365, 23);
            lblDuration.TabIndex = 52;
            lblDuration.Text = "Продължителност на престоя: ";
            lblDuration.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.Location = new Point(137, 367);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(155, 44);
            btnSelectRoom.TabIndex = 53;
            btnSelectRoom.Text = "Избери стая";
            btnSelectRoom.UseVisualStyleBackColor = true;
            // 
            // lblDateStart
            // 
            lblDateStart.BackColor = SystemColors.Control;
            lblDateStart.Enabled = false;
            lblDateStart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDateStart.Location = new Point(138, 414);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(171, 26);
            lblDateStart.TabIndex = 54;
            lblDateStart.Text = "Дата 1";
            lblDateStart.TextAlign = ContentAlignment.MiddleLeft;
            lblDateStart.Visible = false;
            // 
            // lblDateEnd
            // 
            lblDateEnd.Enabled = false;
            lblDateEnd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDateEnd.Location = new Point(329, 411);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(173, 26);
            lblDateEnd.TabIndex = 55;
            lblDateEnd.Text = "Дата 2";
            lblDateEnd.TextAlign = ContentAlignment.MiddleLeft;
            lblDateEnd.Visible = false;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(138, 46);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(365, 23);
            txtBoxFirstName.TabIndex = 56;
            // 
            // numUpDownAge
            // 
            numUpDownAge.Location = new Point(313, 334);
            numUpDownAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numUpDownAge.Name = "numUpDownAge";
            numUpDownAge.Size = new Size(54, 23);
            numUpDownAge.TabIndex = 57;
            // 
            // btnSelectMenus
            // 
            btnSelectMenus.Location = new Point(329, 367);
            btnSelectMenus.Name = "btnSelectMenus";
            btnSelectMenus.Size = new Size(155, 44);
            btnSelectMenus.TabIndex = 58;
            btnSelectMenus.Text = "Избери специална оферта";
            btnSelectMenus.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            monthCalendar.Enabled = false;
            monthCalendar.Location = new Point(541, 334);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 59;
            monthCalendar.Visible = false;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // HotelWinForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1264, 681);
            Controls.Add(monthCalendar);
            Controls.Add(btnSelectMenus);
            Controls.Add(numUpDownAge);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblDateEnd);
            Controls.Add(lblDateStart);
            Controls.Add(btnSelectRoom);
            Controls.Add(lblDuration);
            Controls.Add(radioBtnGroupRes);
            Controls.Add(radioBtnOneRes);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnSaveRes);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnExpiredOn);
            Controls.Add(btnBookedOn);
            Controls.Add(lblAge);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtBoxEGN);
            Controls.Add(lblEGN);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxMiddleName);
            Controls.Add(lblMiddleName);
            ImeMode = ImeMode.Off;
            Name = "HotelWinForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "HotelArteApp";
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMiddleName;
        private TextBox txtBoxMiddleName;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtBoxLastName;
        private Label lblEGN;
        private TextBox txtBoxEGN;
        private Label lblPhoneNumber;
        private TextBox txtBoxPhoneNumber;
        private Label lblEmail;
        private TextBox txtBoxEmail;
        private Label lblAge;
        private Button btnBookedOn;
        private Button btnExpiredOn;
        private Label lblTotalPrice;
        private Button btnSaveRes;
        private Button btnBack;
        private Button btnNext;
        private RadioButton radioBtnOneRes;
        private RadioButton radioBtnGroupRes;
        private Label lblDuration;
        private Button btnSelectRoom;
        private Label lblDateStart;
        private Label lblDateEnd;
        private TextBox txtBoxFirstName;
        private NumericUpDown numUpDownAge;
        private Button btnSelectMenus;
        private MonthCalendar monthCalendar;
    }
}