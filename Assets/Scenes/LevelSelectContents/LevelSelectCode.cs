using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartLevel1()
    {
        // Changes the scene to Level 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void LevelSelecttoTitle()
    {
        // Changes to scene to the title screen
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
