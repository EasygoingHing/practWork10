using System.Collections.Generic;
using System.Data;

namespace Пример_таблицы_WPF
{
    //Класс для визуализации данных на DataGrid.
    static class VisualArray
    {
        /// <summary>
        /// Реализует визуализацию даннных на DataGrid из передаваемого списка структуры PcInfo.
        /// </summary>
        /// <param name="pcList">Список содержащий экземпляры структуры PcInfo.</param>
        /// <returns>Представление таблицы.</returns>
        public static DataTable ToDataTable(List<float> expensesArray, List<float> pricesArray)
        {
            var tempDataGrid = new DataTable();
            DataRow row, rowSecond;//Объявление строки

            for (int i = 0; i < expensesArray.Count; i++)
            {
                tempDataGrid.Columns.Add($"Продукт №{i + 1}" , typeof(float));
            }
            
            row = tempDataGrid.NewRow();
            rowSecond = tempDataGrid.NewRow();//создание строки

            for (int i = 0; i < expensesArray.Count; i++)
            {
                row[i] = expensesArray[i];
                rowSecond[i] = pricesArray[i];
            }

            tempDataGrid.Rows.Add(row);
            tempDataGrid.Rows.Add(rowSecond); //добавление в таблицу

            return tempDataGrid;
        }
    }
}
