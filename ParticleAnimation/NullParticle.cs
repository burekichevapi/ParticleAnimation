namespace ParticleAnimation
{
    public class NullParticle : Particle
    {
        public NullParticle(int position, int speed) : base(position, speed) { }

        public override void Move() => _position += 0;
    }
}
