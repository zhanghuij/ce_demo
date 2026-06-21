public class Player
{
    public string name = string.Empty;
    public uint hp = 0;
    public uint mp = 0;
    public float speed = 0;
    public int team = 0;
    
    public Player(string name, uint hp, int team = 0)
    {
        this.name = name;
        this.hp = hp;
        this.team = team;
    }
    
    public void Hurt(uint damage)
    {
        hp = hp - damage;
    }

    public void ChangeSpeed(float delta)
    {
        speed = speed + delta;
    }
}