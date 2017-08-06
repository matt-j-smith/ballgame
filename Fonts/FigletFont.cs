/*
Figlet Font related code taken from the wonderful Colorful.Console project
https://github.com/tomakita/Colorful.Console
 */
/*The MIT License (MIT)

Copyright (c) 2015 Tom Akita

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ballgame{
    public class FigletFont
    {
        public static FigletFont Default
        {
            get
            {
                return Parse(DefaultFonts.SmallSlant);
            }
        }

        public int BaseLine { get; private set; }

        public int CodeTagCount { get; private set; }

        public int CommentLines { get; private set; }

        public int FullLayout { get; private set; }

        public string HardBlank { get; private set; }

        public int Height { get; private set; }

        public int Kerning { get; private set; }

        public string[] Lines { get; private set; }

        public int MaxLength { get; private set; }

        public int OldLayout { get; private set; }

        public int PrintDirection { get; private set; }

        public string Signature { get; private set; }

        public static FigletFont Load(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                return Load(stream);
            }
        }

        public static FigletFont Load(Stream stream)
        {
            if (stream == null) { throw new ArgumentNullException(nameof(stream)); }

            var fontLines = new List<string>();
            using (var streamReader = new StreamReader(stream))
            {
                while (!streamReader.EndOfStream)
                {
                    fontLines.Add(streamReader.ReadLine());
                }
            }

            return Parse(fontLines);
        }

        public static FigletFont Load(string filePath)
        {
            if (filePath == null) { throw new ArgumentNullException(nameof(filePath)); }

            return Parse(File.ReadLines(filePath));
        }

        public static FigletFont Parse(string fontContent)
        {
            if (fontContent == null) { throw new ArgumentNullException(nameof(fontContent)); }

            return Parse(fontContent.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None));
        }

        public static FigletFont Parse(IEnumerable<string> fontLines)
        {
            if (fontLines == null) { throw new ArgumentNullException(nameof(fontLines)); }

            var font = new FigletFont()
            {
                Lines = fontLines.ToArray()
            };
            var configString = font.Lines.First();
            var configArray = configString.Split(' ');
            font.Signature = configArray.First().Remove(configArray.First().Length - 1);
            if (font.Signature == "flf2a")
            {
                font.HardBlank = configArray.First().Last().ToString();
                font.Height = ParseIntValue(configArray, 1);
                font.BaseLine = ParseIntValue(configArray, 2);
                font.MaxLength = ParseIntValue(configArray, 3);
                font.OldLayout = ParseIntValue(configArray, 4);
                font.CommentLines = ParseIntValue(configArray, 5);
                font.PrintDirection = ParseIntValue(configArray, 6);
                font.FullLayout = ParseIntValue(configArray, 7);
                font.CodeTagCount = ParseIntValue(configArray, 8);
            }

            return font;
        }

        private static int ParseIntValue(string[] values, int index)
        {
            var integer = 0;

            if (values.Length > index)
            {
                int.TryParse(values[index], out integer);
            }

            return integer;
        }
    }
}