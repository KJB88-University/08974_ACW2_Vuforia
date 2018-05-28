using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    PLACE_TRAY,
    MAKE_TEA
}

public class WorldManager : Singleton<WorldManager>
{
    [SerializeField]
    GameObject tray;

    [SerializeField]
    GameObject[] objects;

    [SerializeField]
    TextMesh uiText;

    [SerializeField]
    TextMesh placeTray;

    public GameState gameState = GameState.PLACE_TRAY;

    public void StartGame()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].gameObject.SetActive(true);
        }

        gameState = GameState.MAKE_TEA;

        placeTray.gameObject.SetActive(false);
        uiText.gameObject.SetActive(true);
    }


}
