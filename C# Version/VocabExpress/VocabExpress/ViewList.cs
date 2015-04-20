using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VocabExpress
{
    public partial class ViewList : Form
    {
        private readonly ListManager listManager;


        public ViewList(ListManager listManager)
        {
            InitializeComponent();
            this.listManager = listManager;
            setUpListView();
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            Form addWord = new AddWord(listManager);
            addWord.ShowDialog();
            listManager.saveWords();
            setUpListView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string text = listView.SelectedItems[0].Text;
            listManager.removeWord(text);
            listManager.saveWords();
            setUpListView();
        }

        private void setUpListView()
        {
            List<SpellingWord> list = listManager.getSpellingWords();

            listView.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                listView.Items.Add(list[i].getWord());
            }
        }
    }
}