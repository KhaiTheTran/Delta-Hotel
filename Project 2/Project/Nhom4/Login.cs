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
	/// Summary description for Form1.
	/// </summary>
	public class frm_Login : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Label lbl_login;
		private System.Windows.Forms.Label lbi_password;
		private System.Windows.Forms.Label lbi_username;
		private System.Windows.Forms.Button btn_user;
		private System.Windows.Forms.Button btn_password;
		private System.Windows.Forms.GroupBox groupBox1;
		SqlConnection cn;
		SqlCommand cm;
		SqlDataReader read;
		DataSet ds;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_Login()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_Login));
			this.lbl_login = new System.Windows.Forms.Label();
			this.lbi_password = new System.Windows.Forms.Label();
			this.lbi_username = new System.Windows.Forms.Label();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.btn_user = new System.Windows.Forms.Button();
			this.btn_password = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_login
			// 
			this.lbl_login.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_login.ForeColor = System.Drawing.Color.Blue;
			this.lbl_login.Location = new System.Drawing.Point(104, 8);
			this.lbl_login.Name = "lbl_login";
			this.lbl_login.Size = new System.Drawing.Size(100, 32);
			this.lbl_login.TabIndex = 0;
			this.lbl_login.Text = "Login";
			this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbi_password
			// 
			this.lbi_password.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbi_password.ForeColor = System.Drawing.Color.Blue;
			this.lbi_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbi_password.Location = new System.Drawing.Point(8, 72);
			this.lbi_password.Name = "lbi_password";
			this.lbi_password.Size = new System.Drawing.Size(88, 24);
			this.lbi_password.TabIndex = 1;
			this.lbi_password.Text = "Password";
			this.lbi_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbi_username
			// 
			this.lbi_username.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbi_username.ForeColor = System.Drawing.Color.Blue;
			this.lbi_username.Location = new System.Drawing.Point(8, 32);
			this.lbi_username.Name = "lbi_username";
			this.lbi_username.Size = new System.Drawing.Size(88, 23);
			this.lbi_username.TabIndex = 2;
			this.lbi_username.Text = "User Name";
			this.lbi_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(104, 32);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(160, 22);
			this.txt_user.TabIndex = 3;
			this.txt_user.Text = "";
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(104, 72);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.PasswordChar = '*';
			this.txt_pass.Size = new System.Drawing.Size(160, 22);
			this.txt_pass.TabIndex = 4;
			this.txt_pass.Text = "";
			// 
			// btn_user
			// 
			this.btn_user.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_user.ForeColor = System.Drawing.Color.Blue;
			this.btn_user.Location = new System.Drawing.Point(72, 112);
			this.btn_user.Name = "btn_user";
			this.btn_user.TabIndex = 5;
			this.btn_user.Text = "Login";
			this.btn_user.Click += new System.EventHandler(this.bu_user_Click);
			// 
			// btn_password
			// 
			this.btn_password.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_password.ForeColor = System.Drawing.Color.Blue;
			this.btn_password.Location = new System.Drawing.Point(168, 112);
			this.btn_password.Name = "btn_password";
			this.btn_password.TabIndex = 6;
			this.btn_password.Text = "Cancel";
			this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbi_username);
			this.groupBox1.Controls.Add(this.lbi_password);
			this.groupBox1.Controls.Add(this.btn_password);
			this.groupBox1.Controls.Add(this.txt_user);
			this.groupBox1.Controls.Add(this.txt_pass);
			this.groupBox1.Controls.Add(this.btn_user);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 152);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// frm_Login
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(304, 213);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbl_login);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frm_Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frm_Login());
		}
		/// <summary>
		/// Login click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bu_user_Click(object sender, System.EventArgs e)
		{
			if(txt_user.Text.Equals(""))
			{
				MessageBox.Show("Enter UserName");
				txt_user.Focus();
			}
			else if(txt_pass.Text.Equals(""))
			{
				MessageBox.Show("Enter Password");
				txt_pass.Focus();
			}
			else
			{
				try
				{
					cn=Conetion.conet();
					cm =  new SqlCommand("select UserName,Password from Login where UserName='"+txt_user.Text+"'and Password='"+txt_pass.Text+"'",cn);
					cn.Open();
					read = cm.ExecuteReader();
				
					if(read.HasRows)
					{
						MessageBox.Show("Login successful!");
						Conetion.Password=txt_pass.Text;
						MainForm f = new MainForm();
						f.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Invalid username or password");
						txt_user.ResetText();
						txt_pass.ResetText();
					}
					cn.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Can not connect to the Database!");
					Console.WriteLine(ex);
				}


			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		private void btn_password_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
