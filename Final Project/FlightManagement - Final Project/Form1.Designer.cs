namespace FlightManagement___Final_Project
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
            components = new System.ComponentModel.Container();
            txtPassengerName = new TextBox();
            btnBook = new Button();
            cmbFilterDestination = new ComboBox();
            dtpFilterDate = new DateTimePicker();
            btnClearFilter = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupFilters = new GroupBox();
            label5 = new Label();
            nudSeatsFilter = new NumericUpDown();
            label4 = new Label();
            cmbFilterAirline = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            panelBooking = new Panel();
            pictureBox1 = new PictureBox();
            groupBooking = new GroupBox();
            label3 = new Label();
            listViewFlights = new ListView();
            groupFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSeatsFilter).BeginInit();
            panelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBooking.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassengerName
            // 
            txtPassengerName.Location = new Point(24, 81);
            txtPassengerName.Multiline = true;
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.PlaceholderText = "Passenger Name";
            txtPassengerName.Size = new Size(263, 35);
            txtPassengerName.TabIndex = 1;
            txtPassengerName.TextChanged += txtPassengerName_TextChanged;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(87, 122);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(122, 40);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book Flight";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // cmbFilterDestination
            // 
            cmbFilterDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterDestination.FormattingEnabled = true;
            cmbFilterDestination.Location = new Point(190, 30);
            cmbFilterDestination.Name = "cmbFilterDestination";
            cmbFilterDestination.Size = new Size(163, 33);
            cmbFilterDestination.TabIndex = 3;
            cmbFilterDestination.SelectedIndexChanged += cmbFilterDestination_SelectedIndexChanged;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Location = new Point(128, 69);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(225, 31);
            dtpFilterDate.TabIndex = 4;
            dtpFilterDate.ValueChanged += dtpFilterDate_ValueChanged;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(6, 183);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(119, 34);
            btnClearFilter.TabIndex = 5;
            btnClearFilter.Text = "Clear Filters";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30000;
            timer1.Tick += timer1_Tick;
            // 
            // groupFilters
            // 
            groupFilters.Controls.Add(label5);
            groupFilters.Controls.Add(nudSeatsFilter);
            groupFilters.Controls.Add(label4);
            groupFilters.Controls.Add(cmbFilterAirline);
            groupFilters.Controls.Add(label1);
            groupFilters.Controls.Add(label2);
            groupFilters.Controls.Add(dtpFilterDate);
            groupFilters.Controls.Add(btnClearFilter);
            groupFilters.Controls.Add(cmbFilterDestination);
            groupFilters.Location = new Point(583, 15);
            groupFilters.Name = "groupFilters";
            groupFilters.Size = new Size(362, 223);
            groupFilters.TabIndex = 8;
            groupFilters.TabStop = false;
            groupFilters.Text = "Filters";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 147);
            label5.Name = "label5";
            label5.Size = new Size(211, 25);
            label5.TabIndex = 11;
            label5.Text = "Minimum Seats Available";
            // 
            // nudSeatsFilter
            // 
            nudSeatsFilter.Location = new Point(223, 145);
            nudSeatsFilter.Name = "nudSeatsFilter";
            nudSeatsFilter.Size = new Size(130, 31);
            nudSeatsFilter.TabIndex = 10;
            nudSeatsFilter.ValueChanged += nudSeatsFilter_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 109);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 9;
            label4.Text = "Filter By Airlines";
            // 
            // cmbFilterAirline
            // 
            cmbFilterAirline.FormattingEnabled = true;
            cmbFilterAirline.Location = new Point(148, 106);
            cmbFilterAirline.Name = "cmbFilterAirline";
            cmbFilterAirline.Size = new Size(205, 33);
            cmbFilterAirline.TabIndex = 8;
            cmbFilterAirline.SelectedIndexChanged += cmbFilterAirline_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 6;
            label1.Text = "Filter By Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 7;
            label2.Text = "Filter By Date";
            // 
            // panelBooking
            // 
            panelBooking.Controls.Add(pictureBox1);
            panelBooking.Controls.Add(groupFilters);
            panelBooking.Controls.Add(groupBooking);
            panelBooking.Dock = DockStyle.Bottom;
            panelBooking.Location = new Point(0, 449);
            panelBooking.Name = "panelBooking";
            panelBooking.Size = new Size(957, 250);
            panelBooking.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._661_6611601_fm_flight_management_icon_hd_png_download;
            pictureBox1.Location = new Point(321, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // groupBooking
            // 
            groupBooking.Controls.Add(label3);
            groupBooking.Controls.Add(btnBook);
            groupBooking.Controls.Add(txtPassengerName);
            groupBooking.Location = new Point(12, 25);
            groupBooking.Name = "groupBooking";
            groupBooking.Size = new Size(303, 192);
            groupBooking.TabIndex = 3;
            groupBooking.TabStop = false;
            groupBooking.Text = "Booking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 53);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 3;
            label3.Text = "Passenger Booking";
            // 
            // listViewFlights
            // 
            listViewFlights.BackColor = SystemColors.GradientInactiveCaption;
            listViewFlights.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewFlights.FullRowSelect = true;
            listViewFlights.GridLines = true;
            listViewFlights.Location = new Point(0, 0);
            listViewFlights.Name = "listViewFlights";
            listViewFlights.Size = new Size(957, 449);
            listViewFlights.TabIndex = 8;
            listViewFlights.UseCompatibleStateImageBehavior = false;
            listViewFlights.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 699);
            Controls.Add(listViewFlights);
            Controls.Add(panelBooking);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flight Management System";
            Click += btnClearFilter_Click;
            groupFilters.ResumeLayout(false);
            groupFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSeatsFilter).EndInit();
            panelBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBooking.ResumeLayout(false);
            groupBooking.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPassengerName;
        private Button btnBook;
        private ComboBox cmbFilterDestination;
        private DateTimePicker dtpFilterDate;
        private Button btnClearFilter;
        private System.Windows.Forms.Timer timer1;
        private Panel panelBooking;
        private Label label1;
        private Label label2;
        private GroupBox groupFilters;
        private GroupBox groupBooking;
        private Label label3;
        private ComboBox cmbFilterAirline;
        private Label label4;
        private NumericUpDown nudSeatsFilter;
        private Label label5;
        private ListView listViewFlights;
        private PictureBox pictureBox1;
    }
}
