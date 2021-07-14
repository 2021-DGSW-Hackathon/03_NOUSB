using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceanM : MonoBehaviour
{
    private static SceanM instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
            

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartG()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ContG()
    {
        SceneManager.LoadScene("Game");
    }
    public void FirstG()
    {
        SceneManager.LoadScene("StartG");
    }
    // Start is called before the first frame update

}
