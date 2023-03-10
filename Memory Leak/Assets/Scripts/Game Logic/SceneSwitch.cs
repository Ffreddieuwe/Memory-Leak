using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("DemoLevel"))
        {
            SceneManager.LoadScene("DemoLvl2");
            
        }
        else if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("DemoLvl2"))
        {
            SceneManager.LoadScene("DemoLevel");
        }
        
        
    }
}
