namespace WinForms231229_kontrolkaErrorProvider
{
    public partial class Form1 : Form
    {
        public ErrorProvider errorProviderMoja = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();                    
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProviderMoja.Clear();
            labelKomunikat.Text = "";
            foreach (char c in textBox1.Text)
            {
                if (!Char.IsDigit(c))
                {
                    errorProviderMoja.SetError(textBox1, "znak: "+c+" nie jest cyfr¹!");
                    labelKomunikat.Text = errorProviderMoja.GetError(textBox1);
                    break;
                }

            }            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProviderMoja.Clear();
            errorProviderMoja.SetError(textBox2, " ");
            errorProviderMoja.GetError(textBox2);
        }
    }
}