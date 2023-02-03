using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        int resultadofinal;
       
       
        private void MostrarButton_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(NumeroTextBox.Text);
            resultadofinal = Positivo(numero);
            resultadofinal = Negativo(numero);
            
        }

        private int Positivo(int numero)
        {
            if(numero % 2==0 && numero>=0 ) 
            {
                ResultadoLabel.Text = "El numero " +numero +" es PAR y POSITIVO ";
            }
            else if(numero>=0)
            {
                ResultadoLabel.Text = "El numero " + numero + " es IMPAR y POSITIVO";
            }
            return numero;
            
        }
        private int Negativo(int numero)
        {
            
            if(numero %2==0 && numero<0 )
                
            {
                ResultadoLabel.Text = "El numero " + numero + " es PAR y NEGATIVO";
            }
            else if(numero<0)
            {
                ResultadoLabel.Text = "El numero " + numero + " es IMPAR y NEGATIVO";
            }
            return numero;
        }
       
    }
}
