using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericActivity
{
    public class Repository<TModel> : IRepositoty<TModel> where TModel : class
    {
        public bool Save(TModel model)
        {
            Console.WriteLine(model.ToString());
            return true;
        }

        public bool SaveAll(List<TModel> models)
        {
            foreach (var model in models)
            {
                Console.WriteLine($"Type: {typeof(TModel)} | {model.ToString()}");
            }
            return true;
        }
    }
}
