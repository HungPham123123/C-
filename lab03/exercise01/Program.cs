using System;

class Program
{
    static void Main()
    {
        const int maxAtoms = 10;
        Atom[] atoms = new Atom[maxAtoms];

        Console.WriteLine("Atomic Information");
        Console.WriteLine("==================");

        for (int i = 0; i < maxAtoms; i++)
        {
            atoms[i] = new Atom();

            while (!atoms[i].Accept())
            {
                // Retry input if it's invalid
            }
        }

        Console.WriteLine("No  Sym Name      Weight");
        Console.WriteLine("------------------------");

        foreach (Atom atom in atoms)
        {
            atom.Display();
        }
    }
}
