using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonGenerator : MonoBehaviour
{
    public GameObject numberHandler, aimHandler;
    private List<int> numbers;
    private int[] numbersArray;
    public GameObject[] buttons;
    private int sum = 0, ansN, temp;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Starting...");
        ansN = Random.Range(4, 14);
        List<int> numbers = new List<int>();
        //Debug.Log(ansN);
        for(int i = 0; i < ansN; i++){
            Debug.Log("ansN done");
            temp = Random.Range(1, 15);
            numbers.Add(temp);
            sum = sum + temp;
        }
        //Debug.Log("Populating ans done!");
        for(int i = 0; i < (16 - ansN); i++){
            temp = Random.Range(1, 15);
            numbers.Add(temp);
        }
        numberHandler.GetComponent<numberGenerator>().giveNumber(sum);
        // shuffle numbers list
        for (int i = 0; i < numbers.Count; i++) {
            int temp = numbers[i];
            int randomIndex = Random.Range(i, numbers.Count);
            numbers[i] = numbers[randomIndex];
            numbers[randomIndex] = temp;
        }
        //Debug.Log("Shuffling Done!");
        //for (int i = 0; i < numbers.Count; i++){
            //Debug.Log(i.ToString() + ") " + numbers[i].ToString());
        //}
        // assign list to buttons
        numbersArray = numbers.ToArray();
        for (int i = 0; i < numbers.Count; i++) {
            buttons[i].GetComponent<buttonRegen>().updateText(numbersArray[i].ToString());
        }
        aimHandler.GetComponent<targetClick>().setTarget(ansN);
        //Debug.Log("All Done!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
