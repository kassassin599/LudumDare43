﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")|| collision.collider.CompareTag("Default"))
        {
            print("LEVEL COMPLETE");
            PassedMenu.passed = true;
        }
        if (collision.collider.CompareTag("Enemy"))
        {
            FailedMenu.failed = true;
        }
    }
}
