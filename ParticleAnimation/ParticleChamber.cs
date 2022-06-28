using System.Text;

namespace ParticleAnimation
{
    public class ParticleChamber
    {
        private readonly List<string> _chamberHistory = new();
        
        private readonly int _chamberSize;
        private readonly Chamber _leftChamber;
        private readonly Chamber _rightChamber;

        public ParticleChamber(int speed, string init)
        {
            _chamberSize = init.Length;
            _leftChamber = new Chamber(init, speed, Particle.Type.LEFT_PARTICLE);
            _rightChamber = new Chamber(init, speed, Particle.Type.RIGHT_PARTICLE);

            _chamberHistory.Add(GetSnapshot());
        }

        public List<string> ChamberHistory => _chamberHistory;

        public void Run()
        {
            while (_leftChamber.HasParticles() || _rightChamber.HasParticles()) {
                _leftChamber.MoveParticles();
                _rightChamber.MoveParticles();
                
                _leftChamber.UpdatedChamber();
                _rightChamber.UpdatedChamber();

                _chamberHistory.Add(GetSnapshot());
            }
        }

        private string GetSnapshot()
        {
            var snapShot = new StringBuilder();

            for (int position = 0; position < _chamberSize; position++)
            {
                bool isLeftNull = Chamber.IsNullParticle(_leftChamber.Particles[position]);
                bool isRightNull = Chamber.IsNullParticle(_rightChamber.Particles[position]);
                
                if (isLeftNull && isRightNull)
                    snapShot.Append(Particle.Type.NULL_PARTICLE);
                else 
                    snapShot.Append('X');
            }

            return snapShot.ToString();
        }
    }
}
