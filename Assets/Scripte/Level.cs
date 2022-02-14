using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public Button buttonLevel;
    public int level;
    // Start is called before the first frame update
    private void Awake()
    {
        buttonLevel.onClick.AddListener(openLevel);
    }

    void openLevel()
	{
        SceneManager.LoadScene(level);
	}
}
