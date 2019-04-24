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
	/// Summary description for Customer.
	/// </summary>
	public class Customer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lbl_TitleAddNewCustomer;
		private System.Windows.Forms.Label lbl_Addess;
		private System.Windows.Forms.Label lbl_Phone;
		private System.Windows.Forms.Label Passpor;
		private System.Windows.Forms.Label lbl_birthDate;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.RadioButton rad_Made;
		private System.Windows.Forms.RadioButton rad_Femade;
		private System.Windows.Forms.Label lbl_ListCustomerInTheRoom;
		private System.Windows.Forms.GroupBox grp_InfomationCustomer;
		private System.Windows.Forms.Label lbl_SearchCustomerName;
		private System.Windows.Forms.TextBox txt_SearchCustomerName;
		private System.Windows.Forms.Label lbl_CustomerName;
		private System.Windows.Forms.TextBox txt_CustomerName;
		private System.Windows.Forms.TextBox txt_Address;
		private System.Windows.Forms.TextBox txt_Phone;
		private System.Windows.Forms.TextBox txt_Passpor;
		private System.Windows.Forms.DateTimePicker dtp_BirthDate;
		SqlConnection cn;
		SqlCommand cm;
		SqlDataAdapter da;
		DataSet ds;
		private int sex;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Addnew;
		private System.Windows.Forms.DataGrid dbg_ListCustomerInTheRoom;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Customer()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Customer));
			this.lbl_TitleAddNewCustomer = new System.Windows.Forms.Label();
			this.lbl_SearchCustomerName = new System.Windows.Forms.Label();
			this.txt_SearchCustomerName = new System.Windows.Forms.TextBox();
			this.btn_Search = new System.Windows.Forms.Button();
			this.grp_InfomationCustomer = new System.Windows.Forms.GroupBox();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Addnew = new System.Windows.Forms.Button();
			this.lbl_ListCustomerInTheRoom = new System.Windows.Forms.Label();
			this.dbg_ListCustomerInTheRoom = new System.Windows.Forms.DataGrid();
			this.rad_Femade = new System.Windows.Forms.RadioButton();
			this.rad_Made = new System.Windows.Forms.RadioButton();
			this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
			this.txt_Passpor = new System.Windows.Forms.TextBox();
			this.txt_Phone = new System.Windows.Forms.TextBox();
			this.lbl_Gender = new System.Windows.Forms.Label();
			this.lbl_birthDate = new System.Windows.Forms.Label();
			this.Passpor = new System.Windows.Forms.Label();
			this.lbl_Phone = new System.Windows.Forms.Label();
			this.txt_Address = new System.Windows.Forms.TextBox();
			this.txt_CustomerName = new System.Windows.Forms.TextBox();
			this.lbl_Addess = new System.Windows.Forms.Label();
			this.lbl_CustomerName = new System.Windows.Forms.Label();
			this.grp_InfomationCustomer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListCustomerInTheRoom)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_TitleAddNewCustomer
			// 
			this.lbl_TitleAddNewCustomer.Location = new System.Drawing.Point(256, 16);
			this.lbl_TitleAddNewCustomer.Name = "lbl_TitleAddNewCustomer";
			this.lbl_TitleAddNewCustomer.Size = new System.Drawing.Size(272, 40);
			this.lbl_TitleAddNewCustomer.TabIndex = 0;
			this.lbl_TitleAddNewCustomer.Text = "Add New Customer";
			// 
			// lbl_SearchCustomerName
			// 
			this.lbl_SearchCustomerName.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SearchCustomerName.Location = new System.Drawing.Point(32, 88);
			this.lbl_SearchCustomerName.Name = "lbl_SearchCustomerName";
			this.lbl_SearchCustomerName.Size = new System.Drawing.Size(120, 23);
			this.lbl_SearchCustomerName.TabIndex = 1;
			this.lbl_SearchCustomerName.Text = "Customer Name :";
			// 
			// txt_SearchCustomerName
			// 
			this.txt_SearchCustomerName.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_SearchCustomerName.Location = new System.Drawing.Point(152, 88);
			this.txt_SearchCustomerName.Name = "txt_SearchCustomerName";
			this.txt_SearchCustomerName.Size = new System.Drawing.Size(208, 22);
			this.txt_SearchCustomerName.TabIndex = 2;
			this.txt_SearchCustomerName.Text = "";
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Search.Location = new System.Drawing.Point(384, 88);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.TabIndex = 3;
			this.btn_Search.Text = "Search";
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// grp_InfomationCustomer
			// 
			this.grp_InfomationCustomer.Controls.Add(this.btn_Close);
			this.grp_InfomationCustomer.Controls.Add(this.btn_Cancel);
			this.grp_InfomationCustomer.Controls.Add(this.btn_Update);
			this.grp_InfomationCustomer.Controls.Add(this.btn_Delete);
			this.grp_InfomationCustomer.Controls.Add(this.btn_Addnew);
			this.grp_InfomationCustomer.Controls.Add(this.lbl_ListCustomerInTheRoom);
			this.grp_InfomationCustomer.Controls.Add(this.dbg_ListCustomerInTheRoom);
			this.grp_InfomationCustomer.Controls.Add(this.rad_Femade);
			this.grp_InfomationCustomer.Controls.Add(this.rad_Made);
			this.grp_InfomationCustomer.Controls.Add(this.dtp_BirthDate);
			this.grp_InfomationCustomer.Controls.Add(this.txt_Passpor);
			this.grp_InfomationCustomer.Controls.Add(this.txt_Phone);
			this.grp_InfomationCustomer.Controls.Add(this.lbl_Gender);
			this.grp_InfomationCustomer.Controls.Add(this.lbl_birthDate);
			this.grp_InfomationCustomer.Controls.Add(this.Passpor);
			this.grp_InfomationCustomer.Controls.Add(this.lbl_Phone);
			this.grp_InfomationCustomer.Controls.Add(this.txt_Address);
			this.grp_InfomationCustomer.Controls.Add(this.txt_CustomerName);
			this.grp_InfomationCustomer.Controls.Add(this.lbl_Addess);
			this.grp_InfomationCustomer.Controls.Add(this.lbl_CustomerName);
			this.grp_InfomationCustomer.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_InfomationCustomer.Location = new System.Drawing.Point(16, 128);
			this.grp_InfomationCustomer.Name = "grp_InfomationCustomer";
			this.grp_InfomationCustomer.Size = new System.Drawing.Size(752, 432);
			this.grp_InfomationCustomer.TabIndex = 4;
			this.grp_InfomationCustomer.TabStop = false;
			this.grp_InfomationCustomer.Text = "Infomation Cutomer    ";
			this.grp_InfomationCustomer.Enter += new System.EventHandler(this.grp_InfomationCustomer_Enter);
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(504, 384);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.TabIndex = 19;
			this.btn_Close.Text = "Close";
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Enabled = false;
			this.btn_Cancel.Location = new System.Drawing.Point(416, 384);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.TabIndex = 18;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Enabled = false;
			this.btn_Update.Location = new System.Drawing.Point(320, 384);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.TabIndex = 17;
			this.btn_Update.Text = "Update";
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Enabled = false;
			this.btn_Delete.Location = new System.Drawing.Point(240, 384);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.TabIndex = 16;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Addnew
			// 
			this.btn_Addnew.Location = new System.Drawing.Point(152, 384);
			this.btn_Addnew.Name = "btn_Addnew";
			this.btn_Addnew.TabIndex = 15;
			this.btn_Addnew.Text = "Add New";
			this.btn_Addnew.Click += new System.EventHandler(this.btn_Addnew_Click);
			// 
			// lbl_ListCustomerInTheRoom
			// 
			this.lbl_ListCustomerInTheRoom.Location = new System.Drawing.Point(8, 192);
			this.lbl_ListCustomerInTheRoom.Name = "lbl_ListCustomerInTheRoom";
			this.lbl_ListCustomerInTheRoom.Size = new System.Drawing.Size(184, 23);
			this.lbl_ListCustomerInTheRoom.TabIndex = 14;
			this.lbl_ListCustomerInTheRoom.Text = "List Customer In The Room";
			// 
			// dbg_ListCustomerInTheRoom
			// 
			this.dbg_ListCustomerInTheRoom.DataMember = "";
			this.dbg_ListCustomerInTheRoom.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_ListCustomerInTheRoom.Location = new System.Drawing.Point(8, 216);
			this.dbg_ListCustomerInTheRoom.Name = "dbg_ListCustomerInTheRoom";
			this.dbg_ListCustomerInTheRoom.PreferredColumnWidth = 100;
			this.dbg_ListCustomerInTheRoom.Size = new System.Drawing.Size(736, 152);
			this.dbg_ListCustomerInTheRoom.TabIndex = 13;
			this.dbg_ListCustomerInTheRoom.Click += new System.EventHandler(this.ClickDatagir);
			// 
			// rad_Femade
			// 
			this.rad_Femade.Location = new System.Drawing.Point(592, 160);
			this.rad_Femade.Name = "rad_Femade";
			this.rad_Femade.Size = new System.Drawing.Size(80, 24);
			this.rad_Femade.TabIndex = 12;
			this.rad_Femade.Text = "Female";
			this.rad_Femade.CheckedChanged += new System.EventHandler(this.rad_Femade_CheckedChanged);
			// 
			// rad_Made
			// 
			this.rad_Made.Checked = true;
			this.rad_Made.Location = new System.Drawing.Point(472, 160);
			this.rad_Made.Name = "rad_Made";
			this.rad_Made.Size = new System.Drawing.Size(96, 24);
			this.rad_Made.TabIndex = 11;
			this.rad_Made.TabStop = true;
			this.rad_Made.Text = "Male";
			this.rad_Made.CheckedChanged += new System.EventHandler(this.rad_Made_CheckedChanged);
			// 
			// dtp_BirthDate
			// 
			this.dtp_BirthDate.CustomFormat = "dd/MM/yyyy";
			this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_BirthDate.Location = new System.Drawing.Point(472, 120);
			this.dtp_BirthDate.Name = "dtp_BirthDate";
			this.dtp_BirthDate.Size = new System.Drawing.Size(184, 22);
			this.dtp_BirthDate.TabIndex = 10;
			// 
			// txt_Passpor
			// 
			this.txt_Passpor.Location = new System.Drawing.Point(472, 80);
			this.txt_Passpor.Name = "txt_Passpor";
			this.txt_Passpor.Size = new System.Drawing.Size(184, 22);
			this.txt_Passpor.TabIndex = 9;
			this.txt_Passpor.Text = "";
			// 
			// txt_Phone
			// 
			this.txt_Phone.Location = new System.Drawing.Point(472, 40);
			this.txt_Phone.Name = "txt_Phone";
			this.txt_Phone.Size = new System.Drawing.Size(184, 22);
			this.txt_Phone.TabIndex = 8;
			this.txt_Phone.Text = "";
			// 
			// lbl_Gender
			// 
			this.lbl_Gender.Location = new System.Drawing.Point(392, 160);
			this.lbl_Gender.Name = "lbl_Gender";
			this.lbl_Gender.Size = new System.Drawing.Size(72, 23);
			this.lbl_Gender.TabIndex = 7;
			this.lbl_Gender.Text = "Gender :";
			// 
			// lbl_birthDate
			// 
			this.lbl_birthDate.Location = new System.Drawing.Point(392, 120);
			this.lbl_birthDate.Name = "lbl_birthDate";
			this.lbl_birthDate.Size = new System.Drawing.Size(80, 23);
			this.lbl_birthDate.TabIndex = 6;
			this.lbl_birthDate.Text = "BirthDate :";
			// 
			// Passpor
			// 
			this.Passpor.Location = new System.Drawing.Point(392, 80);
			this.Passpor.Name = "Passpor";
			this.Passpor.Size = new System.Drawing.Size(72, 23);
			this.Passpor.TabIndex = 5;
			this.Passpor.Text = "Passport:";
			// 
			// lbl_Phone
			// 
			this.lbl_Phone.Location = new System.Drawing.Point(392, 40);
			this.lbl_Phone.Name = "lbl_Phone";
			this.lbl_Phone.Size = new System.Drawing.Size(72, 23);
			this.lbl_Phone.TabIndex = 4;
			this.lbl_Phone.Text = "Phone :";
			// 
			// txt_Address
			// 
			this.txt_Address.AutoSize = false;
			this.txt_Address.Location = new System.Drawing.Point(136, 80);
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.Size = new System.Drawing.Size(208, 104);
			this.txt_Address.TabIndex = 3;
			this.txt_Address.Text = "";
			// 
			// txt_CustomerName
			// 
			this.txt_CustomerName.Location = new System.Drawing.Point(136, 40);
			this.txt_CustomerName.Name = "txt_CustomerName";
			this.txt_CustomerName.Size = new System.Drawing.Size(208, 22);
			this.txt_CustomerName.TabIndex = 2;
			this.txt_CustomerName.Text = "";
			// 
			// lbl_Addess
			// 
			this.lbl_Addess.Location = new System.Drawing.Point(16, 80);
			this.lbl_Addess.Name = "lbl_Addess";
			this.lbl_Addess.TabIndex = 1;
			this.lbl_Addess.Text = "Address :";
			// 
			// lbl_CustomerName
			// 
			this.lbl_CustomerName.Location = new System.Drawing.Point(16, 40);
			this.lbl_CustomerName.Name = "lbl_CustomerName";
			this.lbl_CustomerName.Size = new System.Drawing.Size(120, 23);
			this.lbl_CustomerName.TabIndex = 0;
			this.lbl_CustomerName.Text = "Customer Name :";
			// 
			// Customer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(14, 32);
			this.ClientSize = new System.Drawing.Size(776, 565);
			this.Controls.Add(this.grp_InfomationCustomer);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.txt_SearchCustomerName);
			this.Controls.Add(this.lbl_SearchCustomerName);
			this.Controls.Add(this.lbl_TitleAddNewCustomer);
			this.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ForeColor = System.Drawing.Color.Blue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Customer";
			this.Text = "Customer";
			this.Load += new System.EventHandler(this.Customer_Load);
			this.grp_InfomationCustomer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_ListCustomerInTheRoom)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public void EnableTest()
		{
			btn_Delete.Enabled=true;
			btn_Update.Enabled=true;
			btn_Cancel.Enabled=true;
			btn_Addnew.Enabled=false;
			btn_Close.Enabled=false;
		}
		public void ResetTest()
		{
			txt_CustomerName.Clear();
			txt_Address.Clear();
			txt_Phone.Clear();
			txt_Passpor.Clear();
			//this.dtBdate.Text ="";
			dtp_BirthDate.ResetText();
			rad_Femade.Checked = false;
			rad_Made.Checked = false;
		}
		public void LoadCustomer()
		{
			try
			{
				cn = Conetion.conet();
				cn.Open();
				cm =  new SqlCommand("select * from Customer",cn);
				
				da = new SqlDataAdapter(cm);
				ds=new DataSet();
				da.Fill(ds,"Customer");
				dbg_ListCustomerInTheRoom.DataSource=ds;
				dbg_ListCustomerInTheRoom.DataMember="Customer";
				cn.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		private void Customer_Load(object sender, System.EventArgs e)
		{
			LoadCustomer();
		}
		public bool kt(string format,string input) 
		{
			Regex re = new Regex(format);
			return re.IsMatch(input);
		}
		private void btn_Addnew_Click(object sender, System.EventArgs e)
		{
			if((!kt("[a-zA-Z]+$",txt_CustomerName.Text))|| (txt_CustomerName.Text.Equals("")))
			{
				MessageBox.Show("CustomerName no empty and no number");
				txt_CustomerName.ResetText();
				txt_CustomerName.Focus();
			}
			else if((!kt("[a-zA-Z]+$",txt_Address.Text))|| (txt_Address.Text.Equals("")))
			{
				MessageBox.Show("Address no empty and no number");
				txt_Address.ResetText();
				txt_Address.Focus();
			}
			else if((!kt("[0-9]+$",txt_Phone.Text))|| (txt_Phone.Text.Length!=10))
			{
				MessageBox.Show("Phone must number and 10 charater");
				txt_Phone.ResetText();
				txt_Phone.Focus();
			}
			else if((!kt("[0-9]+$",txt_Passpor.Text))|| (txt_Passpor.Text.Length!=9))
			{
				MessageBox.Show("Passpor must number and 9 charater");
				txt_Passpor.ResetText();
				txt_Passpor.Focus();
			}
			
			else
			{
				//string Daymonth =dtp_BirthDate.Text;
				try
				{
					cn.Open();
					cm =  new SqlCommand("insert into Customer values('"+txt_CustomerName.Text+"','"+txt_Address.Text+"','"+txt_Phone.Text+"',"+sex+",'"+dtp_BirthDate.Text+"','"+txt_Passpor.Text+"')",cn);
					
					cm.ExecuteNonQuery();
					MessageBox.Show("Add New succecfull");
					cn.Close();
					LoadCustomer();
					ResetTest();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btn_Update_Click(object sender, System.EventArgs e)
		{
			if((!kt("[a-zA-Z]+$",txt_CustomerName.Text))|| (txt_CustomerName.Text.Equals("")))
			{
				MessageBox.Show("CustomerName no empty and no number");
				txt_CustomerName.ResetText();
				txt_CustomerName.Focus();
			}
			else if((!kt("[a-zA-Z]+$",txt_Address.Text))|| (txt_Address.Text.Equals("")))
			{
				MessageBox.Show("Address no empty and no number");
				txt_Address.ResetText();
				txt_Address.Focus();
			}
			else if((!kt("[0-9]+$",txt_Phone.Text))|| (txt_Phone.Text.Length!=10))
			{
				MessageBox.Show("Phone must number and 10 charater");
				txt_Phone.ResetText();
				txt_Phone.Focus();
			}
			else if((!kt("[0-9]+$",txt_Passpor.Text))|| (txt_Passpor.Text.Length!=9))
			{
				MessageBox.Show("Passpor must number and 9 charater");
				txt_Passpor.ResetText();
				txt_Passpor.Focus();
			}
		
			else
			{
				//string Daymonth =dtp_BirthDate.Text;
				try
				{
					cn.Open();
					cm =  new SqlCommand("Update Customer Set Customer_Name = '"+txt_CustomerName.Text+"',Customer_Address='"+txt_Address.Text+"',Customer_Phone='"+txt_Phone.Text+"',Customer_Gender='"+sex+"',Date_of_Birth='"+dtp_BirthDate.Text+"',Customer_Passpor='"+txt_Passpor.Text+"' Where Customer_Name = '"+txt_CustomerName.Text+"'",cn);
					
					cm.ExecuteNonQuery();
					MessageBox.Show("Update succecfull");
					cn.Close();	
					LoadCustomer();
					ResetTest();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			try
			{
				DialogResult result = MessageBox.Show("Are you sua??","Delete",MessageBoxButtons.YesNo);
				if(Convert.ToString(result)=="Yes")
				{
					cn.Open();
					cm =  new SqlCommand("delete from Customer where Customer_Name = '"+txt_CustomerName.Text.Trim()+"'",cn);
					
					cm.ExecuteNonQuery();
					MessageBox.Show("Delete Sucessfull");
					LoadCustomer();
					ResetTest();
				}
				
			}
			catch(Exception ew)
			{
				MessageBox.Show(ew.Message);
			}
		}
		
		private void rad_Made_CheckedChanged(object sender, System.EventArgs e)
		{
			sex = 1;
			rad_Femade.Checked = !rad_Made.Checked;

		}

		private void rad_Femade_CheckedChanged(object sender, System.EventArgs e)
		{
			sex = 0;
			rad_Made.Checked = !rad_Femade.Checked;

		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			ResetTest();
			btn_Delete.Enabled=false;
			btn_Update.Enabled=false;
			btn_Cancel.Enabled=false;
			btn_Addnew.Enabled=true;
			btn_Close.Enabled=true;
			//EnableTest();
		}

		
		public void DateClick()
		{
			txt_CustomerName.Text = dbg_ListCustomerInTheRoom[dbg_ListCustomerInTheRoom.CurrentRowIndex,1].ToString().Trim();
			txt_Address.Text = dbg_ListCustomerInTheRoom[dbg_ListCustomerInTheRoom.CurrentRowIndex,2].ToString().Trim();
			txt_Phone.Text = dbg_ListCustomerInTheRoom[dbg_ListCustomerInTheRoom.CurrentRowIndex,3].ToString().Trim();
			txt_Passpor.Text = dbg_ListCustomerInTheRoom[dbg_ListCustomerInTheRoom.CurrentRowIndex,6].ToString().Trim();
			rad_Made.Checked = Convert.ToBoolean(dbg_ListCustomerInTheRoom[dbg_ListCustomerInTheRoom.CurrentRowIndex,4]);
			dtp_BirthDate.Text = dbg_ListCustomerInTheRoom[dbg_ListCustomerInTheRoom.CurrentRowIndex,5].ToString().Trim();
			EnableTest();
		}
		private void ClickDatagir(object sender, System.EventArgs e)
		{
			DateClick();
		}

		private void grp_InfomationCustomer_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			cm=new SqlCommand("SELECT * FROM Customer WHERE Customer_Name='"+txt_SearchCustomerName.Text+"'",cn);
			da = new SqlDataAdapter(cm);
			ds=new DataSet();
			da.Fill(ds,"Customer");
			dbg_ListCustomerInTheRoom.DataSource=ds.Tables["Customer"];
			
		}

		
	}
}
