﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eventos.Lib
{
    public class VideoEncode
    {
        public delegate void VideoEncodedHandler(Video video);

        public event VideoEncodedHandler Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Codificando o vídeo ...");
            Thread.Sleep(2000);
            Console.WriteLine("Vídeo convertido!");
            Encoded(video);
        }
    }
}
