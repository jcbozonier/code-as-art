using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CodeArt_Piece1.Poem;

namespace CodeArt_Piece1
{
    public class Woman : Person
    {
        public Woman()
        {
            Face = new Face(this);
            Hand = new object();
            Eyes = new object();
        }

        public Face Face;
        public object Hand;
        public object Eyes;
        private uint _Moments = uint.MaxValue - 6;

        public void Move(object hand)
        {
            Debug.Write(" but your hand moves,\n");
            A_Moment_Passes();
        }

        public void Open(object eyes)
        {
            Debug.Write(" your eyes open.\n");
            A_Moment_Passes(); 
        }

        public A_Sight See(object face)
        {
            A_Moment_Passes();
            return new A_Sight();
        }

        public override void A_Moment_Passes()
        {
            _Moments++;
        }
    }

    public class A_Sight
    {
        public bool Is_Alive()
        {
            Debug.Write("And see my face alive");
            return true;
        }
    }
}
