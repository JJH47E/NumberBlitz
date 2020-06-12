using UnityEngine;
using TMPro;

public class numberGenerator : MonoBehaviour
{
    public TextMeshProUGUI target;
    public bool newTarget, roundWon, roundLost;
    public int targetNumber, givenTarget;
    // Start is called before the first frame update
    void Start()
    {
        newTarget = true;
        roundWon = false;
        roundLost = false;
    }

    // Update is called once per frame
    void Update()
    {
        target.text = targetNumber.ToString();
        if(targetNumber == 0){
            roundWon = true;
        }
        else if(targetNumber < 0){
            //Debug.Log("ROUND LOST");
            roundLost = true;
        }
    }

    void FixedUpdate(){
        if(newTarget == true){
            newTarget = false;
            targetNumber = givenTarget;
            target.text = targetNumber.ToString();
        }
    }

    public void updateTarget(int i){
        targetNumber = targetNumber - i;
    }

    public void giveNumber(int i){
        givenTarget = i;
        Debug.Log("Number Assigned!");
    }
}
