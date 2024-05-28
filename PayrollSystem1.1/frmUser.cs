using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem1._1.includes;
using System.Text.RegularExpressions;

namespace PayrollSystem1._1
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void frmUser_Load(object sender, EventArgs e)
        {
            sql = "SELECT user_id as Id,name as Name,username as Username,type as Type FROM user";
            config.Load_DTG(sql, dtg_userList);
            lbl_id.Text = "id";
            btnsave.Text = "Add";
            funct.clearTxt(GroupBox11);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text == "" ||
                txtname.Text == "" ||
                txtuser.Text == "" ||
                txtpass.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!ValidatePassword(txtpass.Text))
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (btnsave.Text == "Add")
                {
                    sql = "INSERT INTO `user` (`name`,`username`, `pass`, `type` ) VALUES ('" + txtname.Text + "','"
                     + txtuser.Text + "',sha1('" + txtpass.Text + "'),'" + cbotype.Text + "')";
                    config.Execute_CUD(sql, "error to execute.", "Data has been saved in the database.");
                }
                else
                {
                    sql = "UPDATE user set name='" + txtname.Text + "',username='" + txtuser.Text
                     + "', pass = sha1('" + txtpass.Text + "') Where user_id='" + lbl_id.Text + "'";
                    config.Execute_CUD(sql, "error to execute.", "Data has been updated in the database.");
                }
                frmUser_Load(sender, e);
            }
        }

        private bool ValidatePassword(string password)
        {
            // Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            lbl_id.Text = dtg_userList.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dtg_userList.CurrentRow.Cells[1].Value.ToString();
            txtuser.Text = dtg_userList.CurrentRow.Cells[2].Value.ToString();
            btnsave.Text = "Save";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            sql = "SELECT user_id as Id,name as Name,username as Username,type as Type FROM user";
            config.Load_DTG(sql, dtg_userList);
            lbl_id.Text = "id";
            btnsave.Text = "Add";
            funct.clearTxt(GroupBox11);
        }

        private void btnMUdel_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM user WHERE user_id = '" + dtg_userList.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "error to execute.", "Data has been deleted");
            frmUser_Load(sender, e);
        }
    }
}
