public abstract class HotdogDecorator : Hotdog 
{
    protected Hotdog wrappedHotdog;

    protected HotdogDecorator(Hotdog hotdog, string decoratorName) 
        : base(decoratorName)
    {
        wrappedHotdog = hotdog;
    }
}
