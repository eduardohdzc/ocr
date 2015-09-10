﻿using Ocr.Engine;
using Ocr.Engine.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IOcrEngine ocrEngine = OcrEngineHandler.createEngine();

            // TODO: change the hardcoded path with a path read from UI
            string text = ocrEngine.getTextFromImageFile(@"C:\Users\Eduardo\Documents\Visual Studio 2015\Projects\Ocr\number.jpg",Language.ENGLISH, "");
            richTextBox1.Text = text;
        }
    }
}
