using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerLose : MonoBehaviour
{
    public void TryAgain(string menuName)
    {
        SceneManager.LoadScene(menuName);
    }
}
