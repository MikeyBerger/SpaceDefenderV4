using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightEnemyScript : MonoBehaviour
{
    private Transform SS1;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        SS1 = GameObject.FindGameObjectWithTag("SideSpawner1").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(SS1.rotation.x, SS1.rotation.y, SS1.rotation.z) * Speed * Time.deltaTime);
    }
}
