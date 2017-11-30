using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codeFirstBlog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonelBlogEntities pr = new PersonelBlogEntities();
        
     
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = pr.Categories.ToList();
            dataGridView1.DataSource = pr.Articles.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User
            {
                Name = textBox1.Text,
                Id = Guid.NewGuid()
            };
            pr.Users.Add(u);
            pr.SaveChanges();
            dataGridView1.DataSource = pr.Users.ToList();
            MessageBox.Show("Başarıyla Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category c = new Category
            {
                CategoryId = 1,
                CategoryName = textBox2.Text,
                Description = textBox3.Text,
               
            };
            pr.Categories.Add(c);
            pr.SaveChanges();
            dataGridView1.DataSource = pr.Categories.ToList();
            MessageBox.Show("Başarıyla Katdedildi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Article a = new Article
            {
                ArticleId = 1,
                Body = textBox2.Text,
                Title = textBox3.Text,
                CategoryId = 1
            };
            pr.Articles.Add(a);
            pr.SaveChanges();
            dataGridView1.DataSource = pr.Articles.ToList();
            MessageBox.Show("Başarıyla Kaydedildi");

        }
   
        private void button4_Click(object sender, EventArgs e)
        {
            int secili = (int)dataGridView1.SelectedRows[0].Cells[7].Value;
            pr.Articles.Remove(pr.Articles.Find(secili));
            pr.SaveChanges();
            dataGridView1.DataSource = pr.Articles.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            int secili = (int)dataGridView1.SelectedRows[0].Cells[7].Value;
            Article guncellenecek = pr.Articles.Find(secili);
            pr.Entry(guncellenecek).CurrentValues.SetValues(secili);
            pr.SaveChanges();
            dataGridView1.DataSource = pr.Articles.ToList();
        }
    }
}
