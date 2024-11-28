public class PlayerHealth : CharacterHealth
{
    public HpBar hpBar;

    public override void Start()
    {
        base.Start();
        hpBar.SetHpPercent(1);
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        float hpPercent = currentHealth / maxHealth;
        hpBar.SetHpPercent(hpPercent);
    }
}