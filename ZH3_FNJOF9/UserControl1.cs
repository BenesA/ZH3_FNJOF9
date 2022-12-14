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
            orderbox.ValueMember = "StudentFK";

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
    }
}
