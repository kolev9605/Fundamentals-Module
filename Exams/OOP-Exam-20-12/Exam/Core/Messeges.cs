namespace Exam.Core
{
    public static class Messeges
    {
        public const string NotSupportedBehavior = "No such behavior supported";
        public const string NotSupportedCommand = "Unsupplied command";
        public const string NotSupportedAttack = "No such attack supported";
        public const string NullBlobReference = "Blob cannot be null";
        public const string NegativeDamage = "Blob's damage cannot be negative";
        public const string NegativeHealth = "Blob's health cannot be negative";
        public const string NullBehaviorReference = "Behavior cannot be null";
        public const string NullAttackReference = "Attack type cannot be null";
        public const string NullNameReference = "Name cannot be null";
        public const string DeadBlob = "The blob is dead";
        public const string BlobFormatIfAlive = ": {0} HP, {1} Damage";
        public const string BlobFormatIfDead = " KILLED";
        public const string BlobInitialFormat = "Blob {0}";
        public const string BlobKilledEvent = "Blob {0} was killed";
        public const string BehaviorToggleEvent = "Blob {0} toggled {1}";
        public const string NullUserInterface = "The user interface cannot be null.";
    }
}
