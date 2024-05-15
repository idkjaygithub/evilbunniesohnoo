using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreFight : MonoBehaviour
{
    public void LoadAnotherScene()
    {
        SceneManager.LoadScene("Scene2Path1");
    }
}