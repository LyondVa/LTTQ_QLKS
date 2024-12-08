using System.Data;
using System.Windows.Forms;

public interface IFunction
{
    DataSet getData(string query);
    void setData(string query, string message);
    void setDataNoMsg(string query);
    string getData2(string query); // Add this method
    void ToExcel(DataGridView dataGridView, string filePath);
}