using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpawner : MonoBehaviour
{

    public Transform RightShip;
    private float Timer = 0;
    private float Limit;
    public float MinLimit;
    public float MaxLimit;
    private WaveCycler WC;

    // Start is called before the first frame update
    void Start()
    {
        WC = GameObject.FindGameObjectWithTag("Ship").GetComponent<WaveCycler>();
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
        if (Timer >= Limit && WC.SpawnDiagonal)
        {
            Instantiate(RightShip, transform.position, transform.rotation);
            Timer = 0;
        }
    }
}
