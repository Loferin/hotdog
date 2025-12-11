using UnityEngine;

public class HotdogTester : MonoBehaviour 
{
    [Header("=== БАЗОВЫЙ ХОТДОГ ===")]
    [SerializeField] private HotdogBaseConfig baseHotdogConfig;

    [Header("=== ДЕКОРАТОРЫ ===")]
    [SerializeField] private HotdogDecoratorConfig picklesConfig;
    [SerializeField] private HotdogDecoratorConfig onionConfig;

    [Header("=== ТЕСТИРОВАНИЕ ===")]
    [SerializeField] private bool testOnStart = true;

    private void Start() 
    {
        if (testOnStart && baseHotdogConfig != null) 
        {
            TestHotdog(baseHotdogConfig);
        }
    }

    [ContextMenu("Тест хотдога")]
    public void TestHotdog(HotdogBaseConfig config) 
    {
        if (config == null || picklesConfig == null || onionConfig == null) 
        {
            Debug.LogError("Не все конфиги назначены!");
            return;
        }

        Hotdog hotdog = new ConfiguredHotdog(config);
        
        Debug.Log($"\n{'=',20}");
        Debug.Log($" Хот-дог {hotdog.GetName()} ({hotdog.GetWeight()}г) — {hotdog.GetCost()}р.");
        Debug.Log("Дополнительная информация:");
        
        Hotdog withPickles = new ConfiguredDecorator(hotdog, picklesConfig);
        Debug.Log($" {withPickles.GetName()} ({withPickles.GetWeight()}г) — {withPickles.GetCost()}р.");
        
        Hotdog withOnion = new ConfiguredDecorator(hotdog, onionConfig);
        Debug.Log($" {withOnion.GetName()} ({withOnion.GetWeight()}г) — {withOnion.GetCost()}р.");
    }
}

