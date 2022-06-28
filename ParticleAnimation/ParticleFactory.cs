namespace ParticleAnimation
{
    public class ParticleFactory
    {
        public static Particle Create(char particleType, int speed, int position)
        {
            return particleType switch
            {
                Particle.Type.RIGHT_PARTICLE => new RightParticle(position, speed),
                Particle.Type.LEFT_PARTICLE => new LeftParticle(position, speed),
                Particle.Type.NULL_PARTICLE => new NullParticle(position, speed),
                _ => throw new NotImplementedException("Particle does not exisit."),
            };
        }
    }
}
