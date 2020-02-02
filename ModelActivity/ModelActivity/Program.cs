using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelActivity
{
    class Program
    {
        static void Main(string[] args)
        {

            var dtoModel = new ViewModel() { DataNascimento = DateTime.Now, Documento = "67846543", Nome = "Joaozinho", Sexo = 'F', Telefone = "47837647564" };

            var model = new Model();

            Mapper<ViewModel, Model>.MapTo(dtoModel, model);

            var modelProps = model.GetType().GetProperties();

            for (int i = 0; i< modelProps.Length; i++)
            {
                Console.WriteLine($"Propriedade Nº {i+1} | {modelProps[i].Name} : {modelProps[i].GetValue(model)}");
            }
        }
    }
}
