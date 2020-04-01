using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9meetup_codeFirst
{
    class DBContext
    {
    }
	//Declaração da classe Cliente
	public class Cliente
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string CpfCnpj { get; set; }
		public DateTime DataCadastro { get; set; }
		public decimal LimiteCredito { get; set; }
	}

	//Classe referente a conexão com banco de dados e instanciando mapeamento do cliente
	public class AppDBContext : DbContext
	{
		public AppDBContext() : base("server=x1-carbon\\sql2017dev;database=9meetup_codefirst;user id=xxx;password=xxx")
		{ }
		public DbSet<Cliente> Clientes { get; set; }
	}
}
