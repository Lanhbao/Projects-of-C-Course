using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchAString
{
    public partial class FormSearchAString : Form
    {
        public FormSearchAString()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchStringTextBox.Text.Length > 0)
            {
                var searchString = searchStringTextBox.Text;
                var resultFoundOfString = new StringBuilder();

                if (fromFileCheckBox.Checked == true)
                {
                    var pathOfFile = pathOfFileTextBox.Text;
                    var numberOfOccurrencesOfSearchString = SearchString.CheckOccurrencesOfSearchStringFromFile(pathOfFile, searchString);
                    resultFoundOfString.Append(numberOfOccurrencesOfSearchString);
                    resultFoundOfString.Append(" occurrences(s) of the search term ");
                    resultFoundOfString.Append("\"" + searchString + "\"");
                    resultFoundOfString.Append(" were found in file.");
                    resultFoundOfString.Append("\n");
                    //var resulfFoundInFile = numberOfOccurrencesOfSearchString + " occurrences(s) of the search term " + searchString + " were found in file.";
                }
                if (fromMessageCheckBox.Checked == true)
                {
                    var messageToSearch = textBoxToSearchFrom.Text;
                    var numberOfOccurrencesOfSearchString = SearchString.CheckOccurrencesOfSearchString(messageToSearch, searchString);
                    resultFoundOfString.Append(numberOfOccurrencesOfSearchString);
                    resultFoundOfString.Append(" occurrences(s) of the search term ");
                    resultFoundOfString.Append("\"" + searchString+ "\"");
                    resultFoundOfString.Append("\n");
                    //var resulfFoundInMessage = numberOfOccurrencesOfSearchString + " occurrences(s) of the search term " + searchString + " were found in message.";
                }
                MessageBox.Show(resultFoundOfString.ToString(), "Result");
            }
            else
            {
                MessageBox.Show("Please, enter your search string!");
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                pathOfFileTextBox.Text = fileName;
            }
        }
        private void isChecked(object sender, EventArgs e)
        {
            if (fromFileCheckBox.Checked)
            {
                selectButton.Enabled = true;
            }
            else
            {
                selectButton.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectButton.Enabled = false;
            textBoxToSearchFrom.Enabled = false;
        }

        private void checkStateChangeOfFromAMessageCheckBox(object sender, EventArgs e)
        {
            if(fromMessageCheckBox.Checked == true)
            {
                textBoxToSearchFrom.Enabled = true;
            }
            else
            {
                textBoxToSearchFrom.Enabled = false;
            }
        }

        private void textBoxToSearchFrom_TextChanged(object sender, EventArgs e)
        {
            if (textBoxToSearchFrom.Text.Length == 0)
            {
                MessageBox.Show("Please, enter your message!");
            }   
        }
    }
}
