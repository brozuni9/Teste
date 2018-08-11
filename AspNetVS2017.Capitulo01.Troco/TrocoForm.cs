using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }


        private void calcularButton_Click(object sender, EventArgs e)
        {
            var troco = Convert.ToDecimal(valorPagoTextBox.Text) - Convert.ToDecimal(valorCompraTextBox.Text) ;

            trocoTextBox.Text = troco.ToString("c");


            var _100Reais = (int)troco/100;

            troco %= 100;

            var _50Reais = (int)troco / 50;

            troco %= 50;


            var _20Reais = (int)troco / 20;

            troco %= 20;


            var _10Reais = (int)troco / 10;

            troco %= 10;


            var _5Reais = (int)troco / 5;

            troco %= 5;
            
            var _2Reais = (int)troco / 2;

            troco -= troco %= 2;

            var moeda1Real = (int)troco/1;

            troco %= 1;

            var moeda50C = (int) (troco / 0.5m);

            troco %= 0.5m;

            var moeda25C = (int)(troco / 0.25m);

            troco %= 0.25m;

            var moeda10C = (int)(troco / 0.1m);

            troco %= 0.1m;


            var moeda5C = (int)(troco / 0.05m);
            
            troco %= 0.05m;

            var moeda1C = (int)(troco / 0.01m);


            moedasListView.Items[0].Text = moeda1Real.ToString();
            moedasListView.Items[1].Text = moeda50C.ToString();
            moedasListView.Items[2].Text = moeda25C.ToString();
            moedasListView.Items[3].Text = moeda10C.ToString();
            moedasListView.Items[4].Text = moeda5C.ToString();
            moedasListView.Items[5].Text = moeda1C.ToString();
            moedasListView.Items[6].Text = _2Reais.ToString();
            moedasListView.Items[7].Text = _5Reais.ToString();
            moedasListView.Items[8].Text = _10Reais.ToString();
            moedasListView.Items[9].Text = _20Reais.ToString();
            moedasListView.Items[10].Text =_50Reais.ToString();
            moedasListView.Items[11].Text =_100Reais.ToString();

        }

        private void moedasListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
