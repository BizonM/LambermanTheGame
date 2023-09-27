using UnityEngine;

[CreateAssetMenu (fileName = "Tree", menuName = "ScriptableObjects/Tree")]
public class Tree : ScriptableObject
{
    public string TreeTag;
    public int TreeHealth;
}