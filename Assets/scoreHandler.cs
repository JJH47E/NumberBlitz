using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class scoreHandler : MonoBehaviour
{
    public GameObject roundHandle, aimHandler;
    public int score;
    public TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("current") == false){
            PlayerPrefs.SetInt("current", 0);
        }
        if(PlayerPrefs.HasKey("hi") == false){
            PlayerPrefs.SetInt("hi", 0);
        }
        score = PlayerPrefs.GetInt("current");
        SceneManager.UnloadSceneAsync("menu");
    }

    // Update is called once per frame
    void Update()
    {
        if(roundHandle.GetComponent<numberGenerator>().roundLost == true){
            if(score > PlayerPrefs.GetInt("hi")){
                PlayerPrefs.SetInt("hi", score);
            }
            PlayerPrefs.SetInt("current", 0);
            Debug.Log("Score reset");
            SceneManager.LoadScene("menu");
        }
        else if(roundHandle.GetComponent<numberGenerator>().roundWon == true){
            score = score + 5 + aimHandler.GetComponent<targetClick>().clicks;
            PlayerPrefs.SetInt("current", score);
            Debug.Log("Round won.");
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
        txt.text = "Score: " + PlayerPrefs.GetInt("current").ToString();
    }
}
