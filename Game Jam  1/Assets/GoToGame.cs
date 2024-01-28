using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Idk";

    public void GoToSkelli()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    
}
