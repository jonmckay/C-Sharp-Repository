using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingredient_Sorter_Chapter_11
{
    public partial class SecretIngredientForm : Form
    {
        GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        public SecretIngredientForm()
        {
            InitializeComponent();
        }

        private void btnGetIngredient_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
            {
                Console.WriteLine("I'll add " + ingredientMethod((int)numericUpDown1.Value));
            }
            else
            {
                Console.WriteLine("I don't have a secret ingredient!");
            }
        }

        private void btnSuzannesDelegate_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.SuzannesSecretIngredientMethod);
        }

        private void btnAmysDelegate_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(amy.AmysSecretIngredientMethod);
        }
    }
}
