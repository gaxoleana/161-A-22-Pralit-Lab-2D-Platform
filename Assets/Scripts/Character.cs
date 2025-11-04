using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //Attributes
    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }
    private int maxHealth;

    protected Animator anim;
    protected Rigidbody2D rb;
    [SerializeField] HealthBar healthBar;

    public void Initialize(int startHealth)
    {
        Health = startHealth;
        maxHealth = startHealth;
        Debug.Log($"{this.name} is initialed Health : {Health}");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        healthBar = GetComponentInChildren<HealthBar>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        healthBar.UpdateHealthBar(Health, maxHealth);
        Debug.Log($"{this.name} took damage {damage}. Current Health: {Health}");

        IsDead();
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
