using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Использовать коллекцию для выполнения задания. Оформить модули комментариями.
        //Заданы два массива. Проверить, сколько элементов первого массива превосходят соответствующие элементы второго массива. 

        ArrayList array1 = new ArrayList();
        ArrayList array2 = new ArrayList();

        private void btnFill_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // Получаем количество значений
            int kol1 = Convert.ToInt32(txtKolList1.Text);
            int kol2 = Convert.ToInt32(txtKolList2.Text);

            // Заполняем список случайными значениями
            for (int i = 0; i < kol1; i++)
            {
                array1.Add(rnd.Next(-10, 10));
            }
            listBox1.Items.AddRange(array1.ToArray());


            for (int i = 0; i < kol2; i++)
            {
                array2.Add(rnd.Next(-10, 10));
            }
            listBox2.Items.AddRange(array2.ToArray());

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            array1.Clear();
            array2.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int kol = 0;
            for (int i = 0; i < array1.Count; i++)
                if ((int)array1[i] > (int)array2[i])
                {
                    kol++;
                    txtAnswer.Text = Convert.ToString(kol) + " " + "элемента(ов) первого массива превосходят соответствующие элементы второго массива.";
                }
                else
                {
                    txtAnswer.Text = "Элементы первого массива не превосходят соответствующие элементы второго массива.";
                }
          
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хужанова Анастасия\n" +
                "Вариант 10\n" +
                "Заданы два массива.\n" +
                "Проверить, сколько элементов первого массива превосходят соответствующие элементы второго массива.", "О программе", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//закрыть форму
        }
    }



}
