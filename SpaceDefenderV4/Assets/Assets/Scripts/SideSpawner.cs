using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpawner : MonoBehaviour
{
    public Transform[] Ships;
    public float Limit;
    public float SpawnTimer;
    public bool StartSpawning = false;
    //public int MyScore;
    //private SaveSystemV2 SSV2 = new SaveSystemV2();
    private GameMaster GM;

    IEnumerator StopSpawning()
    {
        Instantiate(Ships[0], transform.position, transform.rotation);
        yield return new WaitForSeconds(Limit);
        StartSpawning = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameMaster>();
        //MyScore = GM.Score;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        SpawnTimer += Time.deltaTime;

        

        if (MyScore == MyScore + 10)
        {
            StartSpawning = true;
            //Instantiate(Ships[0], transform.position, transform.rotation);
            //StartCoroutine(StopSpawning());
            //SpawnTimer = 0;
            //StartSpawning = false;
        }


        if (StartSpawning)
        {
            //StartSpawning = true;
            StartCoroutine(StopSpawning());
            StartSpawning = false;
        */

        

        
    }
}
