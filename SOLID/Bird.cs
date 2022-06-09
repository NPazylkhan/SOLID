namespace SOLID
{
    /// <summary>
    /// Liskov Substitution Principle
    /// </summary>
    public class Bird
    {
    }

    public class FlyingBird : Bird
    {
        public void Fly() { }
    }

    public class Ostrich : Bird { }

    public class Pigeon:FlyingBird { }
}
