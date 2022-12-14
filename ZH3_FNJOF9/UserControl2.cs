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
    public partial class UserControl2 : UserControl
    {

        TextbookSupportContext context = new TextbookSupportContext();

        public UserControl2()
        {
            InitializeComponent();

            context.Students.Load();
            dataGridView1.DataSource = studentBindingSource;
        }
    }
}
