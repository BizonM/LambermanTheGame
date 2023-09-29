using UnityEngine;

[CreateAssetMenu (fileName = "Inventory", menuName = "ScriptableObjects/Inventory")]
public class InventoryScriptableObject : ScriptableObject
{
    public int numberOfWood;
    public int numberOfMoney;
    public int playerDamage;
    public int playerSpeed;
}