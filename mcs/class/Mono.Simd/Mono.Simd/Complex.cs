// Complex.cs
//
// Author:
//   Gustavo Varo (gugavaro@microsoft.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Runtime.InteropServices;

namespace Mono.Simd
{
	[StructLayout(LayoutKind.Explicit, Pack = 0, Size = 16)]
	public struct Complex
	{
		[ FieldOffset(0) ]
		internal double x;
		[ FieldOffset(8) ]
		internal double y;

		public Complex (double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public double X { get { return x; } set { x = value; } }
		public double Y { get { return y; } set { y = value; } }

		[Acceleration (AccelMode.SSE2)]
		public static Complex operator + (Complex object1, Complex object2)
		{
			return new Complex (object1.x + object2.x, object1.y + object2.y);
		}

		[Acceleration (AccelMode.SSE2)]
		public static Complex operator * (Complex object1, Complex object2)
		{
			return new Complex (object1.x * object2.x, object1.y * object2.y);
		}

		public override string ToString()
		{
			return "value X: " + x + ", value Y" + y;
		}
	}
}
