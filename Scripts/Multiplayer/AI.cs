using UnityEngine;
using System.Collections;
 
 public class AI : MonoBehaviour
{

    public Transform target;//set target from inspector instead of looking in Update
    public Transform target2;
    public float moveSpeed = 5; //move speed
    public float rotationSpeed = 5; //speed of turning


    void Start()
    {

    }

    void Update()
    {

        //rotate to look at the player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, 0, 0), Space.Self);//correcting the original rotation


        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
     
        }

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
            //move towards the player
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
    }

}