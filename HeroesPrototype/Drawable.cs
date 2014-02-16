using HeroesPrototype.geometry;
using System.Drawing;
namespace HeroesPrototype
{
    // This interface ensures that every object that will be drawn on the screen will have position, dimesion and image
    public interface Drawable
    {
        P2d P { get; set; }
        D2d S { get;  }
        Bitmap GetSprite();
    }
}
