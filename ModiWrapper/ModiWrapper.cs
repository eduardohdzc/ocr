﻿using Ocr.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Wrapper.ModiWrapper
{
    public class ModiWrapper : IOcrEngine
    {
        private string outputText;
        MODI.MiLANGUAGES language;
        public ModiWrapper()
        {
            outputText = "Not Recognized";
        }

        public string getTextFromImageFile(string filePath, string selectedLanguage, string selectedMode)
        {
            switch (selectedLanguage){
                case "SPANISH":
                    language=MODI.MiLANGUAGES.miLANG_SPANISH;
                    break;
                case "ENGLISH":
                    language=MODI.MiLANGUAGES.miLANG_ENGLISH;
                    break;
                case "FRENCH":
                    language=MODI.MiLANGUAGES.miLANG_FRENCH;
                    break;
                default:
                    language=MODI.MiLANGUAGES.miLANG_SPANISH;
                    break;

            }       

            string text = createMODI(filePath);

            return text;
        }

        private string createMODI(string fileName){
            MODI.Document md = new MODI.Document(); 
            md.Create(fileName); 
            md.OCR(language,  true, true); 
            MODI.Image image = (MODI.Image)md.Images[0];
            outputText = image.Layout.Text;
            Console.WriteLine(image.Layout.Text); 
            md.Close();

            return outputText;

        }
    }

 }
