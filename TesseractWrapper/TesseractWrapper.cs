using Ocr.Engine;
using System;
using System.Drawing;
using Tesseract;

namespace Ocr.Wrapper.TesseractWrapper
{
    public class TesseractWrapper : IOcrEngine
    {
     private string outputText;
     private string language;
     public TesseractWrapper()
        {
            outputText = "Not Recognized";
            language = "eng";
        }

     public string getTextFromImageFile(string filePath, string selectedLanguage, string selectedMode)
     {
         switch (selectedLanguage)
         {
             case "SPANISH":
                 language = "spa";
                 break;
             case "ENGLISH":
                 language = "eng";
                 break;
             case "GERMAN":
                 language = "deu";
                 break;
             case "CHINESE_SIMPLIFIED":
                 language = "chi_sim";
                 break;
             default:
                 language = "eng";
                 break;

         }

         string text = createTesseract(filePath, language);

         return text;
     }
     private string createTesseract(string fileName, string language)
     {
            // To DO, Bitmap not recognized
            Bitmap image = new Bitmap(fileName);
            TesseractEngine engine = new TesseractEngine(@"./tessdata", language, EngineMode.Default);
            Page page = engine.Process(image);
             outputText = page.GetText();
             Console.WriteLine(outputText);
             engine.Dispose();

            return outputText;

     }
    }
}
