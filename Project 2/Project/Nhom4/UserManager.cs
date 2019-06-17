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
	/// Summary description for UserManager.
	/// </summary>
	public class UserManager : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.GroupBox grp_UserManager;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_AddNew;
		private System.Windows.Forms.DataGrid dbg_List;
		private System.Windows.Forms.Label lbl_List;
		private System.Windows.Forms.RadioButton rad_Employee;
		private System.Windows.Forms.RadioButton rad_Manager;
		private System.Windows.Forms.TextBox txt_Pass;
		private System.Windows.Forms.TextBox txt_Phone;
		private System.Windows.Forms.TextBox txt_Address;
		private System.Windows.Forms.TextBox txt_FullName;
		private System.Windows.Forms.TextBox txt_UserName;
		private System.Windows.Forms.Label lbl_Per;
		private System.Windows.Forms.Label lbl_Pass;
		private System.Windows.Forms.Label lbl_Phone;
		private System.Windows.Forms.Label lbl_Address;
		private System.Windows.Forms.Label lbl_FullName;
		private System.Windows.Forms.Label lbl_UserName;

		private SqlCommand commnd;
		private SqlConnection cn;
		private SqlDataAdapter da;
		private DataSet ds;
		bool flat=false;
		int per;
		private string txtUserName;
		private string txtFullName;
		private string txtAddress;
		private string txtPhone;
		private string txtPassword;
		private int radPermision=0;
		private System.Windows.Forms.TextBox txt_oldpass;
		private System.Windows.Forms.Label lbl_oldpass;
		

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UserManager()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UserManager));
			this.lbl_title = new System.Windows.Forms.Label();
			this.grp_UserManager = new System.Windows.Forms.GroupBox();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_AddNew = new System.Windows.Forms.Button();
			this.dbg_List = new System.Windows.Forms.DataGrid();
			this.lbl_List = new System.Windows.Forms.Label();
			this.rad_Employee = new System.Windows.Forms.RadioButton();
			this.rad_Manager = new System.Windows.Forms.RadioButton();
			this.txt_Pass = new System.Windows.Forms.TextBox();
			this.txt_Phone = new System.Windows.Forms.TextBox();
			this.txt_Address = new System.Windows.Forms.TextBox();
			this.txt_FullName = new System.Windows.Forms.TextBox();
			this.txt_UserName = new System.Windows.Forms.TextBox();
			this.lbl_Per = new System.Windows.Forms.Label();
			this.lbl_Pass = new System.Windows.Forms.Label();
			this.lbl_Phone = new System.Windows.Forms.Label();
			this.lbl_Address = new System.Windows.Forms.Label();
			this.lbl_FullName = new System.Windows.Forms.Label();
			this.lbl_UserName = new System.Windows.Forms.Label();
			this.txt_oldpass = new System.Windows.Forms.TextBox();
			this.lbl_oldpass = new System.Windows.Forms.Label();
			this.grp_UserManager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dbg_List)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_title
			// 
			this.lbl_title.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title.ForeColor = System.Drawing.Color.Blue;
			this.lbl_title.Location = new System.Drawing.Point(288, 8);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(200, 40);
			this.lbl_title.TabIndex = 0;
			this.lbl_title.Text = "User Manager";
			// 
			// grp_UserManager
			// 
			this.grp_UserManager.Controls.Add(this.lbl_oldpass);
			this.grp_UserManager.Controls.Add(this.txt_oldpass);
			this.grp_UserManager.Controls.Add(this.btn_Close);
			this.grp_UserManager.Controls.Add(this.btn_Cancel);
			this.grp_UserManager.Controls.Add(this.btn_Update);
			this.grp_UserManager.Controls.Add(this.btn_Delete);
			this.grp_UserManager.Controls.Add(this.btn_AddNew);
			this.grp_UserManager.Controls.Add(this.dbg_List);
			this.grp_UserManager.Controls.Add(this.lbl_List);
			this.grp_UserManager.Controls.Add(this.rad_Employee);
			this.grp_UserManager.Controls.Add(this.rad_Manager);
			this.grp_UserManager.Controls.Add(this.txt_Pass);
			this.grp_UserManager.Controls.Add(this.txt_Phone);
			this.grp_UserManager.Controls.Add(this.txt_Address);
			this.grp_UserManager.Controls.Add(this.txt_FullName);
			this.grp_UserManager.Controls.Add(this.txt_UserName);
			this.grp_UserManager.Controls.Add(this.lbl_Per);
			this.grp_UserManager.Controls.Add(this.lbl_Pass);
			this.grp_UserManager.Controls.Add(this.lbl_Phone);
			this.grp_UserManager.Controls.Add(this.lbl_Address);
			this.grp_UserManager.Controls.Add(this.lbl_FullName);
			this.grp_UserManager.Controls.Add(this.lbl_UserName);
			this.grp_UserManager.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_UserManager.ForeColor = System.Drawing.Color.Blue;
			this.grp_UserManager.Location = new System.Drawing.Point(16, 56);
			this.grp_UserManager.Name = "grp_UserManager";
			this.grp_UserManager.Size = new System.Drawing.Size(752, 344);
			this.grp_UserManager.TabIndex = 1;
			this.grp_UserManager.TabStop = false;
			this.grp_UserManager.Text = "User Manager ";
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(490, 296);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.TabIndex = 19;
			this.btn_Close.Text = "Close";
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(410, 296);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.TabIndex = 18;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(330, 296);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.TabIndex = 17;
			this.btn_Update.Text = "Update";
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(250, 296);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.TabIndex = 16;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_AddNew
			// 
			this.btn_AddNew.Location = new System.Drawing.Point(170, 296);
			this.btn_AddNew.Name = "btn_AddNew";
			this.btn_AddNew.TabIndex = 15;
			this.btn_AddNew.Text = "Add New";
			this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
			// 
			// dbg_List
			// 
			this.dbg_List.DataMember = "";
			this.dbg_List.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dbg_List.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dbg_List.Location = new System.Drawing.Point(328, 46);
			this.dbg_List.Name = "dbg_List";
			this.dbg_List.Size = new System.Drawing.Size(416, 192);
			this.dbg_List.TabIndex = 14;
			this.dbg_List.Click += new System.EventHandler(this.dbg_List_Click);
			// 
			// lbl_List
			// 
			this.lbl_List.Location = new System.Drawing.Point(328, 16);
			this.lbl_List.Name = "lbl_List";
			this.lbl_List.Size = new System.Drawing.Size(120, 23);
			this.lbl_List.TabIndex = 13;
			this.lbl_List.Text = "List Of Manager";
			// 
			// rad_Employee
			// 
			this.rad_Employee.Checked = true;
			this.rad_Employee.Location = new System.Drawing.Point(231, 248);
			this.rad_Employee.Name = "rad_Employee";
			this.rad_Employee.Size = new System.Drawing.Size(88, 24);
			this.rad_Employee.TabIndex = 12;
			this.rad_Employee.TabStop = true;
			this.rad_Employee.Text = "Employee";
			this.rad_Employee.CheckedChanged += new System.EventHandler(this.rad_Employee_CheckedChanged);
			// 
			// rad_Manager
			// 
			this.rad_Manager.Location = new System.Drawing.Point(115, 248);
			this.rad_Manager.Name = "rad_Manager";
			this.rad_Manager.Size = new System.Drawing.Size(80, 24);
			this.rad_Manager.TabIndex = 11;
			this.rad_Manager.Text = "Manager";
			this.rad_Manager.CheckedChanged += new System.EventHandler(this.rad_Manager_CheckedChanged);
			// 
			// txt_Pass
			// 
			this.txt_Pass.Location = new System.Drawing.Point(118, 213);
			this.txt_Pass.Name = "txt_Pass";
			this.txt_Pass.PasswordChar = '*';
			this.txt_Pass.Size = new System.Drawing.Size(192, 22);
			this.txt_Pass.TabIndex = 10;
			this.txt_Pass.Text = "";
			// 
			// txt_Phone
			// 
			this.txt_Phone.Location = new System.Drawing.Point(119, 179);
			this.txt_Phone.Name = "txt_Phone";
			this.txt_Phone.Size = new System.Drawing.Size(192, 22);
			this.txt_Phone.TabIndex = 9;
			this.txt_Phone.Text = "";
			// 
			// txt_Address
			// 
			this.txt_Address.AutoSize = false;
			this.txt_Address.Location = new System.Drawing.Point(120, 112);
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.Size = new System.Drawing.Size(192, 56);
			this.txt_Address.TabIndex = 8;
			this.txt_Address.Text = "";
			// 
			// txt_FullName
			// 
			this.txt_FullName.Location = new System.Drawing.Point(120, 80);
			this.txt_FullName.Name = "txt_FullName";
			this.txt_FullName.Size = new System.Drawing.Size(192, 22);
			this.txt_FullName.TabIndex = 7;
			this.txt_FullName.Text = "";
			// 
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(120, 48);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(192, 22);
			this.txt_UserName.TabIndex = 6;
			this.txt_UserName.Text = "";
			// 
			// lbl_Per
			// 
			this.lbl_Per.Location = new System.Drawing.Point(16, 249);
			this.lbl_Per.Name = "lbl_Per";
			this.lbl_Per.TabIndex = 5;
			this.lbl_Per.Text = "Permission";
			// 
			// lbl_Pass
			// 
			this.lbl_Pass.Location = new System.Drawing.Point(16, 216);
			this.lbl_Pass.Name = "lbl_Pass";
			this.lbl_Pass.TabIndex = 4;
			this.lbl_Pass.Text = "Password";
			// 
			// lbl_Phone
			// 
			this.lbl_Phone.Location = new System.Drawing.Point(16, 184);
			this.lbl_Phone.Name = "lbl_Phone";
			this.lbl_Phone.TabIndex = 3;
			this.lbl_Phone.Text = "Phone";
			// 
			// lbl_Address
			// 
			this.lbl_Address.Location = new System.Drawing.Point(16, 112);
			this.lbl_Address.Name = "lbl_Address";
			this.lbl_Address.TabIndex = 2;
			this.lbl_Address.Text = "Address :";
			// 
			// lbl_FullName
			// 
			this.lbl_FullName.Location = new System.Drawing.Point(16, 80);
			this.lbl_FullName.Name = "lbl_FullName";
			this.lbl_FullName.TabIndex = 1;
			this.lbl_FullName.Text = "Full Name :";
			// 
			// lbl_UserName
			// 
			this.lbl_UserName.Location = new System.Drawing.Point(16, 48);
			this.lbl_UserName.Name = "lbl_UserName";
			this.lbl_UserName.TabIndex = 0;
			this.lbl_UserName.Text = "User Name :";
			// 
			// txt_oldpass
			// 
			this.txt_oldpass.Location = new System.Drawing.Point(480, 251);
			this.txt_oldpass.Name = "txt_oldpass";
			this.txt_oldpass.PasswordChar = '*';
			this.txt_oldpass.Size = new System.Drawing.Size(144, 22);
			this.txt_oldpass.TabIndex = 20;
			this.txt_oldpass.Text = "";
			this.txt_oldpass.Visible = false;
			// 
			// lbl_oldpass
			// 
			this.lbl_oldpass.Location = new System.Drawing.Point(328, 253);
			this.lbl_oldpass.Name = "lbl_oldpass";
			this.lbl_oldpass.Size = new System.Drawing.Size(152, 23);
			this.lbl_oldpass.TabIndex = 21;
			this.lbl_oldpass.Text = "Your Login Password:";
			this.lbl_oldpass.Visible = false;
			// 
			// UserManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(776, 414);
			this.Controls.Add(this.grp_UserManager);
			this.Controls.Add(this.lbl_title);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserManager";
			this.Text = "UserManager";
			this.Load += new System.EventHandler(this.UserManager_Load);
			this.grp_UserManager.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dbg_List)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		public void user()
		{
			btn_AddNew.Enabled=false;
			rad_Manager.Enabled=false;
			btn_Delete.Enabled=false;
			lbl_oldpass.Visible=true;
			txt_oldpass.Visible=true;
		}
		private void UserManager_Load(object sender, System.EventArgs e)
		{
			
			try
			{
				cn = Conetion.conet();
				if(cn.State==ConnectionState.Closed)
				{
					cn.Open();
				}
				commnd=new SqlCommand("select Permission from Login where rtrim(Password)='"+Conetion.Password+"'",cn);
				per=Convert.ToInt32(commnd.ExecuteScalar());
				if(per==0)
				{
					user();
					data2();
					flat=true;
				}
				if(per==1)
				{
					data();
				}

				
			}
			catch(Exception ex)
			{
				MessageBox.Show("Can not Connect to Database!");
				Console.WriteLine(ex);
			}
			
	}
	private void data()
	{
		try
		{
			cn = Conetion.conet();
			if(cn.State==ConnectionState.Closed)
			{
				cn.Open();
			}
			commnd=new SqlCommand("select username,Fullname,address,phone,Permission from Login",cn);
			da=new SqlDataAdapter(commnd);
			//cmbuilder=new SqlCommandBuilder(da);
			ds=new DataSet();
			da.Fill(ds,"Login");
			dbg_List.DataSource=ds.Tables["Login"];
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex);
		}
		}
		private void data2()
		{
			try
			{
				cn = Conetion.conet();
				if(cn.State==ConnectionState.Closed)
				{
					cn.Open();
				}				
				commnd=new SqlCommand("select username,Fullname,address,phone,Permission from Login where rtrim(password)='"+Conetion.Password+"'",cn);
				da=new SqlDataAdapter(commnd);
				ds=new DataSet();
				da.Fill(ds,"Login");
				dbg_List.DataSource=ds.Tables["Login"];
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		

		private void reset()
		{
		
			this.txt_Address.Text="";
			this.txt_FullName.Text="";
			this.txt_Pass.Text="";
			this.txt_Phone.Text="";
			this.txt_UserName.Text="";
		}
		private bool Test(string format, string input)
		{
		 
			 Regex rg = new Regex(format);
			 return rg.IsMatch(input);
		 
		}		
			
		private void btn_AddNew_Click(object sender, System.EventArgs e)
		{
			if((!(Test("^[a-zA-Z]+$",txt_UserName.Text.Trim())))||txt_UserName.Text=="")
			{
				MessageBox.Show("Enter UserName and Character not space", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_UserName.Focus();
				return;
			}
			else if(!(Test("^[a-zA-Z ]+$",txt_FullName.Text.Trim())))
			{
				MessageBox.Show("Enter FullName and Character not space", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_FullName.Focus();
				return;
			}
			else if(txt_Address.Text.Length>50)
			{
				MessageBox.Show("Enter Address < 50 character", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_Address.Focus();
				return;
			}
			else if((!(Test("^[0-9]{10}",txt_Phone.Text.Trim()))))
			{
				MessageBox.Show("Enter phone in ten number, please!", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_Phone.Focus();
				return;
			}
			else if(txt_Pass.Text=="")
			{
				MessageBox.Show("Enter Password ", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_Pass.Focus();
				return;

			}
			else
			{
				txtUserName=this.txt_UserName.Text;
				txtFullName=this.txt_FullName.Text;
				txtAddress=this.txt_Address.Text;
				txtPhone=this.txt_Phone.Text;
				txtPassword=this.txt_Pass.Text;
				
				try
				{
					if(cn.State==ConnectionState.Closed)
					{
						cn.Open();
					}
					commnd=new SqlCommand("INSERT INTO Login VALUES('"+txtPassword+"','"+txtUserName+"','"+txtFullName+"','"+txtAddress+"','"+txtPhone+"','"+radPermision+"')",cn);
					commnd.ExecuteNonQuery();
					MessageBox.Show("AddNew Sucessfull","Message",MessageBoxButtons.OK,MessageBoxIcon.Question);
					reset();
					data();
					cn.Close();
					radPermision=0;
				}
				
				catch(Exception ce)
				{
					MessageBox.Show(ce.ToString());
				}
			}

		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			if(txt_Pass.Text!="")
			{
				DialogResult dlg=MessageBox.Show("Do you want delete","Delete User Manager",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
				if(dlg==DialogResult.No)
				{
					return;
				}
				else
				{
					try
					{
						if(cn.State==ConnectionState.Closed)
						{
							cn.Open();
						}
						commnd=new SqlCommand("Delete Login Where rtrim(Password) = '"+txt_Pass.Text.Trim()+"'",cn);
						commnd.ExecuteNonQuery();
						reset();
						data();
						MessageBox.Show("Delete Sucessfull","Delete User Manager",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
					}
					catch(Exception ce)
					{
						MessageBox.Show(ce.ToString());
					}
				}
			}
			else 
			{
				MessageBox.Show("Enter Password Please!");
			}
		}
		private void dbg_List_Click(object sender, System.EventArgs e)
		{
			try
			{
                txt_UserName.Text.Trim() = dbg_List[dbg_List.CurrentRowIndex, 0].ToString().Trim();
                txt_FullName.Text.Trim() = dbg_List[dbg_List.CurrentRowIndex, 1].ToString().Trim();
                txt_Address.Text.Trim() = dbg_List[dbg_List.CurrentRowIndex, 2].ToString().Trim();
                txt_Phone.Text.Trim() = dbg_List[dbg_List.CurrentRowIndex, 3].ToString().Trim();
				rad_Manager.Checked=Convert.ToBoolean(dbg_List[dbg_List.CurrentRowIndex,4]);
				if(flat==false)
				{
					if(cn.State==ConnectionState.Closed)
					{
						cn.Open();
					}
					commnd=new SqlCommand("select password from Login where rtrim(username)='"+txt_UserName.Text.Trim()+"'",cn);
					string pas =commnd.ExecuteScalar().ToString();
					txt_Pass.Text=pas;
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void rad_Manager_CheckedChanged(object sender, System.EventArgs e)
		{
			radPermision=1;
		}

		private void rad_Employee_CheckedChanged(object sender, System.EventArgs e)
		{
			radPermision=0;

		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			reset();

		}

		private void btn_Update_Click(object sender, System.EventArgs e)
		{

			if(!(Test("^[a-zA-Z ]+$",txt_FullName.Text.Trim())))
			{
				MessageBox.Show("Enter FullName and Character not space", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_FullName.Focus();
				return;
			}
			else if(txt_Address.Text.Length>50)
			{
				MessageBox.Show("Enter Address < 50 character", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_Address.Focus();
				return;
			}
			else if((!(Test("^[0-9]{10}",txt_Phone.Text)))||txt_Phone.Text.Trim().Length>10||txt_Phone.Text.Trim().Length<6)
			{
				MessageBox.Show("Enter phone from 6 to 10 number", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_Phone.Focus();
				return;
			}
			else if(txt_Pass.Text.Trim()=="")
			{
				MessageBox.Show(" You are not enter Password correctly!", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_Pass.Focus();
				return;

			}			
			else if(txt_oldpass.Text.Trim()=="")
			{
				lbl_oldpass.Visible=true;
				txt_oldpass.Visible=true;
				MessageBox.Show("You are not enter Login Password correctly!", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_oldpass.Focus();
				return;

			}
			else if(txt_oldpass.Text.Trim()!=Conetion.Password.Trim())
						{
							MessageBox.Show("You only can change your account!", "AddNew User Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

						}

			else
			{
				txtUserName=this.txt_UserName.Text;
				txtFullName=this.txt_FullName.Text;
				txtAddress=this.txt_Address.Text;
				txtPhone=this.txt_Phone.Text;
				txtPassword=this.txt_Pass.Text;
				try
				{
					commnd=new SqlCommand("Update Login Set FullName='"+txtFullName+"',Address='"+txtAddress+"',Phone='"+txtPhone+"',Permission='"+radPermision+"',Password='"+txtPassword+"' Where UserName='"+txtUserName+"'",cn);
					commnd.ExecuteNonQuery();
					reset();
					MessageBox.Show("Update Sucessfull","Update User Manager");
					
				}
				catch(Exception ce)
				{
					MessageBox.Show("This Password may being use by another one!");
				}
				lbl_oldpass.Visible=false;
				txt_oldpass.Text="";
				txt_oldpass.Visible=false;
				radPermision=0;
				if(flat==false)
				{
					data();
				}
				if(flat==true)
				{
					data2();
				}

			}
		
		}

	
	}
}
