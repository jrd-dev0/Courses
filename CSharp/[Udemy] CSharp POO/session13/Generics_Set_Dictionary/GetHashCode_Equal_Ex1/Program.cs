//Em um portal de cursos online, cada usuârio possui um código unico, representado por um número inteiro.
//Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser.
//Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos os cursos que ele possui,
//pois pode haver alunos repetidos em mais de um curso.
//Instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.

//Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
//quantidade total e alunos dele, conforme exemplo.
//https://github.com/acenelio/set2-csharp

namespace GetHashCode_Equal_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());

            SortedSet<int> courseA = new SortedSet<int>();
            for (int i = 0; i < a; i++)
            {
                courseA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());

            SortedSet<int> courseB = new SortedSet<int>();
            for (int i = 0; i < b; i++)
            {
                courseB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());

            SortedSet<int> courseC = new SortedSet<int>();
            for (int i = 0; i < c; i++)
            {
                courseC.Add(int.Parse(Console.ReadLine()));
            }

            SortedSet<int> students = new SortedSet<int>(courseA);
            students.UnionWith(courseB);
            students.UnionWith(courseC);
            

            Console.WriteLine($"Total students: {students.Count}");

        }
    }
}