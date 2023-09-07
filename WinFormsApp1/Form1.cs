namespace WinFormsApp1;


using System;
using System.Data;
using System.Data.SqlClient;

public partial class Form1 : Form
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection conn = new SqlConnection();
    public Form1()
    {
        InitializeComponent();
    }



    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

       

        SqlConnection conn = new SqlConnection("data source=LAPTOP-KJJTGF81\\SQLEXPRESS;initial catalog=TestDB;trusted_connection=true");
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into teacher values('{txtname.Text}','{txtaddress.Text}');", conn);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Inserting Data Successfully");
        conn.Close();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        conn = new SqlConnection("data source=LAPTOP-KJJTGF81\\SQLEXPRESS;initial catalog=TestDB;trusted_connection=true");
        cmd = new SqlCommand();
        cmd.Connection = conn;
    }
}
