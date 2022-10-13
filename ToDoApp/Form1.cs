namespace ToDoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var todos = new List<string>
            {
                "Write Code",
                "Make Coffee"
            };

            checkedListBox1.Items.AddRange(todos.ToArray());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            checkedListBox1.Items.Add(text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var items = checkedListBox1.CheckedItems;

                foreach (var item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                var items=checkedListBox1.Items;
                foreach (var item in items)
                {
                    listBox1.Items.Remove(item);
                }
            }
        }
    }
}