using UnityEngine;
using UnityEngine.SceneManagement;


public class GMainMenuScript : MonoBehaviour
{
    public GameObject settingsPanel;
     public GameObject mainmenu;


    public void OpenGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void exit()
    {
        settingsPanel.SetActive(false);
    }
    
}
    