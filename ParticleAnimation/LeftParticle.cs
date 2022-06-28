namespace ParticleAnimation
{
    public class LeftParticle : Particle
    {
        public LeftParticle(int position, int speed) : base(position, speed) {}

        public override void Move() => _position -= _speed;
    }
}
