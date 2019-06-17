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
	/// Summary description for ChangeRoom.
	/// </summary>
	public class ChangeRoom : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lbl_TitleChangeroom;
		private System.Windows.Forms.GroupBox grp_ChangRoom;
		private System.Windows.Forms.DataGrid dbg_ListCheckIn;
		private System.Windows.Forms.Button btn_SearchRoom;
		private System.Windows.Forms.TextBox txt_SearchRoomID;
		private System.Windows.Forms.DateTimePicker dtp_SearchCheckInDate;
		private System.Windows.Forms.Label lbl_SearchRoomID;
		private System.Windows.Forms.Label lbl_SearchCheckInDate;
		private System.Windows.Forms.GroupBox grp_RoomInfomation;
		private System.Windows.Forms.DataGrid dbg_RoomInfomation;
		private System.Windows.Forms.Label lbl_PriceSearchRoom;
		private System.Windows.Forms.ComboBox cob_Price;
		private System.Windows.Forms.Button btn_SearListRoom;
		private System.Windows.Forms.Button btn_ViewAllRoom;
		private System.Windows.Forms.GroupBox grp_InfomationRoom;
		private System.Windows.Forms.TextBox txt_Price;
		private System.Windows.Forms.TextBox txt_RoomID;
		private System.Windows.Forms.Label lbl_Price;
		private System.Windows.Forms.Label lbl_RoomID;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_ChangeRoom;
		private System.Windows.Forms.Label lbl_ListCheckIn;
		SqlConnection cn;
		SqlCommand cm;
		SqlDataAdapter da;
		DataSet ds;
		SqlDataReader read;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChangeRoom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ChangeRoom));
			this.lbl_TitleChangeroom = new System.Windows.Forms.Label();
			this.grp_ChangRoom = new System.Windows.Forms.GroupBox();
			this.lbl_ListCheckIn = new System.Windows.Forms.Label();
			this.dbg_ListCheckIn = new System.Windows.Forms.DataGrid();
			this.btn_SearchRoom = new System.Windows.Forms.Button();
			this.txt_SearchRoomID = new System.Windows.Forms.TextBox();
			this.dtp_SearchCheckInDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_SearchRoomID = new System.Windows.Forms.Label();
			this.lbl_SearchCheckInDate = new System.Windows.Forms.Label();
			this.grp_RoomInfomation = new System.Windows.Forms.GroupBox();
			this.dbg_RoomInfomation = new System.Windows.Forms.DataGrid();
			this.lbl_PriceSearchRoom = new System.Windows.Forms.Label();
			this.cob_Price = new System.Windows.Forms.ComboBox();
			this.btn_SearListRoom = new System.Windows.Forms.Button();
			this.btn_ViewAllRoom = new System.Windows.Forms.Button();
			this.grp_InfomationRoom = new System.Windows.Forms.GroupBox();
			this.txt_Price = new System.Windows.Forms.TextBox();
			this.txt_RoomID = new System.Windows.Forms.TextBox();
			this.lbl_Price = new System.Windows.Forms.Label();
			this.lbl_RoomID = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_ChangeRoom = new System.Windows.Forms.Button();
			this.grp_ChangRoom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListCheckIn)).BeginInit();
			this.grp_RoomInfomation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_RoomInfomation)).BeginInit();
			this.grp_InfomationRoom.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_TitleChangeroom
			// 
			this.lbl_TitleChangeroom.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_TitleChangeroom.ForeColor = System.Drawing.Color.Blue;
			this.lbl_TitleChangeroom.Location = new System.Drawing.Point(264, 8);
			this.lbl_TitleChangeroom.Name = "lbl_TitleChangeroom";
			this.lbl_TitleChangeroom.Size = new System.Drawing.Size(200, 32);
			this.lbl_TitleChangeroom.TabIndex = 0;
			this.lbl_TitleChangeroom.Text = "Change Room";
			// 
			// grp_ChangRoom
			// 
			this.grp_ChangRoom.Controls.Add(this.lbl_ListCheckIn);
			this.grp_ChangRoom.Controls.Add(this.dbg_ListCheckIn);
			this.grp_ChangRoom.Controls.Add(this.btn_SearchRoom);
			this.grp_ChangRoom.Controls.Add(this.txt_SearchRoomID);
			this.grp_ChangRoom.Controls.Add(this.dtp_SearchCheckInDate);
			this.grp_ChangRoom.Controls.Add(this.lbl_SearchRoomID);
			this.grp_ChangRoom.Controls.Add(this.lbl_SearchCheckInDate);
			this.grp_ChangRoom.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_ChangRoom.ForeColor = System.Drawing.Color.Blue;
			this.grp_ChangRoom.Location = new System.Drawing.Point(8, 48);
			this.grp_ChangRoom.Name = "grp_ChangRoom";
			this.grp_ChangRoom.Size = new System.Drawing.Size(448, 256);
			this.grp_ChangRoom.TabIndex = 1;
			this.grp_ChangRoom.TabStop = false;
			this.grp_ChangRoom.Text = "Change Room";
			this.grp_ChangRoom.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// lbl_ListCheckIn
			// 
			this.lbl_ListCheckIn.Location = new System.Drawing.Point(16, 80);
			this.lbl_ListCheckIn.Name = "lbl_ListCheckIn";
			this.lbl_ListCheckIn.Size = new System.Drawing.Size(120, 23);
			this.lbl_ListCheckIn.TabIndex = 6;
			this.lbl_ListCheckIn.Text = "List Check In :";
			// 
			// dbg_ListCheckIn
			// 
			this.dbg_ListCheckIn.DataMember = "";
			this.dbg_ListCheckIn.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_ListCheckIn.Location = new System.Drawing.Point(8, 104);
			this.dbg_ListCheckIn.Name = "dbg_ListCheckIn";
			this.dbg_ListCheckIn.Size = new System.Drawing.Size(432, 144);
			this.dbg_ListCheckIn.TabIndex = 5;
			this.dbg_ListCheckIn.Click += new System.EventHandler(this.dbg_ListCheckIn_Click);
			// 
			// btn_SearchRoom
			// 
			this.btn_SearchRoom.Location = new System.Drawing.Point(288, 24);
			this.btn_SearchRoom.Name = "btn_SearchRoom";
			this.btn_SearchRoom.TabIndex = 4;
			this.btn_SearchRoom.Text = "Search";
			this.btn_SearchRoom.Click += new System.EventHandler(this.btn_SearchRoom_Click);
			// 
			// txt_SearchRoomID
			// 
			this.txt_SearchRoomID.Location = new System.Drawing.Point(128, 48);
			this.txt_SearchRoomID.Name = "txt_SearchRoomID";
			this.txt_SearchRoomID.Size = new System.Drawing.Size(144, 22);
			this.txt_SearchRoomID.TabIndex = 3;
			this.txt_SearchRoomID.Text = "";
			// 
			// dtp_SearchCheckInDate
			// 
			this.dtp_SearchCheckInDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_SearchCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_SearchCheckInDate.Location = new System.Drawing.Point(128, 24);
			this.dtp_SearchCheckInDate.Name = "dtp_SearchCheckInDate";
			this.dtp_SearchCheckInDate.Size = new System.Drawing.Size(144, 22);
			this.dtp_SearchCheckInDate.TabIndex = 2;
			// 
			// lbl_SearchRoomID
			// 
			this.lbl_SearchRoomID.Location = new System.Drawing.Point(16, 56);
			this.lbl_SearchRoomID.Name = "lbl_SearchRoomID";
			this.lbl_SearchRoomID.TabIndex = 1;
			this.lbl_SearchRoomID.Text = "Room ID :";
			// 
			// lbl_SearchCheckInDate
			// 
			this.lbl_SearchCheckInDate.Location = new System.Drawing.Point(16, 24);
			this.lbl_SearchCheckInDate.Name = "lbl_SearchCheckInDate";
			this.lbl_SearchCheckInDate.Size = new System.Drawing.Size(104, 23);
			this.lbl_SearchCheckInDate.TabIndex = 0;
			this.lbl_SearchCheckInDate.Text = "Check In Date :";
			// 
			// grp_RoomInfomation
			// 
			this.grp_RoomInfomation.Controls.Add(this.dbg_RoomInfomation);
			this.grp_RoomInfomation.Controls.Add(this.lbl_PriceSearchRoom);
			this.grp_RoomInfomation.Controls.Add(this.cob_Price);
			this.grp_RoomInfomation.Controls.Add(this.btn_SearListRoom);
			this.grp_RoomInfomation.Controls.Add(this.btn_ViewAllRoom);
			this.grp_RoomInfomation.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_RoomInfomation.ForeColor = System.Drawing.Color.Blue;
			this.grp_RoomInfomation.Location = new System.Drawing.Point(8, 304);
			this.grp_RoomInfomation.Name = "grp_RoomInfomation";
			this.grp_RoomInfomation.Size = new System.Drawing.Size(760, 216);
			this.grp_RoomInfomation.TabIndex = 2;
			this.grp_RoomInfomation.TabStop = false;
			this.grp_RoomInfomation.Text = "Infomation Room";
			// 
			// dbg_RoomInfomation
			// 
			this.dbg_RoomInfomation.DataMember = "";
			this.dbg_RoomInfomation.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_RoomInfomation.Location = new System.Drawing.Point(12, 56);
			this.dbg_RoomInfomation.Name = "dbg_RoomInfomation";
			this.dbg_RoomInfomation.Size = new System.Drawing.Size(736, 152);
			this.dbg_RoomInfomation.TabIndex = 4;
			this.dbg_RoomInfomation.Click += new System.EventHandler(this.dbg_RoomInfomation_Click);
			// 
			// lbl_PriceSearchRoom
			// 
			this.lbl_PriceSearchRoom.Location = new System.Drawing.Point(8, 24);
			this.lbl_PriceSearchRoom.Name = "lbl_PriceSearchRoom";
			this.lbl_PriceSearchRoom.Size = new System.Drawing.Size(56, 23);
			this.lbl_PriceSearchRoom.TabIndex = 3;
			this.lbl_PriceSearchRoom.Text = "Price";
			// 
			// cob_Price
			// 
			this.cob_Price.Items.AddRange(new object[] {
														   "74",
														   "78",
														   "81",
														   "88",
														   "105",
														   "165",
														   "225"});
			this.cob_Price.Location = new System.Drawing.Point(72, 24);
			this.cob_Price.Name = "cob_Price";
			this.cob_Price.Size = new System.Drawing.Size(128, 24);
			this.cob_Price.TabIndex = 2;
			// 
			// btn_SearListRoom
			// 
			this.btn_SearListRoom.Location = new System.Drawing.Point(208, 24);
			this.btn_SearListRoom.Name = "btn_SearListRoom";
			this.btn_SearListRoom.TabIndex = 1;
			this.btn_SearListRoom.Text = "Search";
			this.btn_SearListRoom.Click += new System.EventHandler(this.btn_SearListRoom_Click);
			// 
			// btn_ViewAllRoom
			// 
			this.btn_ViewAllRoom.Location = new System.Drawing.Point(288, 24);
			this.btn_ViewAllRoom.Name = "btn_ViewAllRoom";
			this.btn_ViewAllRoom.Size = new System.Drawing.Size(112, 23);
			this.btn_ViewAllRoom.TabIndex = 0;
			this.btn_ViewAllRoom.Text = "View All Room";
			this.btn_ViewAllRoom.Click += new System.EventHandler(this.btn_ViewAllRoom_Click);
			// 
			// grp_InfomationRoom
			// 
			this.grp_InfomationRoom.Controls.Add(this.txt_Price);
			this.grp_InfomationRoom.Controls.Add(this.txt_RoomID);
			this.grp_InfomationRoom.Controls.Add(this.lbl_Price);
			this.grp_InfomationRoom.Controls.Add(this.lbl_RoomID);
			this.grp_InfomationRoom.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_InfomationRoom.ForeColor = System.Drawing.Color.Blue;
			this.grp_InfomationRoom.Location = new System.Drawing.Point(462, 48);
			this.grp_InfomationRoom.Name = "grp_InfomationRoom";
			this.grp_InfomationRoom.Size = new System.Drawing.Size(306, 112);
			this.grp_InfomationRoom.TabIndex = 3;
			this.grp_InfomationRoom.TabStop = false;
			this.grp_InfomationRoom.Text = "Infomation Room";
			// 
			// txt_Price
			// 
			this.txt_Price.Location = new System.Drawing.Point(128, 72);
			this.txt_Price.Name = "txt_Price";
			this.txt_Price.Size = new System.Drawing.Size(160, 22);
			this.txt_Price.TabIndex = 5;
			this.txt_Price.Text = "";
			// 
			// txt_RoomID
			// 
			this.txt_RoomID.Location = new System.Drawing.Point(128, 32);
			this.txt_RoomID.Name = "txt_RoomID";
			this.txt_RoomID.Size = new System.Drawing.Size(160, 22);
			this.txt_RoomID.TabIndex = 4;
			this.txt_RoomID.Text = "";
			// 
			// lbl_Price
			// 
			this.lbl_Price.Location = new System.Drawing.Point(16, 72);
			this.lbl_Price.Name = "lbl_Price";
			this.lbl_Price.TabIndex = 1;
			this.lbl_Price.Text = "Price :";
			// 
			// lbl_RoomID
			// 
			this.lbl_RoomID.Location = new System.Drawing.Point(16, 32);
			this.lbl_RoomID.Name = "lbl_RoomID";
			this.lbl_RoomID.TabIndex = 0;
			this.lbl_RoomID.Text = "Room ID :";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btn_Cancel);
			this.groupBox4.Controls.Add(this.btn_ChangeRoom);
			this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.Blue;
			this.groupBox4.Location = new System.Drawing.Point(456, 160);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(312, 64);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ForeColor = System.Drawing.Color.Blue;
			this.btn_Cancel.Location = new System.Drawing.Point(216, 26);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Cancel";
			// 
			// btn_ChangeRoom
			// 
			this.btn_ChangeRoom.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_ChangeRoom.ForeColor = System.Drawing.Color.Blue;
			this.btn_ChangeRoom.Location = new System.Drawing.Point(102, 26);
			this.btn_ChangeRoom.Name = "btn_ChangeRoom";
			this.btn_ChangeRoom.Size = new System.Drawing.Size(104, 23);
			this.btn_ChangeRoom.TabIndex = 0;
			this.btn_ChangeRoom.Text = "Change Room";
			this.btn_ChangeRoom.Click += new System.EventHandler(this.btn_ChangeRoom_Click);
			// 
			// ChangeRoom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(784, 534);
			this.Controls.Add(this.grp_InfomationRoom);
			this.Controls.Add(this.grp_RoomInfomation);
			this.Controls.Add(this.grp_ChangRoom);
			this.Controls.Add(this.lbl_TitleChangeroom);
			this.Controls.Add(this.groupBox4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ChangeRoom";
			this.Text = "ChangeRoom";
			this.Load += new System.EventHandler(this.ChangeRoom_Load);
			this.grp_ChangRoom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListCheckIn)).EndInit();
			this.grp_RoomInfomation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_RoomInfomation)).EndInit();
			this.grp_InfomationRoom.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}
		public void ListRoom()
		{
			try
			{
				cn = Conetion.conet();
				cm =  new SqlCommand("select * from Room where Room_Status=0 and Room_ID NOT IN (SELECT Room_ID FROM Booking_Details)",cn);
				cn.Open();
				da = new SqlDataAdapter();
				da.SelectCommand=cm;
				ds=new DataSet();
				da.Fill(ds,"Room");
				dbg_RoomInfomation.DataSource=ds;
				dbg_RoomInfomation.DataMember="Room";
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void LoadCheckIn()
		{
			try
			{
				cn = Conetion.conet();
				cm = new SqlCommand("SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,Booking_Rooms.Booking_Date,Room.Room_Status FROM Room INNER JOIN Booking_Details ON Room.Room_ID = Booking_Details.Room_ID INNER JOIN Booking_Rooms ON Booking_Details.Booking_ID = Booking_Rooms.Booking_ID INNER JOIN Customer ON Booking_Rooms.Customer_ID = Customer.Customer_ID where Room.Room_Status='1'",cn);
				cn.Open();
				da = new SqlDataAdapter();
				da.SelectCommand=cm;
				ds = new DataSet();
				da.Fill(ds,"Customer");
				dbg_ListCheckIn.DataSource=ds;
				dbg_ListCheckIn.DataMember="Customer";
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		private void ChangeRoom_Load(object sender, System.EventArgs e)
		{
			ListRoom();
			LoadCheckIn();
		}

		private void btn_ViewAllRoom_Click(object sender, System.EventArgs e)
		{
			ListRoom();
		}

		private void btn_SearListRoom_Click(object sender, System.EventArgs e)
		{
			if(cob_Price.Text.Equals(""))
			{
				MessageBox.Show("Price No Empty");
				cob_Price.Focus();
			}
			else
			{
				cn = Conetion.conet();
				int Count=0;
				cm = new SqlCommand("select * from Room where Price=" + int.Parse(cob_Price.Text) + "and Room_Status='0' and Room_ID NOT IN (SELECT Room_ID FROM Booking_Details)", cn);
				cn.Open();
				read = cm.ExecuteReader();
				if(read.HasRows)
				{
					Count = 1;
				}
				read.Close();
				if(Count == 1)
				{
					da = new SqlDataAdapter();
					da.SelectCommand=cm;
					ds = new DataSet();
					da.Fill(ds,"Room");
					dbg_RoomInfomation.DataSource=ds.Tables["Room"];
				}
				if(Count == 0)
				{
					MessageBox.Show("Room Not Exit");
				}
			}
		}

		private void dbg_RoomInfomation_Click(object sender, System.EventArgs e)
		{
			txt_RoomID.Text=dbg_RoomInfomation[dbg_RoomInfomation.CurrentRowIndex,0].ToString().Trim();
			txt_Price.Text=dbg_RoomInfomation[dbg_RoomInfomation.CurrentRowIndex,3].ToString().Trim();
		}

		private void btn_SearchRoom_Click(object sender, System.EventArgs e)
		{
			if(txt_SearchRoomID.Text.Equals(""))
			{
				MessageBox.Show("Please,Choice RoomID");
			}
			else
			{
				try
				{
					cn = Conetion.conet();
					int count = 0;
					//cm =  new SqlCommand("select * from Room where Room_ID = (select Room_ID from Room where Room_ID = '"+txt_SearchRoomID.Text.Trim()+"'",cn);
					//SET DATEFORMAT dmy
					cm =  new SqlCommand("SET DATEFORMAT dmy SELECT Customer.Customer_Name, Customer.Customer_Passpor, Booking_Details.Checkin_Date,Booking_Details.Chechout_Date, Customer.Customer_ID, Room.Room_ID, Room.Price,Room.No_fo_bed, Booking_Rooms.Booking_Date, Room.Room_Status FROM Booking_Details INNER JOIN Room ON Booking_Details.Room_ID = Room.Room_ID INNER JOIN Booking_Rooms ON Booking_Details.Booking_ID = Booking_Rooms.Booking_ID INNER JOIN Customer ON Booking_Rooms.Customer_ID = Customer.Customer_ID WHERE (Room.Room_ID='"+txt_SearchRoomID.Text.Trim()+"')and (Booking_Details.Checkin_Date='"+dtp_SearchCheckInDate.Text.Trim()+"') and (Room.Room_Status='1')",cn);
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
						da.Fill(ds,"Room");
						dbg_ListCheckIn.DataSource = ds.Tables["Room"];
					}
					if(count == 0)
					{
						MessageBox.Show("Room Not Exit");
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		private void btn_ChangeRoom_Click(object sender, System.EventArgs e)
		{
			string GetRooID = dbg_ListCheckIn[dbg_ListCheckIn.CurrentRowIndex, 5].ToString();
			string getRoomChooice = dbg_RoomInfomation[dbg_RoomInfomation.CurrentRowIndex, 0].ToString();
        
			int getBookID = this.Select_BookID(GetRooID);

			this.ChangRoom_UpadateBooking(getRoomChooice, getBookID);
			this.ChangRoom_UpdateRoomChang(getRoomChooice);
			this.ChangRoom_UpdateRoomDangO(GetRooID);
			MessageBox.Show("ChangeRoom Sucsefull");


		}
		//update bang booking detail.
		public void ChangRoom_UpadateBooking(string RooID, int BookID)
		{
			try
			{
				cn = Conetion.conet();
				cm = new SqlCommand("Update Booking_Details set Room_ID = '" + RooID + "' where Booking_ID = "+BookID+"", cn);
				cn.Open();
				cm.ExecuteNonQuery();
				cn.Close();            
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		//update bang Room =1 de lay gia tri checkin.
		public void ChangRoom_UpdateRoomChang(string RooID)
		{
			try
			{
				cn = Conetion.conet();
				cm = new SqlCommand("Update Room set Room_Status = 1 where Room_ID = '" + RooID + "'", cn);
				cn.Open();
				cm.ExecuteNonQuery();
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		//update bang Room set gia tri bang 0  de tra ve pong trong
		public void ChangRoom_UpdateRoomDangO(string RooID)
		{
			try
			{

				cn = Conetion.conet();
				cm = new SqlCommand("Update Room set Room_Status = 0 where Room_ID = '" + RooID + "'", cn);
				cn.Open();
				cm.ExecuteNonQuery();
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		public int Select_BookID(string ROOID)
		{
			try
			{

				cn = Conetion.conet();
				cm = new SqlCommand("select Booking_ID from Booking_Details where Room_ID = '" + ROOID + "'", cn);
				da = new SqlDataAdapter();
				da.SelectCommand = cm;
				ds = new DataSet();
				da.Fill(ds,"Booking");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return Convert.ToInt32(ds.Tables["Booking"].Rows[0]["Booking_ID"].ToString());


		}
		private void dbg_ListCheckIn_Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
