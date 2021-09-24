﻿using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace RandomMap
{
    public class RandomMapGen
    {
        public static int XGrid = 96;
        public static int YGrid => (int)Math.Round(XGrid * Math.Sin(Math.PI / 3));

        public static void Gen(int seed, int beatLength, int total, int xGrid, bool saveToOsz)
        {
            XGrid = xGrid;
            var random = seed < 0 ? new Random() : new Random(seed);
            var ar = Math.Round((1200f - (float)beatLength/ 85 * 600) / 750 * 5 + 5, 2).ToString();
            var od = Math.Round((1200f - (float)beatLength / 85 * 600) / 750 * 5 + 4, 2).ToString();
            beatLength *= 4;
            var version = $"NC {90000f / beatLength:F3}BPM seed {seed}";
            var filename = $"obless_noob - mute (SCORE V2 SUCKS) [{version}]";

            using (var file = new StreamWriter($"{filename}.osu", false))
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
Version: {version}
BeatmapID:0
BeatmapSetID:-1"
                );
                file.Write($@"
[Difficulty]
HPDrainRate:6
CircleSize:4
OverallDifficulty:{od}
ApproachRate:{ar}
");
                file.WriteLine($"SliderMultiplier:{XGrid * 0.02}");
                file.Write(@"SliderTickRate:1

[Events]

[TimingPoints]
");
                file.Write($"0,{beatLength},4,2,0,100,1,0\n\n");
                file.WriteLine("[HitObjects]");

                var d = new Direction(random.Next(0, 5));
                var p = new Pos();
                var defaultHs = new[] { "0", "0:0:0:0:" };

                int choice(int[] list) => list[random.Next(0, list.Length)];

                string[] autohs(int n)
                {
                    var hs = defaultHs.ToArray();

                    if (n % 64 == 0) hs[0] = "4";
                    else if (n % 8 == 0) hs[0] = "2";
                    else if (n % 8 == 4) hs[0] = "8";
                    else if (n % 16 == 10) hs[0] = "2";

                    return hs;
                }

                var i = 0;

                void writecircle(Pos pos, int time, int nc = 0, string[] hs = null)
                {
                    hs ??= defaultHs.ToArray();
                    file.WriteLine($"{pos.X},{pos.Y},{time},{1 + nc * 4},{hs[0]},{hs[1]}");
                    i++;
                }

                void writeslider(Pos pos1, Pos pos2, int time, int nc = 0, string[] hs1 = null, string[] hs2 = null)
                {
                    hs1 ??= defaultHs.ToArray();
                    hs2 ??= defaultHs.ToArray();
                    file.WriteLine($"{pos1.X},{pos1.Y},{time},{2 + nc * 4},0,L|{pos2.X}:{pos2.Y},1,{XGrid},{hs1[0]}|{hs2[0]},{hs1[1]}|{hs2[1]},0:0:0:0:");
                    i += 3;
                }

                while (i <= total)
                {
                    var r = random.NextDouble();
                    var nc = i % 8 == 0 ? 1 : 0;
                    var p0 = p;

                    //五连+滑条
                    if (r < 1.0 / 6)
                    {
                        if (i <= total - 8 && i % 4 == 0)
                        {
                            var r1 = new Direction(choice(new[] { 2, 4 }));
                            var r2 = new Direction(choice(new[] { 0, 1, 5 }));
                            var r3 = new Direction(choice(new[] { 0, 1, 3, 5 }));
                            var d1 = d + r1;
                            var p1 = p.Step(d1);
                            var d2 = d1 + r2;
                            var p2 = p1.Step(d2);
                            var d3 = d2 + r3;
                            var p3 = p2.Step(d3, 2);

                            if (p1.IsInField && p2.IsInField && p3.IsInField)
                            {
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                p = (p0 * 3 + p1) / 4;
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                p = (p0 + p1) / 2;
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                p = (p0 + p1 * 3) / 4;
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                writeslider(p1, p2, i * leng, nc, autohs(i), autohs(i + 2));
                                d = d3;
                                p = p3;
                                i++;
                            }
                        }
                    }
                    //三连+滑条
                    else if (r < 2.0 / 6)
                    {
                        if (i <= total - 6)
                        {
                            var r1 = new Direction(choice(new[] { 0, 1, 2, 3, 4, 5 }));
                            var r2 = new Direction(choice(new[] { 0, 1, 3, 5 }));
                            var d1 = d + r1;
                            var p1 = p.Step(d1);
                            var d2 = d1 + r2;
                            var p2 = p1.Step(d2, 2);

                            if (p1.IsInField && p2.IsInField)
                            {
                                writecircle(p0, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                writecircle(p0, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                writeslider(p0, p1, i * leng, i % 8 == 0 ? 1 : 0, autohs(i), autohs(i + 2));
                                d = d2;
                                p = p2;
                                i++;
                            }
                        }
                    }
                    //滑条
                    else if (r < 3.0 / 6)
                    {
                        if (i <= total - 2)
                        {
                            var r1 = new Direction(choice(new[] { 0, 1, 2, 3, 4, 5 }));
                            var r2 = new Direction(choice(new[] { 0, 1, 3, 5 }));
                            var d1 = d + r1;
                            var p1 = p.Step(d1);
                            var d2 = d1 + r2;
                            var p2 = p1.Step(d2, 2);

                            if (p1.IsInField && p2.IsInField)
                            {
                                writeslider(p0, p1, i * leng, i % 8 == 0 ? 1 : 0, autohs(i), autohs(i + 2));
                                p = p2;
                                d = d2;
                                i++;
                            }
                        }
                    }
                    //五连
                    else if (r < 4.0 / 6)
                    {
                        if (i <= total - 4 && i % 4 == 0)
                        {
                            var r1 = new Direction(choice(new[] { 2, 4 }));
                            var r2 = new Direction(choice(new[] { 2, 4 }));
                            var d1 = d + r1;
                            var p1 = p.Step(d1);
                            var d2 = d1 + r2;
                            var p2 = p1.Step(d2, 2);

                            if (p1.IsInField && p2.IsInField)
                            {
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                p = (p0 * 3 + p1) / 4;
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                p = (p0 + p1) / 2;
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                p = (p0 + p1 * 3) / 4;
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                p = p1;
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                d = d2;
                                p = p2;
                                i++;
                            }
                        }
                    }
                    //三连
                    else if (r < 5.0 / 6)
                    {
                        if (i <= total - 2)
                        {
                            var r1 = new Direction(choice(new[] { 2, 4 }));
                            var d1 = d + r1;
                            var p1 = p.Step(d1, 2);

                            if (p1.IsInField)
                            {
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                writecircle(p, i * leng, i % 8 == 0 ? 1 : 0, autohs(i));
                                d = d1;
                                p = p1;
                                i++;
                            }
                        }
                    }
                    //单点
                    else
                    {
                        var r1 = new Direction(choice(new[] { 2, 4 }));
                        var d1 = d + r1;
                        var p1 = p.Step(d1, 2);

                        if (p1.IsInField)
                        {
                            writecircle(p, i * leng, nc, autohs(i));
                            d = d1;
                            p = p1;
                            i++;
                        }
                    }
                }
            }

            if (saveToOsz)
            {
                using var zip = ZipFile.Open($"{filename}.osz", ZipArchiveMode.Update);

                zip.CreateEntryFromFile($"{filename}.osu", $"{filename}.osu");
            }
        }
    }
}
