using UnityEngine;

[CreateAssetMenu(fileName = "HotdogBaseConfig", 
                 menuName = "Hotdogs/Base Config", 
                 order = 1)]
public class HotdogBaseConfig : ScriptableObject 
{
    [Header("Название хотдога")]
    public string hotdogName = "Классический";
    
    [Header("Базовые характеристики")]
    public int baseCost = 210;
    public int baseWeight = 150;
}
