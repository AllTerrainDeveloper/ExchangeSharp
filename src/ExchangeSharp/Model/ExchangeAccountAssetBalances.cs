/*
MIT LICENSE

Copyright 2017 Digital Ruby, LLC - http://www.digitalruby.com

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;

namespace ExchangeSharp
{
	public class ExchangeAccountAssetBalance
	{
		/// <summary>
		/// DateTime of the balances update
		/// </summary>
		public DateTime EventTime { get; set; }

		/// <summary>
		/// Free quantity to trade
		/// </summary>
		public decimal? Free { get; set; }

		/// <summary>
		/// Locked quantity
		/// </summary>
		public decimal? Locked { get; set; }

		/// <summary>
		/// Borrowed quantity to repay
		/// </summary>
		public decimal? Borrowed { get; set; }

		/// <summary>
		/// Interest quantity to pay
		/// </summary>
		public decimal? Interest { get; set; }

		/// <summary>
		/// Net quantity
		/// </summary>
		public decimal? Net { get; set; }

		/// <summary>
		/// Dictionary of symbols and amounts
		/// </summary>
		public string Asset { get; set; }
	}

	public class ExchangeAccountAssetBalances: WebResult
	{
		/// <summary>
		/// DateTime of the balances update
		/// </summary>
		public List<ExchangeAccountAssetBalance> Balances = new List<ExchangeAccountAssetBalance>();
	}
}
