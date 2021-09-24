using System;
using System.IO;

namespace RandomMap
{
    class RandomMapGen
    {
        public static int XGrid = 96;
        public static int YGrid => (int)Math.Round(XGrid * Math.Sin(Math.PI / 3));

        public static void Gen(int seed, int leng, int total, int xGrid)
        {
            XGrid = xGrid;
            var random = seed < 0 ? new Random() : new Random(seed);
            var beatlength = leng * 4;
            var ar = Math.Round((1200f - (float)leng / 85 * 600) / 750 * 5 + 5, 2).ToString();
            var od = Math.Round((1200f - (float)leng / 85 * 600) / 750 * 5 + 4, 2).ToString();
            var version = $"NC {90000f / beatlength:.3f}BPM seed {seed}";
            //var version = $'NC %.3fBPM seed %d' % (90000 / beatlength, seed);

            using (var file = new StreamWriter("a.txt"))
            {
                file.WriteLine($@"osu file format v14

[General]
AudioFilename: audio.mp3
AudioLeadIn: 0
PreviewTime: -1
Countdown: 0
SampleSet: Soft
StackLeniency: 0.7
Mode: 0
LetterboxInBreaks: 0
WidescreenStoryboard: 1

[Editor]
DistanceSpacing: 1
BeatDivisor: 4
GridSize: 32
TimelineZoom: 3

[Metadata]
Title: mute
TitleUnicode: mute
Artist: obless_noob
ArtistUnicode: obless_noob
Creator: SCORE V2 SUCKS
Version: {version}");
                file.Write($@"OverallDifficulty:{od}
ApproachRate:{ar}
");
                file.WriteLine($"SliderMultiplier:{XGrid * 0.02}");
                file.Write(@"SliderTickRate:1

[Events]

[TimingPoints]

");
                file.Write($"0,{beatlength},4,2,0,100,1,0\n\n");
            }
        }
    }


}
