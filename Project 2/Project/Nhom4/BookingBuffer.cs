using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Nhom4
{
	/// <summary>
	/// Summary description for BookingBuffer.
	/// </summary>
	public class BookingBuffer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		SqlConnection cn;
		SqlCommand comd,comd1,comd2;
		DataSet ds=new DataSet();
		DataSet ds2=new DataSet();

		DataSet ds1=new DataSet();
		SqlDataAdapter adap,adap1;
		string str,str1,str2;
		int f,id,k,custid;
		private System.Windows.Forms.TextBox txt_cust_ID;
		private System.Windows.Forms.TextBox txt_cust_phone;
		private System.Windows.Forms.TextBox txt_cust_add;
		private System.Windows.Forms.DataGrid dataGrid_hide;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt_price;
		private System.Windows.Forms.TextBox txt_amount;
		private System.Windows.Forms.TextBox txt_buff_type;
		private System.Windows.Forms.TextBox txt_hide_id;
		private System.Windows.Forms.GroupBox grp_cust;
		private System.Windows.Forms.Label lbl_cust_Name;
		private System.Windows.Forms.Label llb_cust_id;
		private System.Windows.Forms.Label lbl_date_birth;
		private System.Windows.Forms.DateTimePicker dtp_birth;
		private System.Windows.Forms.Label llb_phone_num;
		private System.Windows.Forms.Label lbl_address;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.GroupBox grp_buf_booking;
		private System.Windows.Forms.ComboBox cbo_pay;
		private System.Windows.Forms.Label lbl_payment;
		private System.Windows.Forms.Label lbl_amount;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_booking;
		private System.Windows.Forms.Label lbl_price;
		private System.Windows.Forms.Label lbl_buf_type;
		private System.Windows.Forms.Label lbl_eating_date;
		private System.Windows.Forms.DateTimePicker dtp_booking;
		private System.Windows.Forms.Label lbl_booking_date;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_print;
		private System.Drawing.Printing.PrintDocument prnDoc_booking;
		private System.Windows.Forms.PrintPreviewDialog prnPrvdlg_booking;
		private System.Windows.Forms.TextBox txt_cust_name;
		private System.Windows.Forms.ComboBox cbo_cust_name;
		private System.Windows.Forms.RadioButton rad_cust_id;
		private System.Windows.Forms.RadioButton rad_cust_name;
		private System.Windows.Forms.DataGrid dbg_B_buf_detail;
		private System.Windows.Forms.DateTimePicker txt_eat_date;
	

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BookingBuffer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		 
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BookingBuffer));
			this.label1 = new System.Windows.Forms.Label();
			this.grp_cust = new System.Windows.Forms.GroupBox();
			this.rad_cust_id = new System.Windows.Forms.RadioButton();
			this.txt_cust_name = new System.Windows.Forms.TextBox();
			this.txt_cust_ID = new System.Windows.Forms.TextBox();
			this.lbl_cust_Name = new System.Windows.Forms.Label();
			this.llb_cust_id = new System.Windows.Forms.Label();
			this.txt_cust_phone = new System.Windows.Forms.TextBox();
			this.lbl_date_birth = new System.Windows.Forms.Label();
			this.dtp_birth = new System.Windows.Forms.DateTimePicker();
			this.llb_phone_num = new System.Windows.Forms.Label();
			this.lbl_address = new System.Windows.Forms.Label();
			this.txt_cust_add = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.cbo_cust_name = new System.Windows.Forms.ComboBox();
			this.rad_cust_name = new System.Windows.Forms.RadioButton();
			this.grp_buf_booking = new System.Windows.Forms.GroupBox();
			this.cbo_pay = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.lbl_payment = new System.Windows.Forms.Label();
			this.txt_amount = new System.Windows.Forms.TextBox();
			this.lbl_amount = new System.Windows.Forms.Label();
			this.dbg_B_buf_detail = new System.Windows.Forms.DataGrid();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_booking = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_price = new System.Windows.Forms.TextBox();
			this.lbl_price = new System.Windows.Forms.Label();
			this.lbl_buf_type = new System.Windows.Forms.Label();
			this.lbl_eating_date = new System.Windows.Forms.Label();
			this.dataGrid_hide = new System.Windows.Forms.DataGrid();
			this.label13 = new System.Windows.Forms.Label();
			this.txt_buff_type = new System.Windows.Forms.TextBox();
			this.dtp_booking = new System.Windows.Forms.DateTimePicker();
			this.lbl_booking_date = new System.Windows.Forms.Label();
			this.txt_hide_id = new System.Windows.Forms.TextBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_print = new System.Windows.Forms.Button();
			this.prnDoc_booking = new System.Drawing.Printing.PrintDocument();
			this.prnPrvdlg_booking = new System.Windows.Forms.PrintPreviewDialog();
			this.txt_eat_date = new System.Windows.Forms.DateTimePicker();
			this.grp_cust.SuspendLayout();
			this.grp_buf_booking.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_B_buf_detail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_hide)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(272, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Booking Buffet";
			// 
			// grp_cust
			// 
			this.grp_cust.Controls.Add(this.rad_cust_id);
			this.grp_cust.Controls.Add(this.txt_cust_name);
			this.grp_cust.Controls.Add(this.txt_cust_ID);
			this.grp_cust.Controls.Add(this.lbl_cust_Name);
			this.grp_cust.Controls.Add(this.llb_cust_id);
			this.grp_cust.Controls.Add(this.txt_cust_phone);
			this.grp_cust.Controls.Add(this.lbl_date_birth);
			this.grp_cust.Controls.Add(this.dtp_birth);
			this.grp_cust.Controls.Add(this.llb_phone_num);
			this.grp_cust.Controls.Add(this.lbl_address);
			this.grp_cust.Controls.Add(this.txt_cust_add);
			this.grp_cust.Controls.Add(this.btn_search);
			this.grp_cust.Controls.Add(this.cbo_cust_name);
			this.grp_cust.Controls.Add(this.rad_cust_name);
			this.grp_cust.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_cust.Location = new System.Drawing.Point(16, 56);
			this.grp_cust.Name = "grp_cust";
			this.grp_cust.Size = new System.Drawing.Size(704, 112);
			this.grp_cust.TabIndex = 1;
			this.grp_cust.TabStop = false;
			this.grp_cust.Text = "Infomation Customer ";
			this.grp_cust.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// rad_cust_id
			// 
			this.rad_cust_id.Checked = true;
			this.rad_cust_id.Location = new System.Drawing.Point(288, 24);
			this.rad_cust_id.Name = "rad_cust_id";
			this.rad_cust_id.Size = new System.Drawing.Size(16, 24);
			this.rad_cust_id.TabIndex = 23;
			this.rad_cust_id.TabStop = true;
			this.rad_cust_id.CheckedChanged += new System.EventHandler(this.rad_cust_id_CheckedChanged);
			// 
			// txt_cust_name
			// 
			this.txt_cust_name.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_cust_name.Location = new System.Drawing.Point(128, 48);
			this.txt_cust_name.Name = "txt_cust_name";
			this.txt_cust_name.Size = new System.Drawing.Size(160, 22);
			this.txt_cust_name.TabIndex = 3;
			this.txt_cust_name.Text = "";
			this.txt_cust_name.TextChanged += new System.EventHandler(this.txt_cust_name_TextChanged);
			// 
			// txt_cust_ID
			// 
			this.txt_cust_ID.Location = new System.Drawing.Point(128, 24);
			this.txt_cust_ID.Name = "txt_cust_ID";
			this.txt_cust_ID.Size = new System.Drawing.Size(160, 22);
			this.txt_cust_ID.TabIndex = 2;
			this.txt_cust_ID.Text = "";
			// 
			// lbl_cust_Name
			// 
			this.lbl_cust_Name.Location = new System.Drawing.Point(8, 53);
			this.lbl_cust_Name.Name = "lbl_cust_Name";
			this.lbl_cust_Name.Size = new System.Drawing.Size(120, 23);
			this.lbl_cust_Name.TabIndex = 1;
			this.lbl_cust_Name.Text = "Customer Name :";
			// 
			// llb_cust_id
			// 
			this.llb_cust_id.Location = new System.Drawing.Point(8, 24);
			this.llb_cust_id.Name = "llb_cust_id";
			this.llb_cust_id.TabIndex = 0;
			this.llb_cust_id.Text = "Customer ID :";
			// 
			// txt_cust_phone
			// 
			this.txt_cust_phone.Location = new System.Drawing.Point(416, 23);
			this.txt_cust_phone.Name = "txt_cust_phone";
			this.txt_cust_phone.Size = new System.Drawing.Size(152, 22);
			this.txt_cust_phone.TabIndex = 3;
			this.txt_cust_phone.Text = "";
			// 
			// lbl_date_birth
			// 
			this.lbl_date_birth.Location = new System.Drawing.Point(8, 75);
			this.lbl_date_birth.Name = "lbl_date_birth";
			this.lbl_date_birth.Size = new System.Drawing.Size(120, 23);
			this.lbl_date_birth.TabIndex = 1;
			this.lbl_date_birth.Text = "Date of Birth :";
			// 
			// dtp_birth
			// 
			this.dtp_birth.CustomFormat = "dd/MM/yyyy";
			this.dtp_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_birth.Location = new System.Drawing.Point(128, 72);
			this.dtp_birth.Name = "dtp_birth";
			this.dtp_birth.Size = new System.Drawing.Size(160, 22);
			this.dtp_birth.TabIndex = 6;
			this.dtp_birth.ValueChanged += new System.EventHandler(this.dateTim_birth_ValueChanged);
			// 
			// llb_phone_num
			// 
			this.llb_phone_num.Location = new System.Drawing.Point(312, 25);
			this.llb_phone_num.Name = "llb_phone_num";
			this.llb_phone_num.Size = new System.Drawing.Size(112, 23);
			this.llb_phone_num.TabIndex = 5;
			this.llb_phone_num.Text = "Phone Number :";
			// 
			// lbl_address
			// 
			this.lbl_address.Location = new System.Drawing.Point(311, 49);
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.Size = new System.Drawing.Size(73, 23);
			this.lbl_address.TabIndex = 5;
			this.lbl_address.Text = "Address :";
			// 
			// txt_cust_add
			// 
			this.txt_cust_add.Location = new System.Drawing.Point(416, 47);
			this.txt_cust_add.Name = "txt_cust_add";
			this.txt_cust_add.Size = new System.Drawing.Size(152, 22);
			this.txt_cust_add.TabIndex = 3;
			this.txt_cust_add.Text = "";
			// 
			// btn_search
			// 
			this.btn_search.BackColor = System.Drawing.SystemColors.Control;
			this.btn_search.Location = new System.Drawing.Point(598, 46);
			this.btn_search.Name = "btn_search";
			this.btn_search.TabIndex = 4;
			this.btn_search.Text = "Search";
			this.btn_search.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbo_cust_name
			// 
			this.cbo_cust_name.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbo_cust_name.Items.AddRange(new object[] {
															   "Cash",
															   "Credit Card"});
			this.cbo_cust_name.Location = new System.Drawing.Point(128, 48);
			this.cbo_cust_name.Name = "cbo_cust_name";
			this.cbo_cust_name.Size = new System.Drawing.Size(160, 24);
			this.cbo_cust_name.TabIndex = 22;
			this.cbo_cust_name.SelectedIndexChanged += new System.EventHandler(this.cbo_cust_name_SelectedIndexChanged);
			// 
			// rad_cust_name
			// 
			this.rad_cust_name.Location = new System.Drawing.Point(288, 48);
			this.rad_cust_name.Name = "rad_cust_name";
			this.rad_cust_name.Size = new System.Drawing.Size(16, 24);
			this.rad_cust_name.TabIndex = 23;
			this.rad_cust_name.Text = "radioButton1";
			this.rad_cust_name.CheckedChanged += new System.EventHandler(this.rad_cust_name_CheckedChanged);
			// 
			// grp_buf_booking
			// 
			this.grp_buf_booking.Controls.Add(this.cbo_pay);
			this.grp_buf_booking.Controls.Add(this.label14);
			this.grp_buf_booking.Controls.Add(this.lbl_payment);
			this.grp_buf_booking.Controls.Add(this.txt_amount);
			this.grp_buf_booking.Controls.Add(this.lbl_amount);
			this.grp_buf_booking.Controls.Add(this.dbg_B_buf_detail);
			this.grp_buf_booking.Controls.Add(this.btn_close);
			this.grp_buf_booking.Controls.Add(this.btn_booking);
			this.grp_buf_booking.Controls.Add(this.label8);
			this.grp_buf_booking.Controls.Add(this.txt_price);
			this.grp_buf_booking.Controls.Add(this.lbl_price);
			this.grp_buf_booking.Controls.Add(this.lbl_buf_type);
			this.grp_buf_booking.Controls.Add(this.lbl_eating_date);
			this.grp_buf_booking.Controls.Add(this.dataGrid_hide);
			this.grp_buf_booking.Controls.Add(this.label13);
			this.grp_buf_booking.Controls.Add(this.txt_buff_type);
			this.grp_buf_booking.Controls.Add(this.dtp_booking);
			this.grp_buf_booking.Controls.Add(this.lbl_booking_date);
			this.grp_buf_booking.Controls.Add(this.txt_hide_id);
			this.grp_buf_booking.Controls.Add(this.btn_update);
			this.grp_buf_booking.Controls.Add(this.btn_print);
			this.grp_buf_booking.Controls.Add(this.txt_eat_date);
			this.grp_buf_booking.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_buf_booking.Location = new System.Drawing.Point(16, 168);
			this.grp_buf_booking.Name = "grp_buf_booking";
			this.grp_buf_booking.Size = new System.Drawing.Size(704, 304);
			this.grp_buf_booking.TabIndex = 2;
			this.grp_buf_booking.TabStop = false;
			this.grp_buf_booking.Text = "Information Buffer Booking";
			this.grp_buf_booking.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// cbo_pay
			// 
			this.cbo_pay.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbo_pay.Items.AddRange(new object[] {
														 "Cash",
														 "Credit Card"});
			this.cbo_pay.Location = new System.Drawing.Point(127, 77);
			this.cbo_pay.Name = "cbo_pay";
			this.cbo_pay.Size = new System.Drawing.Size(120, 24);
			this.cbo_pay.TabIndex = 22;
			this.cbo_pay.SelectedIndexChanged += new System.EventHandler(this.combo_pay_SelectedIndexChanged);
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(259, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 23);
			this.label14.TabIndex = 21;
			this.label14.Text = "USD";
			// 
			// lbl_payment
			// 
			this.lbl_payment.Location = new System.Drawing.Point(8, 77);
			this.lbl_payment.Name = "lbl_payment";
			this.lbl_payment.Size = new System.Drawing.Size(72, 23);
			this.lbl_payment.TabIndex = 19;
			this.lbl_payment.Text = "Payment:";
			// 
			// txt_amount
			// 
			this.txt_amount.Location = new System.Drawing.Point(416, 49);
			this.txt_amount.Name = "txt_amount";
			this.txt_amount.Size = new System.Drawing.Size(152, 22);
			this.txt_amount.TabIndex = 17;
			this.txt_amount.Text = "";
			// 
			// lbl_amount
			// 
			this.lbl_amount.Location = new System.Drawing.Point(311, 52);
			this.lbl_amount.Name = "lbl_amount";
			this.lbl_amount.Size = new System.Drawing.Size(64, 23);
			this.lbl_amount.TabIndex = 16;
			this.lbl_amount.Text = "Amount :";
			// 
			// dbg_B_buf_detail
			// 
			this.dbg_B_buf_detail.CaptionText = "Booking Buffet Details";
			this.dbg_B_buf_detail.DataMember = "";
			this.dbg_B_buf_detail.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_B_buf_detail.Location = new System.Drawing.Point(8, 117);
			this.dbg_B_buf_detail.Name = "dbg_B_buf_detail";
			this.dbg_B_buf_detail.PreferredColumnWidth = 127;
			this.dbg_B_buf_detail.Size = new System.Drawing.Size(688, 128);
			this.dbg_B_buf_detail.TabIndex = 11;
			// 
			// btn_close
			// 
			this.btn_close.Location = new System.Drawing.Point(448, 264);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(75, 24);
			this.btn_close.TabIndex = 9;
			this.btn_close.Text = "Close";
			this.btn_close.Click += new System.EventHandler(this.button3_Click);
			// 
			// btn_booking
			// 
			this.btn_booking.Location = new System.Drawing.Point(280, 264);
			this.btn_booking.Name = "btn_booking";
			this.btn_booking.Size = new System.Drawing.Size(72, 24);
			this.btn_booking.TabIndex = 8;
			this.btn_booking.Text = "Booking";
			this.btn_booking.Click += new System.EventHandler(this.button2_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(592, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 16);
			this.label8.TabIndex = 6;
			this.label8.Text = "USD";
			// 
			// txt_price
			// 
			this.txt_price.Location = new System.Drawing.Point(416, 24);
			this.txt_price.Name = "txt_price";
			this.txt_price.Size = new System.Drawing.Size(152, 22);
			this.txt_price.TabIndex = 5;
			this.txt_price.Text = "";
			// 
			// lbl_price
			// 
			this.lbl_price.Location = new System.Drawing.Point(312, 26);
			this.lbl_price.Name = "lbl_price";
			this.lbl_price.Size = new System.Drawing.Size(48, 23);
			this.lbl_price.TabIndex = 4;
			this.lbl_price.Text = "Price :";
			// 
			// lbl_buf_type
			// 
			this.lbl_buf_type.Location = new System.Drawing.Point(8, 26);
			this.lbl_buf_type.Name = "lbl_buf_type";
			this.lbl_buf_type.TabIndex = 0;
			this.lbl_buf_type.Text = "Buffer Type :";
			// 
			// lbl_eating_date
			// 
			this.lbl_eating_date.Location = new System.Drawing.Point(8, 53);
			this.lbl_eating_date.Name = "lbl_eating_date";
			this.lbl_eating_date.TabIndex = 0;
			this.lbl_eating_date.Text = "Eating Date :";
			// 
			// dataGrid_hide
			// 
			this.dataGrid_hide.DataMember = "";
			this.dataGrid_hide.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_hide.Location = new System.Drawing.Point(120, 152);
			this.dataGrid_hide.Name = "dataGrid_hide";
			this.dataGrid_hide.TabIndex = 10;
			this.dataGrid_hide.Visible = false;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(577, 53);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(55, 23);
			this.label13.TabIndex = 16;
			this.label13.Text = "Person ";
			// 
			// txt_buff_type
			// 
			this.txt_buff_type.Location = new System.Drawing.Point(128, 24);
			this.txt_buff_type.Name = "txt_buff_type";
			this.txt_buff_type.Size = new System.Drawing.Size(160, 22);
			this.txt_buff_type.TabIndex = 5;
			this.txt_buff_type.Text = "";
			// 
			// dtp_booking
			// 
			this.dtp_booking.CustomFormat = "dd/MM/yyyy";
			this.dtp_booking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_booking.Location = new System.Drawing.Point(416, 75);
			this.dtp_booking.Name = "dtp_booking";
			this.dtp_booking.Size = new System.Drawing.Size(152, 22);
			this.dtp_booking.TabIndex = 6;
			this.dtp_booking.ValueChanged += new System.EventHandler(this.dateTim_booking_ValueChanged);
			// 
			// lbl_booking_date
			// 
			this.lbl_booking_date.Location = new System.Drawing.Point(310, 79);
			this.lbl_booking_date.Name = "lbl_booking_date";
			this.lbl_booking_date.TabIndex = 5;
			this.lbl_booking_date.Text = "Booking Date :";
			// 
			// txt_hide_id
			// 
			this.txt_hide_id.Location = new System.Drawing.Point(328, 160);
			this.txt_hide_id.Name = "txt_hide_id";
			this.txt_hide_id.Size = new System.Drawing.Size(40, 22);
			this.txt_hide_id.TabIndex = 5;
			this.txt_hide_id.Text = "";
			// 
			// btn_update
			// 
			this.btn_update.Enabled = false;
			this.btn_update.Location = new System.Drawing.Point(360, 264);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(72, 24);
			this.btn_update.TabIndex = 8;
			this.btn_update.Text = "Update";
			this.btn_update.Click += new System.EventHandler(this.b_update_Click);
			// 
			// btn_print
			// 
			this.btn_print.Enabled = false;
			this.btn_print.Location = new System.Drawing.Point(200, 264);
			this.btn_print.Name = "btn_print";
			this.btn_print.Size = new System.Drawing.Size(72, 24);
			this.btn_print.TabIndex = 8;
			this.btn_print.Text = "Print";
			this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
			// 
			// prnDoc_booking
			// 
			this.prnDoc_booking.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prnDoc_booking_PrintPage);
			// 
			// prnPrvdlg_booking
			// 
			this.prnPrvdlg_booking.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.prnPrvdlg_booking.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.prnPrvdlg_booking.ClientSize = new System.Drawing.Size(400, 300);
			this.prnPrvdlg_booking.Document = this.prnDoc_booking;
			this.prnPrvdlg_booking.Enabled = true;
			this.prnPrvdlg_booking.Icon = ((System.Drawing.Icon)(resources.GetObject("prnPrvdlg_booking.Icon")));
			this.prnPrvdlg_booking.Location = new System.Drawing.Point(148, 17);
			this.prnPrvdlg_booking.MinimumSize = new System.Drawing.Size(375, 250);
			this.prnPrvdlg_booking.Name = "prnPrvdlg_booking";
			this.prnPrvdlg_booking.TransparencyKey = System.Drawing.Color.Empty;
			this.prnPrvdlg_booking.Visible = false;
			// 
			// txt_eat_date
			// 
			this.txt_eat_date.CustomFormat = "dd/MM/yyyy";
			this.txt_eat_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txt_eat_date.Location = new System.Drawing.Point(128, 50);
			this.txt_eat_date.Name = "txt_eat_date";
			this.txt_eat_date.Size = new System.Drawing.Size(160, 22);
			this.txt_eat_date.TabIndex = 6;
			// 
			// BookingBuffer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(14, 32);
			this.ClientSize = new System.Drawing.Size(736, 494);
			this.Controls.Add(this.grp_buf_booking);
			this.Controls.Add(this.grp_cust);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ForeColor = System.Drawing.Color.Blue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BookingBuffer";
			this.Text = "BookingBuffer";
			this.Load += new System.EventHandler(this.BookingBuffer_Load);
			this.grp_cust.ResumeLayout(false);
			this.grp_buf_booking.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_B_buf_detail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_hide)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void BookingBuffer_Load(object sender, System.EventArgs e)
		{
			try
			{
				
				cn=Conetion.conet();
				if(cn.State==ConnectionState.Closed)
				{
					cn.Open();
				}
				//
				comd1=new SqlCommand("select buffet.Type_Buffet,buffet.Price,buffet.Buffet_Date,buffet.Buffet_ID,buffet.Status from Buffet",cn);
				adap1=new SqlDataAdapter(comd1);
				adap1.Fill(ds2,"foods");
				dbg_B_buf_detail.DataSource=ds2;
				dbg_B_buf_detail.DataMember="foods";

				//dataBinding
				dbg_B_buf_detail.DataSource=ds2.Tables["foods"];
				txt_buff_type.DataBindings.Clear();
				txt_price.DataBindings.Clear();
				txt_eat_date.DataBindings.Clear();
				
				txt_hide_id.DataBindings.Clear();
				//
				txt_buff_type.DataBindings.Add("Text",ds2.Tables["foods"],"Type_Buffet");
				txt_price.DataBindings.Add("Text",ds2.Tables["foods"],"Price");
				txt_eat_date.DataBindings.Add("Text",ds2.Tables["foods"],"Buffet_Date");
				txt_hide_id.DataBindings.Add("Text",ds2.Tables["foods"],"Buffet_ID");
				cn.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}
		/// <summary>
		/// Buton search here
		/// We can search by name or ID
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(rad_cust_id.Checked)
			{
				if(!Regex.IsMatch(txt_cust_ID.Text.Trim(),@"[0-9]+$"))
				{
					MessageBox.Show("You should enter digits in CustomerID, Please!");
				}
				else
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						try
						{
							int k=Convert.ToInt16(txt_cust_ID.Text.ToString());
							comd1=new SqlCommand("select customer_Id from customer where rtrim(customer_id)="+k,cn);
							f=Convert.ToInt16(comd1.ExecuteScalar());
						}
						catch(Exception ex)
						{
							f=0;
							Console.WriteLine(ex);
						}
						if(f==0)
						{						
							MessageBox.Show("This ID doesn't not exist!");
						
						}
						else
						{
							////
							id=Convert.ToInt16(txt_cust_ID.Text.Trim());
							ds1.Clear();
							comd=new SqlCommand("select customer.customer_id,customer.customer_name,customer.customer_phone,customer.date_of_birth,customer.customer_address from customer where customer.customer_id="+id,cn);						
							adap=new SqlDataAdapter(comd);
							txt_cust_name.Visible=true;

							adap.Fill(ds1,"customer");
							dataGrid_hide.DataSource=ds1;
							dataGrid_hide.DataMember="customer";
					
							//
							dataGrid_hide.DataSource=ds1.Tables["customer"];
							txt_cust_name.DataBindings.Clear();
							dtp_birth.DataBindings.Clear();
							txt_cust_phone.DataBindings.Clear();
						
							txt_cust_add.DataBindings.Clear();
							////
							txt_cust_name.DataBindings.Add("Text",ds1.Tables["Customer"],"Customer_Name");
							dtp_birth.DataBindings.Add("Text",ds1.Tables["Customer"],"Date_of_Birth");
							txt_cust_phone.DataBindings.Add("Text",ds1.Tables["Customer"],"Customer_Phone");
						
							txt_cust_add.DataBindings.Add("Text",ds1.Tables["Customer"],"Customer_Address");

						}
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			else if(rad_cust_name.Checked)
			{
				if(!Regex.IsMatch(txt_cust_name.Text.Trim(),@"[A-Za-z0-9 ]+$"))
				{
					MessageBox.Show("You should enter Customer Name in this field, Please!");
				}
				else
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}

							////
						string name=txt_cust_name.Text.Trim();
						///
						ds.Clear();

							comd=new SqlCommand("select customer_name,Customer_id from customer where rtrim(customer_name) like '"+name+"%'",cn);						
							adap=new SqlDataAdapter(comd);
							adap.Fill(ds,"customer");
							cbo_cust_name.DataSource=ds.Tables["customer"];
							cbo_cust_name.DisplayMember="customer_name";
						txt_cust_name.Visible=false;

						
					}	
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message+"hello");
					}	
				
				
				}
			}

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		// Button save

		private void button2_Click(object sender, System.EventArgs e)
		{
			txt_cust_name.Enabled=true;
			txt_cust_ID.Enabled=true;

				
				if(!Regex.IsMatch(txt_cust_name.Text.Trim(),@"[A-Za-z0-9 ]+$"))
			{
				MessageBox.Show("You should enter Name correctly!");
			}
			else
				if(str==null)
			{
				MessageBox.Show("Enter the birth day, please!");
			
			}
			else
				if(!Regex.IsMatch(txt_cust_phone.Text.Trim(),@"[0-9]+$"))
			{
				MessageBox.Show("Enter the phone numbers, please!");			
			}			
			else
				if(!Regex.IsMatch(txt_cust_add.Text.Trim(),@"[A-Za-z0-9 ]+$"))
			{
				MessageBox.Show("Enter the customer Address, please!");			
			}			

			else
				if(!Regex.IsMatch(txt_buff_type.Text.Trim(),@"[A-Za-z0-9 ]+$"))
			{
				MessageBox.Show("Select name buffet under, please!");			
			}			
			else
				if(txt_eat_date.Text.Trim()=="")
			{
				MessageBox.Show("Select date buffet under, please!");			
			}				
			else
				if(str2==null)
			{
				MessageBox.Show("Select the Payment, please!");			
			}
		
			else
				if(!Regex.IsMatch(txt_price.Text.Trim(),@"[0-9]+$"))
			{
				MessageBox.Show("Enter the price, please!");			
			}
			else
				if(!Regex.IsMatch(txt_amount.Text.Trim(),@"[0-9]+$"))
			{
				MessageBox.Show("How many persons, please!");			
			}
			else
				if(str1==null)
			{
				MessageBox.Show("Select the Booking date, please!");			
			}else
			if(txt_eat_date.Value.Day<dtp_booking.Value.Day)
			{
				MessageBox.Show("Eating date is not less than Today, Please!");

			}
			else
			{
				try
				{
					if(cn.State==ConnectionState.Closed)
					{
						cn.Open();
					}							
					try
					{
						comd=new SqlCommand("select max(BB_ID) from booking_buffet",cn);
						f=Convert.ToInt16(comd.ExecuteScalar());
						
					}
					catch(Exception ex)
					{
						f=0;
						Console.WriteLine(ex);
					}
					f=f+1;
					k=Convert.ToInt16(txt_hide_id.Text.ToString());
					int h=Convert.ToInt16(txt_amount.Text.ToString());
					comd2=new SqlCommand("set dateformat dmy insert into customer values('"+txt_cust_name.Text+"','"+txt_cust_add.Text+"',"+txt_cust_phone.Text+",'1','"+dtp_birth.Text+"','')",cn);
					comd2.ExecuteNonQuery();
					try
					{
						comd=new SqlCommand("select max(Customer_ID) from Customer",cn);
						custid=Convert.ToInt32(comd.ExecuteScalar());
						
					}
					catch(Exception ex1)
					{
						custid=0;
						Console.WriteLine(ex1);
					}
					txt_cust_ID.Text=custid.ToString();

					comd1=new SqlCommand("set dateformat dmy insert into booking_buffet values("+f+","+k+","+custid+",'"+txt_eat_date.Text+"','"+dtp_booking.Text+"','"+cbo_pay.Text+"',"+h+")",cn);										
					comd1.ExecuteNonQuery();
					MessageBox.Show("Record has been saved!");
					btn_print.Enabled=true;
					btn_update.Enabled=true;
					cn.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
					Console.WriteLine(ex);
				}
			}
		
		}
		public void cleartext()
		{
			txt_cust_add.Text="";
			txt_amount.Text="";
			txt_buff_type.Text="";
			txt_cust_ID.Text="";
			txt_cust_name.Text="";
			txt_cust_phone.Text="";
			txt_eat_date.Text="";
			txt_price.Text="";
			cbo_pay.Text="";
			dtp_birth.Text="";
			dtp_booking.Text="";
		}
		private void dateTim_birth_ValueChanged(object sender, System.EventArgs e)
		{
			str=dtp_birth.Text;
		}

		private void dateTim_booking_ValueChanged(object sender, System.EventArgs e)
		{
			str1=dtp_booking.Text;
		}

		private void combo_pay_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str2=cbo_pay.SelectedItem.ToString();
		}

		private void b_update_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				if(cn.State==ConnectionState.Closed)
				{
					cn.Open();
				}
				//
				comd1=new SqlCommand("select buffet.Type_Buffet,buffet.Price,buffet.Buffet_Date,buffet.Buffet_ID,buffet.Status from Buffet",cn);
				adap1=new SqlDataAdapter(comd1);
				adap1.Fill(ds2,"foods");
				dbg_B_buf_detail.DataSource=ds2;
				dbg_B_buf_detail.DataMember="foods";
				btn_update.Enabled=false;
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		
		}

		private void btn_print_Click(object sender, System.EventArgs e)
		{
			try
			{
				prnPrvdlg_booking.Document=prnDoc_booking;
				prnPrvdlg_booking.ShowDialog();
				btn_print.Enabled=false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void prnDoc_booking_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				e.Graphics.DrawString ("\t\tBooking Buffet\nDelta Hotel\n\n\n\n\n\n\n\n",new Font("Monotype Corsiva",20,FontStyle.Italic),Brushes.Blue,160,125);
				e.Graphics.DrawString ("\n\n\t\t45 Tran Hung Dao street CT.City VN\n\t\t Phone:0710464006-0945706007\n\nCustomer ID:\t"+txt_cust_ID.Text+"\nCustomer Name:\t"+txt_cust_name.Text+"\n Birth of Date:\t"+dtp_birth.Text+"\n Phone Number:\t"+txt_cust_phone.Text+"\n Booking Date:\t"+dtp_booking.Text+"\n Name Buffet:\t"+txt_buff_type.Text+"\n Eating Date:\t"+txt_eat_date.Text+"\n Price:\t\t"+txt_price.Text+" USD\n Amount:\t\t"+txt_amount.Text+" Persons\n Payment:\t\t"+cbo_pay.Text,new Font("Monotype Corsiva",16,FontStyle.Italic),Brushes.Black,160,125);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void cbo_cust_name_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str=cbo_cust_name.Text.Trim().ToString();
			if(str!=null)
			{
				try
				{
					if(cn.State==ConnectionState.Closed)
					{
						cn.Open();
					}
					try
					{
						comd1=new SqlCommand("select customer_Id from customer where rtrim(customer_name)='"+str+"'",cn);
						f=Convert.ToInt16(comd1.ExecuteScalar());
					}
					catch(Exception ex)
					{
						f=0;
						Console.WriteLine(ex);
					}
					
					
						txt_cust_name.Visible=true;
						////
						ds1.Clear();
						comd=new SqlCommand("select customer.customer_id,customer.customer_name,customer.customer_phone,customer.date_of_birth,customer.customer_address from customer where customer.customer_id="+f,cn);						
						adap=new SqlDataAdapter(comd);
							
						adap.Fill(ds1,"customer");
						dataGrid_hide.DataSource=ds1;
						dataGrid_hide.DataMember="customer";
					
						//
						dataGrid_hide.DataSource=ds1.Tables["customer"];
						txt_cust_name.DataBindings.Clear();
						dtp_birth.DataBindings.Clear();
						txt_cust_phone.DataBindings.Clear();
					txt_cust_ID.DataBindings.Clear();
						
						txt_cust_add.DataBindings.Clear();
						////
						txt_cust_name.DataBindings.Add("Text",ds1.Tables["Customer"],"Customer_Name");
						dtp_birth.DataBindings.Add("Text",ds1.Tables["Customer"],"Date_of_Birth");
						txt_cust_phone.DataBindings.Add("Text",ds1.Tables["Customer"],"Customer_Phone");
						
						txt_cust_add.DataBindings.Add("Text",ds1.Tables["Customer"],"Customer_Address");
					txt_cust_ID.DataBindings.Add("Text",ds1.Tables["Customer"],"Customer_ID");

					
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
		
			}
		}

		private void rad_cust_name_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_cust_name.Visible=true;
			txt_cust_name.Enabled=true;
			txt_cust_ID.Enabled=false;

		}

		private void txt_cust_name_TextChanged(object sender, System.EventArgs e)
		{
			txt_cust_name.Update();
		}

		private void rad_cust_id_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_cust_name.Enabled=false;
			txt_cust_ID.Enabled=true;
		}
	}
}
