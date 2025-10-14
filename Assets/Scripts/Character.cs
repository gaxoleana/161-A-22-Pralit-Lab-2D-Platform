using UnityEngine;

public class Character : MonoBehaviour
{
    //Attribute
    private int health;
    public int Health { get => health; set => health = (value < 0) ? 0 : value; }

    protected Animator anim;
    protected Rigidbody rb;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}. Current Health: {Health}");
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log($"{this.name} is dead and destroyed");
            return true;
        }
        return false;
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}
