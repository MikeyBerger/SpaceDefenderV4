using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideEnemy1 : MonoBehaviour
{
    private Transform TheSpawner;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        TheSpawner = GameObject.FindGameObjectWithTag("SideSpawner1").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(TheSpawner.rotation.x, TheSpawner.rotation.y, TheSpawner.rotation.z) * Speed * Time.deltaTime);
    }
}
