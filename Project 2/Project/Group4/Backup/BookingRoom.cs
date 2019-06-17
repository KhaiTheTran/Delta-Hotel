using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;



namespace Nhom4
{
	/// <summary>
	/// Summary description for BookingRoom.
	/// </summary>
	public class BookingRoom : System.Windows.Forms.Form
	{
		SearchRoom objSearch = new SearchRoom();
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label lbl_passpor;
		private System.Windows.Forms.Label lbl_birthdate;
		private System.Windows.Forms.Label lbl_gender;
		private System.Windows.Forms.Label lbl_phone;
		private System.Windows.Forms.Label lbl_address;
		private System.Windows.Forms.Label lbl_customer;
		private System.Windows.Forms.Label lbl_checkoutDate;
		private System.Windows.Forms.Label lbl_checkingdate;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.GroupBox grp_sex;
		private System.Windows.Forms.RadioButton rad_femade;
		private System.Windows.Forms.RadioButton rad_made;
		private System.Windows.Forms.GroupBox grp_booking;
		private System.Windows.Forms.Label lbl_bookingdate;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_booking;
		private System.Windows.Forms.GroupBox grp_listroom;
		private System.Windows.Forms.GroupBox grp_customer;
		private System.Windows.Forms.TextBox txt_Passpor;
		private System.Windows.Forms.TextBox txt_Phone;
		private System.Windows.Forms.TextBox txt_Address;
		private System.Windows.Forms.TextBox txt_CustomerName;
		private System.Windows.Forms.Button btn_CheckIn;
		SqlConnection cn;
		SqlCommand cm;
		SqlDataAdapter da;
		DataSet ds;
		private string sex ="";
		private System.Windows.Forms.DateTimePicker dtb_BirthDate;
		public System.Windows.Forms.DataGrid dbg_ListRoom;
		private System.Windows.Forms.DateTimePicker dtp_BookingDate;
		private System.Windows.Forms.DateTimePicker dtp_CheckoutDate;
		private System.Windows.Forms.DateTimePicker dtp_CheckInDate;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BookingRoom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BookingRoom));
			this.lbl_title = new System.Windows.Forms.Label();
			this.grp_customer = new System.Windows.Forms.GroupBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.lbl_passpor = new System.Windows.Forms.Label();
			this.txt_Passpor = new System.Windows.Forms.TextBox();
			this.dtb_BirthDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_birthdate = new System.Windows.Forms.Label();
			this.grp_sex = new System.Windows.Forms.GroupBox();
			this.rad_femade = new System.Windows.Forms.RadioButton();
			this.rad_made = new System.Windows.Forms.RadioButton();
			this.txt_Phone = new System.Windows.Forms.TextBox();
			this.txt_Address = new System.Windows.Forms.TextBox();
			this.txt_CustomerName = new System.Windows.Forms.TextBox();
			this.lbl_gender = new System.Windows.Forms.Label();
			this.lbl_phone = new System.Windows.Forms.Label();
			this.lbl_address = new System.Windows.Forms.Label();
			this.lbl_customer = new System.Windows.Forms.Label();
			this.grp_booking = new System.Windows.Forms.GroupBox();
			this.dtp_BookingDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_bookingdate = new System.Windows.Forms.Label();
			this.dtp_CheckoutDate = new System.Windows.Forms.DateTimePicker();
			this.dtp_CheckInDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_checkoutDate = new System.Windows.Forms.Label();
			this.lbl_checkingdate = new System.Windows.Forms.Label();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_booking = new System.Windows.Forms.Button();
			this.dbg_ListRoom = new System.Windows.Forms.DataGrid();
			this.grp_listroom = new System.Windows.Forms.GroupBox();
			this.btn_CheckIn = new System.Windows.Forms.Button();
			this.grp_customer.SuspendLayout();
			this.grp_sex.SuspendLayout();
			this.grp_booking.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoom)).BeginInit();
			this.grp_listroom.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_title
			// 
			this.lbl_title.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title.ForeColor = System.Drawing.Color.Blue;
			this.lbl_title.Location = new System.Drawing.Point(264, 16);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(208, 40);
			this.lbl_title.TabIndex = 0;
			this.lbl_title.Text = "Booking Room";
			// 
			// grp_customer
			// 
			this.grp_customer.Controls.Add(this.btn_cancel);
			this.grp_customer.Controls.Add(this.btn_save);
			this.grp_customer.Controls.Add(this.lbl_passpor);
			this.grp_customer.Controls.Add(this.txt_Passpor);
			this.grp_customer.Controls.Add(this.dtb_BirthDate);
			this.grp_customer.Controls.Add(this.lbl_birthdate);
			this.grp_customer.Controls.Add(this.grp_sex);
			this.grp_customer.Controls.Add(this.txt_Phone);
			this.grp_customer.Controls.Add(this.txt_Address);
			this.grp_customer.Controls.Add(this.txt_CustomerName);
			this.grp_customer.Controls.Add(this.lbl_gender);
			this.grp_customer.Controls.Add(this.lbl_phone);
			this.grp_customer.Controls.Add(this.lbl_address);
			this.grp_customer.Controls.Add(this.lbl_customer);
			this.grp_customer.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_customer.ForeColor = System.Drawing.Color.Blue;
			this.grp_customer.Location = new System.Drawing.Point(8, 64);
			this.grp_customer.Name = "grp_customer";
			this.grp_customer.Size = new System.Drawing.Size(320, 360);
			this.grp_customer.TabIndex = 1;
			this.grp_customer.TabStop = false;
			this.grp_customer.Text = "Infomation Customer";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(198, 280);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.TabIndex = 13;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(118, 280);
			this.btn_save.Name = "btn_save";
			this.btn_save.TabIndex = 12;
			this.btn_save.Text = "Save";
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// lbl_passpor
			// 
			this.lbl_passpor.Location = new System.Drawing.Point(12, 240);
			this.lbl_passpor.Name = "lbl_passpor";
			this.lbl_passpor.TabIndex = 11;
			this.lbl_passpor.Text = "Passport";
			// 
			// txt_Passpor
			// 
			this.txt_Passpor.Location = new System.Drawing.Point(119, 239);
			this.txt_Passpor.Name = "txt_Passpor";
			this.txt_Passpor.Size = new System.Drawing.Size(152, 22);
			this.txt_Passpor.TabIndex = 10;
			this.txt_Passpor.Text = "";
			// 
			// dtb_BirthDate
			// 
			this.dtb_BirthDate.CustomFormat = "dd/MM/yyyy";
			this.dtb_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtb_BirthDate.Location = new System.Drawing.Point(120, 208);
			this.dtb_BirthDate.Name = "dtb_BirthDate";
			this.dtb_BirthDate.Size = new System.Drawing.Size(152, 22);
			this.dtb_BirthDate.TabIndex = 9;
			// 
			// lbl_birthdate
			// 
			this.lbl_birthdate.Location = new System.Drawing.Point(10, 214);
			this.lbl_birthdate.Name = "lbl_birthdate";
			this.lbl_birthdate.Size = new System.Drawing.Size(88, 23);
			this.lbl_birthdate.TabIndex = 8;
			this.lbl_birthdate.Text = "BirthDate";
			// 
			// grp_sex
			// 
			this.grp_sex.Controls.Add(this.rad_femade);
			this.grp_sex.Controls.Add(this.rad_made);
			this.grp_sex.Location = new System.Drawing.Point(120, 128);
			this.grp_sex.Name = "grp_sex";
			this.grp_sex.Size = new System.Drawing.Size(152, 48);
			this.grp_sex.TabIndex = 7;
			this.grp_sex.TabStop = false;
			// 
			// rad_femade
			// 
			this.rad_femade.Location = new System.Drawing.Point(75, 16);
			this.rad_femade.Name = "rad_femade";
			this.rad_femade.Size = new System.Drawing.Size(69, 24);
			this.rad_femade.TabIndex = 1;
			this.rad_femade.Text = "Female";
			this.rad_femade.CheckedChanged += new System.EventHandler(this.rad_femade_CheckedChanged);
			// 
			// rad_made
			// 
			this.rad_made.Checked = true;
			this.rad_made.Location = new System.Drawing.Point(8, 16);
			this.rad_made.Name = "rad_made";
			this.rad_made.Size = new System.Drawing.Size(56, 24);
			this.rad_made.TabIndex = 0;
			this.rad_made.TabStop = true;
			this.rad_made.Text = "Male";
			this.rad_made.CheckedChanged += new System.EventHandler(this.rad_made_CheckedChanged);
			// 
			// txt_Phone
			// 
			this.txt_Phone.Location = new System.Drawing.Point(120, 96);
			this.txt_Phone.Name = "txt_Phone";
			this.txt_Phone.Size = new System.Drawing.Size(152, 22);
			this.txt_Phone.TabIndex = 6;
			this.txt_Phone.Text = "";
			// 
			// txt_Address
			// 
			this.txt_Address.Location = new System.Drawing.Point(120, 64);
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.Size = new System.Drawing.Size(152, 22);
			this.txt_Address.TabIndex = 5;
			this.txt_Address.Text = "";
			// 
			// txt_CustomerName
			// 
			this.txt_CustomerName.Location = new System.Drawing.Point(120, 32);
			this.txt_CustomerName.Name = "txt_CustomerName";
			this.txt_CustomerName.Size = new System.Drawing.Size(152, 22);
			this.txt_CustomerName.TabIndex = 4;
			this.txt_CustomerName.Text = "";
			// 
			// lbl_gender
			// 
			this.lbl_gender.Location = new System.Drawing.Point(9, 145);
			this.lbl_gender.Name = "lbl_gender";
			this.lbl_gender.Size = new System.Drawing.Size(72, 23);
			this.lbl_gender.TabIndex = 3;
			this.lbl_gender.Text = "Gender";
			// 
			// lbl_phone
			// 
			this.lbl_phone.Location = new System.Drawing.Point(10, 98);
			this.lbl_phone.Name = "lbl_phone";
			this.lbl_phone.TabIndex = 2;
			this.lbl_phone.Text = "Phone";
			// 
			// lbl_address
			// 
			this.lbl_address.Location = new System.Drawing.Point(10, 66);
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.TabIndex = 1;
			this.lbl_address.Text = "Address";
			// 
			// lbl_customer
			// 
			this.lbl_customer.Location = new System.Drawing.Point(8, 33);
			this.lbl_customer.Name = "lbl_customer";
			this.lbl_customer.Size = new System.Drawing.Size(112, 23);
			this.lbl_customer.TabIndex = 0;
			this.lbl_customer.Text = "Customer Name";
			// 
			// grp_booking
			// 
			this.grp_booking.Controls.Add(this.dtp_BookingDate);
			this.grp_booking.Controls.Add(this.lbl_bookingdate);
			this.grp_booking.Controls.Add(this.dtp_CheckoutDate);
			this.grp_booking.Controls.Add(this.dtp_CheckInDate);
			this.grp_booking.Controls.Add(this.lbl_checkoutDate);
			this.grp_booking.Controls.Add(this.lbl_checkingdate);
			this.grp_booking.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_booking.ForeColor = System.Drawing.Color.Blue;
			this.grp_booking.Location = new System.Drawing.Point(328, 64);
			this.grp_booking.Name = "grp_booking";
			this.grp_booking.Size = new System.Drawing.Size(424, 136);
			this.grp_booking.TabIndex = 2;
			this.grp_booking.TabStop = false;
			this.grp_booking.Text = "Information Booking";
			// 
			// dtp_BookingDate
			// 
			this.dtp_BookingDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_BookingDate.Location = new System.Drawing.Point(128, 27);
			this.dtp_BookingDate.Name = "dtp_BookingDate";
			this.dtp_BookingDate.Size = new System.Drawing.Size(152, 22);
			this.dtp_BookingDate.TabIndex = 8;
			// 
			// lbl_bookingdate
			// 
			this.lbl_bookingdate.Location = new System.Drawing.Point(11, 31);
			this.lbl_bookingdate.Name = "lbl_bookingdate";
			this.lbl_bookingdate.TabIndex = 7;
			this.lbl_bookingdate.Text = "Booking Date";
			// 
			// dtp_CheckoutDate
			// 
			this.dtp_CheckoutDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_CheckoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_CheckoutDate.Location = new System.Drawing.Point(128, 95);
			this.dtp_CheckoutDate.Name = "dtp_CheckoutDate";
			this.dtp_CheckoutDate.Size = new System.Drawing.Size(152, 22);
			this.dtp_CheckoutDate.TabIndex = 6;
			// 
			// dtp_CheckInDate
			// 
			this.dtp_CheckInDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_CheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_CheckInDate.Location = new System.Drawing.Point(128, 60);
			this.dtp_CheckInDate.Name = "dtp_CheckInDate";
			this.dtp_CheckInDate.Size = new System.Drawing.Size(152, 22);
			this.dtp_CheckInDate.TabIndex = 5;
			// 
			// lbl_checkoutDate
			// 
			this.lbl_checkoutDate.Location = new System.Drawing.Point(9, 98);
			this.lbl_checkoutDate.Name = "lbl_checkoutDate";
			this.lbl_checkoutDate.Size = new System.Drawing.Size(104, 23);
			this.lbl_checkoutDate.TabIndex = 2;
			this.lbl_checkoutDate.Text = "CheckIOutDate";
			// 
			// lbl_checkingdate
			// 
			this.lbl_checkingdate.Location = new System.Drawing.Point(10, 66);
			this.lbl_checkingdate.Name = "lbl_checkingdate";
			this.lbl_checkingdate.TabIndex = 1;
			this.lbl_checkingdate.Text = "CheckInDate";
			// 
			// btn_close
			// 
			this.btn_close.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_close.ForeColor = System.Drawing.Color.Blue;
			this.btn_close.Location = new System.Drawing.Point(239, 176);
			this.btn_close.Name = "btn_close";
			this.btn_close.TabIndex = 2;
			this.btn_close.Text = "Close";
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_booking
			// 
			this.btn_booking.Enabled = false;
			this.btn_booking.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_booking.ForeColor = System.Drawing.Color.Blue;
			this.btn_booking.Location = new System.Drawing.Point(149, 176);
			this.btn_booking.Name = "btn_booking";
			this.btn_booking.TabIndex = 0;
			this.btn_booking.Text = "Booking";
			this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
			// 
			// dbg_ListRoom
			// 
			this.dbg_ListRoom.DataMember = "";
			this.dbg_ListRoom.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_ListRoom.Location = new System.Drawing.Point(11, 26);
			this.dbg_ListRoom.Name = "dbg_ListRoom";
			this.dbg_ListRoom.Size = new System.Drawing.Size(400, 128);
			this.dbg_ListRoom.TabIndex = 9;
			this.dbg_ListRoom.Click += new System.EventHandler(this.dbg_ListRoom_Click);
			this.dbg_ListRoom.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dbg_ListRoom_Navigate);
			// 
			// grp_listroom
			// 
			this.grp_listroom.Controls.Add(this.btn_CheckIn);
			this.grp_listroom.Controls.Add(this.btn_booking);
			this.grp_listroom.Controls.Add(this.btn_close);
			this.grp_listroom.Controls.Add(this.dbg_ListRoom);
			this.grp_listroom.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_listroom.ForeColor = System.Drawing.Color.Blue;
			this.grp_listroom.Location = new System.Drawing.Point(328, 200);
			this.grp_listroom.Name = "grp_listroom";
			this.grp_listroom.Size = new System.Drawing.Size(424, 224);
			this.grp_listroom.TabIndex = 9;
			this.grp_listroom.TabStop = false;
			this.grp_listroom.Text = "List Room";
			// 
			// btn_CheckIn
			// 
			this.btn_CheckIn.Enabled = false;
			this.btn_CheckIn.Location = new System.Drawing.Point(54, 176);
			this.btn_CheckIn.Name = "btn_CheckIn";
			this.btn_CheckIn.Size = new System.Drawing.Size(80, 23);
			this.btn_CheckIn.TabIndex = 10;
			this.btn_CheckIn.Text = "Check In";
			this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
			// 
			// BookingRoom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(760, 437);
			this.Controls.Add(this.grp_booking);
			this.Controls.Add(this.grp_customer);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.grp_listroom);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BookingRoom";
			this.Text = "BookingRoom";
			this.Load += new System.EventHandler(this.BookingRoom_Load);
			this.grp_customer.ResumeLayout(false);
			this.grp_sex.ResumeLayout(false);
			this.grp_booking.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListRoom)).EndInit();
			this.grp_listroom.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		
		
		private void BookingRoom_Load(object sender, System.EventArgs e)
		{
				
		}
		public bool kt(string st,string er) 
		{
			Regex re = new Regex(st);
			return re.IsMatch(er);
		}
		private void btn_save_Click(object sender, System.EventArgs e)
		{
			if((!kt("[a-zA-Z]+$",txt_CustomerName.Text))|| (txt_CustomerName.Text.Equals("")))
			{
				MessageBox.Show("CustomerName no empty and no number");
				txt_CustomerName.ResetText();
				txt_CustomerName.Focus();
			}
			else if(txt_Address.Text.Equals(""))
			{
				MessageBox.Show("Address no empty");
				txt_Address.ResetText();
				txt_Address.Focus();
			}
			else if((!kt("[0-9]+$",txt_Phone.Text))|| (txt_Phone.Text.Length!=10))
			{
				MessageBox.Show("Phone must number and 10 charater");
				txt_Phone.ResetText();
				txt_Phone.Focus();
			}
			else if(rad_femade.Checked == false && rad_made.Checked == false)
			{
				MessageBox.Show("Choice Gender");
				grp_sex.Focus();
			}
			else if((!kt("[0-9]+$",txt_Passpor.Text))|| (txt_Passpor.Text.Length!=9))
			{
				MessageBox.Show("Passpor must number and 9 charater");
				txt_Passpor.ResetText();
				txt_Passpor.Focus();
			}
			else
			{
				try
				{
					cn = Conetion.conet();
					cm =  new SqlCommand("insert into Customer values('"+txt_CustomerName.Text+"','"+txt_Address.Text+"','"+txt_Phone.Text+"','"+sex.ToString()+"','"+dtb_BirthDate.Text+"','"+txt_Passpor.Text+"')",cn);
					cn.Open();
					cm.ExecuteNonQuery();
					MessageBox.Show("Save succecfull");
					txt_CustomerName.ResetText();
					txt_Address.ResetText();
					txt_Phone.ResetText();
					txt_Passpor.ResetText();
					rad_femade.ResetText();
					rad_made.ResetText();
					dtb_BirthDate.ResetText();
					cn.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				btn_booking.Enabled=true;
				btn_CheckIn.Enabled=true;
			}
		}

		private void rad_made_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rad_made.Checked)
			{
				sex = "0";
			}
			else
			{
				sex = "1";
			}
		}

		private void rad_femade_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rad_femade.Checked)
			{
				sex = "1";
			}
			else
			{
				sex = "0";
			}
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			txt_CustomerName.ResetText();
			txt_Address.ResetText();
			txt_Phone.ResetText();
			txt_Passpor.ResetText();
			grp_sex.ResetText();
			dtb_BirthDate.ResetText();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void btn_CheckIn_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Insert_BookingRoom();
				this.Insert_Booking_Details();
				Update_Room();
				MessageBox.Show("CheckIn Succecfull");
				CheckIn chec = new CheckIn();
				chec.MdiParent= MainForm.main;
				chec.Show();
				this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public int get_CustomerID()
		{   
			
			string str_SQL = "Select max(Customer_ID)Customer_ID from Customer";
			cm = new SqlCommand(str_SQL, cn);
			da = new SqlDataAdapter();
			ds = new DataSet();

			da.SelectCommand = cm;
			da.Fill(ds, "Customer");

			return (Convert.ToInt32(ds.Tables[0].Rows[0]["Customer_ID"].ToString()));
			//cn.Close();
		}
		public int get_Booking_ID()
		{
			try
			{
				string str_SQL = "Select max(Booking_ID)Booking_ID from Booking_Rooms";
				cm = new SqlCommand(str_SQL, cn);
				da = new SqlDataAdapter();
				ds = new DataSet();

				da.SelectCommand = cm;
				da.Fill(ds, "Customer");
				//da.Fill(ds, "Booking_Rooms");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return (Convert.ToInt32(ds.Tables[0].Rows[0]["Booking_ID"].ToString()));
		}
		public void Insert_BookingRoom()
		{
			try
			{
				int get_Customer = this.get_CustomerID();
				cm = new SqlCommand("SET DATEFORMAT dmy Insert into Booking_Rooms(Customer_ID, Booking_Date)values("+get_Customer+", '" + dtp_BookingDate.Text + "')", cn);
				cn.Open();
				cm.ExecuteNonQuery();                
			}
			catch (Exception Ex)
			{
				Ex.Message.ToString();
			}
			cn.Close();
		}
		public void Insert_Booking_Details()
		{
			try
			{
				int get_BookingID = this.get_Booking_ID();
				cm = new SqlCommand("SET DATEFORMAT dmy Insert into Booking_Details( Booking_ID, Checkin_Date, Chechout_Date, Room_ID)values( " + get_BookingID + ",'" + dtp_CheckInDate.Text + "', '" + dtp_CheckoutDate.Text + "', '" + get_RoomID + "')", cn);
				cn.Open();
				cm.ExecuteNonQuery();
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}
			cn.Close();
		}
		public void Update_Room()
		{
			try
			{
				cm = new SqlCommand("Update Room set Room_Status ='1'where Room_ID='" + get_RoomID+ "'", cn);
				cn.Open();
				cm.ExecuteNonQuery();
			}
			catch (Exception Ex)
			{
				Ex.ToString();
			}
			cn.Close();
		}
		private void btn_booking_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Insert_BookingRoom();
				this.Insert_Booking_Details();
				MessageBox.Show("Booking sucecfull");
				this.Close();
			}
			catch (Exception Ex)
			{
				Ex.ToString();
			}
		}
		public int  set_Status;
		public string get_RoomID;
		private void dbg_ListRoom_Click(object sender, System.EventArgs e)
		{
			try
			{
				string get_Status = dbg_ListRoom[dbg_ListRoom.CurrentRowIndex,6].ToString();
				if (get_Status.Equals("true"))
				{
					set_Status = 1;
				}
				else
				{
					set_Status = 0;
				}

				get_RoomID = dbg_ListRoom[dbg_ListRoom.CurrentRowIndex, 0].ToString();           
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dbg_ListRoom_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}
	}
}
