﻿//-------------------------------------------------------------------------
// <copyright file="CustomerSatisfactionDataCollection.cs" company="Infragistics">
//
// Copyright (c) 2010 Infragistics, Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// </copyright>
//-------------------------------------------------------------------------

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IGShowcase.AirplaneSeatingChart.Models
{
	public class CustomerSatisfactionDataCollection : Collection<CustomerSatisfactionData>
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="CustomerSatisfactionDataCollection"/> class.
		/// </summary>
		public CustomerSatisfactionDataCollection()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomerSatisfactionDataCollection"/> class.
		/// </summary>
		/// <param name="collection">A collection to copy from.</param>
		public CustomerSatisfactionDataCollection(IEnumerable<CustomerSatisfactionData> collection)
		{
			foreach (CustomerSatisfactionData item in collection)
			{
				Add(item);
			}
		}
		#endregion Constructors
	}
}
