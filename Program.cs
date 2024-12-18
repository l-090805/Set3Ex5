namespace Set3Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vector de numere: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(" "), int.Parse);

            Console.WriteLine("O valoare 'e': ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("O valoare 'k'(pozitia pe care sa fie inserat 'e'): ");
            int k = int.Parse(Console.ReadLine());

            if(k < 0 || k > v.Length)
            {
                Console.WriteLine("Valoare lui 'k' nu este valida");
                return;
            }

            int[] newV = new int[v.Length + 1];
            for(int i = 0; i < k; i++)
            {
                newV[i] = v[i];
            }
            newV[k] = e;
            for(int i = k; i < v.Length; i++)
            {
                newV[i+1] = v[i];   
            }

            Console.WriteLine("Vectorul dupa inserare: " + string.Join(" ", newV));
        }
    }
}
