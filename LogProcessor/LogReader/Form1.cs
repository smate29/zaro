using LogCommon;
using System.Text;
using System.Windows.Forms;

namespace LogReader
{
    public partial class Form1 : Form
    {
        List<LogEntry> logEntries;
        int sorok_szama = 0;
        int errorok_szama = 0;
        int debugok_szama = 0;
        int filtered = 0;
        public Form1()
        {
            InitializeComponent();

            Controls.Add(dataGrid);

            using (var dbContext = new SQL())
            {
                logEntries = dbContext.LogEntries.ToList();

                dataRefresh(logEntries);

                for (var i = 0; i < dataGrid.ColumnCount; i++)
                {
                    this.comboBox1.Items.Add(dataGrid.Columns[i].HeaderText);
                }
            }

        }

        private void dataRefresh(List<LogEntry> kecskeporkolt)
        {
            debugok_szama = 0;
            errorok_szama = 0;
            sorok_szama = 0;

            this.dataGrid.Rows.Clear();
            this.dataGrid.Refresh();
            foreach (LogEntry makos in kecskeporkolt)
            {
                this.dataGrid.Rows.Add(makos.Id, makos.CorrelationId, makos.Thread, makos.Level, makos.Logger, makos.Message, makos.Exception);
                sorok_szama++;
                if (makos.Level == "DEBUG")
                {
                    debugok_szama++;
                }
                else if (makos.Level == "ERROR")
                {
                    errorok_szama++;
                }
            }
            this.debugok.Text = debugok_szama.ToString();
            this.errorok.Text = errorok_szama.ToString();
            this.sorokSzama.Text = sorok_szama.ToString();
            this.dataGrid.Refresh();
        }

        private List<LogEntry> searchEntities(String mezo, String kereso)
        {
            List<LogEntry> result = new List<LogEntry>();
            int columschosen = -1;
            for (var i = 0; i < dataGrid.ColumnCount; i++)
            {
                if (dataGrid.Columns[i].HeaderText == mezo)
                {
                    columschosen = i;
                }
            }
            foreach (LogEntry makos in logEntries)
            {
                switch (columschosen)
                {
                    case 0:
                        if (makos.Id.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                    case 1:
                        if (makos.CorrelationId.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                    case 2:
                        if (makos.DataUtc.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                    case 3:
                        if (makos.Thread.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                    case 4:
                        if (makos.Level.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                    case 5:
                        if (makos.Logger.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                    case 6:
                        if (makos.Message.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                    case 7:
                        if (makos.Exception.ToString() == kereso)
                        {
                            result.Add(makos);
                        }
                        break;
                }
            }
            return result;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.messageTX.Text = this.dataGrid.SelectedRows[8].Cells[6].Value.ToString();
            this.exceptionTX.Text = this.dataGrid.SelectedRows[8].Cells[7].Value.ToString();
        }

        private void kereses_BTN_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox1.Text != "")
            {
                List<LogEntry> result = searchEntities(comboBox1.Text, textBox1.Text);
                dataRefresh(result);
                filtered = 1;
                saveBTN.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kérlek válaszd ki a keresési mezõt és adj meg egy értéket is!");
            }
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            filtered = 0;
            saveBTN.Enabled = false;
            dataRefresh(logEntries);
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Filter = "CSV (*.csv)|*.csv";
            dialogSave.FileName = "Output.csv";
            bool fileError = false;
            if (dialogSave.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialogSave.FileName))
                {
                    try
                    {
                        File.Delete(dialogSave.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the date for the disk." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        String output_csv = "";
                        foreach (DataGridViewColumn column in dataGrid.Columns)
                        {
                            output_csv += column.HeaderText + ';';
                        }
                        output_csv += "\r\n";

                        foreach (DataGridViewRow row in dataGrid.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    output_csv += cell.Value.ToString() + ';';
                                }
                            }
                            output_csv += "\r\n";
                        }
                        File.WriteAllText(dialogSave.FileName, output_csv);
                        MessageBox.Show("Data Exported Successfully!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }

        }
    }
}
