using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript01 : MonoBehaviour
{
    public float toughness;
    Vector3 scaleChange = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 worldPos2D = new Vector2(worldPos.x, worldPos.y);
        Vector2 resourcePos = new Vector2(transform.position.x, transform.position.y);
        if (worldPos2D == resourcePos) {
            gameObject.transform.localScale += scaleChange;
        }
    }
}
