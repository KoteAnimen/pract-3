using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lib1
{
    public class Lib_1
    {
        public static void GetMyAnswer(DataGridView dgw, int needRow, out int summ, out int multiple)
        {
            summ = 0;
            multiple = 1;
            if(needRow > dgw.RowCount)// если номер нужной строки превышает количество строк в таблице
            {
                throw new Exception("Выход за пределы массива");// генерируем исключение с сообщением об ошибке
            }
            for (int i = 0; i < dgw.ColumnCount; i++)
            {
                summ += (int)dgw.Rows[needRow - 1].Cells[i].Value;
                multiple *= (int)dgw.Rows[needRow - 1].Cells[i].Value;
            }
                        
        }
    }
}
