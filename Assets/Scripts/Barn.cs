using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barn : MonoBehaviour
{
    public void LoadAnotherScene()
    {
        SceneManager.LoadScene("Scene1Path1");
    }
}