using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitnes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var db = new FatnesDataBase("public"))
            {
                var day = db.Days.FirstOrDefault();

                var newDay = new Models.Day { Id = Guid.NewGuid(), Date = new DateTime(2019, 02, 20), Calories = 100 };
                db.Days.Add(newDay);
                db.SaveChanges();
            }
        }
    }
}
