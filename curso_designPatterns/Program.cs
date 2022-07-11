using curso_designPatterns.SOLID;

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

            InterfaceSegregationPrinciple isp = new InterfaceSegregationPrinciple();
            isp.Execute();
        }
    }
}