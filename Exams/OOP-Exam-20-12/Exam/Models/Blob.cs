namespace Exam.Models
{
    using System;
    using System.Text;
    using Core;
    using Exceptions;
    using Interface;

    public class Blob : IBlob
    {
        private readonly int initialHealth;

        private int damage;
        private string name;
        private IBehavior behavior;
        private IAttack attack;

        private readonly IUserInterface userInterface;

        public Blob(int damage, int health, string name, IBehavior behavior, IAttack attackType, IUserInterface userInterface)
        {
            this.Damage = damage;
            this.Health = health;
            this.Name = name;
            this.Behavior = behavior;
            this.AttackType = attackType;
            this.InitialDamage = damage;
            this.initialHealth = health;
            this.IsAlive = true;
            this.userInterface = userInterface;
        }

        public bool IsAlive { get; set; }

        public int InitialHealth
        {
            get { return this.initialHealth; }
        }

        public int InitialDamage { get; }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new BlobException(Messeges.NegativeDamage);
                }
                this.damage = value;
            }
        }

        public int Health { get; set; }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(Messeges.NullNameReference);
                }
                this.name = value;
            }
        }

        public IBehavior Behavior
        {
            get { return this.behavior; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(Messeges.NullBehaviorReference);
                }
                this.behavior = value;
            }
        }

        public IAttack AttackType
        {
            get { return this.attack; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(Messeges.NullAttackReference);
                }
                this.attack = value;
            }
        }

        public void Update()
        {
            TriggerToggledEffect();
            if (this.Health <= this.initialHealth / 2)
            {
                TriggerBehavior();
            }
            if (this.Health <= 0)
            {
                this.IsAlive = false;
            }
        }

        public void TriggerToggledEffect()
        {
            this.Behavior.ToggledEffect(this);
        }

        public void TriggerBehavior()
        {
            this.Behavior.Trigger(this);
        }

        public void Attack(IBlob targetBlob)
        {
            this.AttackType.ProcessAttack(this, targetBlob);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(Messeges.BlobInitialFormat, this.Name);
            if (this.Health <= 0)
            {
                builder.Append(Messeges.BlobFormatIfDead);
            }
            else
            {
                builder.AppendFormat(Messeges.BlobFormatIfAlive, this.Health, this.Damage);
            }

            return builder.ToString();
        }
    }
}