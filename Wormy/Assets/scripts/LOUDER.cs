using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOUDER : MonoBehaviour
{
    public void LoudFirstLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }
}
