using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour {

    public void SceneToInitialMenu() {
        SceneManager.LoadScene("InitialMenu", LoadSceneMode.Single);
    }
    public void SceneToOptionsMenu() {
        SceneManager.LoadScene("OptionsMenu", LoadSceneMode.Single);
    }
    public void SceneToLevel1() {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void SceneToQuit() {
        Application.Quit();
    }

}
