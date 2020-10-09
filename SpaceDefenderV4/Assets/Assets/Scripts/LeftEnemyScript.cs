using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEnemyScript : MonoBehaviour
{
    private Transform SS2;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        SS2 = GameObject.FindGameObjectWithTag("SideSpawner2").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(SS2.rotation.x, SS2.rotation.y, 0) * Speed * Time.deltaTime);
    }
}
