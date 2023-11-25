using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Go : MonoBehaviour
{

    public void OnStartGame(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
