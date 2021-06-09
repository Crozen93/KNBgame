using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogick : MonoBehaviour
{
  
    [Header("UI")]
    [SerializeField] private Button BtStone;
    [SerializeField] private Button BtPeper;
    [SerializeField] private Button BtNoj;
    [SerializeField] private Text ResultText;
    [SerializeField] private Text ScoreText;

    [SerializeField] private GameObject RockSci;
    [SerializeField] private GameObject PaperRock;
    [SerializeField] private GameObject SkiPaper;

    [SerializeField] private GameObject[] ResultImage;
    [SerializeField] private GameObject[] EnemyImage;

    [Header("Variables")]
    [SerializeField] private int Score;
    [SerializeField] private int PlayerScore;
    [SerializeField] private int EnemyScore;

    [SerializeField] private string PlayerSt;
    [SerializeField] private string EnemySt;
    [SerializeField] private string GameResult;

    // Start is called before the first frame update
    void Start()
    {
        BtStone.onClick.AddListener(() => Round(1));
        BtPeper.onClick.AddListener(() => Round(2));
        BtNoj.onClick.AddListener(()   => Round(3));

    }

    //Round
        void Round(int PlSc)
    {

        //Disable image 
        for (int i = 0; i < 2; i++)
        {
            ResultImage[i].SetActive(false);
            EnemyImage[i].SetActive(false);
        }
    
        EnemyScore = Random.Range(1, 4);  //Enemy logick score random
        PlayerScore = PlSc;               // Player logick score
        PlayerStatus();                    //Debug Inspector


        switch(EnemyScore)
        {
            case 1:
                EnemyImage[0].SetActive(true);
                break;
            case 2:
                EnemyImage[1].SetActive(true);
                break;
            case 3:
                EnemyImage[2].SetActive(true);
                break;
        }
          

        if (PlayerScore == 1 && EnemyScore == 1)
        {
            GameResult = "�����";
            ResultText.text = GameResult;
        }
        if (PlayerScore == 2 && EnemyScore == 2)
        {
            GameResult = "�����";
            ResultText.text = GameResult;
        }
        if (PlayerScore == 3 && EnemyScore == 3)
        {
            GameResult = "�����";
            ResultText.text = GameResult;
        }


        if (PlayerScore == 1 && EnemyScore == 2)
        {
            GameResult = "��������";
            ResultText.text = GameResult;
            ScoreText.text = Score.ToString();
            PaperRock.SetActive(true);
        }
        if (PlayerScore == 1 && EnemyScore == 3)
        {
            GameResult = "������";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
            RockSci.SetActive(true);
        }

        if (PlayerScore == 2 && EnemyScore == 1)
        {
            GameResult = "������";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
            PaperRock.SetActive(true);

        }
        if (PlayerScore == 2 && EnemyScore == 3)
        {
            GameResult = "��������";
            ResultText.text = GameResult;
            SkiPaper.SetActive(true);
        }

        if (PlayerScore == 3 && EnemyScore == 1)
        {
            GameResult = "��������";
            ResultText.text = GameResult;
            RockSci.SetActive(true);
        }
        if (PlayerScore == 3 && EnemyScore == 2)
        {
            GameResult = "������";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
            SkiPaper.SetActive(true);
        }
    }


    //Player and Enemy game status Test in Inspector
    void PlayerStatus()
    {
        switch (PlayerScore)
        {
            case 1:
                PlayerSt = "������";
                break;
            case 2:
                PlayerSt = "������";
                break;
            case 3:
                PlayerSt = "�������";
                break;
        }

        switch (EnemyScore)
        {
            case 1:
                EnemySt = "������";
                break;
            case 2:
                EnemySt = "������";
                break;
            case 3:
                EnemySt = "�������";
                break;
        }
    }
}
