using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

    public Vector2 Location;
    public float maxHealth = 50f;
	private float curHealth = 50f;
    public float deltaHealthBarLength;
	private bool isDead = false;
    private string namedID;

	protected float healthBarLength;
	
	
	// Use this for initialization
	 void Start () 
	{
        curHealth = maxHealth;
		healthBarLength = Screen.width / deltaHealthBarLength;
        namedID = this.tag;
	}
	
	// Update is called once per frame
	 void Update () 
	{

        healthBarLength = (Screen.width / deltaHealthBarLength) * (curHealth / (float)maxHealth);
	}
	
	 void OnGUI()
	{
		GUI.Box (new Rect(Location.x,Location.y, healthBarLength, 20),name + " " + curHealth + "/" + maxHealth);
	}
	
	
	public void TakeDamage(float _value)
	{
		curHealth -= _value;
		
		if(curHealth < 0)
		{
		isDead = true;
		}
		
		if(maxHealth < 1)
			maxHealth = 1;
		
	}
	
	public void Heal(float _value)
	{
		curHealth += _value;
		
		if(curHealth >= maxHealth)
			curHealth = maxHealth;
	}
	
	
	
	//mutators
	public float getMaxHealth(){return maxHealth;}
    public bool IsDead() { return isDead; }
    public float getCurrentHealth() { return curHealth; }
    public float getHealthBarLength() { return healthBarLength; }

    public void setMaxHealth(float _value) { maxHealth = _value; }
    public void setIsDead(bool _value) { isDead = _value; }
    public void getCurrentHealth(float _value) { curHealth = _value; }
    public void getHealthBarLength(float _value) { healthBarLength = _value; }
	
		
}