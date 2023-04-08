using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour
{
   
    [SerializeField] string _nextLevelName;
    
   

    public void GoToNextLevel()
    {
        Debug.Log("Go to level" + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

    
}
