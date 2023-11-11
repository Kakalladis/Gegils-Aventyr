using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour
{
    // Start is called before the first frame update

    public void startGame()
     {
        SceneManager.LoadScene("gegilsBana");
     }

     public void exitGame()
     {
        Application.Quit();
        
     }
    
}
