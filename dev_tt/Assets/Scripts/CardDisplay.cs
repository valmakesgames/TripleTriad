using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
   // Expose UI elements in Hierarchy for wiring up 
   [SerializeField]
   private Image cardImage;
   
   [SerializeField]
   private Image cardElementIcon;
   
   [SerializeField]
   private TMP_Text topRankNumber;
   
   [SerializeField] 
   private TMP_Text leftRankNumber;
   
   [SerializeField]
   private TMP_Text rightRankNumber;
   
   [SerializeField]
   private TMP_Text bottomRankNumber;
   
   // Testing Tonberry Card made with scriptable object
   [SerializeField]
   private CardData testCard;

   public void Start() {
       TestMethod(testCard);
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

  public void TestMethod(CardData cardTestData) {
      Debug.Log(cardTestData.topRankNumber.ToString());
  }
}
