using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Test");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
