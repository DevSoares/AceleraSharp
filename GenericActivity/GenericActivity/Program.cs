using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa() { Name = "Paulo", Age = 23 };
            var dog = new Cachorro() { Name = "Caramelo IV", ScientificName = "Canis lupus familiaris" };
            var pessoaRepo = new Repository<Pessoa>();
            var dogRepo = new Repository<Cachorro>();
            var mixedRepo = new Repository<Object>();
            var pessoaList = new List<Pessoa> { pessoa };
            var dogList = new List<Cachorro> { dog };
            var mixedList = new List<Object>();
            mixedList.Add(pessoaList.FirstOrDefault());
            mixedList.Add(dogList.FirstOrDefault());

            pessoaRepo.Save(pessoa);
            pessoaRepo.SaveAll(pessoaList);
            Console.WriteLine("--------------------");
            dogRepo.Save(dog);
            dogRepo.SaveAll(dogList);
            Console.WriteLine("--------------------");
            mixedRepo.Save(pessoa);
            mixedRepo.Save(dog);
            mixedRepo.SaveAll(mixedList);
        }
    }
}
