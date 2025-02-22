using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene(2);
    }
}
