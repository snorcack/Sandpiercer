using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniGameController : MonoBehaviour
{
    // Start is called before the first frame update

    public List<BouncyPlantScript> BouncyPlantList;
    public TextMeshPro Score;
    public TextMeshPro Target;

    int currentScore = 0;
    int targetScore = 0;

    void Start()
    {
        InitializeGame(40);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int score)
    {
        currentScore += score;
        Score.text = currentScore.ToString();
        if (currentScore>(targetScore-1))
        {
            Debug.Log("Game Win");
        }
                
                }

    public void InitializeGame (int intargetScore)
    {
        int targetTiles = intargetScore / 4;
        targetScore = intargetScore;

        for (int i=0;i<targetTiles;i++)
        {
            BouncyPlantList[i].gameObject.SetActive(true);
        }

        Score.text = currentScore.ToString();
        Target.text = targetScore.ToString();

    }

    public void CleanUpMiniGame ()
    {
        for (int i=0;i<BouncyPlantList.Count;i++)
        {
            BouncyPlantList[i].gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        
    }


}
