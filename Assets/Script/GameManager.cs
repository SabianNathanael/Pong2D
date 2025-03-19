using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;
    public TMP_Text txtPlayerWin;
    public GameObject winScrene;
   public static GameManager Instance;

    public int PlayerScoreL, PlayerScoreR;
   public void Awake()
   {
    if (Instance == null) Instance = this;
    else Destroy(gameObject);
   }

   public void AddScore(string wallName)
   {
        if(wallName == "WallL") 
        {
            PlayerScoreR =PlayerScoreR+ 10;
            txtPlayerScoreR.text = PlayerScoreR.ToString();
            ScoreCheck();
        }
        else if ((wallName == "WallR")) 
        {
            PlayerScoreL =PlayerScoreL+10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
   }

   private void ScoreCheck()
   {
         if (PlayerScoreL == 20)
        {
            Debug.Log("playerL win");
            winScrene.SetActive(true);
            txtPlayerWin.text = ("Player L WIN");

        }
        else if (PlayerScoreR == 20)
        {
            Debug.Log("playerR win"); 
            winScrene.SetActive(true);  
            txtPlayerWin.text = ("Player R WIN");
        }
   }

}
