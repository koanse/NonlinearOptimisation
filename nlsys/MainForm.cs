using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VIJAY.MATH;

namespace nlsys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            nudN.Value = 2;
            nudEq.Value = 2;
            dgvVar.Columns["Значение"].ValueType = typeof(double);
            dgvEq.Columns["Уравнение"].ValueType = typeof(string);
            dgvVar.Rows[0].Cells["Значение"].Value = 9.0;
            dgvVar.Rows[1].Cells["Значение"].Value = 1.0;
            dgvEq.Rows[0].Cells["Уравнение"].Value = "x0^2+x1^2-100";
            dgvEq.Rows[1].Cells["Уравнение"].Value = "x0+x1-10";            
        }
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила студентка группы АС-05-2 Токарчук Надежда");
        }
        void nudN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvVar.Rows.Clear();
                dgvVar.RowCount = (int)nudN.Value;
            }
            catch { }
        }
        void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                NonLinear nl = new NonLinear();
                Data d = new Data();
                foreach (DataGridViewRow r in dgvVar.Rows)
                    NonLinear.EditVariable("x" + r.Index.ToString(),
                        (double)r.Cells["Значение"].Value);
                List<string> listStr = new List<string>();
                foreach (DataGridViewRow r in dgvEq.Rows)
                    listStr.Add((string)r.Cells["Уравнение"].Value);
                NonLinear.SetSystem(listStr.ToArray());
                Data.accuracy = double.Parse(tbAcc.Text);
                Data.iterations = int.Parse(tbIter.Text);
                Data.pdstepsize = double.Parse(tbStep.Text);
                string s = "";
                double[] arrRes = NonLinear.NewtonRapson();
                for (int i = 0; i < arrRes.Length; i++)
                    s += string.Format("{0} ", arrRes[i]);
                //tbResN.Text = s;
                s = "";
                arrRes = NonLinear.QuasiNewton();
                for (int i = 0; i < arrRes.Length; i++)
                    s += string.Format("{0} ", arrRes[i]);
                //tbResQ.Text = s;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            try
            {
                NonLinear nl = new NonLinear();
                Data d = new Data();
                foreach (DataGridViewRow r in dgvVar.Rows)
                    NonLinear.EditVariable("x" + r.Index.ToString(),
                        (double)r.Cells["Значение"].Value);
                List<string> listStr = new List<string>();
                foreach (DataGridViewRow r in dgvEq.Rows)
                    listStr.Add((string)r.Cells["Уравнение"].Value);
                NonLinear.SetSystem(listStr.ToArray());
                Data.accuracy = double.Parse(tbAcc.Text);
                Data.iterations = int.Parse(tbIter.Text);
                Data.pdstepsize = double.Parse(tbStep.Text);
                string s = "";
                double[] arrRes = NonLinear.NewtonRapson();
                for (int i = 0; i < arrRes.Length; i++)
                    s += string.Format("{0} ", arrRes[i]);
                tbResN.Text = s;
                s = "";
                arrRes = NonLinear.QuasiNewton();
                for (int i = 0; i < arrRes.Length; i++)
                    s += string.Format("{0} ", arrRes[i]);
                tbResQ.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void nudEq_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvEq.Rows.Clear();
                dgvEq.RowCount = (int)nudEq.Value;
            }
            catch { }
        }
    }
}