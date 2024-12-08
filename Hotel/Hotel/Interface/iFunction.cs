using System.Data;
using System.Windows.Forms;

public interface IFunction
{
    DataSet getData(string query);
    void setData(string query, string message);
    void setDataNoMsg(string query);
    void ToExcel(DataGridView dataGridView, string filePath);
}