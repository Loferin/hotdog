public class ConfiguredHotdog : Hotdog 
{
    private readonly HotdogBaseConfig config;

    public ConfiguredHotdog(HotdogBaseConfig config) 
        : base(config.hotdogName)
    {
        this.config = config;
    }

    public override int GetCost() => config.baseCost;
    public override int GetWeight() => config.baseWeight;
}

