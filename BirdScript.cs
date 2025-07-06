using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float dieZone;
    public float heighZone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive) 
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
        if (transform.position.y < dieZone) 
        {
            logic.gameOver();
            birdIsAlive = false;
            Destroy(gameObject);
        }

        if (transform.position.y > heighZone)
        {
            logic.gameOver();
            birdIsAlive = false;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}


// *IMPORTANT* If you get this error in Unity: nvalidOperationException: "You are trying to read Input using the UnityEngine.Input class, but you have switched active Input handling to Input System package in Player Settings" Remember that this is the link to show you how to fix it: https://stackoverflow.com/questions/65027247/unity-conflict-between-new-inputsystem-and-old-eventsystem

// *IMPORTANT* Remember how the first time you used it the Intillisense/Auto-Completion wasn't working? Well that was a pain in the ass to deal with but here are the solutions that took literally hours to find: Video: https://www.youtube.com/watch?v=ihVAKiJdd40 Forgot where to find prefrences? Here: https://discussions.unity.com/t/cant-see-preferences-under-edit/918156/4 look for "daniele-ferrari-work" You are so welcome holy shit please never need this again. 