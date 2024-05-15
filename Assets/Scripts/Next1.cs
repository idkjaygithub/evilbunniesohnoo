using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next1 : MonoBehaviour
{
    public void LoadAnotherScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}