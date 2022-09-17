using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharListMaker
{
    public partial class Form1 : Form
    {
        public Dictionary<char,Int32> dic;
        public String resultFilePath;
        public ArrayList srdArrayList;

        public Form1()
        {
            InitializeComponent();
            button_convert.Enabled = false;
        }

        public int addLogs(string s)
        {
            string timeTag = DateTime.Now.ToString("[HH:mm:ss] ");
            if(richTextBox_logs.InvokeRequired)
            {
                richTextBox_logs.Invoke(new Action(() =>
                {
                    richTextBox_logs.AppendText(timeTag + s + "\n");
                    richTextBox_logs.ScrollToCaret();
                }));
            }
            else
            {
                richTextBox_logs.AppendText(timeTag + s + "\n");
                richTextBox_logs.ScrollToCaret();
            }
            return 0;
        }

        private void button_openTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt|All Files|*.*";
            ofd.Multiselect = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                srdArrayList = new ArrayList();
                string[] fPaths = ofd.FileNames;
                foreach(string s in fPaths)
                {
                    srdArrayList.Add(new StreamReader(s, true));
                }
                resultFilePath = System.IO.Path.GetDirectoryName(fPaths[0]);
                button_convert.Enabled = true;
                button_openTextFile.Enabled = false;
                addLogs("已添加" + fPaths.Length.ToString()  + "个文档。");
            }
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            dic = new Dictionary<char,Int32>();
            dic.Clear();
            try
            {
                foreach(StreamReader stream in srdArrayList)
                {
                    Int32 chara = stream.Read();
                    while (chara != -1)
                    {
                        if (!dic.ContainsKey((char)chara))
                        {
                            dic.Add((char)chara, chara);
                        }
                        chara = stream.Read();
                    }
                    stream.Close();
                }

                Int32[] illegal = { 10, 13};
                foreach(Int32 sage in illegal)
                {
                    if (dic.ContainsKey((char)sage))
                    {
                        dic.Remove((char)sage);
                    }
                }

                var val = dic.Keys.ToList();
                val.Sort();

                string timeTag = DateTime.Now.ToString("[HH_mm_ss]");
                if (!Directory.Exists(resultFilePath + "\\Result"))
                {
                    Directory.CreateDirectory(resultFilePath + "\\Result");
                }
                string resultFile = resultFilePath + "\\Result\\" + timeTag +".txt";
                StreamWriter sw = new StreamWriter(resultFile, true, Encoding.Unicode);
                foreach (var key in val)
                {
                    sw.Write((char)key);
                }

                sw.Close();
                srdArrayList.Clear();
                dic.Clear();

                button_convert.Enabled = false;
                button_openTextFile.Enabled = true;

                addLogs("Charlist已生成至路径：" + resultFile);
            }
            catch
            {
                addLogs("yeah~程序炸了~");
                button_convert.Enabled = false;
                button_openTextFile.Enabled = true;
                srdArrayList.Clear();
                dic.Clear();
            }
        }
    }
}
