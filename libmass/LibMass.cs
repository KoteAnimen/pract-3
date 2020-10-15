using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace libmass
{
    public class LibMass
    {
        public static void InstantRandomTable(ref DataGridView dgw, int countColumn, int countRow, int maxNumber)// функция заполнения таблицы рандомными значениями
        {
            dgw.ColumnCount = countColumn;// присваеваем количество столбцов
            dgw.RowCount = countRow;// присваеваем количество строк
            Random rnd = new Random();
            for (int i = 0; i < dgw.RowCount; i++)// заполняем таблицу рандомными значениями
            {
                for (int j = 0; j < dgw.ColumnCount; j++)
                {
                    dgw.Rows[i].Cells[j].Value = rnd.Next(maxNumber);
                }
            }
        }
        public static void OpenDialogToOpen(ref DataGridView dgw, OpenFileDialog ofd1)// функция открытия файла с сохраненной таблицей
        {
            if (ofd1.ShowDialog() == DialogResult.OK)// если диалог открыт
            {
                StreamReader read = new StreamReader(ofd1.FileName);// создаем объект, содержащий имя файла
                dgw.ColumnCount = Convert.ToInt32(read.ReadLine());// считываем количество столбцов из файла и присваиваем текущей таблице
                dgw.RowCount = Convert.ToInt32(read.ReadLine());
                for (int i = 0; i < dgw.RowCount; i++)
                {
                    for (int j = 0; j < dgw.ColumnCount; j++)
                    {
                        dgw.Rows[i].Cells[j].Value = Convert.ToInt32(read.ReadLine());// считываем и присваеваем значения таблицы из файла
                    }

                }
                read.Close();// закрываем диалоговое окно
            }

        }

        public static void OpenDialogToSave(ref DataGridView dgw, SaveFileDialog sfd1)// функция сохранения таблицы
        {
            if (sfd1.ShowDialog() == DialogResult.OK)// если диалог открыт
            {
                StreamWriter file = new StreamWriter(sfd1.FileName);// создаем объект, в котором мы будем записывать значения таблицы
                file.WriteLine(dgw.ColumnCount);// записываем в файл количество столбцов таблицы
                file.WriteLine(dgw.RowCount);// записываем в файл количество строк таблицы
                for (int i = 0; i < dgw.RowCount; i++)
                {
                    for (int j = 0; j < dgw.ColumnCount; j++)
                    {
                        file.WriteLine(dgw.Rows[i].Cells[j].Value);// записываем значения из таблицы в файл
                    }

                }
                file.Close();// закрываем биалоговое окно
            }
        }

        public static void ClearTable(ref DataGridView dgw)// функция очистки таблицы от значений
        {
            for (int i = 0; i < dgw.RowCount; i++)
            {
                for (int j = 0; j < dgw.ColumnCount; j++)
                {
                    dgw.Rows[i].Cells[j].Value = " ";
                }
            }
        }
    }
}

