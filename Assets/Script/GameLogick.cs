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


    public GameObject Gobj1;
    public GameObject Gobj2;
    public GameObject Gobj3;

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
        EnemyScore = Random.Range(1, 3);
        PlayerScore = PlSc;
        PlayerStatus();
        


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
            GameResult = "Победа";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
        }
        if (PlayerScore == 1 && EnemyScore == 3)
        {
            GameResult = "Победа";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
        }

        if (PlayerScore == 2 && EnemyScore == 1)
        {
            GameResult = "Победа";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
        }
        if (PlayerScore == 2 && EnemyScore == 3)
        {
            GameResult = "Проиграл";
            ResultText.text = GameResult;
        }

        if (PlayerScore == 3 && EnemyScore == 1)
        {
            GameResult = "Проиграл";
            ResultText.text = GameResult;
        }
        if (PlayerScore == 3 && EnemyScore == 2)
        {
            GameResult = "Победа";
            ResultText.text = GameResult;
            Score++;
            ScoreText.text = Score.ToString();
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
