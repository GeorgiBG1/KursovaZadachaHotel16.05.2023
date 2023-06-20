namespace KursovaHotel2
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            btnDelAll = new Button();
            monthCalendar = new MonthCalendar();
            numUpDownAge = new NumericUpDown();
            txtBoxFirstName = new TextBox();
            lblDateEnd = new Label();
            lblDateStart = new Label();
            lblDuration = new Label();
            radioBtnGroupRes = new RadioButton();
            radioBtnOneRes = new RadioButton();
            btnNext = new Button();
            btnBack = new Button();
            btnSaveRes = new Button();
            btnExpiredOn = new Button();
            lblAge = new Label();
            txtBoxEmail = new TextBox();
            lblEmail = new Label();
            txtBoxPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtBoxEGN = new TextBox();
            lblEGN = new Label();
            txtBoxLastName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtBoxMiddleName = new TextBox();
            lblMiddleName = new Label();
            tableRooms = new TableLayoutPanel();
            btnRoom35 = new Button();
            btnRoom34 = new Button();
            btnRoom33 = new Button();
            btnRoom32 = new Button();
            btnRoom31 = new Button();
            btnRoom25 = new Button();
            btnRoom24 = new Button();
            btnRoom23 = new Button();
            btnRoom22 = new Button();
            btnRoom21 = new Button();
            btnRoom20 = new Button();
            btnRoom14 = new Button();
            btnRoom13 = new Button();
            btnRoom12 = new Button();
            lblFloor3 = new Label();
            btnRoom11 = new Button();
            lblFloor1 = new Label();
            lblFloor2 = new Label();
            btnRoom30 = new Button();
            btnRoom15 = new Button();
            btnRoom10 = new Button();
            tabControlMenu = new TabControl();
            tabPageWithMenus = new TabPage();
            lblCompletedMenu1 = new Label();
            checkedListBoxMenu = new CheckedListBox();
            lblMenuOnOffPage1 = new Label();
            lblDinner = new Label();
            lblLunch = new Label();
            lblBreakfast = new Label();
            btnPreviousDay = new Button();
            lblSelectedMenu = new Label();
            btnNextDay = new Button();
            lblMenuDate = new Label();
            tabPageBuffet = new TabPage();
            lblCompletedMenu2 = new Label();
            lblBuffetInfo = new Label();
            lblMenuOnOffPage2 = new Label();
            tabPageALLIn = new TabPage();
            lblCompletedMenu3 = new Label();
            lblAllInclusiveInfo = new Label();
            lblMenuOnOffPage3 = new Label();
            tabPageVipMenu = new TabPage();
            lblCompletedMenu4 = new Label();
            lblVipMenuInfo = new Label();
            lblMenuOnOffPage4 = new Label();
            btnBookedOn = new Button();
            lblCheckResData = new Label();
            btnCheckResData = new Button();
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).BeginInit();
            tableRooms.SuspendLayout();
            tabControlMenu.SuspendLayout();
            tabPageWithMenus.SuspendLayout();
            tabPageBuffet.SuspendLayout();
            tabPageALLIn.SuspendLayout();
            tabPageVipMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelAll
            // 
            btnDelAll.BackColor = Color.Red;
            btnDelAll.Cursor = Cursors.Hand;
            btnDelAll.Enabled = false;
            btnDelAll.FlatAppearance.BorderSize = 0;
            btnDelAll.FlatStyle = FlatStyle.Flat;
            btnDelAll.Location = new Point(303, 565);
            btnDelAll.Name = "btnDelAll";
            btnDelAll.Size = new Size(103, 35);
            btnDelAll.TabIndex = 92;
            btnDelAll.Text = "Зачисти БД";
            btnDelAll.UseVisualStyleBackColor = false;
            btnDelAll.Visible = false;
            btnDelAll.Click += btnDelAll_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.Enabled = false;
            monthCalendar.ForeColor = Color.OrangeRed;
            monthCalendar.Location = new Point(191, 334);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 91;
            monthCalendar.TrailingForeColor = Color.SkyBlue;
            monthCalendar.Visible = false;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            monthCalendar.DateSelected += monthCalendar_DateSelected;
            // 
            // numUpDownAge
            // 
            numUpDownAge.BackColor = Color.LightGray;
            numUpDownAge.Location = new Point(12, 351);
            numUpDownAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numUpDownAge.Name = "numUpDownAge";
            numUpDownAge.Size = new Size(100, 23);
            numUpDownAge.TabIndex = 89;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.LightGray;
            txtBoxFirstName.Cursor = Cursors.IBeam;
            txtBoxFirstName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(12, 40);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(369, 22);
            txtBoxFirstName.TabIndex = 88;
            // 
            // lblDateEnd
            // 
            lblDateEnd.BackColor = Color.Transparent;
            lblDateEnd.Enabled = false;
            lblDateEnd.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblDateEnd.ForeColor = Color.SkyBlue;
            lblDateEnd.Location = new Point(12, 474);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(173, 26);
            lblDateEnd.TabIndex = 87;
            lblDateEnd.Text = "Дата 2";
            lblDateEnd.TextAlign = ContentAlignment.MiddleLeft;
            lblDateEnd.Visible = false;
            // 
            // lblDateStart
            // 
            lblDateStart.BackColor = Color.Transparent;
            lblDateStart.Enabled = false;
            lblDateStart.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblDateStart.ForeColor = Color.SkyBlue;
            lblDateStart.Location = new Point(12, 416);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(173, 26);
            lblDateStart.TabIndex = 86;
            lblDateStart.Text = "Дата 1";
            lblDateStart.TextAlign = ContentAlignment.MiddleLeft;
            lblDateStart.Visible = false;
            // 
            // lblDuration
            // 
            lblDuration.BackColor = Color.Transparent;
            lblDuration.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDuration.ForeColor = Color.SkyBlue;
            lblDuration.Location = new Point(11, 527);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(452, 23);
            lblDuration.TabIndex = 84;
            lblDuration.Text = "Продължителност на престоя: ";
            lblDuration.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radioBtnGroupRes
            // 
            radioBtnGroupRes.AutoSize = true;
            radioBtnGroupRes.BackColor = Color.Transparent;
            radioBtnGroupRes.Cursor = Cursors.Hand;
            radioBtnGroupRes.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioBtnGroupRes.ForeColor = Color.SkyBlue;
            radioBtnGroupRes.Location = new Point(12, 585);
            radioBtnGroupRes.Name = "radioBtnGroupRes";
            radioBtnGroupRes.Size = new Size(160, 18);
            radioBtnGroupRes.TabIndex = 83;
            radioBtnGroupRes.Text = "Групова регистрация";
            radioBtnGroupRes.UseVisualStyleBackColor = false;
            radioBtnGroupRes.Click += radioBtnGroupRes_CheckedChanged;
            // 
            // radioBtnOneRes
            // 
            radioBtnOneRes.AutoSize = true;
            radioBtnOneRes.BackColor = Color.Transparent;
            radioBtnOneRes.Checked = true;
            radioBtnOneRes.Cursor = Cursors.Hand;
            radioBtnOneRes.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioBtnOneRes.ForeColor = Color.SkyBlue;
            radioBtnOneRes.Location = new Point(12, 565);
            radioBtnOneRes.Name = "radioBtnOneRes";
            radioBtnOneRes.Size = new Size(168, 18);
            radioBtnOneRes.TabIndex = 82;
            radioBtnOneRes.TabStop = true;
            radioBtnOneRes.Text = "Единична регистрация";
            radioBtnOneRes.UseVisualStyleBackColor = false;
            radioBtnOneRes.Click += radioBtnOneRes_CheckedChanged;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGray;
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.Cursor = Cursors.Hand;
            btnNext.Enabled = false;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.SkyBlue;
            btnNext.Location = new Point(135, 608);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 43);
            btnNext.TabIndex = 81;
            btnNext.Text = "Следващ";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.Cursor = Cursors.Hand;
            btnBack.Enabled = false;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.SkyBlue;
            btnBack.Location = new Point(2, 609);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 42);
            btnBack.TabIndex = 80;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveRes
            // 
            btnSaveRes.BackColor = Color.LightGray;
            btnSaveRes.BackgroundImage = (Image)resources.GetObject("btnSaveRes.BackgroundImage");
            btnSaveRes.Cursor = Cursors.Hand;
            btnSaveRes.FlatStyle = FlatStyle.Flat;
            btnSaveRes.ForeColor = Color.SkyBlue;
            btnSaveRes.Location = new Point(279, 608);
            btnSaveRes.Name = "btnSaveRes";
            btnSaveRes.Size = new Size(127, 43);
            btnSaveRes.TabIndex = 79;
            btnSaveRes.Text = "Завършване на регистрацията";
            btnSaveRes.UseVisualStyleBackColor = false;
            btnSaveRes.Click += btnSaveRes_Click;
            // 
            // btnExpiredOn
            // 
            btnExpiredOn.BackColor = Color.LightGray;
            btnExpiredOn.BackgroundImage = (Image)resources.GetObject("btnExpiredOn.BackgroundImage");
            btnExpiredOn.Cursor = Cursors.Hand;
            btnExpiredOn.FlatStyle = FlatStyle.Flat;
            btnExpiredOn.ForeColor = Color.SkyBlue;
            btnExpiredOn.Location = new Point(12, 445);
            btnExpiredOn.Name = "btnExpiredOn";
            btnExpiredOn.Size = new Size(173, 26);
            btnExpiredOn.TabIndex = 77;
            btnExpiredOn.Text = "Дата на заминаване";
            btnExpiredOn.UseVisualStyleBackColor = false;
            btnExpiredOn.Click += btnExpiredOn_Click;
            // 
            // lblAge
            // 
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.ForeColor = Color.SkyBlue;
            lblAge.Location = new Point(12, 325);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(307, 23);
            lblAge.TabIndex = 75;
            lblAge.Text = "Възраст на клиента";
            lblAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.LightGray;
            txtBoxEmail.Cursor = Cursors.IBeam;
            txtBoxEmail.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.Location = new Point(12, 299);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(369, 22);
            txtBoxEmail.TabIndex = 74;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.MidnightBlue;
            lblEmail.Location = new Point(12, 273);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(369, 23);
            lblEmail.TabIndex = 73;
            lblEmail.Text = "Имейл адрес";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.BackColor = Color.LightGray;
            txtBoxPhoneNumber.Cursor = Cursors.IBeam;
            txtBoxPhoneNumber.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPhoneNumber.Location = new Point(12, 247);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(369, 22);
            txtBoxPhoneNumber.TabIndex = 72;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.BackColor = Color.Transparent;
            lblPhoneNumber.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.MidnightBlue;
            lblPhoneNumber.Location = new Point(12, 221);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(369, 23);
            lblPhoneNumber.TabIndex = 71;
            lblPhoneNumber.Text = "Телефонен номер на клиента";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxEGN
            // 
            txtBoxEGN.BackColor = Color.LightGray;
            txtBoxEGN.Cursor = Cursors.IBeam;
            txtBoxEGN.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEGN.Location = new Point(12, 195);
            txtBoxEGN.Name = "txtBoxEGN";
            txtBoxEGN.Size = new Size(369, 22);
            txtBoxEGN.TabIndex = 70;
            // 
            // lblEGN
            // 
            lblEGN.BackColor = Color.Transparent;
            lblEGN.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEGN.ForeColor = Color.MidnightBlue;
            lblEGN.Location = new Point(12, 169);
            lblEGN.Name = "lblEGN";
            lblEGN.Size = new Size(369, 23);
            lblEGN.TabIndex = 69;
            lblEGN.Text = "ЕГН на клиента";
            lblEGN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.LightGray;
            txtBoxLastName.Cursor = Cursors.IBeam;
            txtBoxLastName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(12, 144);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(369, 22);
            txtBoxLastName.TabIndex = 68;
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.MidnightBlue;
            lblFirstName.Location = new Point(12, 14);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(369, 23);
            lblFirstName.TabIndex = 67;
            lblFirstName.Text = "Първо име на клиента";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.MidnightBlue;
            lblLastName.Location = new Point(12, 118);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(369, 23);
            lblLastName.TabIndex = 66;
            lblLastName.Text = "Фамилия на клиента";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxMiddleName
            // 
            txtBoxMiddleName.BackColor = Color.LightGray;
            txtBoxMiddleName.Cursor = Cursors.IBeam;
            txtBoxMiddleName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxMiddleName.Location = new Point(12, 92);
            txtBoxMiddleName.Name = "txtBoxMiddleName";
            txtBoxMiddleName.Size = new Size(369, 22);
            txtBoxMiddleName.TabIndex = 65;
            // 
            // lblMiddleName
            // 
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.ForeColor = Color.MidnightBlue;
            lblMiddleName.Location = new Point(12, 66);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(369, 23);
            lblMiddleName.TabIndex = 64;
            lblMiddleName.Text = "Презиме на клиента";
            lblMiddleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableRooms
            // 
            tableRooms.BackColor = Color.Transparent;
            tableRooms.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableRooms.ColumnCount = 7;
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableRooms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableRooms.Controls.Add(btnRoom35, 6, 2);
            tableRooms.Controls.Add(btnRoom34, 5, 2);
            tableRooms.Controls.Add(btnRoom33, 4, 2);
            tableRooms.Controls.Add(btnRoom32, 3, 2);
            tableRooms.Controls.Add(btnRoom31, 2, 2);
            tableRooms.Controls.Add(btnRoom25, 6, 1);
            tableRooms.Controls.Add(btnRoom24, 5, 1);
            tableRooms.Controls.Add(btnRoom23, 4, 1);
            tableRooms.Controls.Add(btnRoom22, 3, 1);
            tableRooms.Controls.Add(btnRoom21, 2, 1);
            tableRooms.Controls.Add(btnRoom20, 1, 1);
            tableRooms.Controls.Add(btnRoom14, 5, 0);
            tableRooms.Controls.Add(btnRoom13, 4, 0);
            tableRooms.Controls.Add(btnRoom12, 3, 0);
            tableRooms.Controls.Add(lblFloor3, 0, 2);
            tableRooms.Controls.Add(btnRoom11, 2, 0);
            tableRooms.Controls.Add(lblFloor1, 0, 0);
            tableRooms.Controls.Add(lblFloor2, 0, 1);
            tableRooms.Controls.Add(btnRoom30, 1, 2);
            tableRooms.Controls.Add(btnRoom15, 6, 0);
            tableRooms.Controls.Add(btnRoom10, 1, 0);
            tableRooms.Location = new Point(423, 40);
            tableRooms.Name = "tableRooms";
            tableRooms.RowCount = 3;
            tableRooms.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableRooms.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableRooms.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableRooms.Size = new Size(635, 176);
            tableRooms.TabIndex = 93;
            // 
            // btnRoom35
            // 
            btnRoom35.Cursor = Cursors.Hand;
            btnRoom35.FlatAppearance.BorderSize = 0;
            btnRoom35.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom35.ForeColor = Color.White;
            btnRoom35.Location = new Point(543, 118);
            btnRoom35.Margin = new Padding(0);
            btnRoom35.Name = "btnRoom35";
            btnRoom35.Size = new Size(90, 56);
            btnRoom35.TabIndex = 65;
            btnRoom35.Text = "Ап 35";
            btnRoom35.UseVisualStyleBackColor = true;
            btnRoom35.Click += btnRoom35_Click;
            // 
            // btnRoom34
            // 
            btnRoom34.Cursor = Cursors.Hand;
            btnRoom34.FlatAppearance.BorderSize = 0;
            btnRoom34.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom34.ForeColor = Color.White;
            btnRoom34.Location = new Point(451, 118);
            btnRoom34.Margin = new Padding(0);
            btnRoom34.Name = "btnRoom34";
            btnRoom34.Size = new Size(90, 56);
            btnRoom34.TabIndex = 65;
            btnRoom34.Text = "Ап 34";
            btnRoom34.UseVisualStyleBackColor = true;
            btnRoom34.Click += btnRoom34_Click;
            // 
            // btnRoom33
            // 
            btnRoom33.Cursor = Cursors.Hand;
            btnRoom33.FlatAppearance.BorderSize = 0;
            btnRoom33.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom33.ForeColor = Color.White;
            btnRoom33.Location = new Point(359, 118);
            btnRoom33.Margin = new Padding(0);
            btnRoom33.Name = "btnRoom33";
            btnRoom33.Size = new Size(90, 56);
            btnRoom33.TabIndex = 65;
            btnRoom33.Text = "Ап 33";
            btnRoom33.UseVisualStyleBackColor = true;
            btnRoom33.Click += btnRoom33_Click;
            // 
            // btnRoom32
            // 
            btnRoom32.Cursor = Cursors.Hand;
            btnRoom32.FlatAppearance.BorderSize = 0;
            btnRoom32.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom32.ForeColor = Color.White;
            btnRoom32.Location = new Point(267, 118);
            btnRoom32.Margin = new Padding(0);
            btnRoom32.Name = "btnRoom32";
            btnRoom32.Size = new Size(90, 56);
            btnRoom32.TabIndex = 65;
            btnRoom32.Text = "Ап 32";
            btnRoom32.UseVisualStyleBackColor = true;
            btnRoom32.Click += btnRoom32_Click;
            // 
            // btnRoom31
            // 
            btnRoom31.Cursor = Cursors.Hand;
            btnRoom31.FlatAppearance.BorderSize = 0;
            btnRoom31.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom31.ForeColor = Color.White;
            btnRoom31.Location = new Point(175, 118);
            btnRoom31.Margin = new Padding(0);
            btnRoom31.Name = "btnRoom31";
            btnRoom31.Size = new Size(90, 56);
            btnRoom31.TabIndex = 65;
            btnRoom31.Text = "Ап 31";
            btnRoom31.UseVisualStyleBackColor = true;
            btnRoom31.Click += btnRoom31_Click;
            // 
            // btnRoom25
            // 
            btnRoom25.Cursor = Cursors.Hand;
            btnRoom25.FlatAppearance.BorderSize = 0;
            btnRoom25.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom25.ForeColor = Color.White;
            btnRoom25.Location = new Point(543, 60);
            btnRoom25.Margin = new Padding(0);
            btnRoom25.Name = "btnRoom25";
            btnRoom25.Size = new Size(90, 56);
            btnRoom25.TabIndex = 65;
            btnRoom25.Text = "Ап 25";
            btnRoom25.UseVisualStyleBackColor = true;
            btnRoom25.Click += btnRoom25_Click;
            // 
            // btnRoom24
            // 
            btnRoom24.Cursor = Cursors.Hand;
            btnRoom24.FlatAppearance.BorderSize = 0;
            btnRoom24.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom24.ForeColor = Color.White;
            btnRoom24.Location = new Point(451, 60);
            btnRoom24.Margin = new Padding(0);
            btnRoom24.Name = "btnRoom24";
            btnRoom24.Size = new Size(90, 56);
            btnRoom24.TabIndex = 65;
            btnRoom24.Text = "Стая 24";
            btnRoom24.UseVisualStyleBackColor = true;
            btnRoom24.Click += btnRoom24_Click;
            // 
            // btnRoom23
            // 
            btnRoom23.Cursor = Cursors.Hand;
            btnRoom23.FlatAppearance.BorderSize = 0;
            btnRoom23.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom23.ForeColor = Color.White;
            btnRoom23.Location = new Point(359, 60);
            btnRoom23.Margin = new Padding(0);
            btnRoom23.Name = "btnRoom23";
            btnRoom23.Size = new Size(90, 56);
            btnRoom23.TabIndex = 65;
            btnRoom23.Text = "Стая 23";
            btnRoom23.UseVisualStyleBackColor = true;
            btnRoom23.Click += btnRoom23_Click;
            // 
            // btnRoom22
            // 
            btnRoom22.Cursor = Cursors.Hand;
            btnRoom22.FlatAppearance.BorderSize = 0;
            btnRoom22.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom22.ForeColor = Color.White;
            btnRoom22.Location = new Point(267, 60);
            btnRoom22.Margin = new Padding(0);
            btnRoom22.Name = "btnRoom22";
            btnRoom22.Size = new Size(90, 56);
            btnRoom22.TabIndex = 65;
            btnRoom22.Text = "Стая 22";
            btnRoom22.UseVisualStyleBackColor = true;
            btnRoom22.Click += btnRoom22_Click;
            // 
            // btnRoom21
            // 
            btnRoom21.Cursor = Cursors.Hand;
            btnRoom21.FlatAppearance.BorderSize = 0;
            btnRoom21.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom21.ForeColor = Color.White;
            btnRoom21.Location = new Point(175, 60);
            btnRoom21.Margin = new Padding(0);
            btnRoom21.Name = "btnRoom21";
            btnRoom21.Size = new Size(90, 56);
            btnRoom21.TabIndex = 65;
            btnRoom21.Text = "Стая 21";
            btnRoom21.UseVisualStyleBackColor = true;
            btnRoom21.Click += btnRoom21_Click;
            // 
            // btnRoom20
            // 
            btnRoom20.Cursor = Cursors.Hand;
            btnRoom20.FlatAppearance.BorderSize = 0;
            btnRoom20.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom20.ForeColor = Color.White;
            btnRoom20.Location = new Point(83, 60);
            btnRoom20.Margin = new Padding(0);
            btnRoom20.Name = "btnRoom20";
            btnRoom20.Size = new Size(90, 56);
            btnRoom20.TabIndex = 65;
            btnRoom20.Text = "Стая 20";
            btnRoom20.UseVisualStyleBackColor = true;
            btnRoom20.Click += btnRoom20_Click;
            // 
            // btnRoom14
            // 
            btnRoom14.Cursor = Cursors.Hand;
            btnRoom14.FlatAppearance.BorderSize = 0;
            btnRoom14.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom14.ForeColor = Color.White;
            btnRoom14.Location = new Point(451, 2);
            btnRoom14.Margin = new Padding(0);
            btnRoom14.Name = "btnRoom14";
            btnRoom14.Size = new Size(90, 56);
            btnRoom14.TabIndex = 67;
            btnRoom14.Text = "Ап 14";
            btnRoom14.UseVisualStyleBackColor = true;
            btnRoom14.Click += btnRoom14_Click;
            // 
            // btnRoom13
            // 
            btnRoom13.Cursor = Cursors.Hand;
            btnRoom13.FlatAppearance.BorderSize = 0;
            btnRoom13.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom13.ForeColor = Color.White;
            btnRoom13.Location = new Point(359, 2);
            btnRoom13.Margin = new Padding(0);
            btnRoom13.Name = "btnRoom13";
            btnRoom13.Size = new Size(90, 56);
            btnRoom13.TabIndex = 66;
            btnRoom13.Text = "Ап 13";
            btnRoom13.UseVisualStyleBackColor = true;
            btnRoom13.Click += btnRoom13_Click;
            // 
            // btnRoom12
            // 
            btnRoom12.Cursor = Cursors.Hand;
            btnRoom12.FlatAppearance.BorderSize = 0;
            btnRoom12.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom12.ForeColor = Color.White;
            btnRoom12.Location = new Point(267, 2);
            btnRoom12.Margin = new Padding(0);
            btnRoom12.Name = "btnRoom12";
            btnRoom12.Size = new Size(90, 56);
            btnRoom12.TabIndex = 65;
            btnRoom12.Text = "Стая 12";
            btnRoom12.UseVisualStyleBackColor = true;
            btnRoom12.Click += btnRoom12_Click;
            // 
            // lblFloor3
            // 
            lblFloor3.BackColor = Color.Gray;
            lblFloor3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFloor3.Location = new Point(2, 118);
            lblFloor3.Margin = new Padding(0);
            lblFloor3.Name = "lblFloor3";
            lblFloor3.Size = new Size(79, 56);
            lblFloor3.TabIndex = 65;
            lblFloor3.Text = "Етаж 3";
            lblFloor3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRoom11
            // 
            btnRoom11.Cursor = Cursors.Hand;
            btnRoom11.FlatAppearance.BorderSize = 0;
            btnRoom11.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom11.ForeColor = Color.White;
            btnRoom11.Location = new Point(175, 2);
            btnRoom11.Margin = new Padding(0);
            btnRoom11.Name = "btnRoom11";
            btnRoom11.Size = new Size(90, 56);
            btnRoom11.TabIndex = 0;
            btnRoom11.Text = "Стая 11";
            btnRoom11.UseVisualStyleBackColor = true;
            btnRoom11.Click += btnRoom11_Click;
            // 
            // lblFloor1
            // 
            lblFloor1.BackColor = Color.Gray;
            lblFloor1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFloor1.Location = new Point(2, 2);
            lblFloor1.Margin = new Padding(0);
            lblFloor1.Name = "lblFloor1";
            lblFloor1.Size = new Size(79, 56);
            lblFloor1.TabIndex = 2;
            lblFloor1.Text = "Етаж 1";
            lblFloor1.TextAlign = ContentAlignment.MiddleCenter;
            lblFloor1.DoubleClick += lblFloor1_DoubleClick;
            // 
            // lblFloor2
            // 
            lblFloor2.BackColor = Color.Gray;
            lblFloor2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFloor2.Location = new Point(2, 60);
            lblFloor2.Margin = new Padding(0);
            lblFloor2.Name = "lblFloor2";
            lblFloor2.Size = new Size(79, 56);
            lblFloor2.TabIndex = 3;
            lblFloor2.Text = "Етаж 2";
            lblFloor2.TextAlign = ContentAlignment.MiddleCenter;
            lblFloor2.DoubleClick += lblFloor2_DoubleClick;
            // 
            // btnRoom30
            // 
            btnRoom30.Cursor = Cursors.Hand;
            btnRoom30.FlatAppearance.BorderSize = 0;
            btnRoom30.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom30.ForeColor = Color.White;
            btnRoom30.Location = new Point(83, 118);
            btnRoom30.Margin = new Padding(0);
            btnRoom30.Name = "btnRoom30";
            btnRoom30.Size = new Size(90, 56);
            btnRoom30.TabIndex = 65;
            btnRoom30.Text = "Стая 30";
            btnRoom30.UseVisualStyleBackColor = true;
            btnRoom30.Click += btnRoom30_Click;
            // 
            // btnRoom15
            // 
            btnRoom15.Cursor = Cursors.Hand;
            btnRoom15.FlatAppearance.BorderSize = 0;
            btnRoom15.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom15.ForeColor = Color.White;
            btnRoom15.Location = new Point(543, 2);
            btnRoom15.Margin = new Padding(0);
            btnRoom15.Name = "btnRoom15";
            btnRoom15.Size = new Size(90, 56);
            btnRoom15.TabIndex = 67;
            btnRoom15.Text = "Ап 15";
            btnRoom15.UseVisualStyleBackColor = true;
            btnRoom15.Click += btnRoom15_Click;
            // 
            // btnRoom10
            // 
            btnRoom10.BackColor = Color.Transparent;
            btnRoom10.Cursor = Cursors.Hand;
            btnRoom10.FlatAppearance.BorderSize = 0;
            btnRoom10.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnRoom10.ForeColor = Color.White;
            btnRoom10.Location = new Point(83, 2);
            btnRoom10.Margin = new Padding(0);
            btnRoom10.Name = "btnRoom10";
            btnRoom10.Size = new Size(90, 56);
            btnRoom10.TabIndex = 1;
            btnRoom10.Text = "Стая 10";
            btnRoom10.UseVisualStyleBackColor = false;
            btnRoom10.Click += btnRoom10_Click;
            // 
            // tabControlMenu
            // 
            tabControlMenu.Controls.Add(tabPageWithMenus);
            tabControlMenu.Controls.Add(tabPageBuffet);
            tabControlMenu.Controls.Add(tabPageALLIn);
            tabControlMenu.Controls.Add(tabPageVipMenu);
            tabControlMenu.Location = new Point(423, 232);
            tabControlMenu.Name = "tabControlMenu";
            tabControlMenu.SelectedIndex = 0;
            tabControlMenu.Size = new Size(635, 372);
            tabControlMenu.TabIndex = 94;
            // 
            // tabPageWithMenus
            // 
            tabPageWithMenus.Controls.Add(lblCompletedMenu1);
            tabPageWithMenus.Controls.Add(checkedListBoxMenu);
            tabPageWithMenus.Controls.Add(lblMenuOnOffPage1);
            tabPageWithMenus.Controls.Add(lblDinner);
            tabPageWithMenus.Controls.Add(lblLunch);
            tabPageWithMenus.Controls.Add(lblBreakfast);
            tabPageWithMenus.Controls.Add(btnPreviousDay);
            tabPageWithMenus.Controls.Add(lblSelectedMenu);
            tabPageWithMenus.Controls.Add(btnNextDay);
            tabPageWithMenus.Controls.Add(lblMenuDate);
            tabPageWithMenus.Location = new Point(4, 24);
            tabPageWithMenus.Name = "tabPageWithMenus";
            tabPageWithMenus.Padding = new Padding(3);
            tabPageWithMenus.Size = new Size(627, 344);
            tabPageWithMenus.TabIndex = 0;
            tabPageWithMenus.Text = "Обикновено меню";
            tabPageWithMenus.UseVisualStyleBackColor = true;
            tabPageWithMenus.Click += tabPageWithMenus_Click;
            // 
            // lblCompletedMenu1
            // 
            lblCompletedMenu1.BackColor = SystemColors.Control;
            lblCompletedMenu1.Enabled = false;
            lblCompletedMenu1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCompletedMenu1.Location = new Point(175, 144);
            lblCompletedMenu1.Name = "lblCompletedMenu1";
            lblCompletedMenu1.Size = new Size(276, 56);
            lblCompletedMenu1.TabIndex = 96;
            lblCompletedMenu1.Text = "Менюто е попълнено!";
            lblCompletedMenu1.TextAlign = ContentAlignment.MiddleCenter;
            lblCompletedMenu1.Visible = false;
            // 
            // checkedListBoxMenu
            // 
            checkedListBoxMenu.BackColor = SystemColors.Control;
            checkedListBoxMenu.Cursor = Cursors.Hand;
            checkedListBoxMenu.Enabled = false;
            checkedListBoxMenu.Font = new Font("Garamond", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            checkedListBoxMenu.FormattingEnabled = true;
            checkedListBoxMenu.Items.AddRange(new object[] { "Закуска", "Обяд", "Вечеря" });
            checkedListBoxMenu.Location = new Point(30, 51);
            checkedListBoxMenu.Name = "checkedListBoxMenu";
            checkedListBoxMenu.Size = new Size(260, 202);
            checkedListBoxMenu.TabIndex = 95;
            checkedListBoxMenu.Visible = false;
            // 
            // lblMenuOnOffPage1
            // 
            lblMenuOnOffPage1.BackColor = SystemColors.Control;
            lblMenuOnOffPage1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMenuOnOffPage1.Location = new Point(175, 144);
            lblMenuOnOffPage1.Name = "lblMenuOnOffPage1";
            lblMenuOnOffPage1.Size = new Size(276, 56);
            lblMenuOnOffPage1.TabIndex = 94;
            lblMenuOnOffPage1.Text = "Изберете дати\r\nна резервацията!";
            lblMenuOnOffPage1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDinner
            // 
            lblDinner.BackColor = SystemColors.Control;
            lblDinner.Enabled = false;
            lblDinner.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDinner.Location = new Point(330, 129);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(260, 26);
            lblDinner.TabIndex = 93;
            lblDinner.Text = "Вечеря";
            lblDinner.TextAlign = ContentAlignment.MiddleCenter;
            lblDinner.Visible = false;
            // 
            // lblLunch
            // 
            lblLunch.BackColor = SystemColors.Control;
            lblLunch.Enabled = false;
            lblLunch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLunch.Location = new Point(330, 89);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(260, 26);
            lblLunch.TabIndex = 92;
            lblLunch.Text = "Обяд";
            lblLunch.TextAlign = ContentAlignment.MiddleCenter;
            lblLunch.Visible = false;
            // 
            // lblBreakfast
            // 
            lblBreakfast.BackColor = SystemColors.Control;
            lblBreakfast.Enabled = false;
            lblBreakfast.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBreakfast.Location = new Point(330, 51);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(260, 26);
            lblBreakfast.TabIndex = 91;
            lblBreakfast.Text = "Закуска";
            lblBreakfast.TextAlign = ContentAlignment.MiddleCenter;
            lblBreakfast.Visible = false;
            // 
            // btnPreviousDay
            // 
            btnPreviousDay.Cursor = Cursors.Hand;
            btnPreviousDay.Enabled = false;
            btnPreviousDay.Location = new Point(30, 281);
            btnPreviousDay.Name = "btnPreviousDay";
            btnPreviousDay.Size = new Size(115, 38);
            btnPreviousDay.TabIndex = 90;
            btnPreviousDay.Text = "Предишен ден";
            btnPreviousDay.UseVisualStyleBackColor = true;
            btnPreviousDay.Visible = false;
            btnPreviousDay.Click += btnPreviousDay_Click;
            // 
            // lblSelectedMenu
            // 
            lblSelectedMenu.BackColor = SystemColors.Control;
            lblSelectedMenu.Enabled = false;
            lblSelectedMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSelectedMenu.Location = new Point(330, 14);
            lblSelectedMenu.Name = "lblSelectedMenu";
            lblSelectedMenu.Size = new Size(260, 26);
            lblSelectedMenu.TabIndex = 89;
            lblSelectedMenu.Text = "Избраното меню";
            lblSelectedMenu.TextAlign = ContentAlignment.MiddleCenter;
            lblSelectedMenu.Visible = false;
            // 
            // btnNextDay
            // 
            btnNextDay.Cursor = Cursors.Hand;
            btnNextDay.Enabled = false;
            btnNextDay.Location = new Point(175, 281);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(115, 38);
            btnNextDay.TabIndex = 88;
            btnNextDay.Text = "Следващ ден";
            btnNextDay.UseVisualStyleBackColor = true;
            btnNextDay.Visible = false;
            btnNextDay.Click += btnNextDay_Click;
            // 
            // lblMenuDate
            // 
            lblMenuDate.BackColor = SystemColors.Control;
            lblMenuDate.Enabled = false;
            lblMenuDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMenuDate.Location = new Point(30, 14);
            lblMenuDate.Name = "lblMenuDate";
            lblMenuDate.Size = new Size(260, 26);
            lblMenuDate.TabIndex = 87;
            lblMenuDate.Text = "Дата 3";
            lblMenuDate.TextAlign = ContentAlignment.MiddleCenter;
            lblMenuDate.Visible = false;
            // 
            // tabPageBuffet
            // 
            tabPageBuffet.Controls.Add(lblCompletedMenu2);
            tabPageBuffet.Controls.Add(lblBuffetInfo);
            tabPageBuffet.Controls.Add(lblMenuOnOffPage2);
            tabPageBuffet.Location = new Point(4, 24);
            tabPageBuffet.Name = "tabPageBuffet";
            tabPageBuffet.Padding = new Padding(3);
            tabPageBuffet.Size = new Size(627, 344);
            tabPageBuffet.TabIndex = 1;
            tabPageBuffet.Text = "Блок маса";
            tabPageBuffet.UseVisualStyleBackColor = true;
            tabPageBuffet.Click += tabPageBuffet_Click;
            // 
            // lblCompletedMenu2
            // 
            lblCompletedMenu2.BackColor = SystemColors.Control;
            lblCompletedMenu2.Enabled = false;
            lblCompletedMenu2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCompletedMenu2.Location = new Point(175, 144);
            lblCompletedMenu2.Name = "lblCompletedMenu2";
            lblCompletedMenu2.Size = new Size(276, 56);
            lblCompletedMenu2.TabIndex = 97;
            lblCompletedMenu2.Text = "Менюто е попълнено!";
            lblCompletedMenu2.TextAlign = ContentAlignment.MiddleCenter;
            lblCompletedMenu2.Visible = false;
            // 
            // lblBuffetInfo
            // 
            lblBuffetInfo.BackColor = SystemColors.Control;
            lblBuffetInfo.Enabled = false;
            lblBuffetInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBuffetInfo.Location = new Point(113, 10);
            lblBuffetInfo.Name = "lblBuffetInfo";
            lblBuffetInfo.Size = new Size(400, 284);
            lblBuffetInfo.TabIndex = 96;
            lblBuffetInfo.Text = "Описание на блок масата:\r\n";
            lblBuffetInfo.TextAlign = ContentAlignment.TopCenter;
            lblBuffetInfo.Visible = false;
            // 
            // lblMenuOnOffPage2
            // 
            lblMenuOnOffPage2.BackColor = SystemColors.Control;
            lblMenuOnOffPage2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMenuOnOffPage2.Location = new Point(175, 144);
            lblMenuOnOffPage2.Name = "lblMenuOnOffPage2";
            lblMenuOnOffPage2.Size = new Size(276, 56);
            lblMenuOnOffPage2.TabIndex = 95;
            lblMenuOnOffPage2.Text = "Изберете дати\r\nна резервацията!";
            lblMenuOnOffPage2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageALLIn
            // 
            tabPageALLIn.Controls.Add(lblCompletedMenu3);
            tabPageALLIn.Controls.Add(lblAllInclusiveInfo);
            tabPageALLIn.Controls.Add(lblMenuOnOffPage3);
            tabPageALLIn.Location = new Point(4, 24);
            tabPageALLIn.Name = "tabPageALLIn";
            tabPageALLIn.Padding = new Padding(3);
            tabPageALLIn.Size = new Size(627, 344);
            tabPageALLIn.TabIndex = 2;
            tabPageALLIn.Text = "All Inclusive";
            tabPageALLIn.UseVisualStyleBackColor = true;
            tabPageALLIn.Click += tabPageALLIn_Click;
            // 
            // lblCompletedMenu3
            // 
            lblCompletedMenu3.BackColor = SystemColors.Control;
            lblCompletedMenu3.Enabled = false;
            lblCompletedMenu3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCompletedMenu3.Location = new Point(175, 144);
            lblCompletedMenu3.Name = "lblCompletedMenu3";
            lblCompletedMenu3.Size = new Size(276, 56);
            lblCompletedMenu3.TabIndex = 98;
            lblCompletedMenu3.Text = "Менюто е попълнено!";
            lblCompletedMenu3.TextAlign = ContentAlignment.MiddleCenter;
            lblCompletedMenu3.Visible = false;
            // 
            // lblAllInclusiveInfo
            // 
            lblAllInclusiveInfo.BackColor = SystemColors.Control;
            lblAllInclusiveInfo.Enabled = false;
            lblAllInclusiveInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAllInclusiveInfo.Location = new Point(113, 10);
            lblAllInclusiveInfo.Name = "lblAllInclusiveInfo";
            lblAllInclusiveInfo.Size = new Size(400, 284);
            lblAllInclusiveInfo.TabIndex = 97;
            lblAllInclusiveInfo.Text = "Описание на All Inclusive пакет:\r\n";
            lblAllInclusiveInfo.TextAlign = ContentAlignment.TopCenter;
            lblAllInclusiveInfo.Visible = false;
            // 
            // lblMenuOnOffPage3
            // 
            lblMenuOnOffPage3.BackColor = SystemColors.Control;
            lblMenuOnOffPage3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMenuOnOffPage3.Location = new Point(175, 144);
            lblMenuOnOffPage3.Name = "lblMenuOnOffPage3";
            lblMenuOnOffPage3.Size = new Size(276, 56);
            lblMenuOnOffPage3.TabIndex = 96;
            lblMenuOnOffPage3.Text = "Изберете дати\r\nна резервацията!";
            lblMenuOnOffPage3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageVipMenu
            // 
            tabPageVipMenu.Controls.Add(lblCompletedMenu4);
            tabPageVipMenu.Controls.Add(lblVipMenuInfo);
            tabPageVipMenu.Controls.Add(lblMenuOnOffPage4);
            tabPageVipMenu.Location = new Point(4, 24);
            tabPageVipMenu.Name = "tabPageVipMenu";
            tabPageVipMenu.Padding = new Padding(3);
            tabPageVipMenu.Size = new Size(627, 344);
            tabPageVipMenu.TabIndex = 3;
            tabPageVipMenu.Text = "VIP меню";
            tabPageVipMenu.UseVisualStyleBackColor = true;
            tabPageVipMenu.Click += tabPageVipMenu_Click;
            // 
            // lblCompletedMenu4
            // 
            lblCompletedMenu4.BackColor = SystemColors.Control;
            lblCompletedMenu4.Enabled = false;
            lblCompletedMenu4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCompletedMenu4.Location = new Point(175, 144);
            lblCompletedMenu4.Name = "lblCompletedMenu4";
            lblCompletedMenu4.Size = new Size(276, 56);
            lblCompletedMenu4.TabIndex = 99;
            lblCompletedMenu4.Text = "Менюто е попълнено!";
            lblCompletedMenu4.TextAlign = ContentAlignment.MiddleCenter;
            lblCompletedMenu4.Visible = false;
            // 
            // lblVipMenuInfo
            // 
            lblVipMenuInfo.BackColor = SystemColors.Control;
            lblVipMenuInfo.Enabled = false;
            lblVipMenuInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVipMenuInfo.Location = new Point(113, 10);
            lblVipMenuInfo.Name = "lblVipMenuInfo";
            lblVipMenuInfo.Size = new Size(400, 284);
            lblVipMenuInfo.TabIndex = 97;
            lblVipMenuInfo.Text = "Описание на VIP менюто:\r\n";
            lblVipMenuInfo.TextAlign = ContentAlignment.TopCenter;
            lblVipMenuInfo.Visible = false;
            // 
            // lblMenuOnOffPage4
            // 
            lblMenuOnOffPage4.BackColor = SystemColors.Control;
            lblMenuOnOffPage4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMenuOnOffPage4.Location = new Point(175, 144);
            lblMenuOnOffPage4.Name = "lblMenuOnOffPage4";
            lblMenuOnOffPage4.Size = new Size(276, 56);
            lblMenuOnOffPage4.TabIndex = 96;
            lblMenuOnOffPage4.Text = "Изберете дати\r\nна резервацията!";
            lblMenuOnOffPage4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBookedOn
            // 
            btnBookedOn.BackColor = Color.Transparent;
            btnBookedOn.BackgroundImage = (Image)resources.GetObject("btnBookedOn.BackgroundImage");
            btnBookedOn.Cursor = Cursors.Hand;
            btnBookedOn.FlatStyle = FlatStyle.Flat;
            btnBookedOn.ForeColor = Color.SkyBlue;
            btnBookedOn.Location = new Point(12, 387);
            btnBookedOn.Name = "btnBookedOn";
            btnBookedOn.Size = new Size(173, 26);
            btnBookedOn.TabIndex = 95;
            btnBookedOn.Text = "Дата на пристигане";
            btnBookedOn.UseVisualStyleBackColor = false;
            btnBookedOn.Click += btnBookedOn_Click;
            // 
            // lblCheckResData
            // 
            lblCheckResData.BackColor = Color.Silver;
            lblCheckResData.Enabled = false;
            lblCheckResData.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCheckResData.ForeColor = Color.White;
            lblCheckResData.Image = (Image)resources.GetObject("lblCheckResData.Image");
            lblCheckResData.Location = new Point(356, 307);
            lblCheckResData.Name = "lblCheckResData";
            lblCheckResData.Size = new Size(369, 33);
            lblCheckResData.TabIndex = 96;
            lblCheckResData.Text = "Попълнете цялата информация!";
            lblCheckResData.TextAlign = ContentAlignment.MiddleCenter;
            lblCheckResData.Visible = false;
            // 
            // btnCheckResData
            // 
            btnCheckResData.BackColor = Color.LightGray;
            btnCheckResData.BackgroundImage = (Image)resources.GetObject("btnCheckResData.BackgroundImage");
            btnCheckResData.Cursor = Cursors.Hand;
            btnCheckResData.Enabled = false;
            btnCheckResData.FlatStyle = FlatStyle.Flat;
            btnCheckResData.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckResData.ForeColor = Color.White;
            btnCheckResData.Location = new Point(356, 339);
            btnCheckResData.Name = "btnCheckResData";
            btnCheckResData.Size = new Size(67, 43);
            btnCheckResData.TabIndex = 97;
            btnCheckResData.Text = "OK";
            btnCheckResData.UseVisualStyleBackColor = false;
            btnCheckResData.Visible = false;
            btnCheckResData.Click += btnCheckResData_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1081, 657);
            Controls.Add(btnCheckResData);
            Controls.Add(lblCheckResData);
            Controls.Add(btnBookedOn);
            Controls.Add(monthCalendar);
            Controls.Add(tabControlMenu);
            Controls.Add(tableRooms);
            Controls.Add(btnDelAll);
            Controls.Add(numUpDownAge);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblDateEnd);
            Controls.Add(lblDateStart);
            Controls.Add(lblDuration);
            Controls.Add(radioBtnGroupRes);
            Controls.Add(radioBtnOneRes);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnSaveRes);
            Controls.Add(btnExpiredOn);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservationForm";
            Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).EndInit();
            tableRooms.ResumeLayout(false);
            tabControlMenu.ResumeLayout(false);
            tabPageWithMenus.ResumeLayout(false);
            tabPageBuffet.ResumeLayout(false);
            tabPageALLIn.ResumeLayout(false);
            tabPageVipMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDelAll;
        private MonthCalendar monthCalendar;
        private NumericUpDown numUpDownAge;
        private TextBox txtBoxFirstName;
        private Label lblDateEnd;
        private Label lblDateStart;
        private Label lblDuration;
        private RadioButton radioBtnGroupRes;
        private RadioButton radioBtnOneRes;
        private Button btnNext;
        private Button btnBack;
        private Button btnSaveRes;
        private Button btnExpiredOn;
        private Label lblAge;
        private TextBox txtBoxEmail;
        private Label lblEmail;
        private TextBox txtBoxPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtBoxEGN;
        private Label lblEGN;
        private TextBox txtBoxLastName;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtBoxMiddleName;
        private Label lblMiddleName;
        private TableLayoutPanel tableRooms;
        private Button btnRoom35;
        private Button btnRoom34;
        private Button btnRoom33;
        private Button btnRoom32;
        private Button btnRoom31;
        private Button btnRoom25;
        private Button btnRoom24;
        private Button btnRoom23;
        private Button btnRoom22;
        private Button btnRoom21;
        private Button btnRoom20;
        private Button btnRoom15;
        private Button btnRoom14;
        private Button btnRoom13;
        private Button btnRoom12;
        private Label lblFloor3;
        private Button btnRoom10;
        private Button btnRoom11;
        private Label lblFloor1;
        private Label lblFloor2;
        private Button btnRoom30;
        private TabControl tabControlMenu;
        private TabPage tabPageWithMenus;
        private TabPage tabPageBuffet;
        private TabPage tabPageALLIn;
        private TabPage tabPageVipMenu;
        private CheckedListBox checkedListBoxMenu;
        private Label lblMenuDate;
        private Button btnNextDay;
        private Label lblSelectedMenu;
        private Button btnPreviousDay;
        private Label lblDinner;
        private Label lblLunch;
        private Label lblBreakfast;
        private Label lblMenuOnOffPage1;
        private Label lblMenuOnOffPage2;
        private Label lblMenuOnOffPage3;
        private Label lblMenuOnOffPage4;
        private Label lblBuffetInfo;
        private Label lblAllInclusiveInfo;
        private Label lblVipMenuInfo;
        private Button btnBookedOn;
        private Label lblCompletedMenu1;
        private Label lblCompletedMenu2;
        private Label lblCompletedMenu3;
        private Label lblCompletedMenu4;
        private Label lblCheckResData;
        private Button btnCheckResData;
    }
}