using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeArt_Piece1.Poem
{
    public class Union : IAmImpermanent
    {
        private Person _P1;
        private Person _P2;

        public Union(Person p1, Person p2)
        {
            _P1 = p1;
            _P2 = p2;
        }

        public bool Leave(object tomb)
        {
            A_Moment_Passes();
            return true;
        }

        public void Look_Forward_To(Union we)
        {
            A_Moment_Passes();
        }

        public void A_Moment_Passes()
        {
            _P1.A_Moment_Passes();
            _P2.A_Moment_Passes();
        }
    } 
}
