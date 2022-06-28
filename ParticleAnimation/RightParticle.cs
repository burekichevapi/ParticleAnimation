namespace ParticleAnimation
{
    public class RightParticle : Particle
    {
        public RightParticle(int position, int speed) : base(position, speed) { }

        public override void Move() => _position += _speed;
    }
}
