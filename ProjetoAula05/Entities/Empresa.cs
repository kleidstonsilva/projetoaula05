using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAula05.Entities
{
    public class Empresa
    {
        public Guid IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        
        //Relacionamento de Associação
        //Empresa tem Muitos Funcionários
        public List<Funcionario> Funcionarios { get; set; }


    }
}
