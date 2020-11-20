using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCVS.Case
{
    public partial class Sample
    {
        public void OpenImage()
        {
            Mat src = new Mat(@".\resources\sample.jpg");
            Cv2.ImShow("src", src);
            Cv2.WaitKey();
        }
    }
}
