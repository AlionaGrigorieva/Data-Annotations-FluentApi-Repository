using ClassLibrary1;
using ClassLibrary4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1 : Form
    {
        SageBookContext db;
        GenericUnitOfWork work;
        public Form1()
        {
            InitializeComponent();
            work = new GenericUnitOfWork(new SageBookContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SBForm sg = new SBForm();
            IGenericRepository<Sage> repositorySage = work.Repository<Sage>();
            List<Sage> sages = repositorySage.GetAll().ToList();
            sg.dataGridView1.DataSource = sages;
            DialogResult result = sg.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            repositorySage.Add(new Sage() { Name = sg.SageNameTextBox.Text });
            sages = repositorySage.GetAll().ToList();
            sg.dataGridView1.Refresh();
            MessageBox.Show("New sage has been added.");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBForm sg = new SBForm();
            IGenericRepository<Sage> repositorySage = work.Repository<Sage>();
            List<Sage> sages = repositorySage.GetAll().ToList();
            sg.dataGridView1.DataSource = sages;
            DialogResult result = sg.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (sg.dataGridView1.SelectedRows.Count != 1)
                return;

            int index = sg.dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(sg.dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
            Sage sage = repositorySage.FindById(id);
            
            sage.Name = sg.SageNameTextBox.Text;
            repositorySage.Update(sage);
            sages = repositorySage.GetAll().ToList();
            sg.dataGridView1.Refresh();
            MessageBox.Show("Info has been edited.");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            IGenericRepository<Sage> repositorySage = work.Repository<Sage>();
            List<Sage> sages = repositorySage.GetAll().ToList();
            dl.dataGridView1.DataSource = sages;
            DialogResult result = dl.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (dl.dataGridView1.SelectedRows.Count != 1)
                return;
            int index = dl.dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dl.dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
            Sage sage = repositorySage.FindById(id);
            repositorySage.Remove(sage);
            sages = repositorySage.GetAll().ToList();
            dl.dataGridView1.Refresh();
            MessageBox.Show("The sage has been deleted.");
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SBForm bk = new SBForm();
            IGenericRepository<Book> repositoryBook = work.Repository<Book>();
            List<Book> books = repositoryBook.GetAll().ToList();
            bk.dataGridView1.DataSource = books;
            DialogResult result = bk.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            repositoryBook.Add(new Book() { Name = bk.SageNameTextBox.Text });
            books = repositoryBook.GetAll().ToList();
            bk.dataGridView1.Refresh();
            MessageBox.Show("New book has been added.");
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SBForm bk = new SBForm();
            IGenericRepository<Book> repositoryBook = work.Repository<Book>();
            List<Book> books = repositoryBook.GetAll().ToList();
            bk.dataGridView1.DataSource = books;
            DialogResult result = bk.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (bk.dataGridView1.SelectedRows.Count != 1)
                return;

            int index = bk.dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(bk.dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
            Book book = repositoryBook.FindById(id);
            book.Name = bk.SageNameTextBox.Text;
            repositoryBook.Update(book);
            books = repositoryBook.GetAll().ToList();
            bk.dataGridView1.Refresh();
            MessageBox.Show("Info has been edited.");
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            IGenericRepository<Book> repositoryBook = work.Repository<Book>();
            List<Book> books = repositoryBook.GetAll().ToList();
            dl.dataGridView1.DataSource = books;
            DialogResult result = dl.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (dl.dataGridView1.SelectedRows.Count != 1)
                return;
            int index = dl.dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dl.dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
            Book book = repositoryBook.FindById(id);
            repositoryBook.Remove(book);
            books = repositoryBook.GetAll().ToList();
            dl.dataGridView1.Refresh();
            MessageBox.Show("The book has been deleted.");
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SageBookForm SageBook_form = new SageBookForm();
            IGenericRepository<SageBook> repositorySageBook = work.Repository<SageBook>();
            List<SageBook> sageBooks = repositorySageBook.GetAll().ToList();
            SageBook_form.dataGridView1.DataSource = sageBooks;
            IGenericRepository<Book> repositoryBook = work.Repository<Book>();
            List<Book> books = repositoryBook.GetAll().ToList();
            IGenericRepository<Sage> repositorySage = work.Repository<Sage>();
            List<Sage> sages = repositorySage.GetAll().ToList();
            SageBook_form.SageListBox.DataSource = sages;
            SageBook_form.SageListBox.ValueMember = "id";
            SageBook_form.SageListBox.DisplayMember = "name";
            SageBook_form.BooksListBox.DataSource = books;
            SageBook_form.BooksListBox.ValueMember = "id";
            SageBook_form.BooksListBox.DisplayMember = "name";
            DialogResult result = SageBook_form.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            Sage sage = SageBook_form.SageListBox.SelectedItem as Sage;
            Book book = SageBook_form.BooksListBox.SelectedItem as Book;
            SageBook sagebook = new SageBook
            {
                Book = book,
                Sage = sage,
                IdBook = book.Id,
                IdSage = sage.Id
            };
            repositorySageBook.Add(sagebook);
            sage.SageBooks.Add(sagebook);
            book.SageBooks.Add(sagebook);
            repositorySage.Update(sage);
            repositoryBook.Update(book);
            sageBooks = repositorySageBook.GetAll().ToList();
            SageBook_form.dataGridView1.Refresh();
            MessageBox.Show("New Sage-Book has been added.");
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SageBookForm SageBook_form = new SageBookForm();
            IGenericRepository<SageBook> repositorySageBook = work.Repository<SageBook>();
            List<SageBook> sageBooks = repositorySageBook.GetAll().ToList();
            SageBook_form.dataGridView1.DataSource = sageBooks;
            IGenericRepository<Book> repositoryBook = work.Repository<Book>();
            List<Book> books = repositoryBook.GetAll().ToList();
            IGenericRepository<Sage> repositorySage = work.Repository<Sage>();
            List<Sage> sages = repositorySage.GetAll().ToList();
            SageBook_form.SageListBox.DataSource = sages;
            SageBook_form.SageListBox.ValueMember = "id";
            SageBook_form.SageListBox.DisplayMember = "name";
            SageBook_form.BooksListBox.DataSource = books;
            SageBook_form.BooksListBox.ValueMember = "id";
            SageBook_form.BooksListBox.DisplayMember = "name";
            DialogResult result = SageBook_form.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (SageBook_form.dataGridView1.SelectedRows.Count != 1) return;
            if (SageBook_form.SageListBox.SelectedItems.Count != 1) return;
            if (SageBook_form.BooksListBox.SelectedItems.Count != 1) return;
            int index = SageBook_form.dataGridView1.SelectedRows[0].Index;
            int idBook = 0;
            int idSage = 0;
            bool converted = Int32.TryParse(SageBook_form.dataGridView1[0, index].Value.ToString(), out idSage);
            if (converted == false)
                return;
            bool converted1 = Int32.TryParse(SageBook_form.dataGridView1[1, index].Value.ToString(), out idBook);
            if (converted1 == false)
                return;
            List<SageBook> sagebook = repositorySageBook.FindAll(x => x.IdBook == idBook).ToList();
            List<SageBook> sagebook1 = sagebook.FindAll(x => x.IdSage == idSage).ToList();
            Sage sage = SageBook_form.SageListBox.SelectedItem as Sage;
            Book book = SageBook_form.BooksListBox.SelectedItem as Book;
            repositorySageBook.Remove(sagebook1[0]);
            sagebook1[0].Book = book;
            sagebook[0].Sage = sage;
            sagebook[0].IdBook = book.Id;
            sagebook[0].IdSage = sage.Id;
            repositorySageBook.Add(sagebook[0]);
            sage.SageBooks.Add(sagebook[0]);
            book.SageBooks.Add(sagebook[0]);
            repositorySage.Update(sage);
            repositoryBook.Update(book);
            sageBooks = repositorySageBook.GetAll().ToList();
            SageBook_form.dataGridView1.Refresh();
            MessageBox.Show("Info has been edited.");
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            IGenericRepository<SageBook> repositorySageBook = work.Repository<SageBook>();
            List<SageBook> sageBooks = repositorySageBook.GetAll().ToList();
            IGenericRepository<Book> repositoryBook = work.Repository<Book>();
            IGenericRepository<Sage> repositorySage = work.Repository<Sage>();
            dl.dataGridView1.DataSource = sageBooks;
            DialogResult result = dl.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (dl.dataGridView1.SelectedRows.Count != 1)
                return;
            int index = dl.dataGridView1.SelectedRows[0].Index;
            int idBook = 0;
            int idSage = 0;
            bool converted = Int32.TryParse(dl.dataGridView1[0, index].Value.ToString(), out idSage);
            if (converted == false)
                return;
            bool converted1 = Int32.TryParse(dl.dataGridView1[1, index].Value.ToString(), out idBook);
            if (converted1 == false)
                return;
            List<SageBook> sagebook = repositorySageBook.FindAll(x => x.IdBook == idBook).ToList();
            List<SageBook> sagebook1 = sagebook.FindAll(x => x.IdSage == idSage).ToList();
            repositorySageBook.Remove(sagebook1[0]);
            Sage sage = repositorySage.FindById(idSage);
            Book book = repositoryBook.FindById(idBook);
            sage.SageBooks.Remove(sagebook1[0]);
            book.SageBooks.Remove(sagebook1[0]);
            repositorySage.Update(sage);
            repositoryBook.Update(book);
            sageBooks = repositorySageBook.GetAll().ToList();
            dl.dataGridView1.Refresh();
            MessageBox.Show("The Sage-Book has been deleted.");
        }
    }
}
