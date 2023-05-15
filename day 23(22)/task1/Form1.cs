namespace task1
{
    public partial class Form1 : Form
    {
        private int clickCountbtn = 0;
        private int clickCountlbl = 0;
        private int clickCounttxt = 0;
        private int location1, location2, location3;
        public Form1()
        {
            InitializeComponent();
        }

        private void gaaf_Click(object sender, EventArgs e)
        {
            Button newbtn = new Button();
            newbtn.Text = "новая кнопка";
            newbtn.Location = new Point(100, location1);
            location1 += 20;
            newbtn.Size = new Size(100, 50);
            newbtn.Click += new EventHandler(gaaf_Click);
            Controls.Add(newbtn);

            clickCountbtn++;
            label2.Text = "Кол-во кнопок" + clickCountbtn.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label newlbl = new Label();
            newlbl.Click += new EventHandler(label1_Click);
            newlbl.Text = "Новая метка";
            newlbl.Location = new Point(300, location2);
            location2 += 20;
            Controls.Add((Label)newlbl);

            clickCountlbl++;
            label3.Text = "Кол-во меток" + clickCountlbl.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox newtxt = new TextBox();
            newtxt.Click += new EventHandler(label1_Click);
            newtxt.Text = "Новое поле ввода";
            newtxt.Location = new Point(450, location3);
            newtxt.Size = new Size(100, 50);
            location3 += 20;
            Controls.Add(newtxt);

            clickCounttxt++;
            label4.Text = "Кол-во полей" + clickCounttxt.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}