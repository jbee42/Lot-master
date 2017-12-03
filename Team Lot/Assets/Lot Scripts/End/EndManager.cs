using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour {

    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
