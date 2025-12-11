public class ConfiguredDecorator : HotdogDecorator 
{
    private readonly HotdogDecoratorConfig config;

    public ConfiguredDecorator(Hotdog hotdog, HotdogDecoratorConfig config) 
        : base(hotdog, $"{hotdog.GetName()} {config.extraName}")
    {
        this.config = config;
    }

    public override int GetCost() => wrappedHotdog.GetCost() + config.extraCost;
    public override int GetWeight() => wrappedHotdog.GetWeight() + config.extraWeight;
}
