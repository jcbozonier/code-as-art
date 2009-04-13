using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeArt_Piece1.Poem
{
    public abstract class Person : IAmImpermanent
    {
        public static Union operator +(Person p1, Person p2)
        {
            return new Union(p1, p2);
        }

        public abstract void A_Moment_Passes();
    }
}
