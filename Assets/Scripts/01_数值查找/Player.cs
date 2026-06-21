public class Player
{
    public string name = string.Empty;
    public uint hp = 0;
    public uint mp = 0;
    public float speed = 0;
    public Player(string name, uint hp)
    {
        this.name = name;
        this.hp = hp;
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