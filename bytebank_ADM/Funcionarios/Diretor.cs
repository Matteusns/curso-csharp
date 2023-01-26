using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:Funcionario
    {
        public override double GetBonificacao()
        { // Base pega os metodos da super classe
            return this.Salario + (base.GetBonificacao());
        }
        public Diretor(string cpf, double salario):base(cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            base.Salario *= 1.15;
        }
    }
}
