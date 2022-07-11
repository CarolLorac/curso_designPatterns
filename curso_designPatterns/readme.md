# Design Patterns 

## Defini��o
 Padr�o de c�digo para solu��o de problemas na cria��o de um softwaree

## Padr�o SOLID

 S - Single Responsibility Principle - SRP
	A classe s� deve ter uma responsabilidade/objetivo, ou seja, n�o pode fazer a��es diferntes em contextos diferentes

 O - Open/Closed Principle - OCP
	Serve para n�o quebrar um c�digo que j� funciona quando alter�-lo
	O c�digo deve ser fechado para modifica��o e aberto para extens�o, ou seja, � permitido trabalhar com heran�a (ou interfaces, etc) e criar subclasses, mas n�o � possivel alterar 
	o que foi feito anteriormente e j� � utilizado.
	Quando � necess�rio fazer uma mudan�a significativa, voc� deve criar uma nova classe, como se fosse uma nova vers�o

 L - Liskov Substitution Principle - LSP
	Os objetos das subclasses devem se comportar da mesma forma que os objetos da superclasse, ou seja, os objetos de uma superclasse devem ser substitu�dos por objeto de suas 
	subclasses sem quebrar o aplicativo.
	� quando voc� constroi os c�digos seguindo um padr�o, ent�o, quando for necess�rio modificar algo s� ser� necess�rio mudar o nome

I - Interface Segregation Principle - ISP
	Consiste em deixar as interfaces menores, sem muitos m�todos.
	Segundo o ISP, ao utilizar uma interface, n�o devemos ser expostos a m�todos de que n�o precisa
	https://reflectoring.io/interface-segregation-principle/#what-is-an-interface 

## Anota��es
 * Quando o m�todo � abstrata n�o � poss�vel inst�nci�-lo.
	ex: public abstract class NubankCard {}
 * "virtual" permite o m�todo ser sobrescrito, ou seja, usar um override 
    ex definicao: public **virtual** void Validate() {}
	ex utiliza��o :  public class CreditCard : NubankCard (tem que herdar a classe)
						{
							public **override** void Validate()
							{}
						}
 * Nas interfaces n�o pode adicionar linhas de c�digo, s� � permitido definir o nome dos m�todos 
	ex correto: void Validate();
	ex incorreto: void Validate(){
					Console.WriteLine("Validar");
				  }