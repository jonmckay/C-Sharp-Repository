using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingredient_Sorter_Chapter_11
{
    class Suzanne
    {
        public GetSecretIngredient SuzannesSecretIngredientMethod 
        { 
            get
            {
                return new GetSecretIngredient(SuzannesSecretIngredient);
            }
        }

        private string SuzannesSecretIngredient(int amount)
        {
            return amount.ToString() + " ounces of cloves";
        }
    }
}
