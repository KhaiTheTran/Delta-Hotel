using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Nhom4
{
	/// <summary>
	/// Summary description for BillRoom.
	/// </summary>
	public class BillRoom : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grp_billroom;
		private System.Windows.Forms.Label lbl_BookingID;
		private System.Windows.Forms.Label lbl_RoomID;
		private System.Windows.Forms.Label lbl_Roomtype;
		private System.Windows.Forms.Label lbl_price;
		private System.Windows.Forms.Label lbl_checkindate;
		private System.Windows.Forms.Label lbl_checkoutdate;
		private System.Windows.Forms.Label lbl_totalpay;
		private System.Windows.Forms.Label lbl_billroom;
		private System.Windows.Forms.GroupBox grpCustomer;
		private System.Windows.Forms.Button btn_printbill;
		private System.Windows.Forms.Button btn_close;

		private SqlConnection cn;
		private SqlCommand cm;
		//private SqlCommand cm1;
		//private SqlCommand cm2;
		//SqlDataAdapter da;
		//DataSet ds=new DataSet();
		float total =0,price;
		int f;
		public System.Windows.Forms.DataGrid dbg_customer;
		private System.Windows.Forms.TextBox txt_RoomID;
		private System.Windows.Forms.TextBox txt_Roomtype;
		private System.Windows.Forms.TextBox txt_Price;
		private System.Windows.Forms.DateTimePicker dtp_Checkout;
		private System.Windows.Forms.TextBox txt_total;
		private System.Windows.Forms.DateTimePicker dtp_Checkin;
		private System.Drawing.Printing.PrintDocument prndoc_billroom;
		private System.Windows.Forms.PrintPreviewDialog prnPrvdlg_billroom;
		private System.Windows.Forms.DateTimePicker dtp_BillDate;
		private System.Windows.Forms.Label lbl_Billdate;
		private System.Windows.Forms.TextBox txt_customer_name;
		private System.Windows.Forms.TextBox txt_BokingID;
		private System.Windows.Forms.Label lbl_BookingID1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BillRoom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BillRoom));
			this.lbl_billroom = new System.Windows.Forms.Label();
			this.grp_billroom = new System.Windows.Forms.GroupBox();
			this.lbl_BookingID1 = new System.Windows.Forms.Label();
			this.txt_BokingID = new System.Windows.Forms.TextBox();
			this.dtp_BillDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_Billdate = new System.Windows.Forms.Label();
			this.dtp_Checkin = new System.Windows.Forms.DateTimePicker();
			this.txt_total = new System.Windows.Forms.TextBox();
			this.dtp_Checkout = new System.Windows.Forms.DateTimePicker();
			this.txt_Price = new System.Windows.Forms.TextBox();
			this.txt_Roomtype = new System.Windows.Forms.TextBox();
			this.txt_RoomID = new System.Windows.Forms.TextBox();
			this.txt_customer_name = new System.Windows.Forms.TextBox();
			this.lbl_totalpay = new System.Windows.Forms.Label();
			this.lbl_checkoutdate = new System.Windows.Forms.Label();
			this.lbl_checkindate = new System.Windows.Forms.Label();
			this.lbl_price = new System.Windows.Forms.Label();
			this.lbl_Roomtype = new System.Windows.Forms.Label();
			this.lbl_RoomID = new System.Windows.Forms.Label();
			this.lbl_BookingID = new System.Windows.Forms.Label();
			this.grpCustomer = new System.Windows.Forms.GroupBox();
			this.dbg_customer = new System.Windows.Forms.DataGrid();
			this.btn_printbill = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.prndoc_billroom = new System.Drawing.Printing.PrintDocument();
			this.prnPrvdlg_billroom = new System.Windows.Forms.PrintPreviewDialog();
			this.grp_billroom.SuspendLayout();
			this.grpCustomer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_customer)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_billroom
			// 
			this.lbl_billroom.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_billroom.ForeColor = System.Drawing.Color.Blue;
			this.lbl_billroom.Location = new System.Drawing.Point(319, 10);
			this.lbl_billroom.Name = "lbl_billroom";
			this.lbl_billroom.Size = new System.Drawing.Size(136, 32);
			this.lbl_billroom.TabIndex = 0;
			this.lbl_billroom.Text = "Bill Room";
			// 
			// grp_billroom
			// 
			this.grp_billroom.Controls.Add(this.lbl_BookingID1);
			this.grp_billroom.Controls.Add(this.txt_BokingID);
			this.grp_billroom.Controls.Add(this.dtp_BillDate);
			this.grp_billroom.Controls.Add(this.lbl_Billdate);
			this.grp_billroom.Controls.Add(this.dtp_Checkin);
			this.grp_billroom.Controls.Add(this.txt_total);
			this.grp_billroom.Controls.Add(this.dtp_Checkout);
			this.grp_billroom.Controls.Add(this.txt_Price);
			this.grp_billroom.Controls.Add(this.txt_Roomtype);
			this.grp_billroom.Controls.Add(this.txt_RoomID);
			this.grp_billroom.Controls.Add(this.txt_customer_name);
			this.grp_billroom.Controls.Add(this.lbl_totalpay);
			this.grp_billroom.Controls.Add(this.lbl_checkoutdate);
			this.grp_billroom.Controls.Add(this.lbl_checkindate);
			this.grp_billroom.Controls.Add(this.lbl_price);
			this.grp_billroom.Controls.Add(this.lbl_Roomtype);
			this.grp_billroom.Controls.Add(this.lbl_RoomID);
			this.grp_billroom.Controls.Add(this.lbl_BookingID);
			this.grp_billroom.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_billroom.ForeColor = System.Drawing.Color.Blue;
			this.grp_billroom.Location = new System.Drawing.Point(8, 48);
			this.grp_billroom.Name = "grp_billroom";
			this.grp_billroom.Size = new System.Drawing.Size(312, 344);
			this.grp_billroom.TabIndex = 1;
			this.grp_billroom.TabStop = false;
			this.grp_billroom.Text = "Infomation Bill Room";
			// 
			// lbl_BookingID1
			// 
			this.lbl_BookingID1.Location = new System.Drawing.Point(16, 64);
			this.lbl_BookingID1.Name = "lbl_BookingID1";
			this.lbl_BookingID1.TabIndex = 29;
			this.lbl_BookingID1.Text = "Booking_ID";
			// 
			// txt_BokingID
			// 
			this.txt_BokingID.Enabled = false;
			this.txt_BokingID.Location = new System.Drawing.Point(128, 64);
			this.txt_BokingID.Name = "txt_BokingID";
			this.txt_BokingID.Size = new System.Drawing.Size(168, 22);
			this.txt_BokingID.TabIndex = 28;
			this.txt_BokingID.Text = "";
			// 
			// dtp_BillDate
			// 
			this.dtp_BillDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_BillDate.Enabled = false;
			this.dtp_BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_BillDate.Location = new System.Drawing.Point(128, 192);
			this.dtp_BillDate.Name = "dtp_BillDate";
			this.dtp_BillDate.Size = new System.Drawing.Size(168, 22);
			this.dtp_BillDate.TabIndex = 27;
			// 
			// lbl_Billdate
			// 
			this.lbl_Billdate.Location = new System.Drawing.Point(16, 192);
			this.lbl_Billdate.Name = "lbl_Billdate";
			this.lbl_Billdate.TabIndex = 26;
			this.lbl_Billdate.Text = "Bill Date :";
			// 
			// dtp_Checkin
			// 
			this.dtp_Checkin.CustomFormat = "dd/MM/yyyy";
			this.dtp_Checkin.Enabled = false;
			this.dtp_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Checkin.Location = new System.Drawing.Point(128, 224);
			this.dtp_Checkin.Name = "dtp_Checkin";
			this.dtp_Checkin.Size = new System.Drawing.Size(168, 22);
			this.dtp_Checkin.TabIndex = 25;
			// 
			// txt_total
			// 
			this.txt_total.Enabled = false;
			this.txt_total.Location = new System.Drawing.Point(128, 288);
			this.txt_total.Name = "txt_total";
			this.txt_total.Size = new System.Drawing.Size(168, 22);
			this.txt_total.TabIndex = 23;
			this.txt_total.Text = "";
			// 
			// dtp_Checkout
			// 
			this.dtp_Checkout.CustomFormat = "dd/MM/yyyy";
			this.dtp_Checkout.Enabled = false;
			this.dtp_Checkout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Checkout.Location = new System.Drawing.Point(128, 256);
			this.dtp_Checkout.Name = "dtp_Checkout";
			this.dtp_Checkout.Size = new System.Drawing.Size(168, 22);
			this.dtp_Checkout.TabIndex = 22;
			// 
			// txt_Price
			// 
			this.txt_Price.Enabled = false;
			this.txt_Price.Location = new System.Drawing.Point(128, 160);
			this.txt_Price.Name = "txt_Price";
			this.txt_Price.Size = new System.Drawing.Size(168, 22);
			this.txt_Price.TabIndex = 20;
			this.txt_Price.Text = "";
			this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged_1);
			// 
			// txt_Roomtype
			// 
			this.txt_Roomtype.Enabled = false;
			this.txt_Roomtype.Location = new System.Drawing.Point(128, 128);
			this.txt_Roomtype.Name = "txt_Roomtype";
			this.txt_Roomtype.Size = new System.Drawing.Size(168, 22);
			this.txt_Roomtype.TabIndex = 19;
			this.txt_Roomtype.Text = "";
			// 
			// txt_RoomID
			// 
			this.txt_RoomID.Enabled = false;
			this.txt_RoomID.Location = new System.Drawing.Point(128, 96);
			this.txt_RoomID.Name = "txt_RoomID";
			this.txt_RoomID.Size = new System.Drawing.Size(168, 22);
			this.txt_RoomID.TabIndex = 18;
			this.txt_RoomID.Text = "";
			// 
			// txt_customer_name
			// 
			this.txt_customer_name.Enabled = false;
			this.txt_customer_name.Location = new System.Drawing.Point(128, 32);
			this.txt_customer_name.Name = "txt_customer_name";
			this.txt_customer_name.Size = new System.Drawing.Size(168, 22);
			this.txt_customer_name.TabIndex = 17;
			this.txt_customer_name.Text = "";
			// 
			// lbl_totalpay
			// 
			this.lbl_totalpay.Location = new System.Drawing.Point(16, 288);
			this.lbl_totalpay.Name = "lbl_totalpay";
			this.lbl_totalpay.TabIndex = 7;
			this.lbl_totalpay.Text = "Total Pay :";
			// 
			// lbl_checkoutdate
			// 
			this.lbl_checkoutdate.Location = new System.Drawing.Point(16, 256);
			this.lbl_checkoutdate.Name = "lbl_checkoutdate";
			this.lbl_checkoutdate.Size = new System.Drawing.Size(120, 23);
			this.lbl_checkoutdate.TabIndex = 6;
			this.lbl_checkoutdate.Text = "Check Out Date :";
			// 
			// lbl_checkindate
			// 
			this.lbl_checkindate.Location = new System.Drawing.Point(16, 224);
			this.lbl_checkindate.Name = "lbl_checkindate";
			this.lbl_checkindate.Size = new System.Drawing.Size(104, 23);
			this.lbl_checkindate.TabIndex = 5;
			this.lbl_checkindate.Text = "Check In Date :";
			// 
			// lbl_price
			// 
			this.lbl_price.Location = new System.Drawing.Point(16, 160);
			this.lbl_price.Name = "lbl_price";
			this.lbl_price.TabIndex = 4;
			this.lbl_price.Text = "Price :";
			// 
			// lbl_Roomtype
			// 
			this.lbl_Roomtype.Location = new System.Drawing.Point(16, 128);
			this.lbl_Roomtype.Name = "lbl_Roomtype";
			this.lbl_Roomtype.TabIndex = 3;
			this.lbl_Roomtype.Text = "Room Type :";
			// 
			// lbl_RoomID
			// 
			this.lbl_RoomID.Location = new System.Drawing.Point(16, 96);
			this.lbl_RoomID.Name = "lbl_RoomID";
			this.lbl_RoomID.TabIndex = 2;
			this.lbl_RoomID.Text = "Room ID :";
			// 
			// lbl_BookingID
			// 
			this.lbl_BookingID.Location = new System.Drawing.Point(16, 32);
			this.lbl_BookingID.Name = "lbl_BookingID";
			this.lbl_BookingID.Size = new System.Drawing.Size(120, 23);
			this.lbl_BookingID.TabIndex = 0;
			this.lbl_BookingID.Text = "Customer Name :";
			// 
			// grpCustomer
			// 
			this.grpCustomer.Controls.Add(this.dbg_customer);
			this.grpCustomer.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grpCustomer.ForeColor = System.Drawing.Color.Blue;
			this.grpCustomer.Location = new System.Drawing.Point(327, 47);
			this.grpCustomer.Name = "grpCustomer";
			this.grpCustomer.Size = new System.Drawing.Size(480, 344);
			this.grpCustomer.TabIndex = 2;
			this.grpCustomer.TabStop = false;
			this.grpCustomer.Text = "infomation Customer Check Out";
			// 
			// dbg_customer
			// 
			this.dbg_customer.DataMember = "";
			this.dbg_customer.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_customer.Location = new System.Drawing.Point(-16, 32);
			this.dbg_customer.Name = "dbg_customer";
			this.dbg_customer.Size = new System.Drawing.Size(464, 304);
			this.dbg_customer.TabIndex = 0;
			this.dbg_customer.Click += new System.EventHandler(this.dbg_customer_Click);
			// 
			// btn_printbill
			// 
			this.btn_printbill.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_printbill.ForeColor = System.Drawing.Color.Blue;
			this.btn_printbill.Location = new System.Drawing.Point(328, 408);
			this.btn_printbill.Name = "btn_printbill";
			this.btn_printbill.TabIndex = 3;
			this.btn_printbill.Text = "Print Bill";
			this.btn_printbill.Click += new System.EventHandler(this.btn_printbill_Click);
			// 
			// btn_close
			// 
			this.btn_close.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_close.ForeColor = System.Drawing.Color.Blue;
			this.btn_close.Location = new System.Drawing.Point(408, 408);
			this.btn_close.Name = "btn_close";
			this.btn_close.TabIndex = 4;
			this.btn_close.Text = "Close";
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// prndoc_billroom
			// 
			this.prndoc_billroom.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prndoc_billroom_PrintPage);
			// 
			// prnPrvdlg_billroom
			// 
			this.prnPrvdlg_billroom.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.prnPrvdlg_billroom.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.prnPrvdlg_billroom.ClientSize = new System.Drawing.Size(400, 300);
			this.prnPrvdlg_billroom.Document = this.prndoc_billroom;
			this.prnPrvdlg_billroom.Enabled = true;
			this.prnPrvdlg_billroom.Icon = ((System.Drawing.Icon)(resources.GetObject("prnPrvdlg_billroom.Icon")));
			this.prnPrvdlg_billroom.Location = new System.Drawing.Point(176, 176);
			this.prnPrvdlg_billroom.MinimumSize = new System.Drawing.Size(375, 250);
			this.prnPrvdlg_billroom.Name = "prnPrvdlg_billroom";
			this.prnPrvdlg_billroom.TransparencyKey = System.Drawing.Color.Empty;
			this.prnPrvdlg_billroom.Visible = false;
			// 
			// BillRoom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(816, 446);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_printbill);
			this.Controls.Add(this.grpCustomer);
			this.Controls.Add(this.grp_billroom);
			this.Controls.Add(this.lbl_billroom);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BillRoom";
			this.Text = "BillRoom";
			this.grp_billroom.ResumeLayout(false);
			this.grpCustomer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_customer)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void dbg_customer_Click(object sender, System.EventArgs e)
		{
			try
			{		
				txt_customer_name.Text=dbg_customer[dbg_customer.CurrentRowIndex,0].ToString().Trim();
				txt_RoomID.Text=dbg_customer[dbg_customer.CurrentRowIndex,6].ToString().Trim();
				txt_BokingID.Text=dbg_customer[dbg_customer.CurrentRowIndex,4].ToString().Trim();
				txt_Roomtype.Text=dbg_customer[dbg_customer.CurrentRowIndex,8].ToString().Trim();
				txt_Price.Text=dbg_customer[dbg_customer.CurrentRowIndex,10].ToString().Trim();
				dtp_Checkin.Text=dbg_customer[dbg_customer.CurrentRowIndex,2].ToString().Trim();
				dtp_Checkout.Text=dbg_customer[dbg_customer.CurrentRowIndex,3].ToString().Trim();
				Total();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		public void Total()
		{
			if(dtp_Checkout.Value.Day<dtp_Checkin.Value.Day)
			{
				total=((dtp_Checkout.Value.Day + dtp_Checkin.Value.Day)- dtp_Checkin.Value.Day)* price;

			}
			else
			{
				total=(dtp_Checkout.Value.Day - dtp_Checkin.Value.Day) * price;
			}
			txt_total.Text = total.ToString();

		}

		
		private void btn_printbill_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				cn = Conetion.conet();
				if(cn.State==ConnectionState.Closed)
				{
					cn.Open();

				}
				
				//cm =  new SqlCommand("set dateformat dmy INSERT INTO Bill_Rooms VALUES("+txt_BokingID.Text+",'"+dtp_BillDate.Text+"','"+txt_RoomID.Text+"','"+txt_Roomtype.Text+"',"+txt_Price.Text+",'"+dtp_Checkin.Text+"','"+dtp_Checkout.Text+"',"+txt_total.Text+")",cn);	
				cm = new SqlCommand("set dateformat dmy INSERT INTO Bill_Rooms VALUES(@bookID,@BillDate,@RoomID,@RommType,@Price,@DateIn,@DateOut,@total)",cn);
				
				cm.Parameters.Add("@bookID",SqlDbType.BigInt);
				cm.Parameters.Add("@BillDate",SqlDbType.DateTime);
				cm.Parameters.Add("@RoomID",SqlDbType.VarChar);
				cm.Parameters.Add("@RommType",SqlDbType.VarChar);
				cm.Parameters.Add("@Price",SqlDbType.Money);
				cm.Parameters.Add("@DateIn",SqlDbType.DateTime);
				cm.Parameters.Add("@DateOut",SqlDbType.DateTime);
				cm.Parameters.Add("@total",SqlDbType.Money);

				cm.Parameters["@bookID"].Value = txt_BokingID.Text;
				cm.Parameters["@BillDate"].Value = DateTime.Now;
				cm.Parameters["@RoomID"].Value = txt_RoomID.Text;
				cm.Parameters["@RommType"].Value = txt_Roomtype.Text;
				cm.Parameters["@Price"].Value = txt_Price.Text;
				cm.Parameters["@DateIn"].Value = dtp_Checkin.Value;
				cm.Parameters["@DateOut"].Value = dtp_Checkout.Value;
				cm.Parameters["@total"].Value = txt_total.Text;

				cm.ExecuteNonQuery();
				
				
				MessageBox.Show("Save Bill Room succecfull");
				cn.Close();
			}
			catch(Exception ce)
			{
				MessageBox.Show(ce.ToString());
			}


			try
			{
				prnPrvdlg_billroom.Document=prndoc_billroom;
				prnPrvdlg_billroom.ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		

		private void txt_Price_TextChanged_1(object sender, System.EventArgs e)
		{
			price = Convert.ToSingle(txt_Price.Text);
		
		}


		private void prndoc_billroom_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				e.Graphics.DrawString ("\t\tBill Room\nDelta Hotel\n\n\n\n\n\n\n\n",new Font("Monotype Corsiva",20,FontStyle.Italic),Brushes.Blue,160,125);
				e.Graphics.DrawString ("\n\n\t\t45 Tran Hung Dao street CT.City VN\n\t\t Phone:0710464006-0945706007\n\nCustomer Name:\t"+txt_customer_name.Text+"\nRoom ID:\t\t"+txt_RoomID.Text+"\nBooking ID:\t"+txt_BokingID.Text+"\n Room Type:\t"+txt_Roomtype.Text+"\n Price:\t\t"+txt_Price.Text+"\n Tatal Pay:\t"+txt_total.Text+" USD\n Bill Date:\t\t"+dtp_BillDate.Text+"\n Checkin Date:\t"+dtp_Checkin.Text+"\n Checkout Date:\t"+dtp_Checkout.Text,new Font("Monotype Corsiva",16,FontStyle.Italic),Brushes.Black,160,125);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			
		}

		private void txt_customer_name_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		
	}
}
