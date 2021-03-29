using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepControler : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 target;
    private Vector3 mousePos;
    [SerializeField]private float minX = -5.5f;
    [SerializeField]private float maxX = 5.5f;
    [SerializeField]private float minY = -3f;
    [SerializeField]private float maxY = 3f;
    [SerializeField] private float moveSpeed = 1;
    void Start()
    {
        mousePos = transform.position;
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        print(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
           mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), 0);
        }
        transform.position = Vector3.Lerp(transform.position, mousePos, moveSpeed*Time.deltaTime);
    }
}
