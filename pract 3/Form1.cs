using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libmass;
using lib1;

namespace pract_3
{
    public partial class Form1 : Form
    {
        int maxNumber = 100;
        int summ;
        int mult;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            LibMass.OpenDialogToOpen(ref table, openFileDialog1);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            LibMass.OpenDialogToSave(ref table, saveFileDialog1);
        }

        private void GenerateTable_Click(object sender, EventArgs e)
        {
            LibMass.InstantRandomTable(ref table, (int)countColumn.Value, (int)countRow.Value, maxNumber);
        }

        private void ClearTable_Click(object sender, EventArgs e)
        {
            LibMass.ClearTable(ref table);
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, Вариант 1. Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Найти сумму и произведение элементов K-й строки данной матрицы.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                Lib_1.GetMyAnswer(table, (int)setRowToAnswer.Value, out summ, out mult);
                answerS.Text = summ.ToString();
                answerP.Text = mult.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
