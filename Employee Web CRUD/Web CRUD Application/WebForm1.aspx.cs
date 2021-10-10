using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CRUD_Application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string ID = id.Text;
            string first = fname.Text;
            string last = lname.Text;
            string Email = email.Text;
            string Age = age.Text;
            string cell = cellphone.Text;
            string pos = position.Text;

            string query = " update webemployees set firstname = '" + first + "',lastname = '" + last + "',age = '" + Age + "',email = '" + Email + "',cellphone = '" + cell + "',position = '" + pos +"' where id='" + ID + "';";
            dbcon db = new dbcon("Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True");
            bool check = db.UDI(query);


            if (check)
                result.Text = "Update Was Successful";
            else
                result.Text = "Update Was not Successful";
            ;


        }

        protected void insert_Click(object sender, EventArgs e)
        {
            string ID = id.Text;
            string first = fname.Text;
            string last = lname.Text;
            string Email = email.Text;
            string Age = age.Text;
            string cell = cellphone.Text;
            string pos = position.Text;

            string query = "insert into webemployees values('" + ID +"','" + first + "','" + last +"','" + Age + "','" + Email + "','" + cell +"','" + pos + "');";
            dbcon db = new dbcon("Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True");
            bool check = db.UDI(query);


            if (check)
                result.Text = "Insert Was Successful";
            else
                result.Text = "Insert Was not Successful";
            ;


        }

        protected void delete_Click(object sender, EventArgs e)
        {
            string ID = id.Text;
            string first = fname.Text;
            string last = lname.Text;
            string Email = email.Text;
            string Age = age.Text;
            string cell = cellphone.Text;
            string pos = position.Text;

            string query = "delete from webemployees where id = '" + ID + "';";
            dbcon db = new dbcon("Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True");
            bool check = db.UDI(query);


            if (check)
                result.Text = "Delete Was Successful";
            else
                result.Text = "Delete Was not Successful";
            ;


        }

        protected void read_Click(object sender, EventArgs e)
        {
            dbcon db = new dbcon("Data Source=USMAN-LAPTOP\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True");
            string query = "select * from webemployees where id='"+ id.Text +"'";
            DataTable dt = db.search(query);

            //if (dt.Rows.Count > 0)
            //{
                result.Text = "Read Was Successful";
                //id.Text = dt.Rows[0]["id"].ToString();
                fname.Text = dt.Rows[0]["firstname"].ToString();
                lname.Text = dt.Rows[0]["lastname"].ToString();
                email.Text = dt.Rows[0]["email"].ToString();
                age.Text = dt.Rows[0]["age"].ToString();
                cellphone.Text = dt.Rows[0]["cellphone"].ToString();
                position.Text = dt.Rows[0]["position"].ToString();
            //}
            //else
              //  result.Text = "Read Was not Successful";

        }
    }
}