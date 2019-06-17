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
	/// Summary description for CheckOut.
	/// </summary>
	public class CheckOut : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.GroupBox grp_List;
		private System.Windows.Forms.DataGrid dbg_List;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Label lbl_RoomID1;
		private System.Windows.Forms.TextBox txt_RoomID1;
		private System.Windows.Forms.GroupBox grp_Info;
		private System.Windows.Forms.DateTimePicker dtp_Checkoutdate;
		private System.Windows.Forms.DateTimePicker dtp_Checkindate;
		private System.Windows.Forms.Label lbl_Checkoutdate;
		private System.Windows.Forms.Label lbl_Checkindate;
		private System.Windows.Forms.TextBox txt_RoomID2;
		private System.Windows.Forms.TextBox txt_Passpor;
		private System.Windows.Forms.TextBox txt_Customer;
		private System.Windows.Forms.Label lbl_RoomID2;
		private System.Windows.Forms.Label lbl_Passpor;
		private System.Windows.Forms.Label lbl_Cuctomer;
		private System.Windows.Forms.Button btn_CheckOut;
		private System.Windows.Forms.Button btn_Cancel;

		private SqlConnection cn;
		private SqlDataAdapter da;
		private SqlCommand cm; 
		private DataSet ds,ds1;
		public BillRoom Bill;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CheckOut()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CheckOut));
			this.lbl_Title = new System.Windows.Forms.Label();
			this.grp_List = new System.Windows.Forms.GroupBox();
			this.dbg_List = new System.Windows.Forms.DataGrid();
			this.btn_Search = new System.Windows.Forms.Button();
			this.lbl_RoomID1 = new System.Windows.Forms.Label();
			this.txt_RoomID1 = new System.Windows.Forms.TextBox();
			this.grp_Info = new System.Windows.Forms.GroupBox();
			this.dtp_Checkoutdate = new System.Windows.Forms.DateTimePicker();
			this.dtp_Checkindate = new System.Windows.Forms.DateTimePicker();
			this.lbl_Checkoutdate = new System.Windows.Forms.Label();
			this.lbl_Checkindate = new System.Windows.Forms.Label();
			this.txt_RoomID2 = new System.Windows.Forms.TextBox();
			this.txt_Passpor = new System.Windows.Forms.TextBox();
			this.txt_Customer = new System.Windows.Forms.TextBox();
			this.lbl_RoomID2 = new System.Windows.Forms.Label();
			this.lbl_Passpor = new System.Windows.Forms.Label();
			this.lbl_Cuctomer = new System.Windows.Forms.Label();
			this.btn_CheckOut = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.grp_List.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_List)).BeginInit();
			this.grp_Info.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.Blue;
			this.lbl_Title.Location = new System.Drawing.Point(288, 8);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(152, 32);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "Check Out";
			// 
			// grp_List
			// 
			this.grp_List.Controls.Add(this.dbg_List);
			this.grp_List.Controls.Add(this.btn_Search);
			this.grp_List.Controls.Add(this.lbl_RoomID1);
			this.grp_List.Controls.Add(this.txt_RoomID1);
			this.grp_List.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_List.ForeColor = System.Drawing.Color.Blue;
			this.grp_List.Location = new System.Drawing.Point(16, 48);
			this.grp_List.Name = "grp_List";
			this.grp_List.Size = new System.Drawing.Size(664, 192);
			this.grp_List.TabIndex = 1;
			this.grp_List.TabStop = false;
			this.grp_List.Text = "List Check In";
			// 
			// dbg_List
			// 
			this.dbg_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dbg_List.DataMember = "";
			this.dbg_List.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_List.Location = new System.Drawing.Point(8, 56);
			this.dbg_List.Name = "dbg_List";
			this.dbg_List.Size = new System.Drawing.Size(648, 128);
			this.dbg_List.TabIndex = 3;
			this.dbg_List.Click += new System.EventHandler(this.dbg_List_Click);
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(304, 24);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.TabIndex = 2;
			this.btn_Search.Text = "Search";
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// lbl_RoomID1
			// 
			this.lbl_RoomID1.Location = new System.Drawing.Point(24, 24);
			this.lbl_RoomID1.Name = "lbl_RoomID1";
			this.lbl_RoomID1.TabIndex = 1;
			this.lbl_RoomID1.Text = "Room ID";
			// 
			// txt_RoomID1
			// 
			this.txt_RoomID1.Location = new System.Drawing.Point(136, 24);
			this.txt_RoomID1.Name = "txt_RoomID1";
			this.txt_RoomID1.Size = new System.Drawing.Size(144, 22);
			this.txt_RoomID1.TabIndex = 0;
			this.txt_RoomID1.Text = "";
			// 
			// grp_Info
			// 
			this.grp_Info.Controls.Add(this.dtp_Checkoutdate);
			this.grp_Info.Controls.Add(this.dtp_Checkindate);
			this.grp_Info.Controls.Add(this.lbl_Checkoutdate);
			this.grp_Info.Controls.Add(this.lbl_Checkindate);
			this.grp_Info.Controls.Add(this.txt_RoomID2);
			this.grp_Info.Controls.Add(this.txt_Passpor);
			this.grp_Info.Controls.Add(this.txt_Customer);
			this.grp_Info.Controls.Add(this.lbl_RoomID2);
			this.grp_Info.Controls.Add(this.lbl_Passpor);
			this.grp_Info.Controls.Add(this.lbl_Cuctomer);
			this.grp_Info.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_Info.ForeColor = System.Drawing.Color.Blue;
			this.grp_Info.Location = new System.Drawing.Point(16, 256);
			this.grp_Info.Name = "grp_Info";
			this.grp_Info.Size = new System.Drawing.Size(664, 120);
			this.grp_Info.TabIndex = 2;
			this.grp_Info.TabStop = false;
			this.grp_Info.Text = "Infomation Check Out";
			this.grp_Info.Enter += new System.EventHandler(this.grp_Info_Enter);
			// 
			// dtp_Checkoutdate
			// 
			this.dtp_Checkoutdate.CustomFormat = "dd/MM/yyyy";
			this.dtp_Checkoutdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Checkoutdate.Location = new System.Drawing.Point(440, 72);
			this.dtp_Checkoutdate.Name = "dtp_Checkoutdate";
			this.dtp_Checkoutdate.Size = new System.Drawing.Size(160, 22);
			this.dtp_Checkoutdate.TabIndex = 9;
			// 
			// dtp_Checkindate
			// 
			this.dtp_Checkindate.CustomFormat = "dd/MM/yyyy";
			this.dtp_Checkindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Checkindate.Location = new System.Drawing.Point(440, 24);
			this.dtp_Checkindate.Name = "dtp_Checkindate";
			this.dtp_Checkindate.Size = new System.Drawing.Size(160, 22);
			this.dtp_Checkindate.TabIndex = 8;
			this.dtp_Checkindate.Value = new System.DateTime(2008, 10, 28, 0, 0, 0, 0);
			// 
			// lbl_Checkoutdate
			// 
			this.lbl_Checkoutdate.Location = new System.Drawing.Point(320, 72);
			this.lbl_Checkoutdate.Name = "lbl_Checkoutdate";
			this.lbl_Checkoutdate.Size = new System.Drawing.Size(120, 23);
			this.lbl_Checkoutdate.TabIndex = 7;
			this.lbl_Checkoutdate.Text = "Check Out Date :";
			// 
			// lbl_Checkindate
			// 
			this.lbl_Checkindate.Location = new System.Drawing.Point(320, 24);
			this.lbl_Checkindate.Name = "lbl_Checkindate";
			this.lbl_Checkindate.Size = new System.Drawing.Size(104, 23);
			this.lbl_Checkindate.TabIndex = 6;
			this.lbl_Checkindate.Text = "Check In Date :";
			// 
			// txt_RoomID2
			// 
			this.txt_RoomID2.Location = new System.Drawing.Point(136, 88);
			this.txt_RoomID2.Name = "txt_RoomID2";
			this.txt_RoomID2.Size = new System.Drawing.Size(168, 22);
			this.txt_RoomID2.TabIndex = 5;
			this.txt_RoomID2.Text = "";
			// 
			// txt_Passpor
			// 
			this.txt_Passpor.Location = new System.Drawing.Point(136, 56);
			this.txt_Passpor.Name = "txt_Passpor";
			this.txt_Passpor.Size = new System.Drawing.Size(168, 22);
			this.txt_Passpor.TabIndex = 4;
			this.txt_Passpor.Text = "";
			// 
			// txt_Customer
			// 
			this.txt_Customer.Location = new System.Drawing.Point(136, 24);
			this.txt_Customer.Name = "txt_Customer";
			this.txt_Customer.Size = new System.Drawing.Size(168, 22);
			this.txt_Customer.TabIndex = 3;
			this.txt_Customer.Text = "";
			// 
			// lbl_RoomID2
			// 
			this.lbl_RoomID2.Location = new System.Drawing.Point(16, 88);
			this.lbl_RoomID2.Name = "lbl_RoomID2";
			this.lbl_RoomID2.TabIndex = 2;
			this.lbl_RoomID2.Text = "Room ID :";
			// 
			// lbl_Passpor
			// 
			this.lbl_Passpor.Location = new System.Drawing.Point(16, 56);
			this.lbl_Passpor.Name = "lbl_Passpor";
			this.lbl_Passpor.TabIndex = 1;
			this.lbl_Passpor.Text = "Passport:";
			// 
			// lbl_Cuctomer
			// 
			this.lbl_Cuctomer.Location = new System.Drawing.Point(16, 24);
			this.lbl_Cuctomer.Name = "lbl_Cuctomer";
			this.lbl_Cuctomer.Size = new System.Drawing.Size(120, 23);
			this.lbl_Cuctomer.TabIndex = 0;
			this.lbl_Cuctomer.Text = "Customer Name :";
			// 
			// btn_CheckOut
			// 
			this.btn_CheckOut.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_CheckOut.ForeColor = System.Drawing.Color.Blue;
			this.btn_CheckOut.Location = new System.Drawing.Point(256, 392);
			this.btn_CheckOut.Name = "btn_CheckOut";
			this.btn_CheckOut.Size = new System.Drawing.Size(80, 23);
			this.btn_CheckOut.TabIndex = 3;
			this.btn_CheckOut.Text = "Check Out";
			this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ForeColor = System.Drawing.Color.Blue;
			this.btn_Cancel.Location = new System.Drawing.Point(352, 392);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.TabIndex = 4;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// CheckOut
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 429);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_CheckOut);
			this.Controls.Add(this.grp_Info);
			this.Controls.Add(this.grp_List);
			this.Controls.Add(this.lbl_Title);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CheckOut";
			this.Text = "CheckOut";
			this.Load += new System.EventHandler(this.CheckOut_Load);
			this.grp_List.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_List)).EndInit();
			this.grp_Info.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CheckOut_Load(object sender, System.EventArgs e)
		{
			try
			{

				cn = Conetion.conet();
				cm =  new SqlCommand("SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Booking_Details.Booking_ID,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,RoomType.Room_type_Name,Booking_Rooms.Booking_Date,Room.Price,Room.Room_Status FROM Customer INNER JOIN Booking_Rooms ON Customer.Customer_ID = Booking_Rooms.Customer_ID INNER JOIN Booking_Details ON Booking_Rooms.Booking_ID = Booking_Details.Booking_ID INNER JOIN Room ON Booking_Details.Room_ID = Room.Room_ID INNER JOIN RoomType ON Room.Room_TypeID = RoomType.Room_TypeID where Room.Room_Status='1'",cn);
				cn.Open();
				da = new SqlDataAdapter(cm);
				ds=new DataSet();
				da.Fill(ds,"Customer");
				dbg_List.DataSource=ds.Tables["Customer"];
				cn.Close();
				

			}
			catch(Exception ce)
			{
				MessageBox.Show(ce.ToString());
			}
		}

		private void dbg_List_Click(object sender, System.EventArgs e)
		{
			//			try
			//			{
				
			txt_Customer.Text=dbg_List[dbg_List.CurrentRowIndex,0].ToString().Trim();
			txt_RoomID2.Text=dbg_List[dbg_List.CurrentRowIndex,6].ToString().Trim();
			txt_Passpor.Text=dbg_List[dbg_List.CurrentRowIndex,1].ToString().Trim();
			dtp_Checkindate.Text=dbg_List[dbg_List.CurrentRowIndex,2].ToString().Trim();
			dtp_Checkoutdate.Text=dbg_List[dbg_List.CurrentRowIndex,3].ToString().Trim();
			
			//			}
			//			catch(Exception ce)
			//			{
			//				MessageBox.Show(ce.ToString());
			//			}
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			SqlCommand cm=new SqlCommand("SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Booking_Details.Booking_ID,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,RoomType.Room_type_Name,Booking_Rooms.Booking_Date,Room.Price,Room.Room_Status FROM Customer INNER JOIN Booking_Rooms ON Customer.Customer_ID = Booking_Rooms.Customer_ID INNER JOIN Booking_Details ON Booking_Rooms.Booking_ID = Booking_Details.Booking_ID INNER JOIN Room ON Booking_Details.Room_ID = Room.Room_ID INNER JOIN RoomType ON Room.Room_TypeID = RoomType.Room_TypeID WHERE Room.Room_Status='1' AND Room.Room_ID  = '"+txt_RoomID1.Text+"'",cn);

			SqlDataAdapter da=new SqlDataAdapter(cm);
			ds=new DataSet();
			da.Fill(ds,"Customer");
			dbg_List.DataSource=ds.Tables["Customer"];

		
		}
		public void data()
		{
			Bill.dbg_customer.DataSource=ds1;
			Bill.dbg_customer.DataMember=ds1.Tables["Customer"].TableName;
			dbg_List.DataSource=ds;
		}


		private void btn_CheckOut_Click(object sender, System.EventArgs e)
		{
			try
			{
				string String = "SELECT Customer.Customer_Name,Customer.Customer_Passpor,Booking_Details.Checkin_Date,Booking_Details.Chechout_Date,Booking_Details.Booking_ID,Customer.Customer_ID,Room.Room_ID,Room.No_fo_bed,RoomType.Room_type_Name,Booking_Rooms.Booking_Date,Room.Price "
					+"FROM Customer INNER JOIN Booking_Rooms ON Customer.Customer_ID = Booking_Rooms.Customer_ID "
					+"INNER JOIN Booking_Details ON Booking_Rooms.Booking_ID = Booking_Details.Booking_ID "
					+"INNER JOIN Room ON Booking_Details.Room_ID = Room.Room_ID "
					+"INNER JOIN RoomType ON Room.Room_TypeID = RoomType.Room_TypeID where Customer.Customer_ID='"+dbg_List[dbg_List.CurrentRowIndex,5].ToString()+"'";
				SqlDataAdapter da = new SqlDataAdapter(String, cn);
				ds1 = new DataSet();
				da.Fill(ds1, "Customer");
				Bill=new BillRoom();
				SqlCommand cmUpdateStatus = new SqlCommand("update Room set Room_Status = 0 where Room_ID = '"+txt_RoomID2.Text+"'",cn);
				cn.Open();
				cmUpdateStatus.ExecuteNonQuery();
				cn.Close();
				Bill.MdiParent=MainForm.main;
				this.Close();
				Bill.Show();
				data();
			}
			catch (SqlException se)
			{
				MessageBox.Show(se.Message);
			}

			

		}

		private void grp_Info_Enter(object sender, System.EventArgs e)
		{
		
		}

		
	}
}
