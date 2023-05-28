namespace checkboxlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}