using UnityEngine;

public class Move_script : MonoBehaviour
{
    Vector3 pos = new Vector3(1, 0, 0);
    float x_value = 0;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = pos;

    }

    // Update is called once per frame
    void Update()
    {
        x_value += Time.deltaTime;
        pos.x = x_value;
        transform.position = pos;
    }
}
