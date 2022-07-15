
namespace curso_designPatterns.SOLID.DependencyInversionPrinciple
{
    class PaymentProcessDIP
    {
        public void Pay (string id)
        {
            SqlServerDbProduct product = new SqlServerDbProduct(); //Isso é muito ruim pq faz o código depender do MYSQL, se caso você quisesse mudar de bd daria problemas - código fica engessado 
            string productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }

        //FORMA DE FAZER UM CÓDIGO PARA MUDAR FACILMENTE O BANCO DE DADOS (POR EXEMPLO)

    }
}
