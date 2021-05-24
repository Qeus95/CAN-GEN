using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Data.SQLite;

namespace CAN_GEN
{
    public partial class Form1 : Form
    {
        public SQLiteConnection sqlite_conn2;
        public Form1()
        {
            InitializeComponent();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 tb = new Form1();

            //string timestamp = DateTime.Now.ToString();
            Int32 unixTimestamp = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            //DateTimeOffset labukas = new DateTimeOffset(1995, 5, 10, 23, 17, 10, TimeSpan.Zero);
            //string labukas_date = labukas.ToString("dd-MM-yyyy H:mm:ss");
            string pathX = "";
            location_selector();
            string path = pathX + @"\" + unixTimestamp + ".txt";
            Form1 objektas = new Form1();
            int intervalas = Int32.Parse(lineCTR.Text);
            string byte1 = tB1.Text;
            string byte2 = tB2.Text;
            string byte3 = tB3.Text;
            string byte4 = tB4.Text;
            string byte5 = tB5.Text;
            string byte6 = tB6.Text;
            string byte7 = tB7.Text;
            string byte8 = tB8.Text;
            string canID = tbCANID.Text;


            file_creator();
            void file_creator()
            {
                int lineCTRint;
                int j = 0;

                try
                {
                    lineCTRint = Int32.Parse(tbLineCTR.Text);
                    using (StreamWriter sw = File.CreateText(path))
                    {

                        for (int min = 0; min <= 59 && j < lineCTRint; min++)
                        { //Minutes interval
                            for (int sec = 0; sec <= 59 && j < lineCTRint; sec++)  // Seconds interval
                            {
                                for (int ms = 0; ms <= 999 && j < lineCTRint; ms = ms + intervalas) //Milliseconds interval

                                {
                                    DateTime date_args = new DateTime(1995, 5, 10, 23, min, sec, ms);
                                    string time = date_args.ToString("dd-MM-yyyy H:mm:ss.fff");
                                    sw.WriteLine("" + time + "    29  " + canID + "   0   8   " + byte1 + " " + byte2 + " " + byte3 + " " + byte4 + " " + byte5 + " " + byte6 + " " + byte7 + " " + byte8 + "");
                                    j++;
                                }
                            }
                        }
                        MessageBox.Show("File created and located in " + path);


                    }
                }
                catch
                {
                    MessageBox.Show("Error occured with given parameters");

                }
            };
            void location_selector()
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = "C:\\Users";
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    pathX = dialog.FileName;
                }
            }

            // Create a file to write to.



        }

        private void lineCTR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblByte1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
             SQLiteConnection sqlite_conn;
             //SQLiteConnection sqlite_conn2;
            sqlite_conn = CreateConnection();
            ReadNames(sqlite_conn);
            sqlite_conn.Close();
            sqlite_conn2 = connectCollection();
            loadDataGridView(sqlite_conn2);
            int j = dataGridView1.Columns.Count;
            for (int i = 0; i<j; i++)
            dataGridView1.Columns[i].SortMode= DataGridViewColumnSortMode.NotSortable;


        }

        static SQLiteConnection connectCollection()
        {
            SQLiteConnection sqlite_conn2;
            sqlite_conn2 = new SQLiteConnection("Data source=collection.db;Version=3");
            try
            {
                sqlite_conn2.Open();
            }
            catch
            {

            }
            return sqlite_conn2;
        }

        private void listBoxMyBoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            string kitas = listBoxMyBoy.SelectedItem.ToString();
            ReadBytes(sqlite_conn,kitas);

        }

 

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data source=PackedDB.db;Version=3");
            try 
            {
                sqlite_conn.Open();
            }
            catch 
            {

            }
            return sqlite_conn;
        }

        public void ReadNames(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT \"name\" FROM \"main\".\"dbo.parameters\"";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                listBoxMyBoy.Items.Add(myreader);


            }
            conn.Close();
        }
        public void ReadBytes(SQLiteConnection conn, string kitas)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT \"b1\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                //sqlite_cmd.CommandText = "SELECT b1 FROM \"main\".\"dbo.parameters\" WHERE name = 'Dash Display 1: DD1'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                int myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB1.Text = "0" + myreader;

                sqlite_cmd.CommandText = "SELECT \"b2\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                sqlite_datareader.Read();
                myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB2.Text = "0" + myreader;
                sqlite_cmd.CommandText = "SELECT \"b3\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB3.Text = "0" + myreader;
                sqlite_cmd.CommandText = "SELECT \"b4\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB4.Text = "0" + myreader;
                sqlite_cmd.CommandText = "SELECT \"b5\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB5.Text = "0" + myreader;
                sqlite_cmd.CommandText = "SELECT \"b6\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB6.Text = "0" + myreader;
                sqlite_cmd.CommandText = "SELECT \"b7\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB7.Text = "0" + myreader;
                sqlite_cmd.CommandText = "SELECT \"b8\" FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                myreader = sqlite_datareader.GetByte(0);
                sqlite_datareader.Close();
                tB8.Text = "0" + myreader;
                sqlite_cmd.CommandText = "SELECT can_id FROM \"main\".\"dbo.parameters\" WHERE \"name\" = '" + kitas + "' ";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                sqlite_datareader.Read();
                string can_idx = sqlite_datareader.GetString(0);
                sqlite_datareader.Close();
                tbCANID.Text = can_idx;
                

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while capturing data from DB.");
               // tbCANID.Text = can_id;
            }
            
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
            this.button1.Image = ((Image)(Properties.Resources.hover));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Image = ((Image)(Properties.Resources.generate_btn));
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.Image = ((Image)(Properties.Resources.hover));
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.Image = ((Image)(Properties.Resources.hover));
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlite_datawriter;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn2.CreateCommand();
            //string name = listBoxMyBoy.SelectedItem.ToString();
            
            sqlite_cmd.CommandText = "INSERT INTO \"main\".\"packets\"(\"can_id\", \"b1\", \"b2\", \"b3\", \"b4\", \"b5\", \"b6\", \"b7\", \"b8\", \"frequency\")VALUES ('"+ tbCANID.Text+ "', '"+tB1.Text+ "', '"+tB2.Text+"', '"+tB3.Text+"', '"+tB4.Text+"', '"+tB5.Text+"', '"+tB6.Text+"', '"+tB7.Text+"', '"+tB8.Text+"', 200);";
            MessageBox.Show(sqlite_cmd.CommandText);
            try
            {
                sqlite_datawriter = sqlite_cmd.ExecuteReader();
            }
            catch 
            {
                MessageBox.Show("Data duplicate");
            }
            
            loadDataGridView(sqlite_conn2);
        }

        private void loadDataGridView(SQLiteConnection conn2)
        {
            
            SQLiteDataAdapter data_adapter = new SQLiteDataAdapter("select * from packets", sqlite_conn2);
            DataSet ds = new DataSet();

            data_adapter.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables[0];
 

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.AutoResizeColumns();
        }
    }
}
    
    

