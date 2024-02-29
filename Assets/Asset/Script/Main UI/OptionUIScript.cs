using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionUIScript : MonoBehaviour
{
    public GameObject warningPopup; 

    public void onClickBack()
    {
        AudioManager.instance.Playsfx(AudioManager.Sfx.select1);
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene("Main Scene");
    }

    public void onClickReset()
    {
        AudioManager.instance.Playsfx(AudioManager.Sfx.select1);
        PlayerPrefs.DeleteAll();
        warningPopup.SetActive(false);
    }

    public void onCloseReset()
    {
        AudioManager.instance.Playsfx(AudioManager.Sfx.select1);
        warningPopup.SetActive(false);
    }

    public void onActivePopup()
    {
        AudioManager.instance.Playsfx(AudioManager.Sfx.select1);
        warningPopup.SetActive(true);
    }
}
