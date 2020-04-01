using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9meetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SELECT TOP 1
            var q = new AppDBContext();
            _ = q.Clientes.Find(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SELECT * WHERE Nome LIKE 'NOME%'
            string nome = "Jackson";
            using (var db = new AppDBContext())
            {
                var cli = db.Clientes
                            .Where(c => c.Nome.StartsWith(nome))
                            .ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SELECT Id, Nome WHERE Nome LIKE 'NOME%' 
            using (var context = new AppDBContext())
            {
                string nome = "Jackson";
                var cli = context.Clientes
                            .Where(c => c.Nome.StartsWith(nome))
                            .Select(c => new { c.Id, c.Nome })
                            .ToList();
            }
        }
    }
}
