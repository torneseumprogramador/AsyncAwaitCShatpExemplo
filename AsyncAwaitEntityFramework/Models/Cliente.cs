using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AsyncAwaitEntityFramework.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public static async Task<List<Cliente>> AllAsync()
        {
            await Task.Delay(10000);
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente(){ Id= 1, Nome = "Danilo"});
            return clientes;
        }
    }
}