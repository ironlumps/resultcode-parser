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
using HtmlAgilityPack;


namespace ResultCodeDescriptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            fdlg.Filter = "All files(*.*)| *.*| HTML(*.html) | *.csv | TXT(*.txt) | *.txt";
            fdlg.FilterIndex = 3;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = fdlg.FileName;
                StreamReader parse = new StreamReader(fileName);
                string writing = fileName.Replace(".txt", "Results.txt");
                StreamWriter write = new StreamWriter(writing);

                string result = "";

                string value = parse.ReadToEnd();

                while (value != null)
                {
                    string[] split = value.Split('$');
                    for (int i = 0; i < split.Length; i++)
                    {
                        string descrip = split[i];
                        string[] descripSplit = descrip.Split('|');
                        write.WriteLine(descripSplit[1] + "," + descripSplit[2] + "," + descripSplit[3]);
                    }
                }

                StreamReader reader = new StreamReader(writing);
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {

                }

            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Parse();

            Application.Exit();
        }

        //public string ResultCode(string code, bool checkShort, bool checkLong)
        //{
        //    string shor = "";
        //    string lon = "";

        //    if(code.Equals("ASO1"))
        //    {
        //        shor = "Address Fully Verified";
        //        lon = "The address is valid and deliverable according to official postal agencies.";
        //    }
        //    else if(code.Equals("AS02"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS03"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS09"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS10"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS11"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS12"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS13"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS14"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS15"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS16"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS17"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS18"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS20"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS22"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS23"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //    else if (code.Equals("AS24"))
        //    {
        //        shor = "Street Only Match";
        //        lon = "The street address was verified but the suite/apartment number is missing or invalid.";
        //    }
        //}
        public void Parse()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            fdlg.Title = "Choose Result Codes - Melissa Data WikiResults.txt";
            fdlg.Filter = "All files(*.*)| *.*| HTML(*.html) | *.csv | TXT(*.txt) | *.txt";
            fdlg.FilterIndex = 3;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = fdlg.FileName;
                string writing = fileName.Replace(".txt", "Results.txt");
                if (!File.Exists(writing))
                {
                    StreamReader parse = new StreamReader(fileName);

                    StreamWriter write = new StreamWriter(writing);

                    string result = "";

                    string value = parse.ReadToEnd();


                    string[] split = value.Split('@');
                    for (int i = 0; i < split.Length; i++)
                    {
                        if (!split[i].Contains("<th>"))
                        {
                            string descrip = split[i];
                            descrip = descrip.Replace('\n', ' ');
                            string[] descripSplit = descrip.Split('|');
                            if (descripSplit.Length == 1)
                            {
                                write.WriteLine(descripSplit[0]);
                            }
                            else if (descripSplit.Length == 2)
                            {
                                write.WriteLine(descripSplit[0] + "," + descripSplit[1]);
                            }
                            else
                            {
                                write.WriteLine(descripSplit[0] + "," + descripSplit[1] + "," + descripSplit[2]);
                            }

                        }

                    }

                    write.Close();
                    write.Dispose();
                    parse.Close();
                }
                else
                {
                    OpenFileDialog secondDialog = new OpenFileDialog();
                    secondDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    secondDialog.Filter = "All files(*.*)| *.*| HTML(*.html) | *.csv | TXT(*.txt) | *.txt";
                    secondDialog.Title = "Choose the file you want to run through";
                    secondDialog.FilterIndex = 3;
                    secondDialog.RestoreDirectory = true;
                    if (secondDialog.ShowDialog() == DialogResult.OK)
                    {
                        string newFile = secondDialog.FileName;
                        StreamReader goal = new StreamReader(newFile);
                        if (newFile.EndsWith(".csv"))
                        {
                            newFile = newFile.Replace(".csv", "FinalResults.csv");
                        }
                        if (newFile.EndsWith(".txt"))
                        {
                            newFile = newFile.Replace(".txt", "FinalResults.txt");
                        }



                        string results = "";
                        string goalLine;
                        while ((goalLine = goal.ReadLine()) != null)
                        {
                            string[] goalSplit = goalLine.Split(',');

                            for (int i = 0; i < goalSplit.Length; i++)
                            {
                                StreamReader basic = new StreamReader(writing);
                                StreamWriter finished = new StreamWriter(newFile, true);
                                string baseLine;
                                while ((baseLine = basic.ReadLine()) != null)
                                {
                                    string[] baseSplit = baseLine.Split(',');

                                    if (baseSplit[0].Contains(goalSplit[i]))
                                    {
                                        results += goalSplit[i] + "|";
                                        if (checkShort.Checked == true)
                                        {
                                            results += baseSplit[1] + "|";
                                        }
                                        if (checkLong.Checked == true)
                                        {
                                            results += baseSplit[2];
                                        }

                                        finished.WriteLine(results);
                                        results = "";
                                        break;
                                    }
                                }
                                finished.Flush();
                                finished.Close();
                                basic.Close();

                            }
                        }
                        goal.Close();


                    }


                }





            }

        }
    }
}
