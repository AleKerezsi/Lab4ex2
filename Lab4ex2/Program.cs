using System;

namespace Lab4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura. 
             Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul. Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-irezultatul.*/

            
            Console.WriteLine("Introduceti lungimea n a matricii: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea m a matricii: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea k a matricii: ");
            int k = int.Parse(Console.ReadLine());

            int[,,] matrix = new int[n,m,k];

            for(int i= 0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    for(int q=0; q<k; q++)
                    {
                        Console.WriteLine("Introduceti elementul de pe pozitia cu indicii " + i + " " + j + " " + q);
                        matrix[i, j, q] = int.Parse(Console.ReadLine()); 
                    }
                }
            }

            Console.WriteLine("Suma este: "+ CalculeazaSumaMatrice(matrix, n, m, k));
            Console.WriteLine("Numarul maxim este: "+CalculeazaElementulMaxim(matrix,n,m,k));


        }
        static int CalculeazaSumaMatrice(int[,,] matrix, int n, int m, int k)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int q = 0; q < k; q++)
                    {
                        suma= suma + matrix[i, j, q];
                    }
                }
            }
            return suma;
        }

        static int CalculeazaElementulMaxim(int[,,] matrix, int n, int m, int k)
        {
            int maxim = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int q = 0; q < k; q++)
                    {
                        if (matrix[i, j, q] > maxim)
                        maxim = matrix[i, j, q];

                    }
                }
            }
            return maxim;
        }
    }
}
