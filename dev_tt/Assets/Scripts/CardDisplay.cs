using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    // Expose UI elements in Hierarchy for wiring up 
    [SerializeField] private Image cardImage;

    [SerializeField] private Image cardElementIcon;

    [SerializeField] private TMP_Text topRankNumber;

    [SerializeField] private TMP_Text leftRankNumber;

    [SerializeField] private TMP_Text rightRankNumber;

    [SerializeField] private TMP_Text bottomRankNumber;

    // Test Scriptable Object card assets
    [SerializeField] private CardData testCard;
    [SerializeField] private CardData cardA;
    [SerializeField] private CardData cardB;

    public void Start() {
        ShowTopRankNumber(testCard);
        ShowCardName(testCard);
        ShowCardElement(testCard);
        ShowCardArtName(testCard);
        
        // Compare Top Rank Numbers test
        CompareTopRankNumbers(cardA, cardB);
        
        // Test PopulateCard method
        PopulateCard(testCard);
    }

    // Method to populate TT Card prefab with data from Scriptable Object
    public void PopulateCard(CardData cardData) {
        cardImage.sprite = cardData.cardImage;
        cardElementIcon.sprite = cardData.elementalImage;

        topRankNumber.text = cardData.GetRankNumberDisplay(cardData.topRankNumber);
        leftRankNumber.text = cardData.GetRankNumberDisplay(cardData.leftRankNumber);
        rightRankNumber.text = cardData.GetRankNumberDisplay(cardData.rightRankNumber);
        bottomRankNumber.text = cardData.GetRankNumberDisplay(cardData.bottomRankNumber);
    }

    public void ShowTopRankNumber(CardData cardTestData) {
        Debug.Log(cardTestData.topRankNumber);
    }

    public void ShowCardName(CardData cardName) {
        Debug.Log(cardName.name);
    }

    public void ShowCardElement(CardData cardElement) {
        if (cardElement.elementalImage != null) {
            Debug.Log(cardElement.elementalImage.name);
        }
    }

    public void ShowCardArtName(CardData cardArtName) {
        Debug.Log(cardArtName.cardImage.name);
    }

    public void CompareTopRankNumbers(CardData cardATopRankNumber, CardData cardBTopRankNumber) {
        
        // Need variable for winning card - how?
        string winningCard = "";
        
        if (cardATopRankNumber.topRankNumber > cardBTopRankNumber.topRankNumber) {
            winningCard = "Card A";
        }
        else if (cardATopRankNumber.topRankNumber == cardBTopRankNumber.topRankNumber) {
            Debug.Log("It's a draw!");
        }
        else {
            winningCard = "Card B";
        }
        Debug.Log("Winning card is " + winningCard);
    }
}