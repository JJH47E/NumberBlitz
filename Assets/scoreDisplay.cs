using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class scoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private bool gameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.UnloadSceneAsync("game");
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "HiScore: " + PlayerPrefs.GetInt("hi").ToString();
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            gameStart = true;
        }
    }

    void FixedUpdate() {
        if(gameStart == true){
            gameStart = false;
            SceneManager.LoadScene("game");
        }
    }
}
