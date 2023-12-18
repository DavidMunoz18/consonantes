namespace consonantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir un array con las vocales
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            // Definir un segundo array con 4 vocales y 1 consonante
            char[] consonante = { 'a', 'e', 'c', 'o', 'u' };

           
            int posConsonante = -1; // Inicializar la posición de la consonante como -1

            for (int i = 0; i < consonante.Length; i++)
            {
                // Verificar si el elemento actual no es una vocal
                if (Array.IndexOf(vocales, consonante[i]) == -1)
                {
                    posConsonante = i;
                    break; 
                }
            }

            
            Console.WriteLine("La posición de la consonante en el segundo array es: " + posConsonante);
        }
    }
}
