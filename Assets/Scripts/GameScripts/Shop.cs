using UnityEngine;
public abstract class Shop : MonoBehaviour
{
    [SerializeField] protected GameEvents gameEvents;
    [SerializeField] protected ShopScriptableObject shopInfoScriptableObject;
    [SerializeField] protected InventoryScriptableObject playerInventory;
    protected abstract void OnCollisionEnter2D(Collision2D other);
}
