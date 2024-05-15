using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death1 : MonoBehaviour
{
    public void LoadAnotherScene()
    {
        SceneManager.LoadScene("Home_Screen");
    }
}