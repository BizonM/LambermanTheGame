using UnityEngine;

public class BordersMechanic : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    void OnEnable()
    {
        gameEvents.OnOpenBorders += OpenBorders;
    }

    private void OnDisable()
    {
        gameEvents.OnOpenBorders -= OpenBorders;
    }
    void OpenBorders()
    {
        Destroy(gameObject);
    }
}