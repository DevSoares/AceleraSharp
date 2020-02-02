using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ModelActivity
{
    public static class Mapper<TViewModel, TModel> where TViewModel : class 
                                                   where TModel :class
    {
        
        public static void MapTo(TViewModel viewModel, TModel model)
        {
            Type typeViewModel = viewModel.GetType();
            var viewModelProps = typeViewModel.GetProperties();

            Type typeModel = model.GetType();
            var modelProps = typeModel.GetProperties();
            
            foreach(var prop in viewModelProps)
            {
                PropertyInfo modelProperty = modelProps.FirstOrDefault(mp => mp.Name == prop.Name);                
                modelProperty.SetValue(model, prop.GetValue(viewModel));
            }
        }
    }
}
