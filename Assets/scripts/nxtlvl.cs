
using UnityEngine;
using UnityEngine.SceneManagement;

public class nxtlvl : MonoBehaviour
{
    public void loadnxtlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
