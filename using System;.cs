using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cap4_Fundamentos_Lenguaje
{
    public partial class FrmCap4 : Form
    {
        public FrmCap4()
        {
            InitializeComponent();
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            Char Op;
            Op = this.CbxOperacion.Text.Substring(0, 1)[0];
            this.TxtOperacion.Text = TxtOp1.Text+" "+Op+" "+TxtOp2.Text+" = ";
            switch (Op.ToString())
            {
                case "+":
                    TxtResultado.Text = Convert.ToString(
                        Convert.ToDecimal(TxtOp1.Text) + Convert.ToDecimal(TxtOp2.Text));
                    break;
                case "-":
                    TxtResultado.Text = Convert.ToString(
                        Convert.ToDecimal(TxtOp1.Text) - Convert.ToDecimal(TxtOp2.Text));
                    break;
                case "*":
                    TxtResultado.Text = Convert.ToString(
                        Convert.ToDecimal(TxtOp1.Text) * Convert.ToDecimal(TxtOp2.Text));
                    break;
                case "/":
                    TxtResultado.Text = Convert.ToString(
                        Convert.ToDecimal(TxtOp1.Text) / Convert.ToDecimal(TxtOp2.Text));
                    break;

                default: 
                    TxtResultado.Text = "No existe operación";
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnOperar_Click_Click(object sender, EventArgs e)
        {
            // Variable para almacenar el resultado
            string resultado = string.Empty;

            // Usar switch para determinar la operación
            switch (this.CbxOperaCadena.Text)
            {
                case "Concatenar":
                    // Concatenar cadenas con un espacio extra al final de cada cadena
                    resultado = TxtCadena1.Text + " " + TxtCadena2.Text + " " + TxtCadena3.Text + " ";
                    this.TxtCadenaresultado.Text = resultado;
                    break;

                case "Mayusculas":
                    // Concatenar y convertir a mayúsculas con un espacio extra
                    resultado = TxtCadena1.Text + " " + TxtCadena2.Text + " " + TxtCadena3.Text + " ";
                    this.TxtCadenaresultado.Text = resultado.ToUpper();
                    break;

                default:
                    // Mensaje de error si la operación no es válida
                    TxtCadenaresultado.Text = "No existe operación";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text;
            //Calculamos la longitud de la cadena
            int longitud = cadena.Length;
            txtLongitud.Text = Convert.ToString(longitud);

    
          
            //Calculamos la longitud de la cadena
            txtLongitud.Text = Convert.ToString(cadena.Length);
            //Mostramos el primer caracter
            txtPrimer.Text = cadena.Substring(0, 1);
            //Mostramos el último caracter
            txtUltimo.Text = cadena.Substring(cadena.Length - 1, 1);
            //Mostramos el del segundo al sexto caracter
            txt26.Text = cadena.Substring(2, 6);
            //Buscamos la posición de la primera letra "A" o "a"
            txtA.Text = Convert.ToString(cadena.IndexOf("A", 0) + 1);
            //Convertimos las letras a mayúsculas
            txtMay.Text = cadena.ToUpper();
            //Convertimos las letras a minúsuculas
            txtMin.Text = cadena.ToLower();
            //Eliminar caracteres en blanco
            txtBorrarEspacios.Text = cadena.Replace(" ", "");
        }

        private void reconocer1_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string inputText = txtCadena.Text;

            // Definir las palabras a reconocer
            string[] palabrasReconocidas = { "hola", "mundo", "csharp", "botón" };

            // Limpiar el TextBox de resultados
            TxtResultado2.Clear();

            // Variable para almacenar los resultados
            string resultados = "";

            // Verificar si el texto ingresado contiene alguna de las palabras
            foreach (string palabra in palabrasReconocidas)
            {
                if (!inputText.ToUpper().Contains(palabra.ToUpper()))
                {
                    continue;
                }
                resultados += $"Se reconoció la palabra: {palabra}\r\n";
            }

            // Mostrar los resultados en el TextBox de resultados
            if (string.IsNullOrEmpty(resultados))
            {
                TxtResultado2.Text = "No se reconocieron palabras.";
            }
            else
            {
                TxtResultado2.Text = resultados;
            }
        }
    }

}