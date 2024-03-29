using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel : MonoBehaviour {
    [SerializeField] string sceneName;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Chicken") {
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
        }
    }
}
