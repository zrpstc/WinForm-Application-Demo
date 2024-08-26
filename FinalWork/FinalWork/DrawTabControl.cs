using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork
{
    #region 重绘TabControl的类(添加关闭页面功能)
    class DrawTabControl
    {
        TabControl tabControl = null;

        //打开和关闭的页面索引
        int tabindex_show = 0;
        int tabindex_close = 0;

        const int CLOSEBUTTON_SIZE = 10;

        public DrawTabControl()
        {

        }

        public DrawTabControl(TabControl tabControl1)
        {
            tabControl = tabControl1;
        }

        /// <summary>
        /// 清空控件方法
        /// </summary>
        public void ClearPage()
        {
            //清空控件
            //this.tabcontrol.TabPages.Clear();
            //绘制的方式OwnerDrawFixed表示由窗体绘制大小一样
            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.Padding = new Point(CLOSEBUTTON_SIZE + 5, CLOSEBUTTON_SIZE - 3);
            this.tabControl.DrawItem += new DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.MouseDown += new MouseEventHandler(this.tabControl_MouseDown);

        }

        /// <summary>
        /// 绘制标签页关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                //获取当前Tab选项卡的绘图区域
                Rectangle myTabRect = this.tabControl.GetTabRect(e.Index);
                //设置笔刷
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                //居中显示
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;

                //绘制标签页背景颜色
                e.Graphics.FillRectangle(white, myTabRect);
                //设置选中的标签页背景颜色
                using (Brush selectColor = new SolidBrush(Color.SeaShell))
                {
                    if (e.Index == this.tabControl.SelectedIndex)
                    {
                        e.Graphics.FillRectangle(selectColor, myTabRect);
                    }
                }
                //绘制标签页文本
                e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, new Font("微软雅黑", 10), black, myTabRect, stringFormat);

                //画关闭标志的矩形框
                using (Pen p = new Pen(Color.White))
                {
                    myTabRect.Offset(myTabRect.Width - (CLOSEBUTTON_SIZE + 3), 2);
                    myTabRect.Width = CLOSEBUTTON_SIZE;
                    myTabRect.Height = CLOSEBUTTON_SIZE;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }

                //填充关闭按钮矩形框颜色
                Color recolor = e.State == DrawItemState.Selected ? Color.Red : Color.White;
                using (Brush b = new SolidBrush(recolor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }

                //画关闭符号
                using (Pen objpen = new Pen(Color.Black))
                {
                    //画X
                    Point p1 = new Point(myTabRect.X + 3, myTabRect.Y + 3);
                    Point p2 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + myTabRect.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);

                    Point p3 = new Point(myTabRect.X + 3, myTabRect.Y + myTabRect.Height - 3);
                    Point p4 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);
                    //Bitmap bt = new Bitmap(inage);
                    //获取绘图区域的开始坐标位置
                    //Point p5 = new Point(myTabRect.X, 4);
                    //e.Graphics.DrawImage(bt_change, p5);
                    //e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, Font, objpen.Brush, p5);
                }
                e.Graphics.Dispose();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 点击关闭按钮关闭选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                //获得关闭按钮的区域
                //存在打开的
                if (tabControl.TabPages.Count > 0)
                {
                    Rectangle myTabRect = this.tabControl.GetTabRect(this.tabControl.SelectedIndex);

                    myTabRect.Offset(myTabRect.Width - (CLOSEBUTTON_SIZE + 3), 2);
                    myTabRect.Width = CLOSEBUTTON_SIZE;
                    myTabRect.Height = CLOSEBUTTON_SIZE;
                    //如果鼠标在关闭按钮范围之内则关闭选项卡
                    bool isclose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                    if (isclose == true)
                    {
                        this.tabControl.TabPages.Remove(this.tabControl.SelectedTab);
                    }
                }
            }
        }

        /// <summary>
        /// 双击标签页移除选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }
    }
}
#endregion