using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldManager : Singleton<WorldManager>
{
    public void ResetWorld()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
