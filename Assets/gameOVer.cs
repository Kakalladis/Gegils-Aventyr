using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOVer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        SceneManager.LoadScene("gameOver");
    }
}
