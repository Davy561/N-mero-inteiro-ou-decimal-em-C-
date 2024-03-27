using System;
class Program{
    static void Main(){
        Console.WriteLine("Escreva um número ");
        string saida = Console.ReadLine();

        int n1;

        if(int.TryParse(saida,out n1))
        {
            Console.WriteLine("Ok"+n1);
        }else{
            Console.WriteLine("Not"+n1);
        }
        
    }
}