using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLoop : MonoBehaviour
{
    public GameObject powerup;
    public float speed;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

    }

    void Update()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("DemoLevel"))
        {
            float y = Mathf.PingPong(Time.time * speed, 0.5f);
            powerup.transform.localPosition = new Vector3(-0.09f, y, -0.85f);
        }

        else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("DemoLvl2"))
        {
            float y = 28 + (Mathf.PingPong(Time.time * speed, 0.5f));
            powerup.transform.localPosition = new Vector3(5, y, 0);
        }



    }
}
