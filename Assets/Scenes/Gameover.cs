using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StatScene");
        }
    }
}
