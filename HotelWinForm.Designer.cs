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
            this.lblText = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblEGN = new System.Windows.Forms.Label();
            this.txtBoxEGN = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnBookedOn = new System.Windows.Forms.Button();
            this.btnExpiredOn = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnSaveRes = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioBtnOneRes = new System.Windows.Forms.RadioButton();
            this.radioBtnGroupRes = new System.Windows.Forms.RadioButton();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.numUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.btnSelectMenus = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.SystemColors.Control;
            this.lblText.Location = new System.Drawing.Point(111, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(435, 617);
            this.lblText.TabIndex = 23;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMiddleName.Location = new System.Drawing.Point(139, 69);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(365, 23);
            this.lblMiddleName.TabIndex = 26;
            this.lblMiddleName.Text = "Презиме на клиента";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(139, 95);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(365, 23);
            this.txtBoxMiddleName.TabIndex = 27;
            this.txtBoxMiddleName.TextChanged += new System.EventHandler(this.txtBoxMiddleName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(139, 121);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(365, 23);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Фамилия на клиента";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(139, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(365, 23);
            this.lblFirstName.TabIndex = 29;
            this.lblFirstName.Text = "Първо име на клиента";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(139, 147);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(365, 23);
            this.txtBoxLastName.TabIndex = 30;
            this.txtBoxLastName.TextChanged += new System.EventHandler(this.txtBoxLastName_TextChanged);
            // 
            // lblEGN
            // 
            this.lblEGN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEGN.Location = new System.Drawing.Point(139, 173);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(365, 23);
            this.lblEGN.TabIndex = 31;
            this.lblEGN.Text = "ЕГН на клиента";
            this.lblEGN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxEGN
            // 
            this.txtBoxEGN.Location = new System.Drawing.Point(139, 200);
            this.txtBoxEGN.Name = "txtBoxEGN";
            this.txtBoxEGN.Size = new System.Drawing.Size(365, 23);
            this.txtBoxEGN.TabIndex = 32;
            this.txtBoxEGN.TextChanged += new System.EventHandler(this.txtBoxEGN_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(139, 226);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(365, 23);
            this.lblPhoneNumber.TabIndex = 33;
            this.lblPhoneNumber.Text = "Телефонен номер на клиента";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(139, 252);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(365, 23);
            this.txtBoxPhoneNumber.TabIndex = 34;
            this.txtBoxPhoneNumber.TextChanged += new System.EventHandler(this.txtBoxPhoneNumber_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(139, 278);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(365, 23);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Имейл адрес";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(139, 304);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(365, 23);
            this.txtBoxEmail.TabIndex = 36;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(137, 330);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(170, 23);
            this.lblAge.TabIndex = 38;
            this.lblAge.Text = "Възраст на клиента";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBookedOn
            // 
            this.btnBookedOn.BackColor = System.Drawing.SystemColors.Control;
            this.btnBookedOn.Location = new System.Drawing.Point(139, 443);
            this.btnBookedOn.Name = "btnBookedOn";
            this.btnBookedOn.Size = new System.Drawing.Size(170, 23);
            this.btnBookedOn.TabIndex = 40;
            this.btnBookedOn.Text = "Пристигане";
            this.btnBookedOn.UseVisualStyleBackColor = false;
            this.btnBookedOn.Click += new System.EventHandler(this.btnBookedOn_Click);
            // 
            // btnExpiredOn
            // 
            this.btnExpiredOn.Location = new System.Drawing.Point(329, 443);
            this.btnExpiredOn.Name = "btnExpiredOn";
            this.btnExpiredOn.Size = new System.Drawing.Size(175, 23);
            this.btnExpiredOn.TabIndex = 41;
            this.btnExpiredOn.Text = "Заминаване";
            this.btnExpiredOn.UseVisualStyleBackColor = true;
            this.btnExpiredOn.Click += new System.EventHandler(this.btnExpiredOn_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(137, 489);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(106, 29);
            this.lblTotalPrice.TabIndex = 43;
            this.lblTotalPrice.Text = "Обща Цена:";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveRes
            // 
            this.btnSaveRes.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveRes.Location = new System.Drawing.Point(405, 570);
            this.btnSaveRes.Name = "btnSaveRes";
            this.btnSaveRes.Size = new System.Drawing.Size(127, 43);
            this.btnSaveRes.TabIndex = 47;
            this.btnSaveRes.Text = "Завършване на регистрацията";
            this.btnSaveRes.UseVisualStyleBackColor = false;
            this.btnSaveRes.Click += new System.EventHandler(this.btnSaveRes_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(128, 571);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 42);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(261, 570);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 43);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "Следващ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radioBtnOneRes
            // 
            this.radioBtnOneRes.AutoSize = true;
            this.radioBtnOneRes.Checked = true;
            this.radioBtnOneRes.Location = new System.Drawing.Point(137, 521);
            this.radioBtnOneRes.Name = "radioBtnOneRes";
            this.radioBtnOneRes.Size = new System.Drawing.Size(150, 19);
            this.radioBtnOneRes.TabIndex = 50;
            this.radioBtnOneRes.TabStop = true;
            this.radioBtnOneRes.Text = "Единична регистрация";
            this.radioBtnOneRes.UseVisualStyleBackColor = true;
            this.radioBtnOneRes.CheckedChanged += new System.EventHandler(this.radioBtnOneRes_CheckedChanged_1);
            // 
            // radioBtnGroupRes
            // 
            this.radioBtnGroupRes.AutoSize = true;
            this.radioBtnGroupRes.Location = new System.Drawing.Point(137, 546);
            this.radioBtnGroupRes.Name = "radioBtnGroupRes";
            this.radioBtnGroupRes.Size = new System.Drawing.Size(142, 19);
            this.radioBtnGroupRes.TabIndex = 51;
            this.radioBtnGroupRes.Text = "Групова регистрация";
            this.radioBtnGroupRes.UseVisualStyleBackColor = true;
            this.radioBtnGroupRes.CheckedChanged += new System.EventHandler(this.radioBtnGroupRes_CheckedChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.Location = new System.Drawing.Point(137, 466);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(365, 23);
            this.lblDuration.TabIndex = 52;
            this.lblDuration.Text = "Продължителност на престоя: ";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Location = new System.Drawing.Point(137, 367);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(155, 44);
            this.btnSelectRoom.TabIndex = 53;
            this.btnSelectRoom.Text = "Избери стая";
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            // 
            // lblDateStart
            // 
            this.lblDateStart.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateStart.Enabled = false;
            this.lblDateStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDateStart.Location = new System.Drawing.Point(138, 414);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(171, 26);
            this.lblDateStart.TabIndex = 54;
            this.lblDateStart.Text = "Дата 1";
            this.lblDateStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateStart.Visible = false;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.Enabled = false;
            this.lblDateEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDateEnd.Location = new System.Drawing.Point(329, 411);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(173, 26);
            this.lblDateEnd.TabIndex = 55;
            this.lblDateEnd.Text = "Дата 2";
            this.lblDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateEnd.Visible = false;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(138, 46);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(365, 23);
            this.txtBoxFirstName.TabIndex = 56;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.txtBoxFirstName_TextChanged);
            // 
            // numUpDownAge
            // 
            this.numUpDownAge.Location = new System.Drawing.Point(313, 334);
            this.numUpDownAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDownAge.Name = "numUpDownAge";
            this.numUpDownAge.Size = new System.Drawing.Size(54, 23);
            this.numUpDownAge.TabIndex = 57;
            this.numUpDownAge.ValueChanged += new System.EventHandler(this.numUpDownAge_ValueChanged);
            // 
            // btnSelectMenus
            // 
            this.btnSelectMenus.Location = new System.Drawing.Point(329, 367);
            this.btnSelectMenus.Name = "btnSelectMenus";
            this.btnSelectMenus.Size = new System.Drawing.Size(155, 44);
            this.btnSelectMenus.TabIndex = 58;
            this.btnSelectMenus.Text = "Избери специална оферта";
            this.btnSelectMenus.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Enabled = false;
            this.monthCalendar.Location = new System.Drawing.Point(541, 334);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 59;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // HotelWinForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnSelectMenus);
            this.Controls.Add(this.numUpDownAge);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.radioBtnGroupRes);
            this.Controls.Add(this.radioBtnOneRes);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveRes);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnExpiredOn);
            this.Controls.Add(this.btnBookedOn);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtBoxEGN);
            this.Controls.Add(this.lblEGN);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblText);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "HotelWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "HotelArteApp";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblText;
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