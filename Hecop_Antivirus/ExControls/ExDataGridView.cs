using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hecop_Antivirus.ExControls
{
    public partial class ExDataGridView:DataGridView
    {
        public ExDataGridView()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer| ControlStyles.AllPaintingInWmPaint| ControlStyles.UserPaint, true);
            CellPainting += ExDataGridView_CellPainting;
        }

        private void ExDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Xử lý sự kiện CellContentClick khi CheckBox được nhấp vào
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && this.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Vẽ lại CheckBox tùy chỉnh
                Point checkBoxLocation = new Point();

                checkBoxLocation.X = e.CellBounds.X + 10;
                checkBoxLocation.Y = e.CellBounds.Y + 5;

                CheckBoxRenderer.DrawCheckBox(e.Graphics, checkBoxLocation, (bool)e.FormattedValue == true ?
                    System.Windows.Forms.VisualStyles.CheckBoxState.CheckedHot : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);


            }
        }

        protected override void OnCellClick(DataGridViewCellEventArgs e)
        {
         
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && this.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                BeginEdit(true);
            }
           
            base.OnCellClick(e);
        }

       
    }
}
