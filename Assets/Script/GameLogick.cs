using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogick : MonoBehaviour
{
    [Header("UI")]
    public Button BtStone;
    public Button BtPeper;
    public Button BtNoj;
    public Text ResultText;
    public Text ScoreText;

    public Text ScoreText1;


    public GameObject RockSci;
    public GameObject PaperRock;
    public GameObject SkiPaper;

    public GameObject[] Enemy;

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
        BtNoj.onClick.AddListener(() => Round(3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Round(int PlSc)
    {
        RockSci.SetActive(false);
        PaperRock.SetActive(false);
        SkiPaper.SetActive(false);

        Enemy[0].SetActive(false);
        Enemy[1].SetActive(false);
        Enemy[2].SetActive(false);

        EnemyScore = Random.Range(1, 3);
        PlayerScore = PlSc;
        PlayerStatus();

        if (EnemyScore == 1)
        {
            Enemy[0].SetActive(true);
        }
        if (EnemyScore == 2)
        {
            Enemy[1].SetActive(true);
        }
        if (EnemyScore == 3)
        {
            Enemy[2].SetActive(true);
        }



        if (PlayerScore == 1 && EnemyScore == 1)
        {
            GameResult = "Ничья";
            ResultText.text = GameResult;
        }
        if (PlayerScore == 2 && EnemyScore == 2)
        {
            GameResult = "Ничья";
            ResultText.text = GameResult;
        }
        if (PlayerScore == 3 && EnemyScore == 3)
        {
            GameResult = "Ничья";
            ResultText.text = GameResult;
        }

        if (PlayerScore == 1 && EnemyScore == 2)
        {
            GameResult = "Проиграл";
            ResultText.text = GameResult;
            ScoreText.text = Score.ToString();
            PaperRock.SetActive(true);
        }
        if (PlayerScore == 1 && EnemyScore == 3)
        {
            GameResult = "Победа";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
            RockSci.SetActive(true);
        }

        if (PlayerScore == 2 && EnemyScore == 1)
        {
            GameResult = "Победа";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
            PaperRock.SetActive(true);

        }
        if (PlayerScore == 2 && EnemyScore == 3)
        {
            GameResult = "Проиграл";
            ResultText.text = GameResult;
            SkiPaper.SetActive(true);
        }

        if (PlayerScore == 3 && EnemyScore == 1)
        {
            GameResult = "Проиграл";
            ResultText.text = GameResult;
            RockSci.SetActive(true);
        }
        if (PlayerScore == 3 && EnemyScore == 2)
        {
            GameResult = "Победа";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
            SkiPaper.SetActive(true);
        }


    }

    void PlayerStatus()
    {
        if (PlayerScore == 1)
        {
            PlayerSt = "Камень";
        }
        if (PlayerScore == 2)
        {
            PlayerSt = "Бумага";
        }
        if (PlayerScore == 3)
        {
            PlayerSt = "Ножницы";
        }

        if (EnemyScore == 1)
        {
            EnemySt = "Камень";
        }
        if (EnemyScore == 2)
        {
            EnemySt = "Бумага";
        }
        if (EnemyScore == 3)
        {
            EnemySt = "Ножницы";
        }
    }
}
