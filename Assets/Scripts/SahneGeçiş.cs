using UnityEngine;
using UnityEngine.SceneManagement;
public class SahneGeçiş : MonoBehaviour
{
    public void ChangeSceneByIndex()
    {
        SceneManager.LoadScene(2);
    }
}
