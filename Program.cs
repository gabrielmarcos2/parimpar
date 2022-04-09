{
int numero;
string paridade;

Console.Write("Digete um Numero");
numero = Convert.ToInt32(Console.ReadLine());

paridade = (numero % 2) == 0 ? "par" : "imapar";

Console.WriteLine($"{numero} é {paridade}");
}
