using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("DemoLevel");
        }
    }
}
