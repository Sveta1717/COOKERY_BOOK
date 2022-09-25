namespace COOKERY_BOOK
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            BackColor = Color.Tan;          
            Text = "��� ��˲����� �����";
            Font = new Font("", 10);
            button1 = new Button();
         
            InitializeComponent();
            CreateTree();
        }       

        private void CreateTree()
        {
            TreeNode root = treeView1.Nodes.Add("�������");
            TreeNode firstChild = root.Nodes.Add("����� ������");
            firstChild.Nodes.Add("������");
            firstChild.Nodes.Add("�����");
            TreeNode secondChild = root.Nodes.Add("���� ������");
            secondChild.Nodes.Add("�������");
            secondChild.Nodes.Add("���-���������");
            TreeNode lastChild = root.Nodes.Add("�������");
            lastChild.Nodes.Add("��������");
            lastChild.Nodes.Add("��������� ������");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {           
            string text = e.Node.Text;            
            //int index = e.Node.Index;
            switch (e.Node.Text)
            {
                case "������": PictureBoxLoadImage(@"c:\1\������.jpg");
                    TextBox1Load(@"c:\1\������.txt");
                    TextBox2Load(@"c:\1\������1.txt"); 
                    break;
                case "����": PictureBoxLoadImage(@"c:\1\�����.jpg");
                    TextBox1Load(@"c:\1\�����.txt");
                    TextBox2Load(@"c:\1\�����1.txt");
                    break;
                case "�������": PictureBoxLoadImage(@"�:\1\�������.jpg");
                    TextBox1Load(@"c:\1\�������.txt");
                    TextBox2Load(@"c:\1\�������1.txt");
                    break;
                case "���-���������": PictureBoxLoadImage(@"�:\1\���-���������.jpg");
                    TextBox1Load(@"c:\1\���-���������.txt");
                    TextBox2Load(@"c:\1\���-���������1.txt");
                    break;
                case "��������":
                    PictureBoxLoadImage(@"�:\1\�������.jpg");
                    TextBox1Load(@"c:\1\��������.txt");
                    TextBox2Load(@"c:\1\��������1.txt");
                    break;
                case "��������� ������":
                    PictureBoxLoadImage(@"�:\1\��������� ������.jpg");
                    TextBox1Load(@"c:\1\��������� ������.txt");
                    TextBox2Load(@"c:\1\��������� ������1.txt");
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
            rootNode.Name = "�������";
            rootNode.Text = "����";           
            treeView1.Nodes.Add(rootNode);           
            rootNode.Nodes.Add("ѳ��");
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