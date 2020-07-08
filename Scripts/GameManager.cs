using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public void gameOver()
    {
        SceneManager.LoadScene(0);
    }
}
