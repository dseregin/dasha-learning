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

namespace Fitnes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var db = new FitnesDataBase("public"))
            {

                var ExerciseCapasity = db.ExerciseCapasities.ToList();
            }
        }
    }
}
