using UnityEngine;
using UnityEngine.SceneManagement;

namespace MDAY2026.TitleScreen
{
    public class TitleScreen : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}