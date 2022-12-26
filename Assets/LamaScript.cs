using System.IO.MemoryMappedFiles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamaScript : MonoBehaviour
{
    public Rigidbody2D myRigitBody;
    public float flapStrength;
    public LogicManagerScript logicManagerScript;
    public bool lamaIsALive = true;

    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

        gameObject.name="Bob";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && lamaIsALive){
        myRigitBody.velocity=Vector2.up*flapStrength;
            // myRigitBody.
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManagerScript.gameOver();
        lamaIsALive = false;
    }
}
