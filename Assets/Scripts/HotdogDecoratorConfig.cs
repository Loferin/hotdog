using UnityEngine;

[CreateAssetMenu(fileName = "HotdogDecoratorConfig", 
                 menuName = "Hotdogs/Decorator Config", 
                 order = 2)]
public class HotdogDecoratorConfig : ScriptableObject 
{
    [Header("Название добавки")]
    public string extraName = "с огурцами";
    
    [Header("Характеристики добавки")]
    public int extraCost = 50;
    public int extraWeight = 20;
}
