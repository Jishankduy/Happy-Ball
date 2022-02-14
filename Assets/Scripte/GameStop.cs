using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStop : MonoBehaviour
{
    public Button buttonStop;
    public Button buttonResume;
    public GameObject StopImage;
    public Button buttonRestart;
    public Button buttonExit;


    private void Awake() {
        buttonStop.onClick.AddListener(PlayGame);
        buttonResume.onClick.AddListener(Resume);
        buttonExit.onClick.AddListener(Exit);
        buttonRestart.onClick.AddListener(Restart);

    }

    private void PlayGame() {
        StopImage.SetActive(true);
        
    }

    private void Resume()
    {
        StopImage.SetActive(false);
    }

    void Exit()
	{
        SceneManager.LoadScene(0);
	}

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene(1);
    }
}
