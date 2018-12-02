using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    Vector2 origin;

    [SerializeField]
    GameObject player;

    void Start () {
        origin = new Vector2(-8.5f, 1.13f);
    }
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<PlayerController>().enabled = false;
            Instantiate(player, origin, Quaternion.identity);
        }
    }
}
