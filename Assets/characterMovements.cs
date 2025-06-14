using UnityEngine;

public class demoH1 : MonoBehaviour
{   //speed of moving 
    float walkspeedLR = 3f;
    float walkspeedUD = 3f;
    void Start()
    {

    }

    void Update()
    {    //move along the horizantal axes
        walkspeedLR = Input.GetAxis("Horizontal") * Time.deltaTime;
        //move along the Vertical axes
        walkspeedUD = Input.GetAxis("Vertical") * Time.deltaTime;
        //keep character from rotating cuz GODDAMIT IT KEEO MOVING Z 
        transform.rotation = Quaternion.Euler(0, 0, 0);
        //move to left and right
        transform.Translate(walkspeedLR, 0, 0);
        //move to up and down
        transform.Translate(0, walkspeedUD, 0);
    }
}
