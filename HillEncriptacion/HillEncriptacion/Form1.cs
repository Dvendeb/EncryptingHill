using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HillEncriptacion
{
    public partial class Form1 : Form
    {
        //Declaración de variables
        public String alfabet= " ABCDEFGHIJKLMNÑOPQRSTUVWXYZ.";
        public String stringText, textComplet;
        public char[] arrayAlfabet;
        public char[] arrayStringText;
        public int[] arrayNumbersText;
        public int spaces = 0, numberDiv=0,textLength;
        public int[][] arrayNumbers;
        public int[,] arrayoperation ={{1,0,2},{2,-1,1},{1,3,0}};
        public int[][] arrayEncriptation;

        public Form1()
        {
            InitializeComponent();
        }

        //Metodo onclick del boton para encriptar la cadena de texto ingresada por el usuario
        private void btn_encrypting_Click(object sender, EventArgs e)
        {
            numberLetter();
            showTextNumber();
            createArrayBi();
            encrypting();
            showTextEncrypting();
        }

        //Metodo de transformacion de letra a numero segun la tabla 
        public void numberLetter()
        {
            stringText =txtB_message.Text.ToUpper();
            textComplet = stringText;
            int k = 0;
            if(textComplet.Length % 3 != 0)
            {
                do
                {
                    textComplet = textComplet + " ";
                    k++;
                } while (textComplet.Length % 3 != 0);
            }
            arrayAlfabet = alfabet.ToCharArray();
            arrayStringText = textComplet.ToCharArray();
            arrayNumbersText = new int [arrayStringText.Length];
            textLength = arrayStringText.Length - k;

            for (int i = 0; i < arrayStringText.Length; i++)
            {
                for (int j = 0; j < arrayAlfabet.Length; j++)
                {
                    if (arrayStringText[i]==arrayAlfabet[j])
                    {
                        arrayNumbersText[i] = j;
                    }
                }
            }
        }

        //Metodo para mostrar las letras convertidas en numero
        public void showTextNumber()
        {
            txtB_textNumber.Text = "";
            for (int i = 0; i < arrayStringText.Length; i++)
            {
                txtB_textNumber.Text += " [" + arrayStringText[i] + "-" + arrayNumbersText[i] + "] ";
            }
        }

        private void lbl_Body_Click(object sender, EventArgs e)
        {

        }

        public void createArrayBi()
        {
            spaces = arrayNumbersText.Length;
            numberDiv = (int)(Math.Ceiling((double)spaces / (double)3));
            arrayNumbers = new int[numberDiv][];
            int j = 0;
            for (int i = 0; i < spaces; i = i + 3)
            {
                arrayNumbers[j] = new int[] { arrayNumbersText[i], arrayNumbersText[i + 1], arrayNumbersText[i + 2] };
                j++;
            }
        }

        //Metodo para realizar operaciones y encriptar el mensaje con matriz
        public void encrypting()
        {
            arrayEncriptation = new int[numberDiv][];
            for (int i = 0; i < numberDiv; i++)
            {
                arrayEncriptation[i] =new int []{ arrayNumbers[i][0]*arrayoperation[0,0]+arrayNumbers[i][1]*arrayoperation[0,1]+arrayNumbers[i][2]*arrayoperation[0,2],
                    arrayNumbers[i][0] * arrayoperation[1, 0] + arrayNumbers[i][1] * arrayoperation[1, 1] + arrayNumbers[i][2] * arrayoperation[1, 2], 
                    arrayNumbers[i][0] * arrayoperation[2, 0] + arrayNumbers[i][1] * arrayoperation[2, 1] + arrayNumbers[i][2] * arrayoperation[2, 2] };
            }
        }
        public void showTextEncrypting()
        {
            txtB_TextEncrypting.Text = "";
            for (int i = 0; i < numberDiv; i++)
            {
                txtB_TextEncrypting.Text += " "+arrayEncriptation[i][0]+ " "+ arrayEncriptation[i][1]+ " "+ arrayEncriptation[i][2];
            }
        }
    }
}
