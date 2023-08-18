namespace HW_22._07._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Black, 0, 0, 800, 800);
            Pen p = new Pen(Color.FromArgb(0, 204, 0), 12);
            //�������, ������
            g.DrawEllipse(p, 200, 100, 160, 220);
            Color shell = Color.FromArgb(1, 240, 1);
            Brush shellBr=new SolidBrush(shell);
            //�������, �������
            g.FillEllipse(shellBr, 200, 100, 160, 220);
            //������
            g.FillEllipse(shellBr, 233, 60, 100, 70);
            //�����
            g.FillEllipse(shellBr, 253, 35, 60, 60);
            //����
            g.FillEllipse(shellBr, 173, 230, 40, 40);
            g.FillEllipse(shellBr, 350, 230, 40, 40);
            //����
            g.FillRectangle(shellBr, 240, 290, 25, 80);
            g.FillRectangle(shellBr, 305, 290, 25, 80);
            //�������
            shell=Color.FromArgb (160, 1, 252);
            Brush rect=new SolidBrush(shell);
            //�� �����
            g.FillRectangle(rect, 240, 347, 25, 12);
            g.FillRectangle(rect, 305, 347, 25, 12);
            //�� ������
            g.FillRectangle(rect, 250, 44, 65, 15);

            //�����
            shell = Color.FromArgb(131, 136, 34);
            rect=new SolidBrush(shell);
            g.FillRectangle(rect, 365, 50, 20, 320);

            //����� �� ������
            shell = Color.FromArgb(187, 187, 187);
            rect= new SolidBrush(shell);
            g.FillRectangle(rect, 365, 200, 20, 70);

            //����� �� ����
            g.FillRectangle(Brushes.Yellow, 235, 135, 95, 120);
            g.FillEllipse(Brushes.Yellow, 235, 200, 95, 100);
        }
    }
}