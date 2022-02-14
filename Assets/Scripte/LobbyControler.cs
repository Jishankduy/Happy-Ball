using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyControler : MonoBehaviour
{
    public Button buttonLevelLobby;
    public Button buttonMainLobby;
    public GameObject LevelLobby;
    public Button buttonExit;


    private void Awake() {
        buttonLevelLobby.onClick.AddListener(levelsLobby);
        buttonMainLobby.onClick.AddListener(mainLobby);
        buttonExit.onClick.AddListener(Exit);

    }

    private void levelsLobby() {
        LevelLobby.SetActive(true);
        
    }

    private void mainLobby()
    {
        LevelLobby.SetActive(false);
    }

    void Exit()
	{
        //UnityEditor.EditorApplication.isPlaying = false;
		Debug.Log("has quit game");
		Application.Quit();
	}

    
}
