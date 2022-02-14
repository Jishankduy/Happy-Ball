using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int nextSceneLoad;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        
        {
            SceneManager.LoadScene(nextSceneLoad);
        }
    
    
    }
}
