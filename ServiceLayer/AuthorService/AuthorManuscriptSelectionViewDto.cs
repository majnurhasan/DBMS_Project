﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AuthorService
{
    public class AuthorManuscriptSelectionViewDto
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}
