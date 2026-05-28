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
}
