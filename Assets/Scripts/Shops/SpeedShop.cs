using UnityEngine;
public class SpeedShop : Shop
{ 
    protected override void OnCollisionEnter2D(Collision2D info)
    {
        if (info.collider.CompareTag("Player"))
        {
            if (playerInventory.numberOfMoney >= shopInfoScriptableObject.PriceOfUpgrade)
            {
                playerInventory.playerSpeed += shopInfoScriptableObject.AmountOfUpgrade;
                playerInventory.numberOfMoney -= shopInfoScriptableObject.PriceOfUpgrade;
                gameEvents.OnUpdateCoinCounter.Invoke();
            }

            if (playerInventory.playerSpeed >= 10000)
            {
                gameObject.SetActive(false);
            }
        }
    }
}