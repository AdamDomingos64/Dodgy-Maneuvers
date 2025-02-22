using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneChange : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene(1);
    }
}
