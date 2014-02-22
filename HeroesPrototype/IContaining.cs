using System;
using System.Collections.Generic;
using System.Linq;
using HeroesPrototype.Items;

namespace HeroesPrototype
{
	interface IContaining
	{
		List<Item> Items { get; set; }
	}
}
