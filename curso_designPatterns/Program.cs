using curso_designPatterns.SOLID;
using curso_designPatterns.SOLID.DependencyInversionPrinciple;

namespace curso_designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //OpenClosedPrinciple ocp = new OpenClosedPrinciple();
            //ocp.Execute();

            //LiskovSubstitutionPrinciple lsp = new LiskovSubstitutionPrinciple();
            //lsp.Execute();

            //InterfaceSegregationPrinciple isp = new InterfaceSegregationPrinciple();
            //isp.Execute();

            PaymentProcessDIP dip = new PaymentProcessDIP();
            dip.Pay("CAC123");
        }
    }
}