using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class VictoryDoors : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Task.Run(async () => await Task.Delay(2000));
            SceneManager.LoadScene("win");
        }
    }
}
