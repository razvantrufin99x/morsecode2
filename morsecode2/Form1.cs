namespace morsecode2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        int j = 0;
        int virf = 260;

        public class pereche
        {
            public string semn;
            public string cod;

            public pereche(string ps, string pc)
            {
                semn = ps;
                cod = pc;
            }
        }

        public List<pereche> codulmorse = new List<pereche>();


        public void loadallinlistbox()
        {
            foreach (pereche p in codulmorse)
            {
                listBox1.Items.Add(p.semn + " : " + p.cod);
            }
        }

        public void loadall()
        {


            codulmorse.Add(new pereche("1", ".----"));
            codulmorse.Add(new pereche("2", "..---"));
            codulmorse.Add(new pereche("3", "...--"));
            codulmorse.Add(new pereche("4", "....-"));
            codulmorse.Add(new pereche("5", "....."));
            codulmorse.Add(new pereche("6", "-...."));
            codulmorse.Add(new pereche("7", "--..."));
            codulmorse.Add(new pereche("8", "---.."));
            codulmorse.Add(new pereche("9", "----."));
            codulmorse.Add(new pereche("vid", "-----"));
            codulmorse.Add(new pereche("a", ".-"));
            codulmorse.Add(new pereche("b", "-..."));
            codulmorse.Add(new pereche("c", "-.-."));
            codulmorse.Add(new pereche("d", "-.."));
            codulmorse.Add(new pereche("e", "."));
            codulmorse.Add(new pereche("f", "..-."));
            codulmorse.Add(new pereche("g", "--."));
            codulmorse.Add(new pereche("h", "...."));
            codulmorse.Add(new pereche("i", ".."));
            codulmorse.Add(new pereche("j", ".---"));
            codulmorse.Add(new pereche("k", "-.-"));
            codulmorse.Add(new pereche("l", ".-.."));
            codulmorse.Add(new pereche("m", "--"));
            codulmorse.Add(new pereche("n", "-."));
            codulmorse.Add(new pereche("o", "---"));
            codulmorse.Add(new pereche("p", ".--."));
            codulmorse.Add(new pereche("q", "--.-"));
            codulmorse.Add(new pereche("r", ".-."));
            codulmorse.Add(new pereche("s", "..."));
            codulmorse.Add(new pereche("t", "-"));
            codulmorse.Add(new pereche("u", "..-"));
            codulmorse.Add(new pereche("v", "...-"));
            codulmorse.Add(new pereche("w", ".--"));
            codulmorse.Add(new pereche("x", "-..-"));
            codulmorse.Add(new pereche("y", "-.--"));
            codulmorse.Add(new pereche("z", "--.."));
            codulmorse.Add(new pereche("ia", ".-.-"));
            codulmorse.Add(new pereche("ai", ".--.-"));
            codulmorse.Add(new pereche("ei", "..-.."));
            codulmorse.Add(new pereche("ie", "-..-."));
            codulmorse.Add(new pereche("chs", "----"));
            codulmorse.Add(new pereche("ci", "-.-.."));
            codulmorse.Add(new pereche("ni", "--.--"));
            codulmorse.Add(new pereche("ou", "---."));
            codulmorse.Add(new pereche("ui", "..--"));
            codulmorse.Add(new pereche("ttz", "---.."));
            codulmorse.Add(new pereche(".", ".-.-.-"));
            codulmorse.Add(new pereche(",", "--..--"));
            codulmorse.Add(new pereche(":", "---..."));
            codulmorse.Add(new pereche(";", "-.-.-."));
            codulmorse.Add(new pereche("?", "..--.."));
            codulmorse.Add(new pereche("'", ".---."));
            codulmorse.Add(new pereche("_", "-....-"));
            codulmorse.Add(new pereche("//", "-.--.-"));
            codulmorse.Add(new pereche("()", "..--.-"));
            codulmorse.Add(new pereche("sub", "..--.-"));
            codulmorse.Add(new pereche("=", "-...-"));
            codulmorse.Add(new pereche("\"", ".-..-."));

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadall();
            loadallinlistbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel px = new Panel();
            px.Left = 86 + j * 12;
            px.Top = virf - 10;
            Controls.Add(px);
            px.BackColor = Color.Red;
            px.Height = 10;
            px.Width = 10;
            px.Show();
            i++;
            virf = virf - 12;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel px = new Panel();
            px.Left = 86 + j * 12;
            px.Top = virf - 5;
            Controls.Add(px);
            px.BackColor = Color.Red;
            px.Height = 5;
            px.Width = 10;
            px.Show();
            i++;
            virf = virf - 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            j++;
            i = 0;
            virf = 260;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            string s = codulmorse[n].cod;
            string ss = codulmorse[n].semn;
            //new char
            j++;
            i = 0;
            virf = 260;

            //add label and semn
            Label l1 = new Label();
            l1.Left = 86 + j * 12;
            l1.Top = virf + 50;
            l1.Text = ss;
            l1.Width = 10;
            Controls.Add(l1);
            l1.Show();



            //split into chars
            for (int h = 0; h < s.Length; h++)
            {
                if (s[h] == '-')//if e linie
                {
                    Panel px = new Panel();
                    px.Left = 86 + j * 12;
                    px.Top = virf - 10;
                    Controls.Add(px);
                    px.BackColor = Color.Red;
                    px.Height = 10;
                    px.Width = 10;
                    px.Show();
                    i++;
                    virf = virf - 12;
                }
                else if (s[h] == '.') //if e punct
                {
                    Panel px = new Panel();
                    px.Left = 86 + j * 12;
                    px.Top = virf - 5;
                    Controls.Add(px);
                    px.BackColor = Color.Red;
                    px.Height = 5;
                    px.Width = 10;
                    px.Show();
                    i++;
                    virf = virf - 7;
                }



            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}