namespace COOKERY_BOOK
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            BackColor = Color.Tan;          
            Text = "МОЯ КУЛІНАРНА КНИГА";
            Font = new Font("", 10);
            button1 = new Button();
         
            InitializeComponent();
            CreateTree();
        }       

        private void CreateTree()
        {
            TreeNode root = treeView1.Nodes.Add("Рецепти");
            TreeNode firstChild = root.Nodes.Add("Перші страви");
            firstChild.Nodes.Add("Бограч");
            firstChild.Nodes.Add("Питии");
            TreeNode secondChild = root.Nodes.Add("Другі страви");
            secondChild.Nodes.Add("Лазанья");
            secondChild.Nodes.Add("Беф-строганов");
            TreeNode lastChild = root.Nodes.Add("Десерти");
            lastChild.Nodes.Add("Шарлотка");
            lastChild.Nodes.Add("Львівський сирник");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {           
            string text = e.Node.Text;            
            //int index = e.Node.Index;
            switch (e.Node.Text)
            {
                case "Бограч": PictureBoxLoadImage(@"c:\1\Бограч.jpg");
                    TextBox1Load(@"c:\1\Бограч.txt");
                    TextBox2Load(@"c:\1\Бограч1.txt"); 
                    break;
                case "Борщ": PictureBoxLoadImage(@"c:\1\Питии.jpg");
                    TextBox1Load(@"c:\1\Питии.txt");
                    TextBox2Load(@"c:\1\Питии1.txt");
                    break;
                case "Лазанья": PictureBoxLoadImage(@"с:\1\Лазанья.jpg");
                    TextBox1Load(@"c:\1\Лазанья.txt");
                    TextBox2Load(@"c:\1\Лазанья1.txt");
                    break;
                case "Беф-строганов": PictureBoxLoadImage(@"с:\1\Беф-строганов.jpg");
                    TextBox1Load(@"c:\1\Беф-строганов.txt");
                    TextBox2Load(@"c:\1\Беф-строганов1.txt");
                    break;
                case "Шарлотка":
                    PictureBoxLoadImage(@"с:\1\Лазанья.jpg");
                    TextBox1Load(@"c:\1\Шарлотка.txt");
                    TextBox2Load(@"c:\1\Шарлотка1.txt");
                    break;
                case "Львівський сирник":
                    PictureBoxLoadImage(@"с:\1\Львівський сирник.jpg");
                    TextBox1Load(@"c:\1\Львівський сирник.txt");
                    TextBox2Load(@"c:\1\Львівський сирник1.txt");
                    break;
                default: pictureBox1.Image = null;
                    textBox1.Text = null;
                    textBox2.Text = null;
                    break;
            }
        }            

        private void TextBox1Load(string path)
        {
            try
            {
                textBox1.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox2Load(string path)
        {
            try
            {
                textBox2.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBoxLoadImage(string path)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            TreeNode rootNode = new TreeNode();
            rootNode.Name = "Рецепти";
            rootNode.Text = "Напої";           
            treeView1.Nodes.Add(rootNode);           
            rootNode.Nodes.Add("Сідр");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode();
            rootNode.Nodes.Remove(treeView1.SelectedNode);    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            using (Form2 frm2 = new Form2())
            {
                frm2.SelectNode = e.Node;
                frm2.ShowDialog();
            }
        }        
    }
}