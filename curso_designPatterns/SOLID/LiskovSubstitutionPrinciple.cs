using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID
{
    public class LiskovSubstitutionPrinciple
    {
        public void Execute()
        {
            //DebitCard card = new DebitCard();
            CreditCard card = new CreditCard();

            card.Validate();
            card.CollectPayment();

            //O princípio de liskov está exemplificado acima, pois o código vai funcionar corretamente independente da subclasse instanciada 
        }
    }

    //A interface define o padrão obrigatório de uma classe, tudo que tem nela é obrigado a ser usado nas classes herdadas 
    interface IPaymentInterface
    {
        void CollectPayment();

        void Validate();
    }

    //superclasse
    public abstract class NubankCard : IPaymentInterface
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento efetuado");
        }

        public virtual void Validate() 
        {
            Console.WriteLine("Realizando validação...");
        }
    }

    //subclasse
    public class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Limite OK!!");
        }
    }
    
    //subclasse
    public class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Saldo disponível!!");
        }
    }

    //TODAS AS CLASSES ACIMA DEVERIAM ESTAR EM ARQUIVOS SEPARADOS, ESTOU MANTENDO NO MESMO POR MOTIVOS DIDÁTICOS
}
