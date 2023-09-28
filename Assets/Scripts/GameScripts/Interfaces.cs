public interface IDestructable
{
    void Destroy();
}

public interface IDamageble<T>
{
    void TakeDamage(T damageTaken);
}
