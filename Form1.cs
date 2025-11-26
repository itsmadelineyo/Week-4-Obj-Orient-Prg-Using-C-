using System;

namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();

            btnByte.Click += BtnByte_Click;
            btnShort.Click += BtnShort_Click;
            btnInt.Click += BtnInt_Click;
            btnLong.Click += BtnLong_Click;
            btnFloat.Click += BtnFloat_Click;
            btnDouble.Click += BtnDouble_Click;
            btnDecimal.Click += BtnDecimal_Click;
            btnPow.Click += BtnPow_Click;
            btnRound.Click += BtnRound_Click;
            btnSqrt.Click += BtnSqrt_Click;
            btnClear.Click += BtnClear_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnByte_Click(object sender, EventArgs e)
        {
            byte a = 5, b = 5;
            lblDisplay.Text = $"{a} + {b} = {a + b}";
        }

        private void BtnShort_Click(object sender, EventArgs e)
        {
            short a = 100, b = 50;
            lblDisplay.Text = $"{a} - {b} = {a - b}";
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
            int a = 12, b = 3;
            lblDisplay.Text = $"{a} / {b} = {a / b}";
        }

        private void BtnLong_Click(object sender, EventArgs e)
        {
            long a = 10, b = 3;
            lblDisplay.Text = $"{a} % {b} = {a % b}";
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            float a = 7.8f, b = 2.5f;
            float result = a % b;
            lblDisplay.Text = $"{a} % {b} = {result:0.###}...";
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            double a = 10.6, b = 2.0;
            lblDisplay.Text = $"{a} / {b} = {a / b}";
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            decimal a = 7.3m, b = 2.0m;
            lblDisplay.Text = $"{a} * {b} = {(a * b):F1}";
        }

        private void BtnPow_Click(object sender, EventArgs e)
        {
            int a = 2;
            lblDisplay.Text = $"{a}² = {Math.Pow(a, 2)}";
        }

        private void BtnRound_Click(object sender, EventArgs e)
        {
            double a = 5.66789;
            lblDisplay.Text = $"{a} = {Math.Round(a, 1):F1}";
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            int a = 9;
            lblDisplay.Text = $"(sqrt){a} = {Math.Sqrt(a):F0}";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
