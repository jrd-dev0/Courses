namespace Pedro_Bento_e_o_Mundo_de_OZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utilize Console.ReadLine para leitura do input de cada linha
            // Utilize Console.WriteLine para fazer o output de cada linha

            List<string> listaDeJoias = new List<string>();

            while (true)
            {
                string joia = Console.ReadLine();

                if (!string.IsNullOrEmpty(joia))
                {
                    if (!listaDeJoias.Contains(joia))
                    {
                        listaDeJoias.Add(joia);
                    }
                }
                else
                {
                    break;
                }
                
            }

            int tiposDeJoias = listaDeJoias.Count;

            Console.WriteLine(tiposDeJoias);

        }
    }
}
