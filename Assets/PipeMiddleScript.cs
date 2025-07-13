using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
         GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");

    if (logicObject != null)
    {
        logic = logicObject.GetComponent<LogicScript>();
        if (logic == null)
            Debug.LogError("LogicScript not found on the object tagged 'Logic'");
    }
    else
    {
        Debug.LogError("GameObject with tag 'Logic' not found in scene!");
    }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered trigger: " + collision.gameObject.name);
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            Debug.Log("Score added!");
        }
        
    }
}
