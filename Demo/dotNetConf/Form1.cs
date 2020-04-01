using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetConf
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

        private void Button1_Click(object sender, EventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            //SELECT Id, Nome, CpfCnpj Nome LIKE 'NOME%'
            using (var context = new AppDBContext())
            {
                string nome = "Jackson";
                var cli = context.Clientes
                            .Where(c => c.Nome.StartsWith(nome))
                            .Select(c => new { c.Id, c.Nome, c.CpfCnpj })
                            .ToList();
            }

        }
    }
}
