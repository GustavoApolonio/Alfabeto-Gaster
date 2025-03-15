using System;
					
public class Program
{
	public static void Main()
	{
		Console.Clear();
string x;
string y;
int a ;
Console.WriteLine("digite 1 para que você traduzir sua mensagem para ghaster, digite 2 para trazuir de ghaster para você");
a = Convert.ToInt16(Console.ReadLine()!);

if(a == 1){

    Console.Write("escreva seu texto: ");
x = Console.ReadLine()!.ToUpper();
y = x
    .Replace("A", "✌")
    .Replace("B", "👌")
    .Replace("C", "👍")
    .Replace("D", "👎")
    .Replace("E", "☜")
    .Replace("F", "☞")
    .Replace("G", "☝")
    .Replace("H", "☟")
    .Replace("I", "✋")
    .Replace("J", "☺")
    .Replace("K", "😐")
    .Replace("L", "☹")
    .Replace("M", "💣")
    .Replace("N", "☠ ")
    .Replace("O", "⚐")
    .Replace("P", "🏱")
    .Replace("Q", "✈")
    .Replace("R", "☼")
    .Replace("S", "💧")
    .Replace("T", "❄")
    .Replace("U", "🕆")
    .Replace("V", "✞")
    .Replace("W", "🕈")
    .Replace("X", "✠")
    .Replace("Y", "✡")
    .Replace("Z", "☪")
;
Console.WriteLine(y);

}

else if(a == 2 ){

Console.Write("Escreva seu texto: ");
 x = Console.ReadLine()!.ToUpper();
 y = x
    .Replace("☪", "Z")
    .Replace("✡", "Y")
    .Replace("✠", "X")
    .Replace("🕈", "W")
    .Replace("✞", "V")
    .Replace("🕆", "U")
    .Replace("❄", "T")
    .Replace("💧", "S")
    .Replace("☼", "R")
    .Replace("✈", "Q")
    .Replace("🏱", "P")
    .Replace("⚐", "O")
    .Replace("☠", "N")
    .Replace("💣", "M")
    .Replace("☹", "L")
    .Replace("😐", "K")
    .Replace("☺", "J")
    .Replace("✋", "I")
    .Replace("☟", "H")
    .Replace("☝", "G")
    .Replace("☞", "F")
    .Replace("☜", "E")
    .Replace("👎", "D")
    .Replace("👍", "C")
    .Replace("👌", "B")
    .Replace("✌", "A");

Console.WriteLine(y);


}


else
{
Console.WriteLine("erro");

};


	}
}

