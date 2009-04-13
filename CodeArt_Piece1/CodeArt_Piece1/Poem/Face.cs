using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodeArt_Piece1.Poem
{
    public class Face
    {
        public Face(IAmImpermanent entity)
        {
            _Entity = entity;
            Feelings = new List<Feeling_Of>();
        }

        private bool _is_Cold = true;
        public bool Is_Cold
        {
            get
            {
                Debug.Write(" and your cold");
                return _is_Cold;
            }
            set
            {
                _is_Cold = value;
            }
        }

        private bool _is_quiet = true;
        public bool Is_Quiet
        {
            get
            {
                Debug.Write(" quieted face\n");
                return _is_quiet;
            }
            set
            {
                _is_quiet = value;
            }
        }

        public List<Feeling_Of> Feelings;
        private IAmImpermanent _Entity;

        public void Contains(params Feeling_Of[] feelings)
        {
            foreach (var feeling in feelings)
            {
                if(Feeling_Of.Warmth == feeling)
                    Debug.Write(" with warmth");
                if(Feeling_Of.Happiness == feeling)
                    Debug.Write(" and happiness.");
                _Entity.A_Moment_Passes();
                Feelings.Add(feeling);
            }
        }
    }
}
