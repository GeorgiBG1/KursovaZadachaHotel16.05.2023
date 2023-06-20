namespace KursovaHotel2
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.btnDisableRes = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOrderClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 18;
            this.listBoxClients.Location = new System.Drawing.Point(12, 51);
            this.listBoxClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(1049, 454);
            this.listBoxClients.TabIndex = 1;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.ItemHeight = 18;
            this.listBoxReservations.Location = new System.Drawing.Point(12, 515);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(840, 40);
            this.listBoxReservations.TabIndex = 2;
            // 
            // btnDisableRes
            // 
            this.btnDisableRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisableRes.BackgroundImage")));
            this.btnDisableRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisableRes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDisableRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableRes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisableRes.ForeColor = System.Drawing.Color.White;
            this.btnDisableRes.Location = new System.Drawing.Point(862, 515);
            this.btnDisableRes.Name = "btnDisableRes";
            this.btnDisableRes.Size = new System.Drawing.Size(199, 40);
            this.btnDisableRes.TabIndex = 3;
            this.btnDisableRes.Text = "Прекрати резервация";
            this.btnDisableRes.UseVisualStyleBackColor = true;
            this.btnDisableRes.Click += new System.EventHandler(this.btnDisableRes_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(932, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Опресни";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOrderClients
            // 
            this.btnOrderClients.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrderClients.BackgroundImage")));
            this.btnOrderClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderClients.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderClients.ForeColor = System.Drawing.Color.White;
            this.btnOrderClients.Location = new System.Drawing.Point(12, 6);
            this.btnOrderClients.Name = "btnOrderClients";
            this.btnOrderClients.Size = new System.Drawing.Size(75, 38);
            this.btnOrderClients.TabIndex = 6;
            this.btnOrderClients.UseVisualStyleBackColor = false;
            this.btnOrderClients.Click += new System.EventHandler(this.btnOrderClients_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1217, 567);
            this.Controls.Add(this.btnOrderClients);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDisableRes);
            this.Controls.Add(this.listBoxReservations);
            this.Controls.Add(this.listBoxClients);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxClients;
        private ListBox listBoxReservations;
        private Button btnDisableRes;
        private Button btnRefresh;
        private Button btnOrderClients;
    }
}