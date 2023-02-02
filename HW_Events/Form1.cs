namespace HW_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form= new Form2();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] myCVV = { "Студент: Василь", "Предмет: C# Windows Form", "Група: СПУ111", "Рівень знань: Майже Міщук" };
            int counterSymbol = 0;
            string caption;

            for (int i = 0; i < myCVV.Length; i++)
            {
                counterSymbol += myCVV[i].Length;
                caption = (myCVV.Length - 1 == i) ? $"MessageBox{i + 1}.Середнє число символів - {counterSymbol / myCVV.Length}" : $"MessageBox{i + 1}";
                MessageBox.Show(myCVV[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form= new Form3();
            form.ShowDialog();

        }
    }
}