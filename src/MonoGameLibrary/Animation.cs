namespace MonoGameLibrary.Graphics;

public class Animation
{
    public Animation()
    {
        Frames = [];
        Delay = TimeSpan.FromMilliseconds(100);
    }


    public Animation(List<TextureRegion> frames, TimeSpan delay)
    {
        Frames = frames;
        Delay = delay;
    }

    public TimeSpan Delay { get; set; }
    public List<TextureRegion> Frames { get; set; }
}
