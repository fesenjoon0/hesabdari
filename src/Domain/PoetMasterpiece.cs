﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class PoetMasterpiece
    {
        public PoetMasterpiece()
        {
            PoemIndices = new HashSet<PoemIndex>();
            Poems = new HashSet<Poem>();
        }

        public Guid Id { get; set; }
        public Guid PoetId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public virtual Poet Poet { get; set; }
        public virtual ICollection<PoemIndex> PoemIndices { get; set; }
        public virtual ICollection<Poem> Poems { get; set; }
    }
}