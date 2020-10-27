using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarkt
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> productsDic = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = tbProduct.Text;
            var productNumber = Convert.ToInt32(tbProductNumber.Text);

            if(!string.IsNullOrEmpty(product) && productNumber >0 && !productsDic.ContainsKey(product))
            {
                productsDic.Add(product, productNumber);
                UpdateShop();
            }
            else if(!string.IsNullOrEmpty(product) && productNumber >0 && productsDic.ContainsKey(product))
            {
                var currentNumber = productsDic[product];
                productsDic[product] = currentNumber + productNumber;
                UpdateShop();
            }
        }

        private void UpdateShop()
        {
            lBoxMerchandise.DataSource = productsDic.ToList();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            var produkt = tbProduct.Text;
            int productNumber = Convert.ToInt32(tbProductNumber.Text);

            if (productsDic.ContainsKey(produkt))
            {
                var currentNumber = productsDic[produkt];
                if (productNumber >= currentNumber)
                {
                    productsDic.Remove(produkt);
                    UpdateShop();
                }
                else
                {
                    productsDic[produkt] = currentNumber - productNumber;
                    UpdateShop();
                }

            }
        }
    }
}
