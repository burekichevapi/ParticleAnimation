namespace ParticleAnimation
{
    public class Chamber
    {
        private readonly int _chamberSize;
        private List<Particle> _chamber;

        public Chamber(string particles, int speed, char particleType)
        {
            _chamberSize = particles.Length;
            _chamber = InitializeChamber(particleType, particles, speed);
        }

        public List<Particle> Particles => _chamber;

        public void MoveParticles() => _chamber.ForEach(p => p.Move());

        public void UpdatedChamber()
        {
            var updatedChamber = new List<Particle>(new Particle[_chamberSize]);

            _chamber.ForEach(particle =>
            {
                if (!IsNullParticle(particle) && IsInChamber(particle))
                    updatedChamber[particle.Position] = particle;
            });

            for (int position = 0; position < _chamberSize; position++)
            {
                if (updatedChamber[position] is null)
                    updatedChamber[position] = ParticleFactory.Create(Particle.Type.NULL_PARTICLE, 0, position);
            }

            _chamber = updatedChamber;
        }

        public bool HasParticles() => _chamber.Any(p => !IsNullParticle(p));

        public static bool IsNullParticle(Particle p) => p.GetType().Equals(typeof(NullParticle));

        public  bool IsInChamber(Particle p) => p.Position >= 0 && p.Position < _chamberSize;

        private List<Particle> InitializeChamber(char particleType, string particles, int speed)
        {
            var chamber = new List<Particle>();

            for (int position = 0; position < _chamberSize; position++)
            {
                var particle = ParticleFactory.Create(Particle.Type.NULL_PARTICLE, speed, position);

                if (particles[position].Equals(particleType))
                    particle = ParticleFactory.Create(particleType, speed, position);

                chamber.Add(particle);
            }

            return chamber;
        }
    }
}
