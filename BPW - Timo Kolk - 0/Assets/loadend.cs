
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadend : MonoBehaviour
{
   public void LoadEnd ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
