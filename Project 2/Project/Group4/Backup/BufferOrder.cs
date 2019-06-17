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
	/// Summary description for BufferOrder.
	/// </summary>
	public class BufferOrder : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grp_cutomer;
		private System.Windows.Forms.Label lbl_buffeorder;
		private System.Windows.Forms.Label lbl_customerName;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.GroupBox grp_buffer;
		private System.Windows.Forms.Label lbl_typebuffer;
		private System.Windows.Forms.GroupBox grp_order;
		private System.Windows.Forms.Label lbl_Namebuffer;
		private System.Windows.Forms.Label lbl_eatingdate;
		private System.Windows.Forms.Label lbl_price;
		private System.Windows.Forms.Label lbl_quantity;
		private System.Windows.Forms.GroupBox grp_Listfood;
		private System.Windows.Forms.TextBox txt_price;
		SqlConnection cn;
		SqlCommand comd,comd1,comd2,comd4;
		SqlDataAdapter adap,adap1,adap2,adap4;
		DataSet ds=new DataSet();
		DataSet ds2=new DataSet();
		DataSet ds1=new DataSet();
		DataSet ds5=new DataSet();
		string str,str1,str2;
		int f,id,custid;
		
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_checkoutDate;
		private System.Windows.Forms.TextBox txt_buffetname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_Order;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_cust_ID;
		private System.Windows.Forms.DataGrid dataGrid_hide;
		private System.Windows.Forms.TextBox txt_cus_birth;
		private System.Windows.Forms.TextBox txt_cust_phone;
		private System.Windows.Forms.TextBox txt_hide_ID;
		private System.Windows.Forms.TextBox txt_amount;
		private System.Windows.Forms.Button btn_print;
		private System.Windows.Forms.Label lbl_phone_num;
		private System.Windows.Forms.Label lbl_date_birth;
		private System.Windows.Forms.Label lbl_b_date;
		private System.Windows.Forms.DataGrid dbg_list_buf;
		private System.Windows.Forms.ComboBox cbo_type_buf;
		private System.Windows.Forms.DataGrid dbg_list_food;
		private System.Windows.Forms.PrintPreviewDialog prnPrvdlg_order;
		private System.Drawing.Printing.PrintDocument prnDoc_order;
		private System.Windows.Forms.DateTimePicker dtp_date_eating;
		private System.Windows.Forms.ComboBox cbo_pay;
		private System.Windows.Forms.RadioButton rad_cust_name;
		private System.Windows.Forms.RadioButton rad_cust_id;
		private System.Windows.Forms.ComboBox cbo_cust_name;
		private System.Windows.Forms.TextBox txt_custom_name;
		private System.Windows.Forms.DateTimePicker txt_booking_date;
		private System.Windows.Forms.DateTimePicker dtb_today;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BufferOrder()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BufferOrder));
			this.grp_cutomer = new System.Windows.Forms.GroupBox();
			this.rad_cust_name = new System.Windows.Forms.RadioButton();
			this.lbl_checkoutDate = new System.Windows.Forms.Label();
			this.txt_custom_name = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.txt_cus_birth = new System.Windows.Forms.TextBox();
			this.txt_cust_ID = new System.Windows.Forms.TextBox();
			this.lbl_phone_num = new System.Windows.Forms.Label();
			this.lbl_customerName = new System.Windows.Forms.Label();
			this.lbl_date_birth = new System.Windows.Forms.Label();
			this.txt_cust_phone = new System.Windows.Forms.TextBox();
			this.lbl_b_date = new System.Windows.Forms.Label();
			this.rad_cust_id = new System.Windows.Forms.RadioButton();
			this.cbo_cust_name = new System.Windows.Forms.ComboBox();
			this.lbl_buffeorder = new System.Windows.Forms.Label();
			this.grp_buffer = new System.Windows.Forms.GroupBox();
			this.dbg_list_buf = new System.Windows.Forms.DataGrid();
			this.cbo_type_buf = new System.Windows.Forms.ComboBox();
			this.lbl_typebuffer = new System.Windows.Forms.Label();
			this.dataGrid_hide = new System.Windows.Forms.DataGrid();
			this.grp_order = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbo_pay = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dtp_date_eating = new System.Windows.Forms.DateTimePicker();
			this.txt_amount = new System.Windows.Forms.TextBox();
			this.txt_price = new System.Windows.Forms.TextBox();
			this.lbl_quantity = new System.Windows.Forms.Label();
			this.lbl_price = new System.Windows.Forms.Label();
			this.lbl_eatingdate = new System.Windows.Forms.Label();
			this.lbl_Namebuffer = new System.Windows.Forms.Label();
			this.txt_buffetname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.grp_Listfood = new System.Windows.Forms.GroupBox();
			this.dbg_list_food = new System.Windows.Forms.DataGrid();
			this.txt_hide_ID = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_Order = new System.Windows.Forms.Button();
			this.btn_print = new System.Windows.Forms.Button();
			this.prnPrvdlg_order = new System.Windows.Forms.PrintPreviewDialog();
			this.prnDoc_order = new System.Drawing.Printing.PrintDocument();
			this.txt_booking_date = new System.Windows.Forms.DateTimePicker();
			this.dtb_today = new System.Windows.Forms.DateTimePicker();
			this.grp_cutomer.SuspendLayout();
			this.grp_buffer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_list_buf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_hide)).BeginInit();
			this.grp_order.SuspendLayout();
			this.grp_Listfood.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_list_food)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grp_cutomer
			// 
			this.grp_cutomer.Controls.Add(this.rad_cust_name);
			this.grp_cutomer.Controls.Add(this.lbl_checkoutDate);
			this.grp_cutomer.Controls.Add(this.txt_custom_name);
			this.grp_cutomer.Controls.Add(this.btn_search);
			this.grp_cutomer.Controls.Add(this.txt_cus_birth);
			this.grp_cutomer.Controls.Add(this.txt_cust_ID);
			this.grp_cutomer.Controls.Add(this.lbl_phone_num);
			this.grp_cutomer.Controls.Add(this.lbl_customerName);
			this.grp_cutomer.Controls.Add(this.lbl_date_birth);
			this.grp_cutomer.Controls.Add(this.txt_cust_phone);
			this.grp_cutomer.Controls.Add(this.lbl_b_date);
			this.grp_cutomer.Controls.Add(this.rad_cust_id);
			this.grp_cutomer.Controls.Add(this.cbo_cust_name);
			this.grp_cutomer.Controls.Add(this.txt_booking_date);
			this.grp_cutomer.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_cutomer.ForeColor = System.Drawing.Color.Blue;
			this.grp_cutomer.Location = new System.Drawing.Point(8, 56);
			this.grp_cutomer.Name = "grp_cutomer";
			this.grp_cutomer.Size = new System.Drawing.Size(320, 184);
			this.grp_cutomer.TabIndex = 0;
			this.grp_cutomer.TabStop = false;
			this.grp_cutomer.Text = "Infomaion Customer";
			// 
			// rad_cust_name
			// 
			this.rad_cust_name.Location = new System.Drawing.Point(121, 65);
			this.rad_cust_name.Name = "rad_cust_name";
			this.rad_cust_name.Size = new System.Drawing.Size(16, 24);
			this.rad_cust_name.TabIndex = 24;
			this.rad_cust_name.CheckedChanged += new System.EventHandler(this.rad_cust_name_CheckedChanged);
			// 
			// lbl_checkoutDate
			// 
			this.lbl_checkoutDate.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_checkoutDate.ForeColor = System.Drawing.Color.Blue;
			this.lbl_checkoutDate.Location = new System.Drawing.Point(8, 40);
			this.lbl_checkoutDate.Name = "lbl_checkoutDate";
			this.lbl_checkoutDate.Size = new System.Drawing.Size(112, 23);
			this.lbl_checkoutDate.TabIndex = 8;
			this.lbl_checkoutDate.Text = "Customer ID:";
			// 
			// txt_custom_name
			// 
			this.txt_custom_name.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_custom_name.Location = new System.Drawing.Point(136, 64);
			this.txt_custom_name.Name = "txt_custom_name";
			this.txt_custom_name.Size = new System.Drawing.Size(144, 22);
			this.txt_custom_name.TabIndex = 9;
			this.txt_custom_name.Text = "";
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(239, 39);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(64, 23);
			this.btn_search.TabIndex = 7;
			this.btn_search.Text = "Search";
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// txt_cus_birth
			// 
			this.txt_cus_birth.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_cus_birth.Location = new System.Drawing.Point(136, 88);
			this.txt_cus_birth.Name = "txt_cus_birth";
			this.txt_cus_birth.Size = new System.Drawing.Size(144, 22);
			this.txt_cus_birth.TabIndex = 6;
			this.txt_cus_birth.Text = "";
			// 
			// txt_cust_ID
			// 
			this.txt_cust_ID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_cust_ID.Location = new System.Drawing.Point(136, 40);
			this.txt_cust_ID.Name = "txt_cust_ID";
			this.txt_cust_ID.TabIndex = 5;
			this.txt_cust_ID.Text = "";
			// 
			// lbl_phone_num
			// 
			this.lbl_phone_num.Location = new System.Drawing.Point(8, 112);
			this.lbl_phone_num.Name = "lbl_phone_num";
			this.lbl_phone_num.Size = new System.Drawing.Size(112, 23);
			this.lbl_phone_num.TabIndex = 3;
			this.lbl_phone_num.Text = "Phone Number:";
			// 
			// lbl_customerName
			// 
			this.lbl_customerName.Location = new System.Drawing.Point(8, 64);
			this.lbl_customerName.Name = "lbl_customerName";
			this.lbl_customerName.Size = new System.Drawing.Size(112, 23);
			this.lbl_customerName.TabIndex = 1;
			this.lbl_customerName.Text = "Customer Name:";
			// 
			// lbl_date_birth
			// 
			this.lbl_date_birth.Location = new System.Drawing.Point(8, 88);
			this.lbl_date_birth.Name = "lbl_date_birth";
			this.lbl_date_birth.Size = new System.Drawing.Size(112, 23);
			this.lbl_date_birth.TabIndex = 1;
			this.lbl_date_birth.Text = "Date of Birth:";
			// 
			// txt_cust_phone
			// 
			this.txt_cust_phone.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_cust_phone.Location = new System.Drawing.Point(136, 112);
			this.txt_cust_phone.Name = "txt_cust_phone";
			this.txt_cust_phone.Size = new System.Drawing.Size(144, 22);
			this.txt_cust_phone.TabIndex = 6;
			this.txt_cust_phone.Text = "";
			// 
			// lbl_b_date
			// 
			this.lbl_b_date.Location = new System.Drawing.Point(8, 136);
			this.lbl_b_date.Name = "lbl_b_date";
			this.lbl_b_date.Size = new System.Drawing.Size(112, 23);
			this.lbl_b_date.TabIndex = 3;
			this.lbl_b_date.Text = "Booking Date:";
			// 
			// rad_cust_id
			// 
			this.rad_cust_id.Checked = true;
			this.rad_cust_id.Location = new System.Drawing.Point(121, 40);
			this.rad_cust_id.Name = "rad_cust_id";
			this.rad_cust_id.Size = new System.Drawing.Size(16, 24);
			this.rad_cust_id.TabIndex = 24;
			this.rad_cust_id.TabStop = true;
			this.rad_cust_id.Text = "radioButton1";
			this.rad_cust_id.CheckedChanged += new System.EventHandler(this.rad_cust_id_CheckedChanged);
			// 
			// cbo_cust_name
			// 
			this.cbo_cust_name.Location = new System.Drawing.Point(136, 64);
			this.cbo_cust_name.Name = "cbo_cust_name";
			this.cbo_cust_name.Size = new System.Drawing.Size(144, 24);
			this.cbo_cust_name.TabIndex = 9;
			this.cbo_cust_name.SelectedIndexChanged += new System.EventHandler(this.cbo_cust_name_SelectedIndexChanged);
			// 
			// lbl_buffeorder
			// 
			this.lbl_buffeorder.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_buffeorder.ForeColor = System.Drawing.Color.Blue;
			this.lbl_buffeorder.Location = new System.Drawing.Point(241, 8);
			this.lbl_buffeorder.Name = "lbl_buffeorder";
			this.lbl_buffeorder.Size = new System.Drawing.Size(176, 40);
			this.lbl_buffeorder.TabIndex = 1;
			this.lbl_buffeorder.Text = "Buffet Order";
			// 
			// grp_buffer
			// 
			this.grp_buffer.Controls.Add(this.dbg_list_buf);
			this.grp_buffer.Controls.Add(this.cbo_type_buf);
			this.grp_buffer.Controls.Add(this.lbl_typebuffer);
			this.grp_buffer.Controls.Add(this.dataGrid_hide);
			this.grp_buffer.Controls.Add(this.dtb_today);
			this.grp_buffer.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_buffer.ForeColor = System.Drawing.Color.Blue;
			this.grp_buffer.Location = new System.Drawing.Point(328, 56);
			this.grp_buffer.Name = "grp_buffer";
			this.grp_buffer.Size = new System.Drawing.Size(320, 184);
			this.grp_buffer.TabIndex = 2;
			this.grp_buffer.TabStop = false;
			this.grp_buffer.Text = "Infomation Buffet";
			// 
			// dbg_list_buf
			// 
			this.dbg_list_buf.CaptionText = "Buffet Details";
			this.dbg_list_buf.DataMember = "";
			this.dbg_list_buf.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_list_buf.Location = new System.Drawing.Point(8, 48);
			this.dbg_list_buf.Name = "dbg_list_buf";
			this.dbg_list_buf.PreferredColumnWidth = 90;
			this.dbg_list_buf.Size = new System.Drawing.Size(304, 128);
			this.dbg_list_buf.TabIndex = 2;
			// 
			// cbo_type_buf
			// 
			this.cbo_type_buf.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbo_type_buf.Items.AddRange(new object[] {
															  "Breakfast",
															  "Lunch",
															  "Dinner"});
			this.cbo_type_buf.Location = new System.Drawing.Point(104, 16);
			this.cbo_type_buf.Name = "cbo_type_buf";
			this.cbo_type_buf.Size = new System.Drawing.Size(144, 24);
			this.cbo_type_buf.TabIndex = 1;
			this.cbo_type_buf.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// lbl_typebuffer
			// 
			this.lbl_typebuffer.Location = new System.Drawing.Point(8, 16);
			this.lbl_typebuffer.Name = "lbl_typebuffer";
			this.lbl_typebuffer.Size = new System.Drawing.Size(80, 23);
			this.lbl_typebuffer.TabIndex = 0;
			this.lbl_typebuffer.Text = "Type Buffet";
			// 
			// dataGrid_hide
			// 
			this.dataGrid_hide.CaptionText = "hiden";
			this.dataGrid_hide.DataMember = "";
			this.dataGrid_hide.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_hide.Location = new System.Drawing.Point(72, 80);
			this.dataGrid_hide.Name = "dataGrid_hide";
			this.dataGrid_hide.TabIndex = 9;
			this.dataGrid_hide.Visible = false;
			// 
			// grp_order
			// 
			this.grp_order.Controls.Add(this.label4);
			this.grp_order.Controls.Add(this.cbo_pay);
			this.grp_order.Controls.Add(this.label8);
			this.grp_order.Controls.Add(this.label6);
			this.grp_order.Controls.Add(this.dtp_date_eating);
			this.grp_order.Controls.Add(this.txt_amount);
			this.grp_order.Controls.Add(this.txt_price);
			this.grp_order.Controls.Add(this.lbl_quantity);
			this.grp_order.Controls.Add(this.lbl_price);
			this.grp_order.Controls.Add(this.lbl_eatingdate);
			this.grp_order.Controls.Add(this.lbl_Namebuffer);
			this.grp_order.Controls.Add(this.txt_buffetname);
			this.grp_order.Controls.Add(this.label3);
			this.grp_order.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_order.ForeColor = System.Drawing.Color.Blue;
			this.grp_order.Location = new System.Drawing.Point(8, 248);
			this.grp_order.Name = "grp_order";
			this.grp_order.Size = new System.Drawing.Size(320, 152);
			this.grp_order.TabIndex = 3;
			this.grp_order.TabStop = false;
			this.grp_order.Text = "Infomation Buffet Order";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(237, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "USD";
			// 
			// cbo_pay
			// 
			this.cbo_pay.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbo_pay.Items.AddRange(new object[] {
														 "Cash",
														 "Credit Card"});
			this.cbo_pay.Location = new System.Drawing.Point(120, 120);
			this.cbo_pay.Name = "cbo_pay";
			this.cbo_pay.Size = new System.Drawing.Size(104, 24);
			this.cbo_pay.TabIndex = 17;
			this.cbo_pay.SelectedIndexChanged += new System.EventHandler(this.combo_pay_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Payment:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(236, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 19);
			this.label6.TabIndex = 14;
			this.label6.Text = "USD";
			// 
			// dtp_date_eating
			// 
			this.dtp_date_eating.CustomFormat = "dd/MM/yyyy";
			this.dtp_date_eating.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_date_eating.Location = new System.Drawing.Point(120, 48);
			this.dtp_date_eating.Name = "dtp_date_eating";
			this.dtp_date_eating.Size = new System.Drawing.Size(144, 22);
			this.dtp_date_eating.TabIndex = 8;
			this.dtp_date_eating.ValueChanged += new System.EventHandler(this.date_eating_ValueChanged);
			// 
			// txt_amount
			// 
			this.txt_amount.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_amount.Location = new System.Drawing.Point(120, 96);
			this.txt_amount.Name = "txt_amount";
			this.txt_amount.TabIndex = 7;
			this.txt_amount.Text = "";
			// 
			// txt_price
			// 
			this.txt_price.Enabled = false;
			this.txt_price.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_price.Location = new System.Drawing.Point(120, 72);
			this.txt_price.Name = "txt_price";
			this.txt_price.TabIndex = 6;
			this.txt_price.Text = "";
			// 
			// lbl_quantity
			// 
			this.lbl_quantity.Location = new System.Drawing.Point(8, 99);
			this.lbl_quantity.Name = "lbl_quantity";
			this.lbl_quantity.TabIndex = 3;
			this.lbl_quantity.Text = "Amount:";
			// 
			// lbl_price
			// 
			this.lbl_price.Location = new System.Drawing.Point(8, 75);
			this.lbl_price.Name = "lbl_price";
			this.lbl_price.TabIndex = 2;
			this.lbl_price.Text = "Price:";
			// 
			// lbl_eatingdate
			// 
			this.lbl_eatingdate.Location = new System.Drawing.Point(8, 51);
			this.lbl_eatingdate.Name = "lbl_eatingdate";
			this.lbl_eatingdate.TabIndex = 1;
			this.lbl_eatingdate.Text = "Eating Date:";
			// 
			// lbl_Namebuffer
			// 
			this.lbl_Namebuffer.Location = new System.Drawing.Point(8, 26);
			this.lbl_Namebuffer.Name = "lbl_Namebuffer";
			this.lbl_Namebuffer.TabIndex = 0;
			this.lbl_Namebuffer.Text = "Name Buffet:";
			// 
			// txt_buffetname
			// 
			this.txt_buffetname.Enabled = false;
			this.txt_buffetname.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_buffetname.Location = new System.Drawing.Point(120, 24);
			this.txt_buffetname.Name = "txt_buffetname";
			this.txt_buffetname.Size = new System.Drawing.Size(144, 22);
			this.txt_buffetname.TabIndex = 6;
			this.txt_buffetname.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(221, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Person";
			// 
			// grp_Listfood
			// 
			this.grp_Listfood.Controls.Add(this.dbg_list_food);
			this.grp_Listfood.Controls.Add(this.txt_hide_ID);
			this.grp_Listfood.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_Listfood.ForeColor = System.Drawing.Color.Blue;
			this.grp_Listfood.Location = new System.Drawing.Point(328, 248);
			this.grp_Listfood.Name = "grp_Listfood";
			this.grp_Listfood.Size = new System.Drawing.Size(320, 152);
			this.grp_Listfood.TabIndex = 4;
			this.grp_Listfood.TabStop = false;
			this.grp_Listfood.Text = "List Foods";
			// 
			// dbg_list_food
			// 
			this.dbg_list_food.CaptionText = "List Foods";
			this.dbg_list_food.DataMember = "";
			this.dbg_list_food.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_list_food.Location = new System.Drawing.Point(8, 18);
			this.dbg_list_food.Name = "dbg_list_food";
			this.dbg_list_food.PreferredColumnWidth = 90;
			this.dbg_list_food.Size = new System.Drawing.Size(304, 127);
			this.dbg_list_food.TabIndex = 1;
			// 
			// txt_hide_ID
			// 
			this.txt_hide_ID.Enabled = false;
			this.txt_hide_ID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_hide_ID.Location = new System.Drawing.Point(8, 72);
			this.txt_hide_ID.Name = "txt_hide_ID";
			this.txt_hide_ID.TabIndex = 7;
			this.txt_hide_ID.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_close);
			this.groupBox1.Controls.Add(this.btn_cancel);
			this.groupBox1.Controls.Add(this.btn_Order);
			this.groupBox1.Controls.Add(this.btn_print);
			this.groupBox1.Location = new System.Drawing.Point(144, 408);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(368, 64);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// btn_close
			// 
			this.btn_close.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_close.ForeColor = System.Drawing.Color.Blue;
			this.btn_close.Location = new System.Drawing.Point(278, 24);
			this.btn_close.Name = "btn_close";
			this.btn_close.TabIndex = 10;
			this.btn_close.Text = "Cancel";
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Enabled = false;
			this.btn_cancel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_cancel.ForeColor = System.Drawing.Color.Blue;
			this.btn_cancel.Location = new System.Drawing.Point(190, 24);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.TabIndex = 9;
			this.btn_cancel.Text = "Clear";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_Order
			// 
			this.btn_Order.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Order.ForeColor = System.Drawing.Color.Blue;
			this.btn_Order.Location = new System.Drawing.Point(103, 24);
			this.btn_Order.Name = "btn_Order";
			this.btn_Order.TabIndex = 8;
			this.btn_Order.Text = "Order";
			this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
			// 
			// btn_print
			// 
			this.btn_print.Enabled = false;
			this.btn_print.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_print.ForeColor = System.Drawing.Color.Blue;
			this.btn_print.Location = new System.Drawing.Point(14, 24);
			this.btn_print.Name = "btn_print";
			this.btn_print.TabIndex = 8;
			this.btn_print.Text = "Print";
			this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
			// 
			// prnPrvdlg_order
			// 
			this.prnPrvdlg_order.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.prnPrvdlg_order.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.prnPrvdlg_order.ClientSize = new System.Drawing.Size(400, 300);
			this.prnPrvdlg_order.Document = this.prnDoc_order;
			this.prnPrvdlg_order.Enabled = true;
			this.prnPrvdlg_order.Icon = ((System.Drawing.Icon)(resources.GetObject("prnPrvdlg_order.Icon")));
			this.prnPrvdlg_order.Location = new System.Drawing.Point(137, 17);
			this.prnPrvdlg_order.MinimumSize = new System.Drawing.Size(375, 250);
			this.prnPrvdlg_order.Name = "prnPrvdlg_order";
			this.prnPrvdlg_order.TransparencyKey = System.Drawing.Color.Empty;
			this.prnPrvdlg_order.Visible = false;
			// 
			// prnDoc_order
			// 
			this.prnDoc_order.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prnDoc_order_PrintPage);
			// 
			// txt_booking_date
			// 
			this.txt_booking_date.CustomFormat = "dd/MM/yyyy";
			this.txt_booking_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txt_booking_date.Location = new System.Drawing.Point(136, 136);
			this.txt_booking_date.Name = "txt_booking_date";
			this.txt_booking_date.Size = new System.Drawing.Size(144, 22);
			this.txt_booking_date.TabIndex = 8;
			// 
			// dtb_today
			// 
			this.dtb_today.CustomFormat = "dd/MM/yyyy";
			this.dtb_today.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtb_today.Location = new System.Drawing.Point(72, 104);
			this.dtb_today.Name = "dtb_today";
			this.dtb_today.Size = new System.Drawing.Size(144, 22);
			this.dtb_today.TabIndex = 8;
			// 
			// BufferOrder
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 486);
			this.Controls.Add(this.grp_Listfood);
			this.Controls.Add(this.grp_order);
			this.Controls.Add(this.grp_buffer);
			this.Controls.Add(this.lbl_buffeorder);
			this.Controls.Add(this.grp_cutomer);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BufferOrder";
			this.Text = "BuffetOrder";
			this.Load += new System.EventHandler(this.BufferOrder_Load);
			this.grp_cutomer.ResumeLayout(false);
			this.grp_buffer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_list_buf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_hide)).EndInit();
			this.grp_order.ResumeLayout(false);
			this.grp_Listfood.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_list_food)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void BufferOrder_Load(object sender, System.EventArgs e)
		{
			try
			{
				cn=Conetion.conet();
				////////////////////////////
				ds2.Clear();
				comd2=new SqlCommand("select distinct(Type_food) from foods",cn);				
				adap2=new SqlDataAdapter(comd2);
				adap2.Fill(ds2,"type_fo");
				cbo_type_buf.DataSource=ds2.Tables["type_fo"];
				cbo_type_buf.DisplayMember="Type_food";

				///
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		// combox buffer detail to recieve the record from 
		// database fill on combobox , data grid and buffet text box

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str=cbo_type_buf.Text;
			
			try
			{
				if(cn.State==ConnectionState.Closed)
				{
					cn.Open();
				}
				ds1.Clear();
				ds.Clear();
				////
				comd=new SqlCommand("select foods.Type_Food,foods.Name_Food,foods.Country_Food,foods.Food_ID from foods where rtrim(Type_food)='"+cbo_type_buf.Text.Trim()+"'",cn);
				adap=new SqlDataAdapter(comd);
				adap.Fill(ds,"data");
				dbg_list_food.DataSource=ds;
				dbg_list_food.DataMember="data";

				comd1=new SqlCommand("select Type_Buffet,Price,Buffet_Date,Buffet_ID,Status from buffet where rtrim(Type_Buffet)='"+str.Trim()+"'",cn);
				adap1=new SqlDataAdapter(comd1);
				adap1.Fill(ds1,"foods");
				dbg_list_buf.DataSource=ds1;
				dbg_list_buf.DataMember="foods";

				//dataBinding
				dbg_list_buf.DataSource=ds1.Tables["foods"];
				txt_buffetname.DataBindings.Clear();
				txt_price.DataBindings.Clear();
				dtp_date_eating.DataBindings.Clear();
				txt_hide_ID.DataBindings.Clear();
				//
				txt_buffetname.DataBindings.Add("Text",ds1.Tables["foods"],"Type_Buffet");
				txt_price.DataBindings.Add("Text",ds1.Tables["foods"],"Price");
				dtp_date_eating.DataBindings.Add("Text",ds1.Tables["foods"],"Buffet_Date");
				txt_hide_ID.DataBindings.Add("Text",ds1.Tables["foods"],"Buffet_ID");
				///

				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			
		}

		private void btn_close_Click_1(object sender, System.EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// Search button to fill Customer information into the text box 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_search_Click(object sender, System.EventArgs e)
		{
			if(rad_cust_id.Checked)
			{
				if(!Regex.IsMatch(txt_cust_ID.Text.Trim(),@"[0-9]+$"))
				{
					MessageBox.Show("You should enter digits in this field, Please!");
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
							cleartext();
						}
						else
						{
						
							txt_buffetname.Text="";
							txt_price.Text="";
							txt_amount.Text="";						
							txt_custom_name.Text="";
							////
							id=Convert.ToInt16(txt_cust_ID.Text.Trim());
							comd=new SqlCommand("select customer.customer_id,customer.customer_name,customer.customer_phone,customer.date_of_birth,Booking_buffet.bb_date,booking_buffet.Eating_date,booking_buffet.payment,booking_buffet.Amount,buffet.Type_buffet,buffet.Price from customer,booking_buffet,buffet where customer.customer_id=booking_buffet.customer_id and buffet.buffet_id=booking_buffet.buffet_id and booking_buffet.customer_id="+id,cn);
						
							adap4=new SqlDataAdapter(comd);
							DataSet ds4=new DataSet();
							adap4.Fill(ds4,"customer");
							dataGrid_hide.DataSource=ds4;
							dataGrid_hide.DataMember="customer";
					
							//
							dataGrid_hide.DataSource=ds4.Tables["customer"];
							txt_custom_name.DataBindings.Clear();
							txt_cus_birth.DataBindings.Clear();
							txt_cust_phone.DataBindings.Clear();
							txt_booking_date.DataBindings.Clear();

							txt_buffetname.DataBindings.Clear();
							dtp_date_eating.DataBindings.Clear();
							txt_price.DataBindings.Clear();
							txt_amount.DataBindings.Clear();
							cbo_pay.DataBindings.Clear();

							////
							txt_custom_name.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Name");
							txt_cus_birth.DataBindings.Add("Text",ds4.Tables["Customer"],"Date_of_Birth");
							txt_cust_phone.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Phone");
							txt_booking_date.DataBindings.Add("Text",ds4.Tables["Customer"],"BB_Date");
							txt_buffetname.DataBindings.Add("Text",ds4.Tables["Customer"],"Type_Buffet");
							dtp_date_eating.DataBindings.Add("Text",ds4.Tables["Customer"],"Eating_date");
							txt_price.DataBindings.Add("Text",ds4.Tables["Customer"],"Price");
							txt_amount.DataBindings.Add("Text",ds4.Tables["Customer"],"Amount");
							cbo_pay.DataBindings.Add("Text",ds4.Tables["Customer"],"Payment");

							///this if statement to catch exception from the first If
							///if Customer has not booking yet.

							if(f!=0 && (txt_custom_name.Text==""))																		
							{
								ds4.Clear();
								comd=new SqlCommand("select customer.customer_id,customer.customer_name,customer.customer_phone,customer.date_of_birth,Booking_buffet.bb_date from customer,booking_buffet where customer.customer_id="+id,cn);						
								adap4=new SqlDataAdapter(comd);
							
								adap4.Fill(ds4,"customer");
								dataGrid_hide.DataSource=ds4;
								dataGrid_hide.DataMember="customer";
					
								//
								dataGrid_hide.DataSource=ds4.Tables["customer"];
								txt_custom_name.DataBindings.Clear();
								txt_cus_birth.DataBindings.Clear();
								txt_cust_phone.DataBindings.Clear();
								txt_booking_date.DataBindings.Clear();
								////
								txt_custom_name.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Name");
								txt_cus_birth.DataBindings.Add("Text",ds4.Tables["Customer"],"Date_of_Birth");
								txt_cust_phone.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Phone");
								txt_booking_date.DataBindings.Add("Text",ds4.Tables["Customer"],"BB_Date");							
							}

							cn.Close();
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
				if(!Regex.IsMatch(txt_custom_name.Text.Trim(),@"[A-Za-z0-9 ]+$"))
				{
					MessageBox.Show("You should enter Customer Name field, Please!");
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
						string name=txt_custom_name.Text.Trim();
						///
						ds5.Clear();

						comd=new SqlCommand("select customer_name,Customer_id from customer where rtrim(customer_name) like '"+name+"%'",cn);						
						adap=new SqlDataAdapter(comd);
						adap.Fill(ds5,"customer");
						cbo_cust_name.DataSource=ds5.Tables["customer"];
						cbo_cust_name.DisplayMember="customer_name";
						txt_custom_name.Visible=false;

						
					}	
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message+"hello");
					}	
				}
			}
		}
		public void cleartext()
		{
			txt_custom_name.Clear();
			txt_cust_ID.Clear();
		
			txt_cus_birth.Clear();
			txt_cust_phone.Clear();
			txt_buffetname.Clear();
			txt_price.Clear();
			txt_amount.Clear();	
			cbo_pay.Text="";	

		}
		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			cleartext();
			btn_cancel.Enabled=false;		
		}
		/// <summary>
		/// Button order 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Order_Click(object sender, System.EventArgs e)
		{
			txt_custom_name.Enabled=true;
			txt_cust_ID.Enabled=true;

			if(!Regex.IsMatch(txt_cust_ID.Text.Trim(),@"[0-9]+$"))
			{
				MessageBox.Show("You should enter digits in Customer ID, Please!");	
			}
			else	
				if(!Regex.IsMatch(txt_custom_name.Text.Trim(),@"[A-Za-z0-9 ]+$"))
			{
				MessageBox.Show("You should enter Customer Name correctly!");
			}
			else
				if(txt_cus_birth.Text.Trim()=="")
			{
				MessageBox.Show("Enter the birth day, please!");
			
			}
			else
				if(!Regex.IsMatch(txt_cust_phone.Text.Trim(),@"[0-9]+$"))
			{
				MessageBox.Show("Enter the phone numbers, please!");			
			}
			else
				if(!Regex.IsMatch(txt_buffetname.Text.Trim(),@"[A-Za-z0-9 ]+$"))
			{
				MessageBox.Show("Select Name of Buffet on the right, please!");			
			}			
			else
				if(str1==null)
			{
				MessageBox.Show("Select Eating date, please!");			
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
				if(str2==null)
			{
				MessageBox.Show("Select the Payment, please!");			
			}
			else
				if(dtp_date_eating.Value.Day<dtb_today.Value.Day)
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
					int k=Convert.ToInt16(txt_hide_ID.Text.ToString());
					int h=Convert.ToInt16(txt_amount.Text.ToString());
					comd2=new SqlCommand("set dateformat dmy insert into customer values('"+txt_custom_name.Text+"','',"+txt_cust_phone.Text+",'1','"+txt_cus_birth.Text+"','')",cn);
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

					comd1=new SqlCommand("set dateformat dmy insert into booking_buffet values("+f+","+k+","+custid+",'"+dtp_date_eating.Text+"','"+txt_booking_date.Text+"','"+cbo_pay.Text+"',"+h+")",cn);

					comd1.ExecuteNonQuery();
					MessageBox.Show("Record has been saved!");
					cn.Close();
					btn_print.Enabled=true;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}

		private void date_eating_ValueChanged(object sender, System.EventArgs e)
		{
			str1=dtp_date_eating.Text.ToString();
		}

		private void combo_pay_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str2=cbo_pay.SelectedItem.ToString();
		}

		private void btn_print_Click(object sender, System.EventArgs e)
		{
			try
			{
				prnPrvdlg_order.Document=prnDoc_order;
				prnPrvdlg_order.ShowDialog();
				btn_print.Enabled=false;
				btn_cancel.Enabled=true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void prnDoc_order_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				e.Graphics.DrawString ("\t\tBuffet Order\nDelta Hotel\n\n\n\n\n\n\n\n",new Font("Monotype Corsiva",20,FontStyle.Italic),Brushes.Blue,160,125);
				e.Graphics.DrawString ("\n\n\t\t45 Tran Hung Dao street CT.City VN\n\t\t Phone:0710464006-0945706007\n\nCustomer ID:\t"+txt_cust_ID.Text+"\nCustomer Name:\t"+txt_custom_name.Text+"\n Birth of Date:\t"+txt_cus_birth.Text+"\n Phone Number:\t"+txt_cust_phone.Text+"\n Booking Date:\t"+txt_booking_date.Text+"\n Name Buffet:\t"+txt_buffetname.Text+"\n Eating Date:\t"+dtp_date_eating.Text+"\n Price:\t\t"+txt_price.Text+" USD\n Amount:\t\t"+txt_amount.Text+" Persons\n Payment:\t\t"+cbo_pay.Text,new Font("Monotype Corsiva",16,FontStyle.Italic),Brushes.Black,160,125);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void rad_cust_id_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_custom_name.Visible=true;
			txt_custom_name.Enabled=false;
			txt_cust_ID.Enabled=true;

		}
		/// <summary>
		/// This Combox find the customer name and add information into the text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbo_cust_name_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str=cbo_cust_name.Text.Trim();
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
					
					
					txt_custom_name.Visible=true;
					////
					txt_custom_name.Text="";
					////
					//query three table the same customer in customer, booking_buffet and buffet
					comd4=new SqlCommand("select customer.customer_id,customer.customer_name,customer.customer_phone,customer.date_of_birth,Booking_buffet.bb_date,booking_buffet.Eating_date,booking_buffet.payment,booking_buffet.Amount,buffet.Type_buffet,buffet.Price from customer,booking_buffet,buffet where customer.customer_id=booking_buffet.customer_id and buffet.buffet_id=booking_buffet.buffet_id and booking_buffet.customer_id="+f,cn);
						
					adap4=new SqlDataAdapter(comd4);
					DataSet ds4=new DataSet();
					adap4.Fill(ds4,"customer");
					dataGrid_hide.DataSource=ds4;
					dataGrid_hide.DataMember="customer";
					
					//
					dataGrid_hide.DataSource=ds4.Tables["customer"];
					txt_custom_name.DataBindings.Clear();
					txt_cus_birth.DataBindings.Clear();
					txt_cust_phone.DataBindings.Clear();
					txt_booking_date.DataBindings.Clear();

					txt_buffetname.DataBindings.Clear();
					dtp_date_eating.DataBindings.Clear();
					txt_price.DataBindings.Clear();
					txt_amount.DataBindings.Clear();
					cbo_pay.DataBindings.Clear();
					txt_cust_ID.DataBindings.Clear();

					////
					txt_custom_name.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Name");
					txt_cus_birth.DataBindings.Add("Text",ds4.Tables["Customer"],"Date_of_Birth");
					txt_cust_phone.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Phone");
					txt_booking_date.DataBindings.Add("Text",ds4.Tables["Customer"],"BB_Date");
					txt_buffetname.DataBindings.Add("Text",ds4.Tables["Customer"],"Type_Buffet");
					dtp_date_eating.DataBindings.Add("Text",ds4.Tables["Customer"],"Eating_date");
					txt_price.DataBindings.Add("Text",ds4.Tables["Customer"],"Price");
					txt_amount.DataBindings.Add("Text",ds4.Tables["Customer"],"Amount");
					cbo_pay.DataBindings.Add("Text",ds4.Tables["Customer"],"Payment");
					txt_cust_ID.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_ID");
					///
					///this if statement to catch exception from the first If
					///if Customer has not booking yet.
					if(f!=0 && (txt_custom_name.Text==""))																			
					{
						ds4.Clear();
						comd4=new SqlCommand("select customer.customer_id,customer.customer_name,customer.customer_phone,customer.date_of_birth,Booking_buffet.bb_date from customer,booking_buffet where customer.customer_id="+f,cn);						
						adap4=new SqlDataAdapter(comd4);
							
						adap4.Fill(ds4,"customer");
						dataGrid_hide.DataSource=ds4;
						dataGrid_hide.DataMember="customer";
					
						//
						dataGrid_hide.DataSource=ds4.Tables["customer"];
						txt_custom_name.DataBindings.Clear();
						txt_cus_birth.DataBindings.Clear();
						txt_cust_phone.DataBindings.Clear();
						txt_cust_ID.DataBindings.Clear();
						txt_booking_date.DataBindings.Clear();
						////
						txt_custom_name.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Name");
						txt_cus_birth.DataBindings.Add("Text",ds4.Tables["Customer"],"Date_of_Birth");
						txt_cust_phone.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_Phone");
						txt_booking_date.DataBindings.Add("Text",ds4.Tables["Customer"],"BB_Date");	
						txt_cust_ID.DataBindings.Add("Text",ds4.Tables["Customer"],"Customer_ID");

					}

					cn.Close();
				}			
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}				
			}				
		
		}

		private void rad_cust_name_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_custom_name.Enabled=true;
			txt_cust_ID.Enabled=false;

		}

	}
}
