﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_CampFinalProject.Dtos.ShoppingList
{
    public class UpdateShoppingListDTO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string UserId { get; set; }
        public string ListName { get; set; }
    }
}
