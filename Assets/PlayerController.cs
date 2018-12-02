using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    float speed = 10f;

	void Start () {
        transform.GetComponent<PlayerController>().enabled = true;
    }
	
	void Update () {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), 0f).normalized;
        transform.Translate(input * speed * Time.deltaTime);
	}

   
}
