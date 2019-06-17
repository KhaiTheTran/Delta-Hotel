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
	/// Summary description for Report.
	/// </summary>
	public class Report : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		SqlConnection cn;
		SqlCommand comd,comd1,comd2;
		SqlDataAdapter da,da1,da2;
		DataSet ds=new DataSet();
		DataSet ds2=new DataSet();
		DataSet ds1=new DataSet();
		public string tranfer,str,str1,str2,str4,str5;
		int f,id,g;
		private System.Windows.Forms.DataGrid dbg_report;
		private System.Windows.Forms.RadioButton rad_booking_buffet;
		private System.Windows.Forms.RadioButton rad_booking_Room;
		public System.Windows.Forms.DateTimePicker dtp_month_report;
		private System.Windows.Forms.Button btn_searchview;
		private System.Windows.Forms.Button bnt_print;
		private System.Windows.Forms.Button bnt_close;
		private System.Windows.Forms.GroupBox grp_search;
		private System.Windows.Forms.GroupBox grp_list_report;
		private System.Windows.Forms.GroupBox grp_Button;

		private System.ComponentModel.Container components = null;

		public Report()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Report));
			this.label1 = new System.Windows.Forms.Label();
			this.grp_search = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rad_booking_buffet = new System.Windows.Forms.RadioButton();
			this.rad_booking_Room = new System.Windows.Forms.RadioButton();
			this.dtp_month_report = new System.Windows.Forms.DateTimePicker();
			this.btn_searchview = new System.Windows.Forms.Button();
			this.grp_list_report = new System.Windows.Forms.GroupBox();
			this.dbg_report = new System.Windows.Forms.DataGrid();
			this.bnt_print = new System.Windows.Forms.Button();
			this.bnt_close = new System.Windows.Forms.Button();
			this.grp_Button = new System.Windows.Forms.GroupBox();
			this.grp_search.SuspendLayout();
			this.grp_list_report.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_report)).BeginInit();
			this.grp_Button.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(248, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bussiness Reported";
			// 
			// grp_search
			// 
			this.grp_search.Controls.Add(this.label2);
			this.grp_search.Controls.Add(this.rad_booking_buffet);
			this.grp_search.Controls.Add(this.rad_booking_Room);
			this.grp_search.Controls.Add(this.dtp_month_report);
			this.grp_search.Controls.Add(this.btn_searchview);
			this.grp_search.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_search.Location = new System.Drawing.Point(8, 56);
			this.grp_search.Name = "grp_search";
			this.grp_search.Size = new System.Drawing.Size(736, 88);
			this.grp_search.TabIndex = 1;
			this.grp_search.TabStop = false;
			this.grp_search.Text = "Search Report Infomation";
			this.grp_search.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(304, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Month Report :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// rad_booking_buffet
			// 
			this.rad_booking_buffet.Checked = true;
			this.rad_booking_buffet.Location = new System.Drawing.Point(161, 39);
			this.rad_booking_buffet.Name = "rad_booking_buffet";
			this.rad_booking_buffet.Size = new System.Drawing.Size(120, 24);
			this.rad_booking_buffet.TabIndex = 1;
			this.rad_booking_buffet.TabStop = true;
			this.rad_booking_buffet.Text = "Bill Buffers";
			this.rad_booking_buffet.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// rad_booking_Room
			// 
			this.rad_booking_Room.Location = new System.Drawing.Point(32, 39);
			this.rad_booking_Room.Name = "rad_booking_Room";
			this.rad_booking_Room.Size = new System.Drawing.Size(120, 24);
			this.rad_booking_Room.TabIndex = 0;
			this.rad_booking_Room.Text = "Bill Rooms";
			this.rad_booking_Room.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// dtp_month_report
			// 
			this.dtp_month_report.CustomFormat = "dd/MM/yyyy";
			this.dtp_month_report.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_month_report.Location = new System.Drawing.Point(424, 39);
			this.dtp_month_report.Name = "dtp_month_report";
			this.dtp_month_report.Size = new System.Drawing.Size(144, 22);
			this.dtp_month_report.TabIndex = 2;
			this.dtp_month_report.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// btn_searchview
			// 
			this.btn_searchview.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_searchview.Location = new System.Drawing.Point(600, 37);
			this.btn_searchview.Name = "btn_searchview";
			this.btn_searchview.Size = new System.Drawing.Size(96, 24);
			this.btn_searchview.TabIndex = 3;
			this.btn_searchview.Text = "Search View";
			this.btn_searchview.Click += new System.EventHandler(this.button1_Click);
			// 
			// grp_list_report
			// 
			this.grp_list_report.Controls.Add(this.dbg_report);
			this.grp_list_report.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_list_report.Location = new System.Drawing.Point(8, 144);
			this.grp_list_report.Name = "grp_list_report";
			this.grp_list_report.Size = new System.Drawing.Size(736, 232);
			this.grp_list_report.TabIndex = 2;
			this.grp_list_report.TabStop = false;
			this.grp_list_report.Text = "Infomation List  ";
			// 
			// dbg_report
			// 
			this.dbg_report.CaptionText = "Report";
			this.dbg_report.DataMember = "";
			this.dbg_report.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_report.Location = new System.Drawing.Point(8, 20);
			this.dbg_report.Name = "dbg_report";
			this.dbg_report.PreferredColumnWidth = 120;
			this.dbg_report.Size = new System.Drawing.Size(720, 204);
			this.dbg_report.TabIndex = 0;
			// 
			// bnt_print
			// 
			this.bnt_print.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bnt_print.Location = new System.Drawing.Point(21, 16);
			this.bnt_print.Name = "bnt_print";
			this.bnt_print.Size = new System.Drawing.Size(96, 23);
			this.bnt_print.TabIndex = 4;
			this.bnt_print.Text = "Print Report";
			this.bnt_print.Click += new System.EventHandler(this.button2_Click);
			// 
			// bnt_close
			// 
			this.bnt_close.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bnt_close.Location = new System.Drawing.Point(133, 16);
			this.bnt_close.Name = "bnt_close";
			this.bnt_close.Size = new System.Drawing.Size(96, 23);
			this.bnt_close.TabIndex = 5;
			this.bnt_close.Text = "Close";
			this.bnt_close.Click += new System.EventHandler(this.button3_Click);
			// 
			// grp_Button
			// 
			this.grp_Button.Controls.Add(this.bnt_print);
			this.grp_Button.Controls.Add(this.bnt_close);
			this.grp_Button.Location = new System.Drawing.Point(251, 384);
			this.grp_Button.Name = "grp_Button";
			this.grp_Button.Size = new System.Drawing.Size(248, 48);
			this.grp_Button.TabIndex = 6;
			this.grp_Button.TabStop = false;
			// 
			// Report
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(752, 446);
			this.Controls.Add(this.grp_Button);
			this.Controls.Add(this.grp_list_report);
			this.Controls.Add(this.grp_search);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Blue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Report";
			this.Text = "Report";
			this.Load += new System.EventHandler(this.Report_Load);
			this.grp_search.ResumeLayout(false);
			this.grp_list_report.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_report)).EndInit();
			this.grp_Button.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{


		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
		}

		private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
		{
			str=dtp_month_report.Text;
		}

		private void Report_Load(object sender, System.EventArgs e)
		{
			try
			{
				cn=Conetion.conet();
				comd2=new SqlCommand("select Customer.Customer_ID,Customer.Customer_Name,Booking_buffet.Amount,BillFoods.Total_Pay,Booking_buffet.Eating_Date,BillFoods.Bill_date from BillFoods,Booking_buffet,customer where customer.customer_ID=Booking_Buffet.customer_ID and booking_Buffet.BB_ID=Billfoods.BB_ID ",cn);
				da=new SqlDataAdapter(comd2);
				ds2.Clear();
				da.Fill(ds2,"customer");
				dbg_report.DataSource=ds2;
				dbg_report.DataMember="customer";
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}
			/// <summary>
			/// Button search buffet and room to report
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(rad_booking_buffet.Checked)
			{
				if(str==null)
				{
					MessageBox.Show("Month Report must be checked correctly, Please!");
				}
				else
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						str1=dtp_month_report.Text.ToString().Trim();
						tranfer=str1;
						str2= str1.Substring(3,2);
						id=Convert.ToInt32(str2);
						str4=str1.Substring(6,4);
						f=Convert.ToInt32(str4);
						comd2=new SqlCommand("select Customer.Customer_ID,Customer.Customer_Name,Booking_buffet.Amount,BillFoods.Total_Pay,Booking_buffet.Eating_Date,BillFoods.Bill_date from BillFoods,Booking_buffet,customer where customer.customer_ID=Booking_Buffet.customer_ID and booking_Buffet.BB_ID=Billfoods.BB_ID and month(BillFoods.Bill_date)="+id+ "and year(BillFoods.Bill_date)="+f,cn);
						da2=new SqlDataAdapter(comd2);
						ds1.Clear();
						da2.Fill(ds1,"type_fo");
						dbg_report.DataSource=ds1;
						dbg_report.DataMember="Type_fo";
						cn.Close();
						///
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
				///search room
			else if(rad_booking_Room.Checked)
			{
				if(str==null)
				{
					MessageBox.Show("Month Report must be checked, Please!");
				}
				else
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						
						str1=dtp_month_report.Text.ToString().Trim();
						tranfer=str1;
						str2= str1.Substring(3,2);
						id=Convert.ToInt32(str2);
						str4=str1.Substring(6,4);
						f=Convert.ToInt32(str4);
						comd2=new SqlCommand("select Customer.Customer_ID,Customer.Customer_Name,Bill_Rooms.Room_Type,Bill_Rooms.Price,Bill_Rooms.Total_Pay,Bill_Rooms.Checkin_Date,Bill_Rooms.Chechout_Date,Bill_Rooms.Bil_Dates from Bill_Rooms,Booking_Rooms,customer where customer.customer_ID=Booking_Rooms.customer_ID and Booking_Rooms.Booking_ID=Bill_Rooms.Booking_ID and month(Bill_Rooms.Bil_Dates)="+id+ "and year(Bill_Rooms.Bil_Dates)="+f,cn);
						da2=new SqlDataAdapter(comd2);
						ds.Clear();
						da2.Fill(ds,"type_fo");
						dbg_report.DataSource=ds;
						dbg_report.DataMember="Type_fo";
						cn.Close();

						///
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}


				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(rad_booking_buffet.Checked)
			{
				BillBuffetReport bilreport=new BillBuffetReport();
				bilreport.Show();
			}
			else
				if(rad_booking_Room.Checked)
			{
				RoomReportfrom romreport=new RoomReportfrom();
				romreport.Show();
			}

		}

	}
}
