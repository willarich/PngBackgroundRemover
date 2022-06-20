using System.Drawing;

namespace BackgroundRemover;

public class BitmapDto
{
    private Bitmap _bitmap;

    public BitmapDto(string path)
    {
        _bitmap = new Bitmap(path);
    }

    public void save()
    {
        // int width = Convert.ToInt32(drawImage.Width);
        // int height = Convert.ToInt32(drawImage.Height);
        // using (Bitmap bmp = new Bitmap(width, height))
        // {
        //     drawImage.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
        //     bmp.Save(dialog.FileName, ImageFormat.Jpeg);
        // }
    }
}