using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestOne : MonoBehaviour
{
    public Text textValue;
    public TextMesh textElement;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("PAPA");
        textElement.text = textValue.text;
    }
}
