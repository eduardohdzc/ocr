using Ocr.Wrapper;
using Ocr.Wrapper.ModiWrapper;
using Ocr.Wrapper.TesseractWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine.Handler
{
    public class OcrEngineHandler
    {
        public static IOcrEngine createEngine()
        {
            //IOcrEngine engineWrapper = new ModiWrapper();
            IOcrEngine engineWrap = new TesseractWrapper();
            
            return engineWrap;
        }

        // Factory abstract
        public static IOcrEngine createEngine(string engine)
        {
           if(engine.Equals("MODI"))
            {
                return new ModiWrapper();
            }
           else if(engine.Equals("Tesseract"))
            {
                return new TesseractWrapper();
            }
            return new TesseractWrapper();
        }
    }
}
