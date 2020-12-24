using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    // GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        // this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    
        // transform.Translate(0, -0.1f, 0);

        // if (transform.position.y < -5.0f)
        // {
        //     Destroy(gameObject);
        // }

        // Vector2 p1 = transform.position;
        // Vector2 p2 = this.player.transform.position;
        // Vector2 distance = p1 - p2;
        // float d = distance.magnitude;
        // float r1 = 0.5f;
        // float r2 = 1.0f;

        // if (d < r1 + r2)
        // {
        //     // GameObject director = GameObject.Find("GameDirector");
        //     // director.GetComponent<GameDirector>().DecreaseHp();
            
        //     Destroy(gameObject);
        // }
    
    void Update () {
		transform.Translate (0, 0, 0);

        

		// if (transform.position.y > 5) {
		// 	Destroy (gameObject);
		// }
	}

	void OnTriggerEnter2D(Collider2D coll) {
		// Destroy (coll.gameObject);
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseHp();
		Destroy (gameObject);
	}
    
}
