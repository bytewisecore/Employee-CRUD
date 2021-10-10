using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eid = id.Text;
            string efname = fname.Text;
            string elname = lname.Text;
            string egender = gender.SelectedItem.ToString();
            string eage = age.Text;
            string ecell = cellphone.Text;
            string enation = nationality.Text;
            string edob =  dob.Value.ToShortDateString();

            string query = "insert into employees values('" + eid + "','" + efname + "','" + elname + "','" + egender + "','" + eage + "','" + ecell + "','" + enation + "','" + edob + "')";
            string con = "Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            SqlConnection sql = new SqlConnection(con);
            sql.Open();
            SqlCommand cmd = new SqlCommand(query,sql);

            if (cmd.ExecuteNonQuery() >= 1)
                MessageBox.Show("Insertion Was Sucessful");
            else
                MessageBox.Show("Insertion Was Not Sucessful");
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbcon demo = new dbcon("Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True");
            string query = "select * from employees where id = '" + id.Text + "'";
            DataTable dt = demo.search(query);
            id.Text = dt.Rows[0]["id"].ToString();
            fname.Text = dt.Rows[0]["firstname"].ToString();
            lname.Text = dt.Rows[0]["lastname"].ToString();
            //gender.SelectedItem.ToString();
            age.Text = dt.Rows[0]["age"].ToString() ;
            cellphone.Text = dt.Rows[0]["cellphone"].ToString();
            nationality.Text = dt.Rows[0]["nationality"].ToString();
            //dob.Value = dt.Rows[0]["lastname"].ToString().ToShortDateString();


        }

        private void update_Click(object sender, EventArgs e)
        {
            string eid = id.Text;
            string efname = fname.Text;
            string elname = lname.Text;
            string egender = gender.SelectedItem.ToString();
            string eage = age.Text;
            string ecell = cellphone.Text;
            string enation = nationality.Text;
            string edob = dob.Value.ToShortDateString();

            string query = "update employees set id='" + eid + "',firstname='" + efname + "',lastname='" + elname + "',gender='" + egender + "',age='" + eage + "',cellphone='" + ecell + "',nationality='" + enation + "',dateofbirth='" + edob + "' where id="+eid;
            string con = "Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            SqlConnection sql = new SqlConnection(con);
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);

            if (cmd.ExecuteNonQuery() >= 1)
                MessageBox.Show("Update Was Sucessful");
            else
                MessageBox.Show("Update Was Not Sucessful");
            sql.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string eid = id.Text;
            
            string query = "delete from employees where id=" + eid;
            string con = "Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            SqlConnection sql = new SqlConnection(con);
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);

            if (cmd.ExecuteNonQuery() >= 1)
                MessageBox.Show("Delete Was Sucessful");
            else
                MessageBox.Show("Delete Was Not Sucessful");
            sql.Close();
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
