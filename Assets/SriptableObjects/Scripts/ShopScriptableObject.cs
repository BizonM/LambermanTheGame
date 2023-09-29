using UnityEngine;

[CreateAssetMenu (fileName = "Shop", menuName = "ScriptableObjects/Shop")]
public class ShopScriptableObject : ScriptableObject
{
    public int PriceOfUpgrade;
    public int AmountOfUpgrade;
}
