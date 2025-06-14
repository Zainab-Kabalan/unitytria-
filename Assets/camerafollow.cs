using UnityEngine;

public class camerafollow : MonoBehaviour
{
    [SerializeField] GameObject character;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = character.transform.position + new Vector3(0, 0, -10);

    }
}
