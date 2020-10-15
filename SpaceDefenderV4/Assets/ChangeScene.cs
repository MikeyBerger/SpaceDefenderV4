using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private OOPsScript OOPs;
    private IncScript INC;
    public string MainMenu;
    public float WaitTime;

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(MainMenu);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SceneChange());
    }
}
