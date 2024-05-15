using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House : MonoBehaviour
{
    public void LoadAnotherScene()
    {
        SceneManager.LoadScene("Scene1Path2");
    }
}