using TP03.eventoMusical;
using TP03.faculdade;
using TP03.geometria; 

Console.WriteLine("Escolha uma opção: ");
Console.WriteLine("1 - App ingressos");
Console.WriteLine("2 - App Matricula");
Console.WriteLine("3 - Testar Figuras Geométricas"); 
Console.WriteLine("0 - Sair");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        EventoMusical.Executar();
        Console.ReadKey();
        break;
    case 2:
        TestaMatricula.Executar();
        Console.ReadKey();
        break;
    case 3:
        TestarFiguras.Executar();  
        Console.ReadKey();
        break;
    case 0:
        Console.WriteLine("Saindo...");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
