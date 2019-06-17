using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using Nhom4;
namespace Nhom4
{
	/// <summary>
	/// Summary description for CheckIn.
	/// </summary>
	public class CheckIn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_TitleCheckIn;
		private System.Windows.Forms.GroupBox grp_SearchInfomationCustomer;
		private System.Windows.Forms.Label lbl_ListAllooking;
		private System.Windows.Forms.Label lbl_RoomID;
		private System.Windows.Forms.Label lbl_CustomerName;
		private System.Windows.Forms.Label lbl_CheckInDate;
		private System.Windows.Forms.Label lbl_CheckOutDate;
		private System.Windows.Forms.TextBox txt_RoomID;
		private System.Windows.Forms.TextBox txt_CustomerName;
		private System.Windows.Forms.DateTimePicker dtp_CheckInDate;
		private System.Windows.Forms.DateTimePicker dtp_CheckOutDate;
		private System.Windows.Forms.DataGrid dbg_ListRoomBookingCustomer;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.TextBox txt_CustomerNameSearch;
		private System.Windows.Forms.Label lbl_CustomerNameSearch;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_CheckIn;
		private System.Windows.Forms.GroupBox grp_ListCheckIn;
		private System.Windows.Forms.DataGrid dbg_ListCheckIn;
		SqlConnection cn;
		SqlCommand cm;
		SqlDataAdapter da,da1;
		DataSet ds,ds1;
		SqlDataReader read;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CheckIn()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CheckIn));
			this.lbl_TitleCheckIn = new System.Windows.Forms.Label();
			this.grp_SearchInfomationCustomer = new System.Windows.Forms.GroupBox();
			this.lbl_ListAllooking = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_RoomID = new System.Windows.Forms.Label();
			this.lbl_CustomerName = new System.Windows.Forms.Label();
			this.lbl_CheckInDate = new System.Windows.Forms.Label();
			this.lbl_CheckOutDate = new System.Windows.Forms.Label();
			this.txt_RoomID = new System.Windows.Forms.TextBox();
			this.txt_CustomerName = new System.Windows.Forms.TextBox();
			this.dtp_CheckInDate = new System.Windows.Forms.DateTimePicker();
			this.dtp_CheckOutDate = new System.Windows.Forms.DateTimePicker();
			this.dbg_ListRoomBookingCustomer = new System.Windows.Forms.DataGrid();
			this.btn_Search = new System.Windows.Forms.Button();
			this.txt_CustomerNameSearch = new System.Windows.Forms.TextBox();
			this.lbl_CustomerNameSearch = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_CheckIn = new System.Windows.Forms.Button();
			this.grp_ListCheckIn = new System.Windows.Forms.GroupBox();
			this.dbg_ListCheckIn = new System.Windows.Forms.DataGrid();
			this.grp_SearchInfomationCustomer.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoomBookingCustomer)).BeginInit();
			this.grp_ListCheckIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListCheckIn)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_TitleCheckIn
			// 
			this.lbl_TitleCheckIn.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_TitleCheckIn.ForeColor = System.Drawing.Color.Blue;
			this.lbl_TitleCheckIn.Location = new System.Drawing.Point(304, 8);
			this.lbl_TitleCheckIn.Name = "lbl_TitleCheckIn";
			this.lbl_TitleCheckIn.Size = new System.Drawing.Size(136, 32);
			this.lbl_TitleCheckIn.TabIndex = 0;
			this.lbl_TitleCheckIn.Text = "Check In";
			// 
			// grp_SearchInfomationCustomer
			// 
			this.grp_SearchInfomationCustomer.Controls.Add(this.lbl_ListAllooking);
			this.grp_SearchInfomationCustomer.Controls.Add(this.groupBox1);
			this.grp_SearchInfomationCustomer.Controls.Add(this.dbg_ListRoomBookingCustomer);
			this.grp_SearchInfomationCustomer.Controls.Add(this.btn_Search);
			this.grp_SearchInfomationCustomer.Controls.Add(this.txt_CustomerNameSearch);
			this.grp_SearchInfomationCustomer.Controls.Add(this.lbl_CustomerNameSearch);
			this.grp_SearchInfomationCustomer.Controls.Add(this.btn_Close);
			this.grp_SearchInfomationCustomer.Controls.Add(this.btn_CheckIn);
			this.grp_SearchInfomationCustomer.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_SearchInfomationCustomer.ForeColor = System.Drawing.Color.Blue;
			this.grp_SearchInfomationCustomer.Location = new System.Drawing.Point(24, 40);
			this.grp_SearchInfomationCustomer.Name = "grp_SearchInfomationCustomer";
			this.grp_SearchInfomationCustomer.Size = new System.Drawing.Size(744, 224);
			this.grp_SearchInfomationCustomer.TabIndex = 2;
			this.grp_SearchInfomationCustomer.TabStop = false;
			this.grp_SearchInfomationCustomer.Text = "Search Infomation customer";
			this.grp_SearchInfomationCustomer.Enter += new System.EventHandler(this.grp_SearchInfomationCustomer_Enter);
			// 
			// lbl_ListAllooking
			// 
			this.lbl_ListAllooking.Location = new System.Drawing.Point(10, 48);
			this.lbl_ListAllooking.Name = "lbl_ListAllooking";
			this.lbl_ListAllooking.Size = new System.Drawing.Size(176, 23);
			this.lbl_ListAllooking.TabIndex = 11;
			this.lbl_ListAllooking.Text = "List All Booking Customer";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_RoomID);
			this.groupBox1.Controls.Add(this.lbl_CustomerName);
			this.groupBox1.Controls.Add(this.lbl_CheckInDate);
			this.groupBox1.Controls.Add(this.lbl_CheckOutDate);
			this.groupBox1.Controls.Add(this.txt_RoomID);
			this.groupBox1.Controls.Add(this.txt_CustomerName);
			this.groupBox1.Controls.Add(this.dtp_CheckInDate);
			this.groupBox1.Controls.Add(this.dtp_CheckOutDate);
			this.groupBox1.Location = new System.Drawing.Point(448, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 152);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// lbl_RoomID
			// 
			this.lbl_RoomID.Location = new System.Drawing.Point(8, 24);
			this.lbl_RoomID.Name = "lbl_RoomID";
			this.lbl_RoomID.TabIndex = 0;
			this.lbl_RoomID.Text = "Room ID :";
			// 
			// lbl_CustomerName
			// 
			this.lbl_CustomerName.Location = new System.Drawing.Point(8, 56);
			this.lbl_CustomerName.Name = "lbl_CustomerName";
			this.lbl_CustomerName.Size = new System.Drawing.Size(128, 23);
			this.lbl_CustomerName.TabIndex = 9;
			this.lbl_CustomerName.Text = "Customer\'s Name :";
			// 
			// lbl_CheckInDate
			// 
			this.lbl_CheckInDate.Location = new System.Drawing.Point(8, 88);
			this.lbl_CheckInDate.Name = "lbl_CheckInDate";
			this.lbl_CheckInDate.Size = new System.Drawing.Size(104, 23);
			this.lbl_CheckInDate.TabIndex = 3;
			this.lbl_CheckInDate.Text = "Check In Date :";
			// 
			// lbl_CheckOutDate
			// 
			this.lbl_CheckOutDate.Location = new System.Drawing.Point(8, 120);
			this.lbl_CheckOutDate.Name = "lbl_CheckOutDate";
			this.lbl_CheckOutDate.Size = new System.Drawing.Size(120, 23);
			this.lbl_CheckOutDate.TabIndex = 4;
			this.lbl_CheckOutDate.Text = "Check Out Date :";
			// 
			// txt_RoomID
			// 
			this.txt_RoomID.Location = new System.Drawing.Point(136, 16);
			this.txt_RoomID.Name = "txt_RoomID";
			this.txt_RoomID.Size = new System.Drawing.Size(144, 22);
			this.txt_RoomID.TabIndex = 6;
			this.txt_RoomID.Text = "";
			// 
			// txt_CustomerName
			// 
			this.txt_CustomerName.Location = new System.Drawing.Point(136, 56);
			this.txt_CustomerName.Name = "txt_CustomerName";
			this.txt_CustomerName.Size = new System.Drawing.Size(144, 22);
			this.txt_CustomerName.TabIndex = 2;
			this.txt_CustomerName.Text = "";
			// 
			// dtp_CheckInDate
			// 
			this.dtp_CheckInDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_CheckInDate.Enabled = false;
			this.dtp_CheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_CheckInDate.Location = new System.Drawing.Point(136, 88);
			this.dtp_CheckInDate.Name = "dtp_CheckInDate";
			this.dtp_CheckInDate.Size = new System.Drawing.Size(144, 22);
			this.dtp_CheckInDate.TabIndex = 8;
			// 
			// dtp_CheckOutDate
			// 
			this.dtp_CheckOutDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_CheckOutDate.Enabled = false;
			this.dtp_CheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_CheckOutDate.Location = new System.Drawing.Point(136, 120);
			this.dtp_CheckOutDate.Name = "dtp_CheckOutDate";
			this.dtp_CheckOutDate.Size = new System.Drawing.Size(144, 22);
			this.dtp_CheckOutDate.TabIndex = 7;
			// 
			// dbg_ListRoomBookingCustomer
			// 
			this.dbg_ListRoomBookingCustomer.DataMember = "";
			this.dbg_ListRoomBookingCustomer.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_ListRoomBookingCustomer.Location = new System.Drawing.Point(8, 72);
			this.dbg_ListRoomBookingCustomer.Name = "dbg_ListRoomBookingCustomer";
			this.dbg_ListRoomBookingCustomer.Size = new System.Drawing.Size(432, 112);
			this.dbg_ListRoomBookingCustomer.TabIndex = 3;
			this.dbg_ListRoomBookingCustomer.Click += new System.EventHandler(this.ClickAllCustomerBooking);
			this.dbg_ListRoomBookingCustomer.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dbg_ListRoomBookingCustomer_Navigate);
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(362, 18);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.TabIndex = 2;
			this.btn_Search.Text = "&Search";
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// txt_CustomerNameSearch
			// 
			this.txt_CustomerNameSearch.Location = new System.Drawing.Point(144, 19);
			this.txt_CustomerNameSearch.Name = "txt_CustomerNameSearch";
			this.txt_CustomerNameSearch.Size = new System.Drawing.Size(168, 22);
			this.txt_CustomerNameSearch.TabIndex = 1;
			this.txt_CustomerNameSearch.Text = "";
			// 
			// lbl_CustomerNameSearch
			// 
			this.lbl_CustomerNameSearch.Location = new System.Drawing.Point(7, 19);
			this.lbl_CustomerNameSearch.Name = "lbl_CustomerNameSearch";
			this.lbl_CustomerNameSearch.Size = new System.Drawing.Size(128, 23);
			this.lbl_CustomerNameSearch.TabIndex = 0;
			this.lbl_CustomerNameSearch.Text = "Customer\'s Name :";
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(216, 192);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.TabIndex = 2;
			this.btn_Close.Text = "Close";
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_CheckIn
			// 
			this.btn_CheckIn.Location = new System.Drawing.Point(128, 192);
			this.btn_CheckIn.Name = "btn_CheckIn";
			this.btn_CheckIn.TabIndex = 1;
			this.btn_CheckIn.Text = "Check In";
			this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
			// 
			// grp_ListCheckIn
			// 
			this.grp_ListCheckIn.Controls.Add(this.dbg_ListCheckIn);
			this.grp_ListCheckIn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_ListCheckIn.ForeColor = System.Drawing.Color.Blue;
			this.grp_ListCheckIn.Location = new System.Drawing.Point(24, 272);
			this.grp_ListCheckIn.Name = "grp_ListCheckIn";
			this.grp_ListCheckIn.Size = new System.Drawing.Size(744, 192);
			this.grp_ListCheckIn.TabIndex = 3;
			this.grp_ListCheckIn.TabStop = false;
			this.grp_ListCheckIn.Text = "List Check In";
			// 
			// dbg_ListCheckIn
			// 
			this.dbg_ListCheckIn.DataMember = "";
			this.dbg_ListCheckIn.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_ListCheckIn.Location = new System.Drawing.Point(16, 32);
			this.dbg_ListCheckIn.Name = "dbg_ListCheckIn";
			this.dbg_ListCheckIn.Size = new System.Drawing.Size(720, 152);
			this.dbg_ListCheckIn.TabIndex = 0;
			this.dbg_ListCheckIn.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dbg_ListCheckIn_Navigate);
			// 
			// CheckIn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(776, 517);
			this.Controls.Add(this.grp_ListCheckIn);
			this.Controls.Add(this.grp_SearchInfomationCustomer);
			this.Controls.Add(this.lbl_TitleCheckIn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CheckIn";
			this.Text = "CheckIn";
			this.Load += new System.EventHandler(this.CheckIn_Load);
			this.grp_SearchInfomationCustomer.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoomBookingCustomer)).EndInit();
			this.grp_ListCheckIn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListCheckIn)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}
		public void LoadBookingRoom()
		{
			try
			{
				cn = Conetion.conet();
				cm =  new SqlCommand("SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,Booking_Rooms.Booking_Date,Room.Room_Status FROM Room INNER JOIN Booking_Details ON Room.Room_ID = Booking_Details.Room_ID INNER JOIN Booking_Rooms ON Booking_Details.Booking_ID = Booking_Rooms.Booking_ID INNER JOIN Customer ON Booking_Rooms.Customer_ID = Customer.Customer_ID where Room.Room_Status='0'",cn);
				cn.Open();
				da = new SqlDataAdapter();
				da.SelectCommand = cm;
				ds = new DataSet();
				da.Fill(ds,"Customer");
				dbg_ListRoomBookingCustomer.DataSource = ds;
				dbg_ListRoomBookingCustomer.DataMember = "Customer";
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void LoadChecInRoom()
		{
			try
			{
				cn = Conetion.conet();
				cm =  new SqlCommand("SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,Booking_Rooms.Booking_Date,Room.Room_Status FROM Room INNER JOIN Booking_Details ON Room.Room_ID = Booking_Details.Room_ID INNER JOIN Booking_Rooms ON Booking_Details.Booking_ID = Booking_Rooms.Booking_ID INNER JOIN Customer ON Booking_Rooms.Customer_ID = Customer.Customer_ID where Room.Room_Status='1'",cn);
				cn.Open();
				da1 = new SqlDataAdapter();
				da1.SelectCommand = cm;
				ds1 = new DataSet();
				da1.Fill(ds1,"Customer");
				dbg_ListCheckIn.DataSource = ds1;
				dbg_ListCheckIn.DataMember = "Customer";
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void UpdateCheckIn()
		{
			try
			{
				cn.Open();
				cm = new SqlCommand("Update Room set Room_Status = '1' where Room_ID = '"+txt_RoomID.Text+"'",cn);
				cm.ExecuteNonQuery();
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void CheckIn_Load(object sender, System.EventArgs e)
		{
			LoadBookingRoom();
			LoadChecInRoom();
		}
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			try
			{
				int count = 0;
				cm =  new SqlCommand("SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,Booking_Rooms.Booking_Date,Room.Room_Status FROM Room INNER JOIN Booking_Details ON Room.Room_ID = Booking_Details.Room_ID INNER JOIN Booking_Rooms ON Booking_Details.Booking_ID = Booking_Rooms.Booking_ID INNER JOIN Customer ON Booking_Rooms.Customer_ID = Customer.Customer_ID where Customer.Customer_Name='"+txt_CustomerNameSearch.Text+"'and Room.Room_Status='0'",cn);
				cn.Open();
				read = cm.ExecuteReader();
				if(read.HasRows)
				{
					count = 1;
					
				}
				read.Close();
				if(count == 1)
				{
					da = new SqlDataAdapter();
					da.SelectCommand = cm;
					ds = new DataSet();
					da.Fill(ds,"Customer");
					dbg_ListRoomBookingCustomer.DataSource = ds.Tables["Customer"];
				}
				if(count == 0)
				{
					MessageBox.Show("Customer Not Exit");
				}
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ClickAllCustomerBooking(object sender, System.EventArgs e)
		{
			txt_RoomID.Text = dbg_ListRoomBookingCustomer[dbg_ListRoomBookingCustomer.CurrentRowIndex,5].ToString().Trim();
			txt_CustomerName.Text = dbg_ListRoomBookingCustomer[dbg_ListRoomBookingCustomer.CurrentRowIndex,0].ToString().Trim();
			dtp_CheckInDate.Text = dbg_ListRoomBookingCustomer[dbg_ListRoomBookingCustomer.CurrentRowIndex,2].ToString().Trim();
			dtp_CheckOutDate.Text = dbg_ListRoomBookingCustomer[dbg_ListRoomBookingCustomer.CurrentRowIndex,3].ToString().Trim();
		}
		public void Loaddata()
		{
			cn = Conetion.conet();
			if(cn.State==ConnectionState.Closed)
			{
				cn.Open();
			}
			cm=new SqlCommand("SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,Booking_Rooms.Booking_Date,Room.Room_Status FROM Room INNER JOIN Booking_Details ON Room.Room_ID = Booking_Details.Room_ID INNER JOIN Booking_Rooms ON Booking_Details.Booking_ID = Booking_Rooms.Booking_ID INNER JOIN Customer ON Booking_Rooms.Customer_ID = Customer.Customer_ID where Room.Room_Status='1'",cn);
			da=new SqlDataAdapter(cm);
			ds=new DataSet();
			da.Fill(ds,"Customer");
			dbg_ListCheckIn.DataSource=ds.Tables["Customer"];
		}
		private void btn_CheckIn_Click(object sender, System.EventArgs e)
		{
			LoadChecInRoom();
			UpdateCheckIn();
			Loaddata();
			MessageBox.Show("CheckIn Sucsefull");
		}

		private void grp_SearchInfomationCustomer_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void dbg_ListCheckIn_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}

		private void dbg_ListRoomBookingCustomer_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}
	}
}
