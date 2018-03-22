using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzON.Shared
{
    public static class DataGridViewExtensions
    {        
        public static void SettingFormStyle(this DataGridView dgv,int SizeFont)
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Font = new Font("Tahoma", SizeFont, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            headerStyle.BackColor = Color.Navy;
            headerStyle.ForeColor = Color.White;
            dgv.Font = new Font("Tahoma", SizeFont - 2, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
        }
    }
}
