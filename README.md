# Design Patterns 
 Padrão de código para solução de problemas na criação de um software

# Padrão SOLID

 S - Single Responsibility Principle - SRP
	A classe só deve ter uma responsabilidade/objetivo, ou seja, não pode fazer ações diferntes em contextos diferentes

 O - Open/Closed Principle - OCP
	Serve para não quebrar um código que já funciona quando alterá-lo
	O código deve ser fechado para modificação e aberto para extensão, ou seja, é permitido trabalhar com herança (ou interfaces, etc) e criar subclasses, mas não é possivel alterar 
	o que foi feito anteriormente e já é utilizado.
	Quando é necessário fazer uma mudança significativa, você deve criar uma nova classe, como se fosse uma nova versão

 L - Liskov Substitution Principle - LSP
	Os objetos das subclasses devem se comportar da mesma forma que os objetos da superclasse, ou seja, os objetos de uma superclasse devem ser substituídos por objeto de suas 
	subclasses sem quebrar o aplicativo.
	É quando você constroi os códigos seguindo um padrão, então, quando for necessário modificar algo só será necessário mudar o nome

I - Interface Segregation Principle - ISP
	Consiste em deixar as interfaces menores, sem muitos métodos.
	Segundo o ISP, ao utilizar uma interface, não devemos ser expostos a métodos de que não precisa
	https://reflectoring.io/interface-segregation-principle/#what-is-an-interface 

# Anotações
 * Quando o método é abstrata não é possível instânciá-lo.
	ex: public abstract class NubankCard {}
 * "virtual" permite o método ser sobrescrito, ou seja, usar um override 
    ex definicao: public **virtual** void Validate() {}
	ex utilização :  public class CreditCard : NubankCard (tem que herdar a classe)
						{
							public **override** void Validate()
							{}
						}
 * Nas interfaces não pode adicionar linhas de código, só é permitido definir o nome dos métodos 
	ex correto: void Validate();
	ex incorreto: void Validate(){
					Console.WriteLine("Validar");
				  }
