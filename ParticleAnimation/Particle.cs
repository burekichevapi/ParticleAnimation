namespace ParticleAnimation
{
    public abstract class Particle
    {
        public static class Type
        {
            public const char RIGHT_PARTICLE = 'R';
            public const char LEFT_PARTICLE = 'L';
            public const char NULL_PARTICLE = '.';
        }

        protected int _position;
        protected int _speed;
        
        public Particle(int position, int speed)
        {
            _position = position;
            _speed = speed;
        }

        public abstract void Move();

        public int Position => _position;
    }
}
