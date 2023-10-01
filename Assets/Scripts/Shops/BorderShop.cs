using UnityEngine;

public class BorderShop : Shop
{
    protected override void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Player"))
        {
            if (playerInventory.numberOfMoney >= shopInfoScriptableObject.PriceOfUpgrade)
            {
                playerInventory.numberOfMoney -= shopInfoScriptableObject.PriceOfUpgrade;
                gameEvents.OnOpenBorders.Invoke();
                gameEvents.OnUpdateCoinCounter.Invoke();
                gameObject.SetActive(false);
            }
        }
    }
}