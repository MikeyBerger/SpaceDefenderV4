using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

    public SaveSystemV2 SSV2 = new SaveSystemV2();

    public int Score;
    public int HiScore;
    public Text ScoreText;
    public Text HiScoreText;
    public bool SpawnShips = true;
    public Transform[] Ships;
    public Transform TheShip;
    public Transform[] Spawners;
    private Transform TheSpawner;
    private int RandSpawner;
    public float Timer;
    public float Limit;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        HiScore = PlayerPrefs.GetInt("HiScore");
    }

    // Update is called once per frame
    public void Update()
    {
        Timer += Time.deltaTime;

        SpawnShips = true;

        RandSpawner = Random.Range(0, 100);

        if (RandSpawner <= 50)
        {
            TheSpawner = Spawners[0];
        }
        else if (RandSpawner > 50)
        {
            TheSpawner = Spawners[1];
        }

        if (Score > HiScore)
        {
            HiScore = Score;
            PlayerPrefs.SetInt("HiScore", HiScore);
        }

        ScoreText.text = "Score: " + Score.ToString();
        HiScoreText.text = "HighScore: " + HiScore.ToString();

        //SpawnSideShips();
    }

    void SpawnSideShips()
    {
        if (Timer >= Limit)
        {

            if (SpawnShips)
            {
                Instantiate(TheShip, TheSpawner.position, TheSpawner.rotation);
                SpawnShips = false;
            }

            Timer = 0;
        }
    }
}
