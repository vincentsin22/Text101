using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //this was added so we can use the variable Text in line 9. This is because Text is a part of the UI and it needs to be identified. 

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent; //[serializeField] is used in front of variables so we can make this available in the Unity Inspector. If we check, textComponent will be available. 
                                         //Text is a type of variable. textComponent is the variable name (I Think)

    [SerializeField] State startingState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        //the dot after textComponent means it will access the text within it 
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
