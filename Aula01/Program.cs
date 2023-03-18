// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Aula01;

public class Program {

   public static void Main(){

/* Orientação a Objetos */
/* Exemplo conta bancária - Encapsulamento */

      Conta conta = new Conta();
      // conta.saldo = 100; // Valor protected
      System.Console.WriteLine($"Saldo: {conta.saldo}");
      conta.deposita(120);
      System.Console.WriteLine($"Saldo: {conta.saldo}");
      conta.saca(60);
      System.Console.WriteLine($"Saldo: {conta.saldo}");

/* Exemplo pista - Herança*/

      // Pista pista = new Pista();
      // pista.id = 1;
      // pista.clima = "Chuva";

      // Treino treino = new Treino();
      // treino.id = 2;
      // treino.clima = "Sol";
      // treino.barreiras = 4;

// /* Exemplo Carro */
//       Carro carro = new Carro();
//       carro.id = 1;
//       carro.nome = "BMW";
//       carro.veloxMax = 300;

//       System.Console.WriteLine($"Id:{carro.id} Nome: {carro.nome} Velocidade:{carro.veloxMax}");
//       carro.alterar(350); // Alterando a velocidade
//       System.Console.WriteLine($"Id:{carro.id} Nome: {carro.nome} Velocidade:{carro.veloxMax}");

      // Carro carro2 = new Carro();
      // carro2.id = 2;
      // carro2.nome = "Ford";
      // carro2.veloxMax = 230;

      // System.Console.WriteLine($"Id:{carro2.id} Nome: {carro2.nome} Velocidade:{carro2.veloxMax}");


/* Desafio IMC */
      // System.Console.WriteLine("Informe seu nome:");
      // string? nome = Console.ReadLine();
      // System.Console.WriteLine("Você digitou: " + nome);

      // System.Console.WriteLine("Informe a sua idade:");
      // int idade = Convert.ToInt32(Console.ReadLine());
      // System.Console.WriteLine("Sua idade: " + idade);

      // System.Console.WriteLine("Informe a sua altura:");
      // double altura = Convert.ToDouble(Console.ReadLine());

      // System.Console.WriteLine("Informe o seu peso:");
      // double peso = Convert.ToDouble(Console.ReadLine());

      // calculaIMC(altura, peso);

      // void calculaIMC(double altura, double peso){
      //    double resultado = peso / (altura * altura);
      //    System.Console.WriteLine("Resultado do calculo IMC: " + resultado);
      //    if (resultado < 18.5) {
      //       System.Console.WriteLine("Abaixo do peso.");
      //    } else if (resultado >= 18.5 && resultado <= 24.9) {
      //       System.Console.WriteLine("Peso normal.");
      //    } else if (resultado >= 25.0 && resultado <= 29.9) {
      //       System.Console.WriteLine("Pré-obesidade.");
      //    } else if (resultado >= 30.0 && resultado <= 34.9) {
      //       System.Console.WriteLine("Obesidade grau 1.");
      //    } else if (resultado >= 35.0 && resultado <= 39.9) {
      //       System.Console.WriteLine("Obesidade grau 2.");            
      //    } else if (resultado > 40) {
      //       System.Console.WriteLine("Obesidade grau 3.");
      //    }
      // }


      // int numero = 1;
      // System.Console.WriteLine(numero);
      // int retorno;
      // System.Console.WriteLine(retorno);

/* if else */ 

      // if (numero == 10) {
      //    retorno = alterar(numero);
      // } else {
      //    retorno = numero;
      // }
      // System.Console.WriteLine(retorno);

/* while */ 

      // retorno = alterar(numero);

      // System.Console.WriteLine("Loop while");
      // while (numero < 10){
      //    System.Console.WriteLine(retorno);
      //    numero++;
      // }
      // System.Console.WriteLine("");

      // System.Console.WriteLine("Loop for");
      // for (int i = 0; i<10; i++) {
      //    System.Console.WriteLine(i);
      // }

      // int alterar(int num){
      //    return num + 1;
      // }


/* vetor de string */ 
   //    string [] nomes = new string[]{"Peter", "Clark", "Jason"};
   //    foreach (string nome in nomes){
   //       System.Console.WriteLine(nome);
   //       if (nome == nomes[0]) { 
   //          break; 
   //       }
   //    }

   // }

/* switch */ 
   // int var = 2;
   // switch (var)
   // {
   //    case 3: 
   //       System.Console.WriteLine("3");
   //       break;
   //    default:
   //       System.Console.WriteLine("Nada");
   //       break;

   // }

   }
}