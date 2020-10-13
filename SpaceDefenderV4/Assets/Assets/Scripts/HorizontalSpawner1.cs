using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSpawner1 : MonoBehaviour
{
    public Transform EnemyShip;
    public float Limit;
    private float Timer;
    private WaveCycler WC;

    // Start is called before the first frame update
    void Start()
    {
        WC = GameObject.FindGameObjectWithTag("Ship").GetComponent<WaveCycler>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= Limit && WC.SpawnHorizontal)
        {
            Instantiate(EnemyShip, transform.position, transform.rotation);
        }
    }
}
