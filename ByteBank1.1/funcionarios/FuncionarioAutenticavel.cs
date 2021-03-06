﻿using ByteBank1._1.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1._1.funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario,Autenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return (this.Senha == senha);
        }
    }
}
