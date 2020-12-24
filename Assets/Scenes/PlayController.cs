using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    Rigidbody2D rigid2D;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)) {
            this.transform.Translate (-0.3f,0.0f,0.0f);
      }
        // 右に移動
        if (Input.GetKey (KeyCode.RightArrow)) {
            this.transform.Translate (0.3f,0.0f,0.0f);
      }
    }
}
