using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericActivity
{
    interface IRepositoty<TModel> where TModel : class
    {
        bool Save(TModel model);

        bool SaveAll(List<TModel> models);
    }
}
