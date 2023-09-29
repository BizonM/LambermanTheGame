using UnityEngine;
using Random = System.Random;

public class Crate : MonoBehaviour, IDamageble, IDestructable
{
    [SerializeField] private int health;
    [SerializeField] private int minWoodGain;
    [SerializeField] private int maxWoodGain;
    [SerializeField] private InventoryScriptableObject playerInventory;
    [SerializeField] private GameEvents gameEvents;

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }
    
    public void Destroy()
    {
        if (health <= 0)
        {
            Random random = new Random();
            int num = random.Next(minWoodGain, maxWoodGain);
            playerInventory.numberOfWood += num;
            gameEvents.OnUpdateWoodCounter.Invoke();
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D info)
    {
        TakeDamage(playerInventory.playerDamage);
        Destroy();
    }
}
