﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WriteToFileTxt {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            WriteFile();
        }

        private void WriteFile() {
            string path = "W:\\8.Технический отдел\\Общая\\Группа C#\\Запись файлов txt\\text.txt";
            if (File.Exists(path)) {
                StreamWriter streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
            }
            else {
                File.Create(path).Close();
                MessageBox.Show("Файл не найден и созданн новый.");
                WriteFile();
            }
        }

        private void btnRead_Click(object sender, EventArgs e) {
            ReadFile();
        }

        private void ReadFile() {
            string path = "W:\\8.Технический отдел\\Общая\\Группа C#\\Запись файлов txt\\text.txt";
            if (File.Exists(path)) {
                StreamReader streamReader = new StreamReader(path);
                listBox1.Items.Clear();
                while (!streamReader.EndOfStream) {
                    string str = streamReader.ReadLine();
                    listBox1.Items.Add(str);
                }
                streamReader.Close();
            }
            else {
                MessageBox.Show("Файл не найден!");
            }
        }
    }
}
