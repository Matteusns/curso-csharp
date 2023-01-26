using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.CPF = cpf;
            TotalDeFuncionarios++;
            this.Salario = salario;
        }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
