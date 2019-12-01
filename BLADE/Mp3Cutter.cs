using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Utils;
using NAudio.Wave;
using System.IO;
using System.Windows.Forms;

namespace BLADE
{
    public class Mp3Cutter
    {
        public static void TrimMp3(string inputPath, string outputPath, int startSecond, int endSecond)
        {
            using (var reader = new Mp3FileReader(inputPath))
            {
                FileStream writer = File.Create(outputPath);

                Mp3Frame frame;
                while ((frame = reader.ReadNextFrame()) != null)
                {
                    var currentSecond = (int)reader.CurrentTime.TotalSeconds;
                    if (currentSecond >= startSecond && currentSecond <= endSecond)
                    {
                        writer.Write(frame.RawData, 0, frame.RawData.Length);
                    }
                    else
                    {
                        if (currentSecond > endSecond)
                        {
                            writer.Dispose();
                            break;
                        }
                    }
                }

                writer.Dispose();
            }
        }
    }
}
