using UnityEngine;
using TMPro;

public class buttonRegen : MonoBehaviour
{
    public GameObject TargetHandler, aimHandler;
    public bool pressedNumber;
    public TextMeshProUGUI txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        if(pressedNumber == true){
            pressedNumber = false;
            txt.color = new Color(0, 0, 0, 0);
            txt.text = "null";
        }
    }

    public void whenPressed() {
        if(txt.text == "null"){

        }
        else{
            pressedNumber = true;
            //Debug.Log(txt.text + " has been pressed");
            TargetHandler.GetComponent<numberGenerator>().updateTarget(int.Parse(txt.text));
            aimHandler.GetComponent<targetClick>().decrementTarget();
            Debug.Log("Target - 1");
        }
    }

    public void updateText(string i) {
        txt.text = i;
        //Debug.Log("Text Updated");
    }
}
