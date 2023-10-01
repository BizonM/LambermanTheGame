using UnityEngine;

public class BorderController: MonoBehaviour
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
        gameObject.SetActive(false);
    }
}