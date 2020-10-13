using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightEnemyScript : MonoBehaviour
{
    private Transform SS1;
    public float Speed;
    private Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        SS1 = GameObject.FindGameObjectWithTag("SideSpawner1").GetComponent<Transform>();
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector3(SS1.rotation.x, SS1.rotation.y, 0) * Speed * Time.deltaTime;
        transform.Translate(new Vector3(SS1.rotation.x, SS1.rotation.y, 0) * Speed * Time.deltaTime);
    }
}
