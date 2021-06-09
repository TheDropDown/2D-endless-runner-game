using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 updatePos;
    public float height;
    public float speed,upBound,lowBound;
   public GameObject effect;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, updatePos , speed*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow)&&transform.position.y<upBound)
        {
            anim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            updatePos = new Vector2(transform.position.x, transform.position.y + height);
            
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)&&transform.position.y > lowBound)
        {
            anim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            updatePos = new Vector2(transform.position.x, transform.position.y - height);
            
        }

    }
}
