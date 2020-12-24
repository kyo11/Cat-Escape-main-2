using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    int hpflag = 10;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        hpflag -= 1;

        if (hpflag == 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }
}
