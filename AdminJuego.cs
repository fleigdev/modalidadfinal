using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdminJuego : MonoBehaviour
{
    public void btnCambiarEscena(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
