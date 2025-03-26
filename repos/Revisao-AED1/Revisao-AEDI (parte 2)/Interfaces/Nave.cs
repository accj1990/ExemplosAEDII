namespace interfaces
{
    public interface Nave
    {
        protected string Type { get; set; }
        protected string Name { get; set; }
        protected int Life { get; set; }
        protected int Attack { get; set; }
        protected int Defense { get; set; }

        public void AttackEnemy(int attacker, int defense);

    }
}
