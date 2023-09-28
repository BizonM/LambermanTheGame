using UnityEngine;
public class TreeMechanic : MonoBehaviour, IDamageble<int>, IDestructable
{
    [SerializeField] private InventoryScriptableObject playerInventory;
    [SerializeField] private TreeScrtiptableObject treeInformation;
    [SerializeField] private int treeHealth;
    void Start()
    {
        treeHealth = treeInformation.TreeHealth;
        gameObject.tag = treeInformation.TreeTag;
    }

    public void TakeDamage(int damageTaken)
    {
        treeHealth -= damageTaken;
    }

    public void Destroy()
    {
        if (treeHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Player"))
        {
           TakeDamage(playerInventory.playerDamage);
           Destroy();
        }
    }
    
}