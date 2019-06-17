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
	/// Summary description for SearchRoom.
	/// </summary>
	public class SearchRoom : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.GroupBox grp_searchinfomation;
		private System.Windows.Forms.Label lbl_roomtype;
		private System.Windows.Forms.Label lbl_price;
		private System.Windows.Forms.Label lbl_noofbed;
		private System.Windows.Forms.ComboBox cob_roomtype;
		private System.Windows.Forms.ComboBox cob_price;
		private System.Windows.Forms.ComboBox cob_noofbed;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.GroupBox grp_Room;
		private System.Windows.Forms.Label lbl_listRoom;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Label lbl_listRoomBooking;
		private System.Windows.Forms.Button btn_booking;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_close;
		SqlConnection cn;
		SqlCommand cm;
		SqlDataAdapter da;
		DataSet ds,ds1;
		SqlDataReader read;
		public BookingRoom broom;

		private  System.Windows.Forms.DataGrid dbg_ListRoomBooking;
		private  System.Windows.Forms.DataGrid dbg_ListRoom;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SearchRoom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SearchRoom));
			this.lbl_title = new System.Windows.Forms.Label();
			this.grp_searchinfomation = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_Search = new System.Windows.Forms.Button();
			this.cob_noofbed = new System.Windows.Forms.ComboBox();
			this.cob_price = new System.Windows.Forms.ComboBox();
			this.cob_roomtype = new System.Windows.Forms.ComboBox();
			this.lbl_noofbed = new System.Windows.Forms.Label();
			this.lbl_price = new System.Windows.Forms.Label();
			this.lbl_roomtype = new System.Windows.Forms.Label();
			this.grp_Room = new System.Windows.Forms.GroupBox();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_booking = new System.Windows.Forms.Button();
			this.dbg_ListRoomBooking = new System.Windows.Forms.DataGrid();
			this.lbl_listRoomBooking = new System.Windows.Forms.Label();
			this.btn_Add = new System.Windows.Forms.Button();
			this.dbg_ListRoom = new System.Windows.Forms.DataGrid();
			this.lbl_listRoom = new System.Windows.Forms.Label();
			this.grp_searchinfomation.SuspendLayout();
			this.grp_Room.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoomBooking)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoom)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_title
			// 
			this.lbl_title.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title.ForeColor = System.Drawing.Color.Blue;
			this.lbl_title.Location = new System.Drawing.Point(264, 8);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(192, 40);
			this.lbl_title.TabIndex = 0;
			this.lbl_title.Text = "Search Room";
			// 
			// grp_searchinfomation
			// 
			this.grp_searchinfomation.Controls.Add(this.pictureBox1);
			this.grp_searchinfomation.Controls.Add(this.btn_Search);
			this.grp_searchinfomation.Controls.Add(this.cob_noofbed);
			this.grp_searchinfomation.Controls.Add(this.cob_price);
			this.grp_searchinfomation.Controls.Add(this.cob_roomtype);
			this.grp_searchinfomation.Controls.Add(this.lbl_noofbed);
			this.grp_searchinfomation.Controls.Add(this.lbl_price);
			this.grp_searchinfomation.Controls.Add(this.lbl_roomtype);
			this.grp_searchinfomation.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_searchinfomation.ForeColor = System.Drawing.Color.Blue;
			this.grp_searchinfomation.Location = new System.Drawing.Point(8, 56);
			this.grp_searchinfomation.Name = "grp_searchinfomation";
			this.grp_searchinfomation.Size = new System.Drawing.Size(720, 160);
			this.grp_searchinfomation.TabIndex = 1;
			this.grp_searchinfomation.TabStop = false;
			this.grp_searchinfomation.Text = "Search Infomation";
			this.grp_searchinfomation.Enter += new System.EventHandler(this.grp_searchinfomation_Enter);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(496, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 128);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(320, 24);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.TabIndex = 10;
			this.btn_Search.Text = "Search";
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// cob_noofbed
			// 
			this.cob_noofbed.Items.AddRange(new object[] {
															 "1",
															 "2",
															 "3",
															 "4",
															 "5",
															 "6"});
			this.cob_noofbed.Location = new System.Drawing.Point(128, 88);
			this.cob_noofbed.Name = "cob_noofbed";
			this.cob_noofbed.Size = new System.Drawing.Size(168, 24);
			this.cob_noofbed.TabIndex = 5;
			// 
			// cob_price
			// 
			this.cob_price.Items.AddRange(new object[] {
														   "74",
														   "78",
														   "81",
														   "88",
														   "105",
														   "225"});
			this.cob_price.Location = new System.Drawing.Point(128, 56);
			this.cob_price.Name = "cob_price";
			this.cob_price.Size = new System.Drawing.Size(168, 24);
			this.cob_price.TabIndex = 4;
			// 
			// cob_roomtype
			// 
			this.cob_roomtype.AllowDrop = true;
			this.cob_roomtype.Items.AddRange(new object[] {
															  "Guest ",
															  "Suite  "});
			this.cob_roomtype.Location = new System.Drawing.Point(128, 24);
			this.cob_roomtype.Name = "cob_roomtype";
			this.cob_roomtype.Size = new System.Drawing.Size(168, 24);
			this.cob_roomtype.TabIndex = 3;
			// 
			// lbl_noofbed
			// 
			this.lbl_noofbed.Location = new System.Drawing.Point(8, 88);
			this.lbl_noofbed.Name = "lbl_noofbed";
			this.lbl_noofbed.TabIndex = 2;
			this.lbl_noofbed.Text = "No of Bed";
			// 
			// lbl_price
			// 
			this.lbl_price.Location = new System.Drawing.Point(8, 56);
			this.lbl_price.Name = "lbl_price";
			this.lbl_price.TabIndex = 1;
			this.lbl_price.Text = "Price";
			// 
			// lbl_roomtype
			// 
			this.lbl_roomtype.Location = new System.Drawing.Point(8, 24);
			this.lbl_roomtype.Name = "lbl_roomtype";
			this.lbl_roomtype.TabIndex = 0;
			this.lbl_roomtype.Text = "Room Type";
			// 
			// grp_Room
			// 
			this.grp_Room.Controls.Add(this.btn_close);
			this.grp_Room.Controls.Add(this.btn_cancel);
			this.grp_Room.Controls.Add(this.btn_booking);
			this.grp_Room.Controls.Add(this.dbg_ListRoomBooking);
			this.grp_Room.Controls.Add(this.lbl_listRoomBooking);
			this.grp_Room.Controls.Add(this.btn_Add);
			this.grp_Room.Controls.Add(this.dbg_ListRoom);
			this.grp_Room.Controls.Add(this.lbl_listRoom);
			this.grp_Room.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_Room.ForeColor = System.Drawing.Color.Blue;
			this.grp_Room.Location = new System.Drawing.Point(8, 216);
			this.grp_Room.Name = "grp_Room";
			this.grp_Room.Size = new System.Drawing.Size(720, 336);
			this.grp_Room.TabIndex = 2;
			this.grp_Room.TabStop = false;
			this.grp_Room.Text = "Room Infomation";
			// 
			// btn_close
			// 
			this.btn_close.Location = new System.Drawing.Point(424, 296);
			this.btn_close.Name = "btn_close";
			this.btn_close.TabIndex = 8;
			this.btn_close.Text = "Close";
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Enabled = false;
			this.btn_cancel.Location = new System.Drawing.Point(320, 296);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.TabIndex = 7;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_booking
			// 
			this.btn_booking.Enabled = false;
			this.btn_booking.Location = new System.Drawing.Point(224, 296);
			this.btn_booking.Name = "btn_booking";
			this.btn_booking.TabIndex = 5;
			this.btn_booking.Text = "Booking";
			this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
			// 
			// dbg_ListRoomBooking
			// 
			this.dbg_ListRoomBooking.DataMember = "";
			this.dbg_ListRoomBooking.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_ListRoomBooking.Location = new System.Drawing.Point(8, 184);
			this.dbg_ListRoomBooking.Name = "dbg_ListRoomBooking";
			this.dbg_ListRoomBooking.Size = new System.Drawing.Size(704, 104);
			this.dbg_ListRoomBooking.TabIndex = 4;
			// 
			// lbl_listRoomBooking
			// 
			this.lbl_listRoomBooking.Location = new System.Drawing.Point(288, 168);
			this.lbl_listRoomBooking.Name = "lbl_listRoomBooking";
			this.lbl_listRoomBooking.Size = new System.Drawing.Size(128, 16);
			this.lbl_listRoomBooking.TabIndex = 3;
			this.lbl_listRoomBooking.Text = "List Room Booking";
			this.lbl_listRoomBooking.Click += new System.EventHandler(this.label8_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Enabled = false;
			this.btn_Add.Location = new System.Drawing.Point(315, 145);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.TabIndex = 2;
			this.btn_Add.Text = "Add";
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// dbg_ListRoom
			// 
			this.dbg_ListRoom.DataMember = "";
			this.dbg_ListRoom.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_ListRoom.Location = new System.Drawing.Point(8, 24);
			this.dbg_ListRoom.Name = "dbg_ListRoom";
			this.dbg_ListRoom.Size = new System.Drawing.Size(704, 120);
			this.dbg_ListRoom.TabIndex = 1;
			this.dbg_ListRoom.Click += new System.EventHandler(this.ClickData);
			this.dbg_ListRoom.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dbg_ListRoom_Navigate);
			// 
			// lbl_listRoom
			// 
			this.lbl_listRoom.Location = new System.Drawing.Point(320, 8);
			this.lbl_listRoom.Name = "lbl_listRoom";
			this.lbl_listRoom.Size = new System.Drawing.Size(72, 16);
			this.lbl_listRoom.TabIndex = 0;
			this.lbl_listRoom.Text = "List Room";
			// 
			// SearchRoom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(736, 557);
			this.Controls.Add(this.grp_Room);
			this.Controls.Add(this.grp_searchinfomation);
			this.Controls.Add(this.lbl_title);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchRoom";
			this.Text = "SearchRoom";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.SearchRoom_Load);
			this.grp_searchinfomation.ResumeLayout(false);
			this.grp_Room.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoomBooking)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoom)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label8_Click(object sender, System.EventArgs e)
		{
		
		}

		private void SearchRoom_Load(object sender, System.EventArgs e)
		{
			try
			{
				cn = Conetion.conet();
				cm =  new SqlCommand("select * from Room where Room_Status='0' and (Room_ID NOT IN (SELECT Room_ID FROM Booking_Details))",cn);
				cn.Open();
				da = new SqlDataAdapter();
				da.SelectCommand=cm;
				ds=new DataSet();
				da.Fill(ds,"Room");
				dbg_ListRoom.DataSource=ds;
				dbg_ListRoom.DataMember="Room";
				cn.Close();
				ds1=ds.Clone();
				dbg_ListRoomBooking.DataSource=ds1;
				dbg_ListRoomBooking.DataMember=ds1.Tables[0].TableName;	
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void SearchDataGrid()
		{
			da = new SqlDataAdapter();
			ds = new DataSet();
			da.Fill(ds,"Room");
			DataView view = new DataView(ds.Tables[0]);
			dbg_ListRoom.DataSource = view;
		}
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			if(cob_roomtype.Text.Equals(""))
			{
				MessageBox.Show("Please,Choice Room Type!!!!");
				return;
			}
			else if(cob_price.Text.Equals(""))
			{
				MessageBox.Show("Please,Choice Price!!!!");
				return;
			}
			else if(cob_noofbed.Text.Equals(""))
			{
				MessageBox.Show("Please,Choice No_Of_Bed");
				return;
			}
			else
			{
				try
				{
					int count = 0;
					cm = new SqlCommand("select * from Room where Room_TypeID = (select Room_TypeID from RoomType where Room_type_Name = '" + cob_roomtype.Text.Trim() + "')and Price=" + int.Parse(cob_price.Text) + " and No_fo_bed=" + int.Parse(cob_noofbed.Text) + "and Room_Status='0' and (Room_ID NOT IN (Select Room_ID From Booking_Details))", cn);
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
						dbg_ListRoom.DataSource = ds.Tables["Room"];
					}
					if(count == 0)
					{
						MessageBox.Show("Room Not Exit");
					}
					cn.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btn_Add_Click(object sender, System.EventArgs e)
		{
			btn_booking.Enabled=true;
			btn_cancel.Enabled=true;
			ds.Tables["Room"].PrimaryKey=new DataColumn[]{ds.Tables["Room"].Columns["Room_ID"]};
			//ds1.Tables["Room"].PrimaryKey = new DataColumn[] {ds1.Tables["Room"].Columns["Room_ID"]};
			object Room_ID = dbg_ListRoom[dbg_ListRoom.CurrentCell.RowNumber,0];
			DataRow row = ds.Tables["Room"].Rows.Find(new object[]{Room_ID});
			try
			{
				ds1.Tables[0].ImportRow(row);
				ds.Tables["Room"].Rows[dbg_ListRoom.CurrentCell.RowNumber].Delete();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			btn_Add.Enabled=false;
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				ds1.Tables[0].Rows.Remove(ds1.Tables[0].Rows[dbg_ListRoomBooking.CurrentCell.RowNumber]);
			}
			catch(Exception)
			{
				MessageBox.Show("Record empty!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}		
		}

		private void dbg_ListRoom_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{

		}
		public void Loaddatagrid()
		{
			broom.dbg_ListRoom.DataSource=ds1;
			broom.dbg_ListRoom.DataMember=ds1.Tables[0].TableName;
			dbg_ListRoomBooking.DataSource=ds1;		
		}
		private void btn_booking_Click(object sender, System.EventArgs e)
		{	
			broom = new BookingRoom();
			broom.MdiParent=MainForm.main;
			broom.Show();	
			Loaddatagrid();
			this.Close();
		}

		private void ClickData(object sender, System.EventArgs e)
		{
			btn_Add.Enabled=true;
		}

		private void grp_searchinfomation_Enter(object sender, System.EventArgs e)
		{
		
		}

	
	}
}
