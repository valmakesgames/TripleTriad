using UnityEngine;

// Scriptable Object to make TT Cards with
[CreateAssetMenu(fileName = "NewCard", menuName = "New TT Card")]
public class CardData : ScriptableObject
{
    [Header("Card Image")]
    public Sprite cardImage;
    
    [Header("Rank Numbers")]
    public int topRankNumber;
    public int leftRankNumber;
    public int rightRankNumber;
    public int bottomRankNumber;
    
    [Header("Card Type")]
    // Does this card have an Elemental Attribute, add the Elemental image
    public Sprite elementalImage;
}
