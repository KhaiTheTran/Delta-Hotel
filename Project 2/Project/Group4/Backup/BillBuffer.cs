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
	/// Summary description for BillBuffer.
	/// </summary>
	public class BillBuffer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_search;
		SqlConnection cn;
		SqlCommand comd,comd1,comd2;
		SqlDataAdapter adap,adap2;
		DataSet ds=new DataSet();
		DataSet ds1=new DataSet();
		DataSet ds2=new DataSet();
		DataSet ds_hide=new DataSet();

		string str,str1,str2,str4,str5,spec;
		int f,id,g,h;
		private System.Windows.Forms.DataGrid dataGrid_hide;
		private System.Windows.Forms.TextBox txt_tatalpay;
		private System.Windows.Forms.TextBox txt_cust_ID;
		private System.Windows.Forms.TextBox txt_buf_type;
		private System.Windows.Forms.TextBox txt_amount;
		private System.Windows.Forms.TextBox txt_Price;
		private System.Windows.Forms.TextBox txt_bb_Id_hide;
		private System.Drawing.Printing.PrintDocument prnDoc_bill;
		private System.Windows.Forms.PrintPreviewDialog prnprvdlg_bill;
		private System.Windows.Forms.Label lbl_Tatal_pay;
		private System.Windows.Forms.DateTimePicker dtp_bill_date;
		private System.Windows.Forms.Label lbl_Bill_date;
		private System.Windows.Forms.Label lbl_cust_name;
		private System.Windows.Forms.Label lbl_Buf_type;
		private System.Windows.Forms.Label lbl_cust_id;
		private System.Windows.Forms.DataGrid dbg_bill_buf;
		private System.Windows.Forms.Label lbl_Eating_date;
		private System.Windows.Forms.TextBox txt_Eating_date;
		private System.Windows.Forms.Button btn_billPrint;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.GroupBox grp_bill;
		private System.Windows.Forms.GroupBox grp_buf;
		private System.Windows.Forms.GroupBox grp_but;
		private System.Windows.Forms.RadioButton rad_cust_name;
		private System.Windows.Forms.RadioButton rad_cust_id;
		private System.Windows.Forms.ComboBox cbo_cust_name;
		private System.Windows.Forms.TextBox txt_cust_name;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BillBuffer()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BillBuffer));
			this.label1 = new System.Windows.Forms.Label();
			this.grp_bill = new System.Windows.Forms.GroupBox();
			this.txt_cust_name = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.txt_tatalpay = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_Tatal_pay = new System.Windows.Forms.Label();
			this.dtp_bill_date = new System.Windows.Forms.DateTimePicker();
			this.lbl_Bill_date = new System.Windows.Forms.Label();
			this.lbl_Eating_date = new System.Windows.Forms.Label();
			this.lbl_cust_name = new System.Windows.Forms.Label();
			this.txt_Eating_date = new System.Windows.Forms.TextBox();
			this.lbl_Buf_type = new System.Windows.Forms.Label();
			this.txt_cust_ID = new System.Windows.Forms.TextBox();
			this.lbl_cust_id = new System.Windows.Forms.Label();
			this.txt_buf_type = new System.Windows.Forms.TextBox();
			this.rad_cust_name = new System.Windows.Forms.RadioButton();
			this.rad_cust_id = new System.Windows.Forms.RadioButton();
			this.cbo_cust_name = new System.Windows.Forms.ComboBox();
			this.grp_buf = new System.Windows.Forms.GroupBox();
			this.dbg_bill_buf = new System.Windows.Forms.DataGrid();
			this.dataGrid_hide = new System.Windows.Forms.DataGrid();
			this.btn_billPrint = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.grp_but = new System.Windows.Forms.GroupBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.txt_amount = new System.Windows.Forms.TextBox();
			this.txt_Price = new System.Windows.Forms.TextBox();
			this.txt_bb_Id_hide = new System.Windows.Forms.TextBox();
			this.prnDoc_bill = new System.Drawing.Printing.PrintDocument();
			this.prnprvdlg_bill = new System.Windows.Forms.PrintPreviewDialog();
			this.grp_bill.SuspendLayout();
			this.grp_buf.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_bill_buf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_hide)).BeginInit();
			this.grp_but.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(256, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bill Buffet";
			// 
			// grp_bill
			// 
			this.grp_bill.Controls.Add(this.txt_cust_name);
			this.grp_bill.Controls.Add(this.btn_search);
			this.grp_bill.Controls.Add(this.txt_tatalpay);
			this.grp_bill.Controls.Add(this.label6);
			this.grp_bill.Controls.Add(this.lbl_Tatal_pay);
			this.grp_bill.Controls.Add(this.dtp_bill_date);
			this.grp_bill.Controls.Add(this.lbl_Bill_date);
			this.grp_bill.Controls.Add(this.lbl_Eating_date);
			this.grp_bill.Controls.Add(this.lbl_cust_name);
			this.grp_bill.Controls.Add(this.txt_Eating_date);
			this.grp_bill.Controls.Add(this.lbl_Buf_type);
			this.grp_bill.Controls.Add(this.txt_cust_ID);
			this.grp_bill.Controls.Add(this.lbl_cust_id);
			this.grp_bill.Controls.Add(this.txt_buf_type);
			this.grp_bill.Controls.Add(this.rad_cust_name);
			this.grp_bill.Controls.Add(this.rad_cust_id);
			this.grp_bill.Controls.Add(this.cbo_cust_name);
			this.grp_bill.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_bill.ForeColor = System.Drawing.Color.Blue;
			this.grp_bill.Location = new System.Drawing.Point(16, 56);
			this.grp_bill.Name = "grp_bill";
			this.grp_bill.Size = new System.Drawing.Size(320, 192);
			this.grp_bill.TabIndex = 1;
			this.grp_bill.TabStop = false;
			this.grp_bill.Text = "Infomation Bill Buffet";
			// 
			// txt_cust_name
			// 
			this.txt_cust_name.Location = new System.Drawing.Point(144, 56);
			this.txt_cust_name.Name = "txt_cust_name";
			this.txt_cust_name.Size = new System.Drawing.Size(152, 22);
			this.txt_cust_name.TabIndex = 25;
			this.txt_cust_name.Text = "";
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(232, 30);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(64, 23);
			this.btn_search.TabIndex = 16;
			this.btn_search.Text = "Search";
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// txt_tatalpay
			// 
			this.txt_tatalpay.ForeColor = System.Drawing.Color.LimeGreen;
			this.txt_tatalpay.Location = new System.Drawing.Point(144, 130);
			this.txt_tatalpay.Name = "txt_tatalpay";
			this.txt_tatalpay.Size = new System.Drawing.Size(96, 22);
			this.txt_tatalpay.TabIndex = 14;
			this.txt_tatalpay.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(266, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "USD";
			// 
			// lbl_Tatal_pay
			// 
			this.lbl_Tatal_pay.Location = new System.Drawing.Point(9, 132);
			this.lbl_Tatal_pay.Name = "lbl_Tatal_pay";
			this.lbl_Tatal_pay.Size = new System.Drawing.Size(80, 23);
			this.lbl_Tatal_pay.TabIndex = 12;
			this.lbl_Tatal_pay.Text = "Tatal Pay:";
			// 
			// dtp_bill_date
			// 
			this.dtp_bill_date.CustomFormat = "dd/MM/yyyy";
			this.dtp_bill_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_bill_date.Location = new System.Drawing.Point(144, 154);
			this.dtp_bill_date.Name = "dtp_bill_date";
			this.dtp_bill_date.Size = new System.Drawing.Size(152, 22);
			this.dtp_bill_date.TabIndex = 11;
			this.dtp_bill_date.ValueChanged += new System.EventHandler(this.dateTime_bill_date_ValueChanged);
			// 
			// lbl_Bill_date
			// 
			this.lbl_Bill_date.Location = new System.Drawing.Point(8, 158);
			this.lbl_Bill_date.Name = "lbl_Bill_date";
			this.lbl_Bill_date.Size = new System.Drawing.Size(71, 23);
			this.lbl_Bill_date.TabIndex = 3;
			this.lbl_Bill_date.Text = "Bill Date :";
			// 
			// lbl_Eating_date
			// 
			this.lbl_Eating_date.Location = new System.Drawing.Point(5, 108);
			this.lbl_Eating_date.Name = "lbl_Eating_date";
			this.lbl_Eating_date.Size = new System.Drawing.Size(104, 23);
			this.lbl_Eating_date.TabIndex = 2;
			this.lbl_Eating_date.Text = " Eating Date :";
			// 
			// lbl_cust_name
			// 
			this.lbl_cust_name.Location = new System.Drawing.Point(8, 57);
			this.lbl_cust_name.Name = "lbl_cust_name";
			this.lbl_cust_name.Size = new System.Drawing.Size(112, 23);
			this.lbl_cust_name.TabIndex = 1;
			this.lbl_cust_name.Text = "Customer Name:";
			// 
			// txt_Eating_date
			// 
			this.txt_Eating_date.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_Eating_date.Location = new System.Drawing.Point(144, 106);
			this.txt_Eating_date.Name = "txt_Eating_date";
			this.txt_Eating_date.Size = new System.Drawing.Size(152, 22);
			this.txt_Eating_date.TabIndex = 10;
			this.txt_Eating_date.Text = "";
			// 
			// lbl_Buf_type
			// 
			this.lbl_Buf_type.Location = new System.Drawing.Point(8, 83);
			this.lbl_Buf_type.Name = "lbl_Buf_type";
			this.lbl_Buf_type.Size = new System.Drawing.Size(88, 23);
			this.lbl_Buf_type.TabIndex = 1;
			this.lbl_Buf_type.Text = "Buffet Type:";
			// 
			// txt_cust_ID
			// 
			this.txt_cust_ID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_cust_ID.Location = new System.Drawing.Point(144, 31);
			this.txt_cust_ID.Name = "txt_cust_ID";
			this.txt_cust_ID.Size = new System.Drawing.Size(80, 22);
			this.txt_cust_ID.TabIndex = 10;
			this.txt_cust_ID.Text = "";
			// 
			// lbl_cust_id
			// 
			this.lbl_cust_id.Location = new System.Drawing.Point(8, 33);
			this.lbl_cust_id.Name = "lbl_cust_id";
			this.lbl_cust_id.Size = new System.Drawing.Size(112, 23);
			this.lbl_cust_id.TabIndex = 1;
			this.lbl_cust_id.Text = "Customer ID";
			// 
			// txt_buf_type
			// 
			this.txt_buf_type.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txt_buf_type.Location = new System.Drawing.Point(144, 81);
			this.txt_buf_type.Name = "txt_buf_type";
			this.txt_buf_type.Size = new System.Drawing.Size(152, 22);
			this.txt_buf_type.TabIndex = 10;
			this.txt_buf_type.Text = "";
			// 
			// rad_cust_name
			// 
			this.rad_cust_name.Location = new System.Drawing.Point(128, 55);
			this.rad_cust_name.Name = "rad_cust_name";
			this.rad_cust_name.Size = new System.Drawing.Size(16, 24);
			this.rad_cust_name.TabIndex = 24;
			this.rad_cust_name.CheckedChanged += new System.EventHandler(this.rad_cust_name_CheckedChanged);
			// 
			// rad_cust_id
			// 
			this.rad_cust_id.Checked = true;
			this.rad_cust_id.Location = new System.Drawing.Point(128, 31);
			this.rad_cust_id.Name = "rad_cust_id";
			this.rad_cust_id.Size = new System.Drawing.Size(16, 24);
			this.rad_cust_id.TabIndex = 24;
			this.rad_cust_id.TabStop = true;
			this.rad_cust_id.CheckedChanged += new System.EventHandler(this.rad_cust_id_CheckedChanged);
			// 
			// cbo_cust_name
			// 
			this.cbo_cust_name.Location = new System.Drawing.Point(144, 56);
			this.cbo_cust_name.Name = "cbo_cust_name";
			this.cbo_cust_name.Size = new System.Drawing.Size(152, 24);
			this.cbo_cust_name.TabIndex = 15;
			this.cbo_cust_name.SelectedIndexChanged += new System.EventHandler(this.cbo_cust_name_SelectedIndexChanged);
			// 
			// grp_buf
			// 
			this.grp_buf.Controls.Add(this.dbg_bill_buf);
			this.grp_buf.Controls.Add(this.dataGrid_hide);
			this.grp_buf.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_buf.ForeColor = System.Drawing.Color.Blue;
			this.grp_buf.Location = new System.Drawing.Point(336, 56);
			this.grp_buf.Name = "grp_buf";
			this.grp_buf.Size = new System.Drawing.Size(320, 192);
			this.grp_buf.TabIndex = 9;
			this.grp_buf.TabStop = false;
			this.grp_buf.Text = "List Bill Buffet";
			// 
			// dbg_bill_buf
			// 
			this.dbg_bill_buf.CaptionText = "Biil Buffet Details";
			this.dbg_bill_buf.DataMember = "";
			this.dbg_bill_buf.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_bill_buf.Location = new System.Drawing.Point(8, 24);
			this.dbg_bill_buf.Name = "dbg_bill_buf";
			this.dbg_bill_buf.Size = new System.Drawing.Size(304, 160);
			this.dbg_bill_buf.TabIndex = 17;
			// 
			// dataGrid_hide
			// 
			this.dataGrid_hide.DataMember = "";
			this.dataGrid_hide.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_hide.Location = new System.Drawing.Point(120, 48);
			this.dataGrid_hide.Name = "dataGrid_hide";
			this.dataGrid_hide.Size = new System.Drawing.Size(130, 64);
			this.dataGrid_hide.TabIndex = 14;
			// 
			// btn_billPrint
			// 
			this.btn_billPrint.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_billPrint.ForeColor = System.Drawing.Color.Blue;
			this.btn_billPrint.Location = new System.Drawing.Point(54, 23);
			this.btn_billPrint.Name = "btn_billPrint";
			this.btn_billPrint.Size = new System.Drawing.Size(72, 23);
			this.btn_billPrint.TabIndex = 10;
			this.btn_billPrint.Text = "Print Bill";
			this.btn_billPrint.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_close
			// 
			this.btn_close.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_close.ForeColor = System.Drawing.Color.Blue;
			this.btn_close.Location = new System.Drawing.Point(259, 23);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(69, 23);
			this.btn_close.TabIndex = 12;
			this.btn_close.Text = "Close";
			this.btn_close.Click += new System.EventHandler(this.button3_Click);
			// 
			// grp_but
			// 
			this.grp_but.Controls.Add(this.btn_billPrint);
			this.grp_but.Controls.Add(this.btn_close);
			this.grp_but.Controls.Add(this.btn_update);
			this.grp_but.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.grp_but.Location = new System.Drawing.Point(141, 264);
			this.grp_but.Name = "grp_but";
			this.grp_but.Size = new System.Drawing.Size(389, 64);
			this.grp_but.TabIndex = 13;
			this.grp_but.TabStop = false;
			// 
			// btn_update
			// 
			this.btn_update.Enabled = false;
			this.btn_update.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_update.ForeColor = System.Drawing.Color.Blue;
			this.btn_update.Location = new System.Drawing.Point(155, 23);
			this.btn_update.Name = "btn_update";
			this.btn_update.TabIndex = 12;
			this.btn_update.Text = "Update";
			this.btn_update.Click += new System.EventHandler(this.button4_Click);
			// 
			// txt_amount
			// 
			this.txt_amount.ForeColor = System.Drawing.Color.Lime;
			this.txt_amount.Location = new System.Drawing.Point(440, 176);
			this.txt_amount.Name = "txt_amount";
			this.txt_amount.Size = new System.Drawing.Size(96, 20);
			this.txt_amount.TabIndex = 14;
			this.txt_amount.Text = "";
			// 
			// txt_Price
			// 
			this.txt_Price.ForeColor = System.Drawing.Color.Lime;
			this.txt_Price.Location = new System.Drawing.Point(504, 168);
			this.txt_Price.Name = "txt_Price";
			this.txt_Price.Size = new System.Drawing.Size(96, 20);
			this.txt_Price.TabIndex = 14;
			this.txt_Price.Text = "";
			// 
			// txt_bb_Id_hide
			// 
			this.txt_bb_Id_hide.Location = new System.Drawing.Point(368, 168);
			this.txt_bb_Id_hide.Name = "txt_bb_Id_hide";
			this.txt_bb_Id_hide.Size = new System.Drawing.Size(56, 20);
			this.txt_bb_Id_hide.TabIndex = 13;
			this.txt_bb_Id_hide.Text = "";
			// 
			// prnDoc_bill
			// 
			this.prnDoc_bill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prnDoc_bill_PrintPage);
			// 
			// prnprvdlg_bill
			// 
			this.prnprvdlg_bill.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.prnprvdlg_bill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.prnprvdlg_bill.ClientSize = new System.Drawing.Size(400, 300);
			this.prnprvdlg_bill.Document = this.prnDoc_bill;
			this.prnprvdlg_bill.Enabled = true;
			this.prnprvdlg_bill.Icon = ((System.Drawing.Icon)(resources.GetObject("prnprvdlg_bill.Icon")));
			this.prnprvdlg_bill.Location = new System.Drawing.Point(124, 17);
			this.prnprvdlg_bill.MinimumSize = new System.Drawing.Size(375, 250);
			this.prnprvdlg_bill.Name = "prnprvdlg_bill";
			this.prnprvdlg_bill.TransparencyKey = System.Drawing.Color.Empty;
			this.prnprvdlg_bill.Visible = false;
			// 
			// BillBuffer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 342);
			this.Controls.Add(this.grp_but);
			this.Controls.Add(this.grp_buf);
			this.Controls.Add(this.grp_bill);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Price);
			this.Controls.Add(this.txt_amount);
			this.Controls.Add(this.txt_bb_Id_hide);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BillBuffer";
			this.Text = "BillBuffer";
			this.Load += new System.EventHandler(this.BillBuffer_Load);
			this.grp_bill.ResumeLayout(false);
			this.grp_buf.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_bill_buf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_hide)).EndInit();
			this.grp_but.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void BillBuffer_Load(object sender, System.EventArgs e)
		{
			try
			{
				cn= Conetion.conet();
				////////////////////////////
				comd2=new SqlCommand("select Customer.Customer_Name,Customer.Customer_Phone,Booking_buffet.BB_date,BillFoods.Total_Pay,BillFoods.Bill_date from BillFoods,Booking_buffet,customer where customer.customer_ID=Booking_Buffet.customer_ID and booking_Buffet.BB_ID=Billfoods.BB_ID",cn);				
				adap2=new SqlDataAdapter(comd2);
				ds.Clear();
				adap2.Fill(ds,"type_fo");
				dbg_bill_buf.DataSource=ds;
				dbg_bill_buf.DataMember="Type_fo";

				///
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}
			//button printBill
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(!Regex.IsMatch(txt_cust_ID.Text.Trim(),@"[0-9]+$"))
			{
				MessageBox.Show("You should enter digits in Customer ID, Please!");	
			}
			else	
				if(!Regex.IsMatch(txt_cust_name.Text.Trim(),@"[A-Za-z0-9 ]+$"))
			{
				MessageBox.Show("You should enter Name correctly!");
			}
			else
				if(!Regex.IsMatch(txt_buf_type.Text.Trim(),@"[A-Za-z0-9 ]+$"))
			{
				MessageBox.Show("Enter the Buffet type correctly, please!");
			
			}
			else
				if(!Regex.IsMatch(txt_tatalpay.Text.Trim(),@"[0-9]+$"))
			{
				MessageBox.Show("Enter the money correctly, please!");			
			}
			else
				if(str5==null)
			{
				MessageBox.Show("Select date, please!");			
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
						comd=new SqlCommand("select max(BillBuffet_ID) from BillFoods",cn);
						f=Convert.ToInt16(comd.ExecuteScalar());
						
					}
					catch(Exception ex)
					{
						f=0;
						Console.WriteLine(ex);
					}
					f=f+1;
					int k=Convert.ToInt16(txt_bb_Id_hide.Text.ToString());
					comd1=new SqlCommand("set dateformat dmy insert into BillFoods values("+f+","+k+","+txt_tatalpay.Text+",'"+dtp_bill_date.Text+"')",cn);

					comd1.ExecuteNonQuery();
					MessageBox.Show("Record has been saved!");
					cn.Close();					
					prnprvdlg_bill.Document=prnDoc_bill;
					prnprvdlg_bill.ShowDialog();
					btn_update.Enabled=true;
					cleartext();
				
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				btn_update.Enabled=true;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
				//button update
		private void button4_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(cn.State==ConnectionState.Closed)
				{
					cn.Open();
				}
				comd2=new SqlCommand("select Customer.Customer_Name,Customer.Customer_Phone,Booking_buffet.BB_date,BillFoods.Total_Pay,BillFoods.Bill_date from BillFoods,Booking_buffet,customer where customer.customer_ID=Booking_Buffet.customer_ID and booking_Buffet.BB_ID=Billfoods.BB_ID",cn);
				adap2=new SqlDataAdapter(comd2);
				ds.Clear();
				adap2.Fill(ds,"type_fo");
				dbg_bill_buf.DataSource=ds;
				dbg_bill_buf.DataMember="Type_fo";
				cn.Close();
				
				btn_update.Enabled=false;
				///
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		public void cleartext()
		{
			txt_amount.Text="";
			txt_Eating_date.Text="";
			txt_buf_type.Text="";
			txt_cust_ID.Text="";
			txt_cust_name.Text="";
			txt_Price.Text="";
			txt_tatalpay.Text="";
			
		}
		// button search
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
							int k=Convert.ToInt32(txt_cust_ID.Text.Trim());
							comd1=new SqlCommand("select customer_Id from customer where rtrim(customer_id)="+k,cn);
							f=Convert.ToInt32(comd1.ExecuteScalar());
						}
						catch(Exception ex)
						{
							f=0;
							Console.WriteLine(ex);
						}

						if(f==0)
						{						
							MessageBox.Show("This ID doesn't exist! \n Or Customer name doesn't exist!");
							cleartext();
						}
						else
						{
						
													
							txt_Eating_date.Text="";
							txt_tatalpay.Text="";
							txt_buf_type.Text="";
							txt_cust_name.Text="";

							////
							id=Convert.ToInt32(txt_cust_ID.Text);
							ds_hide.Clear();

							comd=new SqlCommand("select customer.customer_id,customer.customer_name,booking_buffet.Eating_date,booking_buffet.BB_ID,booking_buffet.Amount,buffet.Type_buffet,buffet.Price from customer,booking_buffet,buffet where customer.customer_id=booking_buffet.customer_id and buffet.buffet_id=booking_buffet.buffet_id and booking_buffet.customer_id="+id,cn);

							adap=new SqlDataAdapter(comd);
							adap.Fill(ds_hide,"customer");
							dataGrid_hide.DataSource=ds_hide;
							dataGrid_hide.DataMember="customer";
							//
							dataGrid_hide.DataSource=ds_hide.Tables["customer"];
							txt_cust_name.DataBindings.Clear();
							txt_Eating_date.DataBindings.Clear();
							txt_buf_type.DataBindings.Clear();
							txt_amount.DataBindings.Clear();
							txt_Price.DataBindings.Clear();
							txt_bb_Id_hide.DataBindings.Clear();
							////
							txt_cust_name.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Customer_Name");
							txt_Eating_date.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Eating_date");
							txt_buf_type.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Type_Buffet");
							txt_amount.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Amount");
							txt_Price.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Price");
							txt_bb_Id_hide.DataBindings.Add("Text",ds_hide.Tables["Customer"],"BB_ID");
							////
							str1=txt_amount.Text.ToString();
							str2=txt_Price.Text.ToString();
							int i=str2.IndexOf('.');
							str4=str2.Substring(0,i);
							g=Convert.ToInt32(str1);
							h=Convert.ToInt32(str4);
							f=g*h;
							str=Convert.ToString(f);
							txt_tatalpay.Text=str;
						
							cn.Close();
						}
					}
					catch(Exception ex)
					{
						MessageBox.Show("This Customer has not ordered buffet yet!");
						Console.WriteLine(ex);
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
						string name=txt_cust_name.Text;
						////
						ds2.Clear();

						comd=new SqlCommand("select customer_name,Customer_id from customer where rtrim(customer_name) like '"+name+"%'",cn);						
						adap=new SqlDataAdapter(comd);
						adap.Fill(ds2,"customer");

						cbo_cust_name.DataSource=ds2.Tables["customer"];
						cbo_cust_name.DisplayMember="customer_name";
						txt_cust_name.Visible=false;
						cn.Close();						
					}	
					catch(Exception ex)
					{
						Console.WriteLine(ex);
					}	
				

				
				}
			}
		}

		private void dateTime_bill_date_ValueChanged(object sender, System.EventArgs e)
		{
			str5=dtp_bill_date.Text.ToString();
		}

		private void prnDoc_bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				e.Graphics.DrawString ("\t\tBill Buffet\nDelta Hotel\n\n\n\n\n\n\n\n",new Font("Monotype Corsiva",20,FontStyle.Italic),Brushes.Blue,160,125);
				e.Graphics.DrawString ("\n\n\t\t45 Tran Hung Dao street CT.City VN\n\t\t Phone:0710464006-0945706007\n\nCustomer ID:\t"+txt_cust_ID.Text+"\nCustomer Name:\t"+txt_cust_name.Text+"\n Buffet type:\t"+txt_buf_type.Text+"\n Eating date:\t"+txt_Eating_date.Text+"\n Tatal Pay:\t"+txt_tatalpay.Text+" USD\n Bill Date:\t\t"+dtp_bill_date.Text,new Font("Monotype Corsiva",16,FontStyle.Italic),Brushes.Black,160,125);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void cbo_cust_name_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			str=cbo_cust_name.SelectedItem.ToString();
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
						spec=cbo_cust_name.Text.Trim();

						comd1=new SqlCommand("select customer_Id from customer where rtrim(customer_name)='"+spec+"'",cn);
						f=Convert.ToInt16(comd1.ExecuteScalar());
					}
					catch(Exception ex)
					{
						f=0;
						Console.WriteLine(ex);
					}
					ds_hide.Clear();
					
					////
					comd=new SqlCommand("select customer.customer_id,customer.customer_name,booking_buffet.Eating_date,booking_buffet.BB_ID,booking_buffet.Amount,buffet.Type_buffet,buffet.Price from customer,booking_buffet,buffet where customer.customer_id=booking_buffet.customer_id and buffet.buffet_id=booking_buffet.buffet_id and booking_buffet.customer_id="+f,cn);
						
						
					adap=new SqlDataAdapter(comd);

					adap.Fill(ds_hide,"customer");
					dataGrid_hide.DataSource=ds_hide;
					dataGrid_hide.DataMember="customer";
					//
					dataGrid_hide.DataSource=ds_hide.Tables["customer"];
					txt_cust_name.DataBindings.Clear();
					txt_Eating_date.DataBindings.Clear();
					txt_buf_type.DataBindings.Clear();
					txt_amount.DataBindings.Clear();
					txt_Price.DataBindings.Clear();
					txt_bb_Id_hide.DataBindings.Clear();
					txt_cust_ID.DataBindings.Clear();
					////
					txt_cust_name.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Customer_Name");
					txt_Eating_date.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Eating_date");
					txt_buf_type.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Type_Buffet");
					txt_amount.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Amount");
					txt_Price.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Price");
					txt_bb_Id_hide.DataBindings.Add("Text",ds_hide.Tables["Customer"],"BB_ID");
					txt_cust_ID.DataBindings.Add("Text",ds_hide.Tables["Customer"],"Customer_ID");
					////
					str1=txt_amount.Text.ToString();
					str2=txt_Price.Text.ToString();
					int i=str2.IndexOf('.');
					str4=str2.Substring(0,i);
					g=Convert.ToInt32(str1);
					h=Convert.ToInt32(str4);
					f=g*h;
					str=Convert.ToString(f);
					txt_tatalpay.Text=str;
					txt_cust_name.Visible=true;

						
				}				
				catch(Exception ex)
				{
					txt_cust_name.Visible=true;
					Console.WriteLine(ex);
				}	
			}
		}

		private void rad_cust_id_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_cust_name.Visible=true;
			txt_cust_name.Enabled=false;
			txt_cust_ID.Enabled=true;
		}

		private void rad_cust_name_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_cust_name.Enabled=true;
			txt_cust_ID.Enabled=false;
		}
	}
}
