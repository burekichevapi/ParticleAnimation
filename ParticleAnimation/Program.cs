// See https://aka.ms/new-console-template for more information


using ParticleAnimation;

static void Animate(int speed, string init)
{
    var particleChamber = new ParticleChamber(speed, init);
    particleChamber.Run();
    particleChamber.ChamberHistory.ForEach(snapShot => Console.WriteLine(snapShot));
}

Console.WriteLine(0);
Animate(2, "..R....");
Console.WriteLine();

Console.WriteLine(1);
Animate(3, "RR..LRL");
Console.WriteLine();

Console.WriteLine(2);
Animate(2, "LRLR.LRLR");
Console.WriteLine();

Console.WriteLine(3);
Animate(10, "RLRLRLRLRL");
Console.WriteLine();

Console.WriteLine(4);
Animate(1, "...");
Console.WriteLine();

Console.WriteLine(5);
Animate(1, "LRRL.LR.LRR.R.LRRL.");
Console.WriteLine();
