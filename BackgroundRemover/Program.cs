// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Drawing.Imaging;

Console.WriteLine("Hello, World!");

var path = "./Images";
//var path = "./";

string[] files = Directory.GetFiles(path);

foreach (var file in files)
{
    Console.WriteLine(file);
    if (string.IsNullOrWhiteSpace(file) || file.Length < 4 || !file.Contains(".png"))
        continue;
    var bitmap = new Bitmap(file, true);
    var test1 = bitmap.GetPixel(0,0);
    Console.WriteLine(test1.Name);
    Console.WriteLine(test1.ToString());
    Console.WriteLine("No, " + test1.Equals(Color.FromArgb(255,255,255)) + test1.Equals(Color.FromArgb(247,247,247)));
    if (!test1.Equals(Color.FromArgb(255,255,255)) 
    && !test1.Equals(Color.FromArgb(247,247,247)))
        continue;

    
    for(var x=0; x<bitmap.Width; x++)
    {
        for(var y=0; y<bitmap.Height; y++)
        {
            Color pixelColor = bitmap.GetPixel(x, y);
            Color newColor = Color.FromArgb(0, pixelColor);//Color.FromArgb(pixelColor.R, 0, 0);
            if (pixelColor.Equals(Color.FromArgb(255,255,255)) || pixelColor.Equals(Color.FromArgb(247,247,247)))
            {
                bitmap.SetPixel(x, y, newColor);
            }

            //Console.WriteLine($"alpha: {pixelColor.A}, r {pixelColor.R}, g {pixelColor.G}, b {pixelColor.B}");
        }
    }

    Directory.CreateDirectory("./Output");
    //bitmap.Save($"./Output/test{new Random().Next(100)}.png", ImageFormat.Png);
    var newFileName = file.Replace(path, "");
    newFileName = newFileName.Replace(@"\", "");

    Console.WriteLine("NEW " + newFileName);
    bitmap.Save(newFileName, ImageFormat.Png);
}

;

