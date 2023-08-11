using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class GameUIHandler : MonoBehaviour
    {
        public void LoadNextScene()
        {
            var nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            if (SceneManager.sceneCountInBuildSettings <= nextScene)
                return;
            SceneManager.LoadScene(nextScene);
        }
        
        public void LoadPreviousScene()
        {
            var previousScene = SceneManager.GetActiveScene().buildIndex - 1;
            if (previousScene < 0)
                return;
            SceneManager.LoadScene(previousScene);
        }
    }
}
