using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveCycler : MonoBehaviour
{
    public Transform[] VerticalSpawners;
    public Transform[] DiagonalSpawners;
    public Transform[] HorizontalSpawners;
    public Transform VerticalEnemy;
    public Transform LeftDiagonalEnemy;
    public Transform RightDiagonalEnemy;
    public Transform HorizontalEnemy1;
    public Transform HorizontalEnemy2;
    public bool SpawnVertical = false;
    public bool SpawnDiagonal = false;
    public bool SpawnHorizontal = false;
    public int RandWave;
    public float Limit;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        RandWave = Random.Range(0, 100);

        if(RandWave <= 50 && Timer >= Limit)
        {
            SpawnVertical = true;
            SpawnDiagonal = false;
            SpawnHorizontal = false;
            Timer = 0;
        }
        else if (RandWave >= 50 && Timer >= Limit)
        {
            SpawnDiagonal = true;
            SpawnHorizontal = false;
            SpawnVertical = false;
            Timer = 0;
        }
        /*
        else if (RandWave == 3 && Timer >= Limit)
        {
            SpawnHorizontal = true;
            SpawnVertical = false;
            SpawnDiagonal = false;
            Timer = 0;
        }
        */
    }
}
