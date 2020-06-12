using UnityEngine;
using TMPro;

public class targetClick : MonoBehaviour
{

    public int clicks;
    public TextMeshProUGUI aim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aim.text = "Move Target: " + clicks.ToString();
    }

    public void setTarget(int i){
        clicks = i;
        //Debug.Log("Target Clicks: " + clicks.ToString());
    }

    public void decrementTarget(){
        clicks = clicks - 1;
    }
}
