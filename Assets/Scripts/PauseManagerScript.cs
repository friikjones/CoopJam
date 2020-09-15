using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManagerScript : MonoBehaviour {

    public GameObject pauseCanvas;
    public bool paused;

    void Start() {
        // GameObject.Find("Canvas").GetComponent<GameObject>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            paused = !paused;
        }
        if (paused) {
            pauseCanvas.SetActive(true);
        } else {
            pauseCanvas.SetActive(false);
        }
    }
}
