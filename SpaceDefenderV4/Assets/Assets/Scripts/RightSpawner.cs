using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSpawner : MonoBehaviour
{
    public Transform RightShip;
    private float Timer = 0;
    private float Limit;
    public float MinLimit;
    public float MaxLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Limit = Random.Range(MinLimit, MaxLimit);

        Timer += Time.deltaTime;

        SpawnShip();
    }

    void SpawnShip()
    {
        if (Timer >= Limit)
        {
            Instantiate(RightShip, transform.position, transform.rotation);
            Timer = 0;
        }
    }
}
