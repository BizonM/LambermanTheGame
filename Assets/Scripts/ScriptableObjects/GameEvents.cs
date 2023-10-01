using System;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvents",menuName = "ScriptableObjects/GameEvents")]
public class GameEvents : ScriptableObject
{
    public Action OnOpenBorders;
    public Action OnUpdateWoodCounter;
    public Action OnUpdateCoinCounter;
    public Action OnUpdateDamageCounter;
}