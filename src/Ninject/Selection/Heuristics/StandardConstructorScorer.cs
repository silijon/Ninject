﻿using System;
using System.Reflection;
using Ninject.Syntax;

namespace Ninject.Selection.Heuristics
{
	public class StandardConstructorScorer : IConstructorScorer
	{
		public int Score(ConstructorInfo constructor)
		{
			return constructor.HasAttribute<InjectAttribute>() ? Int32.MaxValue : constructor.GetParameters().Length;
		}
	}
}