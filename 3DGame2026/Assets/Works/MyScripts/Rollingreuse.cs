using UnityEngine;
using System.Collections;
public class Rollingreuse : MonoBehaviour // this is the rolling behaviour...
{
    public float rollForce = 12f;
    public float rollCooldown = 2f;

    public bool isRolling = false; //This is for enemyfollow specifically, will delete for others

    private Rigidbody rb; //this focuses on the rigidbody which IS required in order for the movements to work
    private bool canRoll = true;

    void Awake()
    {
        rb = GetComponent<Rigidbody>(); //for the roll
    }


    public void Roll(Vector3 direction)
    {
        if (!canRoll) return;
        canRoll = false;
       

        rb.linearVelocity = Vector3.zero; //this focuses on making the roll movement reset velocity 

        StartCoroutine(Cooldown());
    }

    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(rollCooldown);
        canRoll = true;
    }
}