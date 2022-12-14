using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_FNJOF9.Models;

namespace ZH3_FNJOF9
{
    public partial class UserControl1 : UserControl
    {

        TextbookSupportContext context = new TextbookSupportContext();

        public UserControl1()
        {
            InitializeComponent();

            context.Textbooks.Load();
            context.Students.Load();
            context.Orders.Load();

            studentbox.DisplayMember = "Name";
            bookbox.DisplayMember = "Title";
            orderbox.DisplayMember = "Title";
            orderbox.ValueMember = "OrderSK";

            Getstudent();
            Getbooks();
        }

        private void Getstudent()
        {
            studentbox.DataSource = (
                from x in context.Students
                where x.Name.Contains(studentszur.Text)
                select x).ToList();
        }

        private void Getbooks()
        {
            bookbox.DataSource = (
                from x in context.Textbooks
                where x.Title.Contains(konyvszur.Text)
                select x).ToList();
        }

        private void studentszur_TextChanged(object sender, EventArgs e)
        {
            Getstudent();
        }

        private void konyvszur_TextChanged(object sender, EventArgs e)
        {
            Getbooks();
        }

        private void Getorders()
        {
            Student stu = (Student)studentbox.SelectedItem;
            orderbox.DataSource = (
                from x in context.Orders
                where x.StudentFk == stu.StudentId
                select new
                {
                    x.OrderSk,
                    x.StudentFk,
                    x.TextbookFk.Title
                }).ToList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Student stu = (Student)studentbox.SelectedItem;
            Textbook tex = (Textbook)bookbox.SelectedItem;
            Order or = new Order();
            or.TextbookFk = tex.TextbookId;
            or.StudentFk = stu.StudentId;
            context.Orders.Local.Add(or);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Getorders();
        }

        private void studentbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getorders();
        }

        private void rem_Click(object sender, EventArgs e)
        {
            int oID = Convert.ToInt32(orderbox.SelectedValue);
            var o = from x in context.Orders
                    where x.OrderSk == oID
                    select x;
            context.Orders.Remove(o.FirstOrDefault());
            context.SaveChanges();
            Getorders();
        }
    }
}
