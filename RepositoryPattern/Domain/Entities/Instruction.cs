﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entities
{
    public class Instruction 
    {
        public int Id { get; set; }

        [Column(TypeName = "text")]
        public string Detail { get; set; }
        public string Tip { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

    }
}
