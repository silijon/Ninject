﻿using System;
using Ninject.Bindings;

namespace Ninject
{
	public class NamedAttribute : ConstraintAttribute
	{
		public string Name { get; set; }

		public NamedAttribute(string name)
		{
			Name = name;
		}

		public override bool Matches(IBinding binding)
		{
			return binding.Name == Name;
		}
	}
}